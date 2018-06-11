namespace MTNContactsExported_NET2_0
{
    partial class Main
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.TbxOpen = new System.Windows.Forms.TextBox();
            this.gBxOpen = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gBxOut = new System.Windows.Forms.GroupBox();
            this.btnOpenOutFolder = new System.Windows.Forms.Button();
            this.RbtnConvSim = new System.Windows.Forms.RadioButton();
            this.RbtnConvAndroid = new System.Windows.Forms.RadioButton();
            this.TbxOut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.process1 = new System.Diagnostics.Process();
            this.gBxOpen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gBxOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(6, 19);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(148, 51);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(6, 139);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(131, 48);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // TbxOpen
            // 
            this.TbxOpen.Location = new System.Drawing.Point(160, 10);
            this.TbxOpen.Multiline = true;
            this.TbxOpen.Name = "TbxOpen";
            this.TbxOpen.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TbxOpen.Size = new System.Drawing.Size(525, 171);
            this.TbxOpen.TabIndex = 2;
            this.TbxOpen.WordWrap = false;
            // 
            // gBxOpen
            // 
            this.gBxOpen.Controls.Add(this.pictureBox1);
            this.gBxOpen.Controls.Add(this.btnOpen);
            this.gBxOpen.Controls.Add(this.TbxOpen);
            this.gBxOpen.Location = new System.Drawing.Point(13, 13);
            this.gBxOpen.Name = "gBxOpen";
            this.gBxOpen.Size = new System.Drawing.Size(691, 199);
            this.gBxOpen.TabIndex = 3;
            this.gBxOpen.TabStop = false;
            this.gBxOpen.Text = "Raw File";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 116);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // gBxOut
            // 
            this.gBxOut.Controls.Add(this.btnOpenOutFolder);
            this.gBxOut.Controls.Add(this.RbtnConvSim);
            this.gBxOut.Controls.Add(this.RbtnConvAndroid);
            this.gBxOut.Controls.Add(this.btnConvert);
            this.gBxOut.Location = new System.Drawing.Point(13, 228);
            this.gBxOut.Name = "gBxOut";
            this.gBxOut.Size = new System.Drawing.Size(154, 282);
            this.gBxOut.TabIndex = 4;
            this.gBxOut.TabStop = false;
            this.gBxOut.Text = "Output";
            // 
            // btnOpenOutFolder
            // 
            this.btnOpenOutFolder.Location = new System.Drawing.Point(7, 220);
            this.btnOpenOutFolder.Name = "btnOpenOutFolder";
            this.btnOpenOutFolder.Size = new System.Drawing.Size(121, 26);
            this.btnOpenOutFolder.TabIndex = 4;
            this.btnOpenOutFolder.Text = "Open Out Folder";
            this.btnOpenOutFolder.UseVisualStyleBackColor = true;
            // 
            // RbtnConvSim
            // 
            this.RbtnConvSim.AutoSize = true;
            this.RbtnConvSim.Location = new System.Drawing.Point(6, 82);
            this.RbtnConvSim.Name = "RbtnConvSim";
            this.RbtnConvSim.Size = new System.Drawing.Size(122, 17);
            this.RbtnConvSim.TabIndex = 3;
            this.RbtnConvSim.TabStop = true;
            this.RbtnConvSim.Text = "Convert For SimCard";
            this.RbtnConvSim.UseVisualStyleBackColor = true;
            this.RbtnConvSim.Click += new System.EventHandler(this.RbtnConvAndroid_Click);
            // 
            // RbtnConvAndroid
            // 
            this.RbtnConvAndroid.AutoSize = true;
            this.RbtnConvAndroid.Location = new System.Drawing.Point(7, 20);
            this.RbtnConvAndroid.Name = "RbtnConvAndroid";
            this.RbtnConvAndroid.Size = new System.Drawing.Size(110, 17);
            this.RbtnConvAndroid.TabIndex = 2;
            this.RbtnConvAndroid.TabStop = true;
            this.RbtnConvAndroid.Text = "Covert for Android";
            this.RbtnConvAndroid.UseVisualStyleBackColor = true;
            this.RbtnConvAndroid.Click += new System.EventHandler(this.RbtnConvAndroid_Click);
            // 
            // TbxOut
            // 
            this.TbxOut.BackColor = System.Drawing.SystemColors.InfoText;
            this.TbxOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxOut.ForeColor = System.Drawing.Color.White;
            this.TbxOut.Location = new System.Drawing.Point(174, 253);
            this.TbxOut.Multiline = true;
            this.TbxOut.Name = "TbxOut";
            this.TbxOut.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbxOut.Size = new System.Drawing.Size(524, 257);
            this.TbxOut.TabIndex = 5;
            this.TbxOut.Text = "Output:";

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Log Window.";
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(716, 521);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxOut);
            this.Controls.Add(this.gBxOut);
            this.Controls.Add(this.gBxOpen);
            this.Name = "Main";
            this.Text = "Contacts Converter";
            this.Load += new System.EventHandler(this.Main_Load);
            this.gBxOpen.ResumeLayout(false);
            this.gBxOpen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gBxOut.ResumeLayout(false);
            this.gBxOut.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox TbxOpen;
        private System.Windows.Forms.GroupBox gBxOpen;
        private System.Windows.Forms.GroupBox gBxOut;
        private System.Windows.Forms.RadioButton RbtnConvSim;
        private System.Windows.Forms.RadioButton RbtnConvAndroid;
        private System.Windows.Forms.TextBox TbxOut;
        private System.Windows.Forms.Label label1;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Button btnOpenOutFolder;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

