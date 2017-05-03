namespace ModelView.Controls.FigureControls
{
    partial class RectangleControl
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
            this.WidthLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.AreaLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.AreaTextBox = new System.Windows.Forms.TextBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(3, 10);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(35, 13);
            this.WidthLabel.TabIndex = 0;
            this.WidthLabel.Text = "Width";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(3, 49);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(38, 13);
            this.HeightLabel.TabIndex = 1;
            this.HeightLabel.Text = "Height";
            // 
            // AreaLabel
            // 
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.Location = new System.Drawing.Point(3, 88);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(29, 13);
            this.AreaLabel.TabIndex = 2;
            this.AreaLabel.Text = "Area";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(3, 127);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(40, 13);
            this.LengthLabel.TabIndex = 3;
            this.LengthLabel.Text = "Length";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(6, 26);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.ShortcutsEnabled = false;
            this.WidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.WidthTextBox.TabIndex = 4;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.AllRectangleTextBox_TextChanged);
            this.WidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllRectangleTextBox_KeyPress);
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(6, 65);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.ShortcutsEnabled = false;
            this.HeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.HeightTextBox.TabIndex = 5;
            this.HeightTextBox.TextChanged += new System.EventHandler(this.AllRectangleTextBox_TextChanged);
            this.HeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllRectangleTextBox_KeyPress);
            // 
            // AreaTextBox
            // 
            this.AreaTextBox.Location = new System.Drawing.Point(6, 104);
            this.AreaTextBox.Name = "AreaTextBox";
            this.AreaTextBox.ReadOnly = true;
            this.AreaTextBox.ShortcutsEnabled = false;
            this.AreaTextBox.Size = new System.Drawing.Size(100, 20);
            this.AreaTextBox.TabIndex = 6;
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(6, 143);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.ReadOnly = true;
            this.LengthTextBox.ShortcutsEnabled = false;
            this.LengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.LengthTextBox.TabIndex = 7;
            // 
            // RectangleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LengthTextBox);
            this.Controls.Add(this.AreaTextBox);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.AreaLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WidthLabel);
            this.Name = "RectangleControl";
            this.Size = new System.Drawing.Size(164, 180);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label AreaLabel;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox AreaTextBox;
        private System.Windows.Forms.TextBox LengthTextBox;
    }
}
