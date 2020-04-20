﻿namespace CustomMsgBox {
    partial class CustomMessageBox {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usageLabel = new System.Windows.Forms.Label();
            this.authLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // vLabel
            // 
            this.vLabel.AutoSize = true;
            this.vLabel.Location = new System.Drawing.Point(71, 13);
            this.vLabel.Name = "vLabel";
            this.vLabel.Size = new System.Drawing.Size(86, 13);
            this.vLabel.TabIndex = 1;
            this.vLabel.Text = "Key Sender v1.1";
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(71, 26);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(197, 13);
            this.descLabel.TabIndex = 2;
            this.descLabel.Text = "Auto-types from clipboard to any textfield";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.usageLabel);
            this.panel1.Controls.Add(this.descLabel);
            this.panel1.Controls.Add(this.vLabel);
            this.panel1.Location = new System.Drawing.Point(9, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 110);
            this.panel1.TabIndex = 0;
            // 
            // usageLabel
            // 
            this.usageLabel.AutoSize = true;
            this.usageLabel.Location = new System.Drawing.Point(10, 54);
            this.usageLabel.Name = "usageLabel";
            this.usageLabel.Size = new System.Drawing.Size(164, 13);
            this.usageLabel.TabIndex = 3;
            this.usageLabel.Text = "1. Copy any text to your clipboard";
            // 
            // authLabel
            // 
            this.authLabel.AutoSize = true;
            this.authLabel.Location = new System.Drawing.Point(19, 112);
            this.authLabel.Name = "authLabel";
            this.authLabel.Size = new System.Drawing.Size(124, 13);
            this.authLabel.TabIndex = 1;
            this.authLabel.Text = "Author: Nikolay Avroniev";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 170);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.authLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomMessageBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About KeySender";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label vLabel;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label authLabel;
        private System.Windows.Forms.Label usageLabel;
        private System.Windows.Forms.Button button1;
    }
}

