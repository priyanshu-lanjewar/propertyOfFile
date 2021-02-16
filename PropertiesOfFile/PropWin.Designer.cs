namespace PropertiesOfFile
{
    partial class PropWin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loc = new System.Windows.Forms.TextBox();
            this.noPages = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalUpper = new System.Windows.Forms.TextBox();
            this.totalLower = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.totalSpecial = new System.Windows.Forms.TextBox();
            this.totalWords = new System.Windows.Forms.TextBox();
            this.totalCharAll = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.totalCharAllWithoutSpace = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(206, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Statistics of Selected Documents";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(25, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Location/Name : ";
            // 
            // loc
            // 
            this.loc.Cursor = System.Windows.Forms.Cursors.No;
            this.loc.Enabled = false;
            this.loc.Location = new System.Drawing.Point(357, 56);
            this.loc.Name = "loc";
            this.loc.ReadOnly = true;
            this.loc.Size = new System.Drawing.Size(396, 22);
            this.loc.TabIndex = 3;
            this.loc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // noPages
            // 
            this.noPages.Cursor = System.Windows.Forms.Cursors.No;
            this.noPages.Location = new System.Drawing.Point(357, 101);
            this.noPages.Name = "noPages";
            this.noPages.ReadOnly = true;
            this.noPages.Size = new System.Drawing.Size(396, 22);
            this.noPages.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(25, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "No. Of Pages :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(25, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "No. Of Uppercase Character :";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(25, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "No. Of Lowercase character : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // totalUpper
            // 
            this.totalUpper.Cursor = System.Windows.Forms.Cursors.No;
            this.totalUpper.Location = new System.Drawing.Point(357, 276);
            this.totalUpper.Name = "totalUpper";
            this.totalUpper.ReadOnly = true;
            this.totalUpper.Size = new System.Drawing.Size(396, 22);
            this.totalUpper.TabIndex = 8;
            // 
            // totalLower
            // 
            this.totalLower.Cursor = System.Windows.Forms.Cursors.No;
            this.totalLower.Location = new System.Drawing.Point(357, 322);
            this.totalLower.Name = "totalLower";
            this.totalLower.ReadOnly = true;
            this.totalLower.Size = new System.Drawing.Size(396, 22);
            this.totalLower.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(25, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "No. Of Words :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(25, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(282, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "No. Of All Characters (With Space) :";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(25, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(290, 27);
            this.label8.TabIndex = 12;
            this.label8.Text = "No. Of Special Character : ";
            // 
            // totalSpecial
            // 
            this.totalSpecial.Cursor = System.Windows.Forms.Cursors.No;
            this.totalSpecial.Location = new System.Drawing.Point(357, 368);
            this.totalSpecial.Name = "totalSpecial";
            this.totalSpecial.ReadOnly = true;
            this.totalSpecial.Size = new System.Drawing.Size(396, 22);
            this.totalSpecial.TabIndex = 13;
            // 
            // totalWords
            // 
            this.totalWords.Cursor = System.Windows.Forms.Cursors.No;
            this.totalWords.Location = new System.Drawing.Point(357, 147);
            this.totalWords.Name = "totalWords";
            this.totalWords.ReadOnly = true;
            this.totalWords.Size = new System.Drawing.Size(396, 22);
            this.totalWords.TabIndex = 14;
            // 
            // totalCharAll
            // 
            this.totalCharAll.Cursor = System.Windows.Forms.Cursors.No;
            this.totalCharAll.Location = new System.Drawing.Point(357, 191);
            this.totalCharAll.Name = "totalCharAll";
            this.totalCharAll.ReadOnly = true;
            this.totalCharAll.Size = new System.Drawing.Size(396, 22);
            this.totalCharAll.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(25, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(305, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "No. Of All Characters (Without Space) :";
            // 
            // totalCharAllWithoutSpace
            // 
            this.totalCharAllWithoutSpace.Cursor = System.Windows.Forms.Cursors.No;
            this.totalCharAllWithoutSpace.Location = new System.Drawing.Point(357, 233);
            this.totalCharAllWithoutSpace.Name = "totalCharAllWithoutSpace";
            this.totalCharAllWithoutSpace.ReadOnly = true;
            this.totalCharAllWithoutSpace.Size = new System.Drawing.Size(396, 22);
            this.totalCharAllWithoutSpace.TabIndex = 17;
            // 
            // PropWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 433);
            this.Controls.Add(this.totalCharAllWithoutSpace);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.totalCharAll);
            this.Controls.Add(this.totalWords);
            this.Controls.Add(this.totalSpecial);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalLower);
            this.Controls.Add(this.totalUpper);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.noPages);
            this.Controls.Add(this.loc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PropWin";
            this.Text = "Statistics Window";
            this.Load += new System.EventHandler(this.PropWin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loc;
        private System.Windows.Forms.TextBox noPages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox totalUpper;
        private System.Windows.Forms.TextBox totalLower;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox totalSpecial;
        private System.Windows.Forms.TextBox totalWords;
        private System.Windows.Forms.TextBox totalCharAll;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox totalCharAllWithoutSpace;
    }
}