namespace Y2K_IMZGenReloaded
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveIMGZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableDebugConsoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.imdCnt = new System.Windows.Forms.NumericUpDown();
            this.createIMDs = new System.Windows.Forms.Button();
            this.imdCImg = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.currentImd = new System.Windows.Forms.NumericUpDown();
            this.updateCurIMD = new System.Windows.Forms.Button();
            this.imdSelImg = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imdSavImg = new System.Windows.Forms.PictureBox();
            this.saveIMD = new System.Windows.Forms.Button();
            this.width = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.length = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imdCnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imdCImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentImd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imdSelImg)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imdSavImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.length)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(394, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveIMGZToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fIleToolStripMenuItem.Text = "File";
            // 
            // saveIMGZToolStripMenuItem
            // 
            this.saveIMGZToolStripMenuItem.Name = "saveIMGZToolStripMenuItem";
            this.saveIMGZToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveIMGZToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.saveIMGZToolStripMenuItem.Text = "Save IMGZ";
            this.saveIMGZToolStripMenuItem.Click += new System.EventHandler(this.saveIMGZToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableDebugConsoleToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.debugToolStripMenuItem.Text = "Debug";
            // 
            // enableDebugConsoleToolStripMenuItem
            // 
            this.enableDebugConsoleToolStripMenuItem.Name = "enableDebugConsoleToolStripMenuItem";
            this.enableDebugConsoleToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.enableDebugConsoleToolStripMenuItem.Text = "Debug Console";
            this.enableDebugConsoleToolStripMenuItem.Click += new System.EventHandler(this.enableDebugConsoleToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "IMGD Count:";
            // 
            // imdCnt
            // 
            this.imdCnt.Location = new System.Drawing.Point(106, 34);
            this.imdCnt.Name = "imdCnt";
            this.imdCnt.Size = new System.Drawing.Size(122, 22);
            this.imdCnt.TabIndex = 2;
            // 
            // createIMDs
            // 
            this.createIMDs.Location = new System.Drawing.Point(234, 32);
            this.createIMDs.Name = "createIMDs";
            this.createIMDs.Size = new System.Drawing.Size(118, 25);
            this.createIMDs.TabIndex = 3;
            this.createIMDs.Text = "Create";
            this.createIMDs.UseVisualStyleBackColor = true;
            this.createIMDs.Click += new System.EventHandler(this.button1_Click);
            // 
            // imdCImg
            // 
            this.imdCImg.Image = global::Y2K_IMZGenReloaded.Properties.Resources._1;
            this.imdCImg.Location = new System.Drawing.Point(357, 31);
            this.imdCImg.Name = "imdCImg";
            this.imdCImg.Size = new System.Drawing.Size(25, 25);
            this.imdCImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imdCImg.TabIndex = 4;
            this.imdCImg.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Selected IMGD:";
            // 
            // currentImd
            // 
            this.currentImd.Location = new System.Drawing.Point(124, 65);
            this.currentImd.Name = "currentImd";
            this.currentImd.Size = new System.Drawing.Size(104, 22);
            this.currentImd.TabIndex = 6;
            // 
            // updateCurIMD
            // 
            this.updateCurIMD.Location = new System.Drawing.Point(234, 63);
            this.updateCurIMD.Name = "updateCurIMD";
            this.updateCurIMD.Size = new System.Drawing.Size(118, 25);
            this.updateCurIMD.TabIndex = 7;
            this.updateCurIMD.Text = "Update";
            this.updateCurIMD.UseVisualStyleBackColor = true;
            this.updateCurIMD.Click += new System.EventHandler(this.button2_Click);
            // 
            // imdSelImg
            // 
            this.imdSelImg.Image = global::Y2K_IMZGenReloaded.Properties.Resources._2;
            this.imdSelImg.Location = new System.Drawing.Point(357, 62);
            this.imdSelImg.Name = "imdSelImg";
            this.imdSelImg.Size = new System.Drawing.Size(25, 25);
            this.imdSelImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imdSelImg.TabIndex = 8;
            this.imdSelImg.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imdSavImg);
            this.groupBox1.Controls.Add(this.saveIMD);
            this.groupBox1.Controls.Add(this.width);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.length);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 83);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IMGD";
            // 
            // imdSavImg
            // 
            this.imdSavImg.Image = global::Y2K_IMZGenReloaded.Properties.Resources._3;
            this.imdSavImg.Location = new System.Drawing.Point(339, 33);
            this.imdSavImg.Name = "imdSavImg";
            this.imdSavImg.Size = new System.Drawing.Size(25, 25);
            this.imdSavImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imdSavImg.TabIndex = 5;
            this.imdSavImg.TabStop = false;
            // 
            // saveIMD
            // 
            this.saveIMD.Location = new System.Drawing.Point(222, 33);
            this.saveIMD.Name = "saveIMD";
            this.saveIMD.Size = new System.Drawing.Size(111, 25);
            this.saveIMD.TabIndex = 4;
            this.saveIMD.Text = "Save IMGD";
            this.saveIMD.UseVisualStyleBackColor = true;
            this.saveIMD.Click += new System.EventHandler(this.button3_Click);
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(96, 49);
            this.width.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(120, 22);
            this.width.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Width (px):";
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(96, 21);
            this.length.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(120, 22);
            this.length.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Length (px):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 183);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.imdSelImg);
            this.Controls.Add(this.updateCurIMD);
            this.Controls.Add(this.currentImd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imdCImg);
            this.Controls.Add(this.createIMDs);
            this.Controls.Add(this.imdCnt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "IMZGen Reloaded";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imdCnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imdCImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentImd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imdSelImg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imdSavImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.length)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveIMGZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableDebugConsoleToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown imdCnt;
        private System.Windows.Forms.Button createIMDs;
        private System.Windows.Forms.PictureBox imdCImg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown currentImd;
        private System.Windows.Forms.Button updateCurIMD;
        private System.Windows.Forms.PictureBox imdSelImg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown length;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox imdSavImg;
        private System.Windows.Forms.Button saveIMD;
        private System.Windows.Forms.NumericUpDown width;
        private System.Windows.Forms.Label label4;
    }
}

