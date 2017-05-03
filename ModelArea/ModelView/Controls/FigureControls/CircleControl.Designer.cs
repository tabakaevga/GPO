namespace ModelView.Controls.FigureControls
{
    partial class CircleControl
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
            this.RadiusLabel = new System.Windows.Forms.Label();
            this.RadiusTextBox = new System.Windows.Forms.TextBox();
            this.AreaLabel = new System.Windows.Forms.Label();
            this.AreaTextBox = new System.Windows.Forms.TextBox();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RadiusLabel
            // 
            this.RadiusLabel.AutoSize = true;
            this.RadiusLabel.Location = new System.Drawing.Point(3, 10);
            this.RadiusLabel.Name = "RadiusLabel";
            this.RadiusLabel.Size = new System.Drawing.Size(40, 13);
            this.RadiusLabel.TabIndex = 0;
            this.RadiusLabel.Text = "Radius";
            // 
            // RadiusTextBox
            // 
            this.RadiusTextBox.Location = new System.Drawing.Point(6, 26);
            this.RadiusTextBox.Name = "RadiusTextBox";
            this.RadiusTextBox.ShortcutsEnabled = false;
            this.RadiusTextBox.Size = new System.Drawing.Size(74, 20);
            this.RadiusTextBox.TabIndex = 1;
            this.RadiusTextBox.TextChanged += new System.EventHandler(this.RadiusTextBox_TextChanged);
            this.RadiusTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllCircleTextBox_KeyPress);
            // 
            // AreaLabel
            // 
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.Location = new System.Drawing.Point(3, 49);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(29, 13);
            this.AreaLabel.TabIndex = 2;
            this.AreaLabel.Text = "Area";
            // 
            // AreaTextBox
            // 
            this.AreaTextBox.Location = new System.Drawing.Point(6, 65);
            this.AreaTextBox.Name = "AreaTextBox";
            this.AreaTextBox.ShortcutsEnabled = false;
            this.AreaTextBox.Size = new System.Drawing.Size(74, 20);
            this.AreaTextBox.TabIndex = 3;
            this.AreaTextBox.TextChanged += new System.EventHandler(this.AreaTextBox_TextChanged);
            this.AreaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllCircleTextBox_KeyPress);
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(3, 88);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(40, 13);
            this.LengthLabel.TabIndex = 5;
            this.LengthLabel.Text = "Length";
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(6, 104);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.ShortcutsEnabled = false;
            this.LengthTextBox.Size = new System.Drawing.Size(74, 20);
            this.LengthTextBox.TabIndex = 6;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            this.LengthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllCircleTextBox_KeyPress);
            // 
            // CircleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LengthTextBox);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.AreaTextBox);
            this.Controls.Add(this.AreaLabel);
            this.Controls.Add(this.RadiusTextBox);
            this.Controls.Add(this.RadiusLabel);
            this.Name = "CircleControl";
            this.Size = new System.Drawing.Size(117, 162);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RadiusLabel;
        private System.Windows.Forms.TextBox RadiusTextBox;
        private System.Windows.Forms.Label AreaLabel;
        private System.Windows.Forms.TextBox AreaTextBox;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.TextBox LengthTextBox;
    }
}
