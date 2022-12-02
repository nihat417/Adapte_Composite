namespace Composite
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_FolderSize = new System.Windows.Forms.Label();
            this.lbl_FolderPath = new System.Windows.Forms.Label();
            this.btn_SelectFolder = new System.Windows.Forms.Button();
            this.lbl_FileSize = new System.Windows.Forms.Label();
            this.lbl_FileName = new System.Windows.Forms.Label();
            this.btn_SelectFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_FolderSize
            // 
            this.lbl_FolderSize.AutoSize = true;
            this.lbl_FolderSize.ForeColor = System.Drawing.Color.Black;
            this.lbl_FolderSize.Location = new System.Drawing.Point(536, 101);
            this.lbl_FolderSize.Name = "lbl_FolderSize";
            this.lbl_FolderSize.Size = new System.Drawing.Size(63, 15);
            this.lbl_FolderSize.TabIndex = 17;
            this.lbl_FolderSize.Text = "FolderSize:";
            // 
            // lbl_FolderPath
            // 
            this.lbl_FolderPath.AutoSize = true;
            this.lbl_FolderPath.ForeColor = System.Drawing.Color.Black;
            this.lbl_FolderPath.Location = new System.Drawing.Point(536, 76);
            this.lbl_FolderPath.Name = "lbl_FolderPath";
            this.lbl_FolderPath.Size = new System.Drawing.Size(67, 15);
            this.lbl_FolderPath.TabIndex = 16;
            this.lbl_FolderPath.Text = "FolderPath:";
            // 
            // btn_SelectFolder
            // 
            this.btn_SelectFolder.ForeColor = System.Drawing.Color.Black;
            this.btn_SelectFolder.Location = new System.Drawing.Point(536, 35);
            this.btn_SelectFolder.Name = "btn_SelectFolder";
            this.btn_SelectFolder.Size = new System.Drawing.Size(88, 23);
            this.btn_SelectFolder.TabIndex = 15;
            this.btn_SelectFolder.Text = "Select Folder";
            this.btn_SelectFolder.UseVisualStyleBackColor = true;
            this.btn_SelectFolder.Click += new System.EventHandler(this.btn_Click);
            // 
            // lbl_FileSize
            // 
            this.lbl_FileSize.AutoSize = true;
            this.lbl_FileSize.ForeColor = System.Drawing.Color.Black;
            this.lbl_FileSize.Location = new System.Drawing.Point(38, 101);
            this.lbl_FileSize.Name = "lbl_FileSize";
            this.lbl_FileSize.Size = new System.Drawing.Size(51, 15);
            this.lbl_FileSize.TabIndex = 14;
            this.lbl_FileSize.Text = "FileSize: ";
            // 
            // lbl_FileName
            // 
            this.lbl_FileName.AutoSize = true;
            this.lbl_FileName.ForeColor = System.Drawing.Color.Black;
            this.lbl_FileName.Location = new System.Drawing.Point(38, 76);
            this.lbl_FileName.Name = "lbl_FileName";
            this.lbl_FileName.Size = new System.Drawing.Size(63, 15);
            this.lbl_FileName.TabIndex = 13;
            this.lbl_FileName.Text = "FileName: ";
            // 
            // btn_SelectFile
            // 
            this.btn_SelectFile.ForeColor = System.Drawing.Color.Black;
            this.btn_SelectFile.Location = new System.Drawing.Point(38, 35);
            this.btn_SelectFile.Name = "btn_SelectFile";
            this.btn_SelectFile.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectFile.TabIndex = 12;
            this.btn_SelectFile.Text = "Select File";
            this.btn_SelectFile.UseVisualStyleBackColor = true;
            this.btn_SelectFile.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_FolderSize);
            this.Controls.Add(this.lbl_FolderPath);
            this.Controls.Add(this.btn_SelectFolder);
            this.Controls.Add(this.lbl_FileSize);
            this.Controls.Add(this.lbl_FileName);
            this.Controls.Add(this.btn_SelectFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_FolderSize;
        private Label lbl_FolderPath;
        private Button btn_SelectFolder;
        private Label lbl_FileSize;
        private Label lbl_FileName;
        private Button btn_SelectFile;
    }
}