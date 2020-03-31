namespace ModernLifeInstaller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_installPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBrows = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label_fileinstalling = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 246);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ModernLifeInstaller.Properties.Resources.mlrpg_logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(86, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(588, 207);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txt_installPath
            // 
            this.txt_installPath.Location = new System.Drawing.Point(185, 334);
            this.txt_installPath.Name = "txt_installPath";
            this.txt_installPath.Size = new System.Drawing.Size(426, 20);
            this.txt_installPath.TabIndex = 2;
            this.txt_installPath.Text = "C:\\Program Files (x86)\\Modern Life RPG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Install Path:";
            // 
            // BtnBrows
            // 
            this.BtnBrows.FlatAppearance.BorderSize = 0;
            this.BtnBrows.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(92)))), ((int)(((byte)(130)))));
            this.BtnBrows.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(96)))), ((int)(((byte)(135)))));
            this.BtnBrows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBrows.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BtnBrows.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.BtnBrows.Location = new System.Drawing.Point(614, 325);
            this.BtnBrows.Margin = new System.Windows.Forms.Padding(0);
            this.BtnBrows.Name = "BtnBrows";
            this.BtnBrows.Size = new System.Drawing.Size(48, 35);
            this.BtnBrows.TabIndex = 4;
            this.BtnBrows.TabStop = false;
            this.BtnBrows.Text = "...";
            this.BtnBrows.UseVisualStyleBackColor = true;
            this.BtnBrows.Click += new System.EventHandler(this.BtnBrows_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(92)))), ((int)(((byte)(130)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(96)))), ((int)(((byte)(135)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.button1.Location = new System.Drawing.Point(185, 388);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(426, 35);
            this.button1.TabIndex = 5;
            this.button1.TabStop = false;
            this.button1.Text = "Start Installation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_fileinstalling
            // 
            this.label_fileinstalling.AutoSize = true;
            this.label_fileinstalling.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fileinstalling.ForeColor = System.Drawing.Color.White;
            this.label_fileinstalling.Location = new System.Drawing.Point(182, 287);
            this.label_fileinstalling.Name = "label_fileinstalling";
            this.label_fileinstalling.Size = new System.Drawing.Size(0, 18);
            this.label_fileinstalling.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(92)))), ((int)(((byte)(130)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(96)))), ((int)(((byte)(135)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.button2.Location = new System.Drawing.Point(753, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 35);
            this.button2.TabIndex = 7;
            this.button2.TabStop = false;
            this.button2.Text = "_";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label_fileinstalling);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnBrows);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_installPath);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modern Life RPG Installer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_installPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBrows;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label_fileinstalling;
        private System.Windows.Forms.Button button2;
    }
}

