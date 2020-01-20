namespace MovieSplitter
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.fileSelectButton = new System.Windows.Forms.Button();
            this.targetFileLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.使い方ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ライセンス表示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoFrameBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.splitTimeGridView = new System.Windows.Forms.DataGridView();
            this.Splittable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accelerationTimeGridView = new System.Windows.Forms.DataGridView();
            this.AcceleratableStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcceleratableEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frameCountLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.splitTimeBox = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.moveSecondUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoFrameBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitTimeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accelerationTimeGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveSecondUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSelectButton
            // 
            this.fileSelectButton.Location = new System.Drawing.Point(16, 70);
            this.fileSelectButton.Name = "fileSelectButton";
            this.fileSelectButton.Size = new System.Drawing.Size(200, 60);
            this.fileSelectButton.TabIndex = 0;
            this.fileSelectButton.Text = "選択";
            this.fileSelectButton.UseVisualStyleBackColor = true;
            this.fileSelectButton.Click += new System.EventHandler(this.FileSelectButtonClick);
            // 
            // targetFileLabel
            // 
            this.targetFileLabel.AutoSize = true;
            this.targetFileLabel.Location = new System.Drawing.Point(12, 43);
            this.targetFileLabel.Name = "targetFileLabel";
            this.targetFileLabel.Size = new System.Drawing.Size(280, 24);
            this.targetFileLabel.TabIndex = 1;
            this.targetFileLabel.Text = "ファイルが選択されていません";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.使い方ToolStripMenuItem,
            this.ライセンス表示ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1374, 40);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 使い方ToolStripMenuItem
            // 
            this.使い方ToolStripMenuItem.Name = "使い方ToolStripMenuItem";
            this.使い方ToolStripMenuItem.Size = new System.Drawing.Size(103, 36);
            this.使い方ToolStripMenuItem.Text = "使い方";
            // 
            // ライセンス表示ToolStripMenuItem
            // 
            this.ライセンス表示ToolStripMenuItem.Name = "ライセンス表示ToolStripMenuItem";
            this.ライセンス表示ToolStripMenuItem.Size = new System.Drawing.Size(173, 36);
            this.ライセンス表示ToolStripMenuItem.Text = "ライセンス表示";
            this.ライセンス表示ToolStripMenuItem.Click += new System.EventHandler(this.DisplayLicenseClick);
            // 
            // videoFrameBox
            // 
            this.videoFrameBox.Location = new System.Drawing.Point(16, 258);
            this.videoFrameBox.Name = "videoFrameBox";
            this.videoFrameBox.Size = new System.Drawing.Size(640, 480);
            this.videoFrameBox.TabIndex = 3;
            this.videoFrameBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(16, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "＜";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.PrevFrameClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(82, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 60);
            this.button2.TabIndex = 5;
            this.button2.Text = "＞";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NextFrameClick);
            // 
            // splitTimeGridView
            // 
            this.splitTimeGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitTimeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.splitTimeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Splittable});
            this.splitTimeGridView.Location = new System.Drawing.Point(698, 43);
            this.splitTimeGridView.Name = "splitTimeGridView";
            this.splitTimeGridView.RowHeadersWidth = 82;
            this.splitTimeGridView.RowTemplate.Height = 33;
            this.splitTimeGridView.Size = new System.Drawing.Size(270, 691);
            this.splitTimeGridView.TabIndex = 6;
            // 
            // Splittable
            // 
            this.Splittable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Splittable.HeaderText = "分割可能フレーム";
            this.Splittable.MinimumWidth = 10;
            this.Splittable.Name = "Splittable";
            this.Splittable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // accelerationTimeGridView
            // 
            this.accelerationTimeGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accelerationTimeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accelerationTimeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AcceleratableStart,
            this.AcceleratableEnd});
            this.accelerationTimeGridView.Location = new System.Drawing.Point(974, 43);
            this.accelerationTimeGridView.Name = "accelerationTimeGridView";
            this.accelerationTimeGridView.RowHeadersWidth = 82;
            this.accelerationTimeGridView.RowTemplate.Height = 33;
            this.accelerationTimeGridView.Size = new System.Drawing.Size(400, 691);
            this.accelerationTimeGridView.TabIndex = 7;
            // 
            // AcceleratableStart
            // 
            this.AcceleratableStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AcceleratableStart.HeaderText = "開始";
            this.AcceleratableStart.MinimumWidth = 10;
            this.AcceleratableStart.Name = "AcceleratableStart";
            this.AcceleratableStart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AcceleratableEnd
            // 
            this.AcceleratableEnd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AcceleratableEnd.HeaderText = "終了";
            this.AcceleratableEnd.MinimumWidth = 10;
            this.AcceleratableEnd.Name = "AcceleratableEnd";
            this.AcceleratableEnd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frameCountLabel
            // 
            this.frameCountLabel.AutoSize = true;
            this.frameCountLabel.Font = new System.Drawing.Font("MS UI Gothic", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.frameCountLabel.Location = new System.Drawing.Point(149, 136);
            this.frameCountLabel.Name = "frameCountLabel";
            this.frameCountLabel.Size = new System.Drawing.Size(104, 53);
            this.frameCountLabel.TabIndex = 8;
            this.frameCountLabel.Text = "0/0";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(492, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 60);
            this.button3.TabIndex = 9;
            this.button3.Text = "分割";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // splitTimeBox
            // 
            this.splitTimeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.splitTimeBox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.splitTimeBox.FormattingEnabled = true;
            this.splitTimeBox.Items.AddRange(new object[] {
            "10分",
            "15分",
            "30分"});
            this.splitTimeBox.Location = new System.Drawing.Point(365, 70);
            this.splitTimeBox.Name = "splitTimeBox";
            this.splitTimeBox.Size = new System.Drawing.Size(121, 41);
            this.splitTimeBox.TabIndex = 10;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 757);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1374, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 12);
            // 
            // moveSecondUpDown
            // 
            this.moveSecondUpDown.Font = new System.Drawing.Font("MS UI Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.moveSecondUpDown.Location = new System.Drawing.Point(16, 202);
            this.moveSecondUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.moveSecondUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.moveSecondUpDown.Name = "moveSecondUpDown";
            this.moveSecondUpDown.Size = new System.Drawing.Size(120, 44);
            this.moveSecondUpDown.TabIndex = 16;
            this.moveSecondUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(142, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "秒分";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(239, 204);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 48);
            this.button4.TabIndex = 18;
            this.button4.Text = "進める";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.MoveNextSecondClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(345, 204);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 48);
            this.button5.TabIndex = 19;
            this.button5.Text = "戻す";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.MovePrevSecondClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 779);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.moveSecondUpDown);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitTimeBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.frameCountLabel);
            this.Controls.Add(this.accelerationTimeGridView);
            this.Controls.Add(this.splitTimeGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.videoFrameBox);
            this.Controls.Add(this.targetFileLabel);
            this.Controls.Add(this.fileSelectButton);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormKeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoFrameBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitTimeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accelerationTimeGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveSecondUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fileSelectButton;
        private System.Windows.Forms.Label targetFileLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 使い方ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ライセンス表示ToolStripMenuItem;
        private System.Windows.Forms.PictureBox videoFrameBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView splitTimeGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Splittable;
        private System.Windows.Forms.DataGridView accelerationTimeGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcceleratableStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcceleratableEnd;
        private System.Windows.Forms.Label frameCountLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox splitTimeBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.NumericUpDown moveSecondUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

