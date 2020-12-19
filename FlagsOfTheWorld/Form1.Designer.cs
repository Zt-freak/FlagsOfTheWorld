﻿using System.Windows.Forms;

namespace FlagsOfTheWorld
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
            this.flagBox = new System.Windows.Forms.PictureBox();
            this.dropdown = new System.Windows.Forms.ComboBox();
            this.score = new System.Windows.Forms.Label();
            this.switchModeButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.flagBox)).BeginInit();
            this.SuspendLayout();
            // 
            // flagBox
            // 
            this.flagBox.Location = new System.Drawing.Point(125, 9);
            this.flagBox.Margin = new System.Windows.Forms.Padding(0);
            this.flagBox.Name = "flagBox";
            this.flagBox.Size = new System.Drawing.Size(64, 64);
            this.flagBox.TabIndex = 0;
            this.flagBox.TabStop = false;
            // 
            // dropdown
            // 
            this.dropdown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dropdown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dropdown.FormattingEnabled = true;
            this.dropdown.Location = new System.Drawing.Point(12, 85);
            this.dropdown.Name = "dropdown";
            this.dropdown.Size = new System.Drawing.Size(300, 24);
            this.dropdown.TabIndex = 1;
            // 
            // label1
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(262, 250);
            this.score.Name = "label1";
            this.score.Size = new System.Drawing.Size(42, 16);
            this.score.TabIndex = 3;
            this.score.Text = "score";
            this.score.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // button1
            // 
            this.switchModeButton.Location = new System.Drawing.Point(12, 243);
            this.switchModeButton.Name = "button1";
            this.switchModeButton.Size = new System.Drawing.Size(75, 23);
            this.switchModeButton.TabIndex = 4;
            this.switchModeButton.Text = "switch";
            this.switchModeButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.submitButton.Location = new System.Drawing.Point(125, 167);
            this.submitButton.Name = "button2";
            this.submitButton.Size = new System.Drawing.Size(64, 23);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 278);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.switchModeButton);
            this.Controls.Add(this.score);
            this.Controls.Add(this.dropdown);
            this.Controls.Add(this.flagBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flagBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flagBox;
        private System.Windows.Forms.ComboBox dropdown;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Button switchModeButton;
        private System.Windows.Forms.Button submitButton;
    }
}

