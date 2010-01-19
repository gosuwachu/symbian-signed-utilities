namespace S60SigningTool
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.file = new System.Windows.Forms.ComboBox();
            this.browseFile = new System.Windows.Forms.Button();
            this.certificate = new System.Windows.Forms.ComboBox();
            this.browseCertificate = new System.Windows.Forms.Button();
            this.key = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.browseKey = new System.Windows.Forms.Button();
            this.unsign = new System.Windows.Forms.CheckBox();
            this.run = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.browseOutput = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.loadProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // file
            // 
            this.file.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.file.FormattingEnabled = true;
            this.file.Location = new System.Drawing.Point(91, 26);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(407, 21);
            this.file.TabIndex = 1;
            // 
            // browseFile
            // 
            this.browseFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseFile.Location = new System.Drawing.Point(504, 24);
            this.browseFile.Name = "browseFile";
            this.browseFile.Size = new System.Drawing.Size(75, 23);
            this.browseFile.TabIndex = 2;
            this.browseFile.Text = "Browse";
            this.browseFile.UseVisualStyleBackColor = true;
            this.browseFile.Click += new System.EventHandler(this.browseFile_Click);
            // 
            // certificate
            // 
            this.certificate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.certificate.FormattingEnabled = true;
            this.certificate.Location = new System.Drawing.Point(91, 84);
            this.certificate.Name = "certificate";
            this.certificate.Size = new System.Drawing.Size(406, 21);
            this.certificate.TabIndex = 3;
            // 
            // browseCertificate
            // 
            this.browseCertificate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseCertificate.Location = new System.Drawing.Point(503, 82);
            this.browseCertificate.Name = "browseCertificate";
            this.browseCertificate.Size = new System.Drawing.Size(75, 23);
            this.browseCertificate.TabIndex = 4;
            this.browseCertificate.Text = "Browse";
            this.browseCertificate.UseVisualStyleBackColor = true;
            this.browseCertificate.Click += new System.EventHandler(this.browseCertificate_Click);
            // 
            // key
            // 
            this.key.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.key.FormattingEnabled = true;
            this.key.Location = new System.Drawing.Point(91, 115);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(406, 21);
            this.key.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "File to sign:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Certificate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Key:";
            // 
            // browseKey
            // 
            this.browseKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseKey.Location = new System.Drawing.Point(503, 113);
            this.browseKey.Name = "browseKey";
            this.browseKey.Size = new System.Drawing.Size(75, 23);
            this.browseKey.TabIndex = 9;
            this.browseKey.Text = "Browse";
            this.browseKey.UseVisualStyleBackColor = true;
            this.browseKey.Click += new System.EventHandler(this.browseKey_Click);
            // 
            // unsign
            // 
            this.unsign.AutoSize = true;
            this.unsign.Location = new System.Drawing.Point(15, 148);
            this.unsign.Name = "unsign";
            this.unsign.Size = new System.Drawing.Size(76, 17);
            this.unsign.TabIndex = 10;
            this.unsign.Text = "unsign first";
            this.unsign.UseVisualStyleBackColor = true;
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(97, 144);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(75, 23);
            this.run.TabIndex = 11;
            this.run.Text = "Run";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // output
            // 
            this.output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.output.FormattingEnabled = true;
            this.output.Location = new System.Drawing.Point(91, 57);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(406, 21);
            this.output.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Output:";
            // 
            // browseOutput
            // 
            this.browseOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseOutput.Location = new System.Drawing.Point(504, 54);
            this.browseOutput.Name = "browseOutput";
            this.browseOutput.Size = new System.Drawing.Size(75, 23);
            this.browseOutput.TabIndex = 14;
            this.browseOutput.Text = "Browse";
            this.browseOutput.UseVisualStyleBackColor = true;
            this.browseOutput.Click += new System.EventHandler(this.browseOutput_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 172);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.loadProjectToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(102, 22);
            this.toolStripDropDownButton1.Text = "Load project";
            // 
            // loadProjectToolStripMenuItem
            // 
            this.loadProjectToolStripMenuItem.Name = "loadProjectToolStripMenuItem";
            this.loadProjectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadProjectToolStripMenuItem.Text = "Load project";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(91, 22);
            this.toolStripButton1.Text = "Save project";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 194);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.browseOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.output);
            this.Controls.Add(this.run);
            this.Controls.Add(this.unsign);
            this.Controls.Add(this.browseKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.key);
            this.Controls.Add(this.browseCertificate);
            this.Controls.Add(this.certificate);
            this.Controls.Add(this.browseFile);
            this.Controls.Add(this.file);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "S60SignSisTool";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox file;
        private System.Windows.Forms.Button browseFile;
        private System.Windows.Forms.ComboBox certificate;
        private System.Windows.Forms.Button browseCertificate;
        private System.Windows.Forms.ComboBox key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button browseKey;
        private System.Windows.Forms.CheckBox unsign;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.ComboBox output;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button browseOutput;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem loadProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

