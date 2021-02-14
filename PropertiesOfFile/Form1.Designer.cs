namespace PropertiesOfFile
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
            this.selectFile = new System.Windows.Forms.Button();
            this.fileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            process = new System.Windows.Forms.ProgressBar();
            this.calculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.anekaConfig = new System.Windows.Forms.Button();
            this.confFileLoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selectFile
            // 
            this.selectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.selectFile.Location = new System.Drawing.Point(25, 127);
            this.selectFile.Name = "selectFile";
            this.selectFile.Size = new System.Drawing.Size(542, 31);
            this.selectFile.TabIndex = 0;
            this.selectFile.Text = "Click here to choose file";
            this.selectFile.UseVisualStyleBackColor = true;
            this.selectFile.Click += new System.EventHandler(this.selectFile_Click);
            // 
            // fileName
            // 
            this.fileName.Cursor = System.Windows.Forms.Cursors.No;
            this.fileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fileName.Location = new System.Drawing.Point(90, 85);
            this.fileName.Name = "fileName";
            this.fileName.ReadOnly = true;
            this.fileName.Size = new System.Drawing.Size(477, 26);
            this.fileName.TabIndex = 1;
            this.fileName.TextChanged += new System.EventHandler(this.fileName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(32, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "File : ";
            // 
            // process
            // 
            process.BackColor = System.Drawing.SystemColors.ButtonShadow;
            process.Location = new System.Drawing.Point(25, 232);
            process.Name = "process";
            process.Size = new System.Drawing.Size(542, 23);
            process.TabIndex = 3;
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.calculate.Location = new System.Drawing.Point(25, 178);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(542, 31);
            this.calculate.TabIndex = 4;
            this.calculate.Text = "Click here to Start";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(86, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(409, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "-------------------- Aneka Configuration --------------------";
            // 
            // anekaConfig
            // 
            this.anekaConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.anekaConfig.Location = new System.Drawing.Point(25, 310);
            this.anekaConfig.Name = "anekaConfig";
            this.anekaConfig.Size = new System.Drawing.Size(542, 31);
            this.anekaConfig.TabIndex = 7;
            this.anekaConfig.Text = "Click to Select Configuration file";
            this.anekaConfig.UseVisualStyleBackColor = true;
            this.anekaConfig.Click += new System.EventHandler(this.anekaConfig_Click);
            // 
            // confFileLoc
            // 
            this.confFileLoc.Cursor = System.Windows.Forms.Cursors.No;
            this.confFileLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.confFileLoc.Location = new System.Drawing.Point(25, 354);
            this.confFileLoc.Name = "confFileLoc";
            this.confFileLoc.ReadOnly = true;
            this.confFileLoc.Size = new System.Drawing.Size(542, 26);
            this.confFileLoc.TabIndex = 8;
            this.confFileLoc.Text = "conf.xml";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(78, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(443, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "WORD (.docx) File Statistics Finder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confFileLoc);
            this.Controls.Add(this.anekaConfig);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calculate);
            this.Controls.Add(process);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.selectFile);
            this.Name = "Form1";
            this.Text = "Word File Statistics Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button selectFile;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button anekaConfig;
        private System.Windows.Forms.TextBox confFileLoc;
        private System.Windows.Forms.Label label2;
        private static System.Windows.Forms.ProgressBar process;
    }
}

