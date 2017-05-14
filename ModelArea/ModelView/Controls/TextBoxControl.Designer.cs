namespace ModelView.Controls
{
    partial class TextBoxControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.AreaTextBox = new System.Windows.Forms.TextBox();
            this.AreaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(6, 55);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.ReadOnly = true;
            this.LengthTextBox.ShortcutsEnabled = false;
            this.LengthTextBox.Size = new System.Drawing.Size(74, 20);
            this.LengthTextBox.TabIndex = 10;
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(3, 39);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(40, 13);
            this.LengthLabel.TabIndex = 9;
            this.LengthLabel.Text = "Length";
            // 
            // AreaTextBox
            // 
            this.AreaTextBox.Location = new System.Drawing.Point(6, 16);
            this.AreaTextBox.Name = "AreaTextBox";
            this.AreaTextBox.ReadOnly = true;
            this.AreaTextBox.ShortcutsEnabled = false;
            this.AreaTextBox.Size = new System.Drawing.Size(74, 20);
            this.AreaTextBox.TabIndex = 8;
            // 
            // AreaLabel
            // 
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.Location = new System.Drawing.Point(3, 0);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(29, 13);
            this.AreaLabel.TabIndex = 7;
            this.AreaLabel.Text = "Area";
            // 
            // TextBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LengthTextBox);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.AreaTextBox);
            this.Controls.Add(this.AreaLabel);
            this.Name = "TextBoxControl";
            this.Size = new System.Drawing.Size(90, 88);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.TextBox AreaTextBox;
        private System.Windows.Forms.Label AreaLabel;
    }
}
