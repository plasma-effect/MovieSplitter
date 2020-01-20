using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace MovieSplitter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ~Form1()
        {
            this.video.Dispose();
        }

        VideoCapture video;
        readonly double[] compatibleFPS = new double[] { 20, 30, 60 };
        const int baseWidth = 1400 - 640;
        const int baseHeight = 850 - 480;
        int frame;
        
        private void FileSelectButtonClick(object sender, EventArgs e)
        {
                using (var ofd = new OpenFileDialog())
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        var video = new VideoCapture(ofd.FileName);
                        if (!video.IsOpened())
                        {
                            MessageBox.Show("動画ファイルではありません", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            video.Dispose();
                            return;
                        }
                        if (!this.compatibleFPS.Contains(video.Fps))
                        {
                            MessageBox.Show("このソフトは現在20fps, 30fps, 60fpsの動画ファイルにのみ対応しています", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            video.Dispose();
                            return;
                        }
                        this.targetFileLabel.Text = ofd.FileName;
                        this.video = video;
                        this.Width = baseWidth + this.video.FrameWidth;
                        this.Height = baseHeight + this.video.FrameHeight;
                        this.videoFrameBox.Width = this.video.FrameWidth;
                        this.videoFrameBox.Height = this.video.FrameHeight;
                        this.frame = 0;
                        DisplayFrame();
                        this.statusLabel.Text = $"{ofd.FileName} を開きました({this.video.Fps}fps, {this.video.FrameCount}frames)";
                    }
                }
            
        }

        private void DisplayFrame()
        {
            using (var img = new Mat())
            {
                this.video.Set(VideoCaptureProperties.PosFrames, this.frame);
                this.video.Read(img);
                this.videoFrameBox.Image = img.ToBitmap();
            }
            this.frameCountLabel.Text = $"{this.frame + 1}/{this.video.FrameCount}";
        }

        private void DisplayLicenseClick(object sender, EventArgs e)
        {
            MessageBox.Show(Resource.Licenses, "ライセンスについて", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PrevFrameClick(object sender, EventArgs e)
        {
            MovePrevFrame();
        }

        private bool MovePrevFrame(int frame = 1)
        {
            if (this.frame != 0)
            {
                this.frame = Math.Max(0, this.frame - frame);
                DisplayFrame();
                return this.frame != 0;
            }
            return false;
        }

        private void NextFrameClick(object sender, EventArgs e)
        {
            MoveNextFrame();
        }

        private bool MoveNextFrame(int frame = 1)
        {
            if (this.frame + 1 != this.video.FrameCount)
            {
                this.frame = Math.Min(this.video.FrameCount - 1, this.frame + frame);
                DisplayFrame();
                return this.frame + 1 != this.video.FrameCount;
            }
            return false;
        }

        private void FormKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Right)
            {
                MoveNextFrame();
            }
            else if (e.KeyChar == (char)Keys.Left)
            {
                MovePrevFrame();
            }
        }

        private void MoveNextSecondClick(object sender, EventArgs e)
        {
            MoveNextFrame((int)this.moveSecondUpDown.Value * (int)this.video.Fps);
        }

        private void MovePrevSecondClick(object sender, EventArgs e)
        {
            MovePrevFrame((int)this.moveSecondUpDown.Value * (int)this.video.Fps);
        }
    }
}
