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
            this.scoreLabel = new System.Windows.Forms.Label();
            this.switchModeButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.answerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flagBox)).BeginInit();
            this.SuspendLayout();
            // 
            // flagBox
            // 
            this.flagBox.Location = new System.Drawing.Point(125, 9);
            this.flagBox.Margin = new System.Windows.Forms.Padding(0);
            this.flagBox.Name = "flagBox";
            this.flagBox.Size = new System.Drawing.Size(64, 64);
            this.flagBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            // scoreLabel
            // 
            this.scoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreLabel.Location = new System.Drawing.Point(93, 244);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(219, 16);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "score: 0";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // switchModeButton
            // 
            this.switchModeButton.Location = new System.Drawing.Point(12, 236);
            this.switchModeButton.Name = "switchModeButton";
            this.switchModeButton.Size = new System.Drawing.Size(75, 30);
            this.switchModeButton.TabIndex = 4;
            this.switchModeButton.Text = "switch";
            this.switchModeButton.UseVisualStyleBackColor = true;
            this.switchModeButton.Click += new System.EventHandler(this.switchModeButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(125, 115);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(64, 23);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(12, 156);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(85, 16);
            this.answerLabel.TabIndex = 6;
            this.answerLabel.Text = "answerLabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 278);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.switchModeButton);
            this.Controls.Add(this.scoreLabel);
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
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button switchModeButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label answerLabel;
    }
}

