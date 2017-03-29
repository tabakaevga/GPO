namespace ModelView
{
    partial class AddingForm
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
            this.SideATextBox = new System.Windows.Forms.TextBox();
            this.SideBTextBox = new System.Windows.Forms.TextBox();
            this.SideCTextBox = new System.Windows.Forms.TextBox();
            this.RadiusTextBox = new System.Windows.Forms.TextBox();
            this.AddFigureGroupBox = new System.Windows.Forms.GroupBox();
            this.TriangleRadioButton = new System.Windows.Forms.RadioButton();
            this.RectangleRadioButton = new System.Windows.Forms.RadioButton();
            this.CircleRadioButton = new System.Windows.Forms.RadioButton();
            this.SideALabel = new System.Windows.Forms.Label();
            this.SideBLabel = new System.Windows.Forms.Label();
            this.SideCLabel = new System.Windows.Forms.Label();
            this.RadiusLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.AddFigureGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideATextBox
            // 
            this.SideATextBox.Location = new System.Drawing.Point(167, 28);
            this.SideATextBox.Name = "SideATextBox";
            this.SideATextBox.Size = new System.Drawing.Size(100, 20);
            this.SideATextBox.TabIndex = 0;
            this.SideATextBox.Visible = false;
            // 
            // SideBTextBox
            // 
            this.SideBTextBox.Location = new System.Drawing.Point(167, 71);
            this.SideBTextBox.Name = "SideBTextBox";
            this.SideBTextBox.Size = new System.Drawing.Size(100, 20);
            this.SideBTextBox.TabIndex = 1;
            this.SideBTextBox.Visible = false;
            // 
            // SideCTextBox
            // 
            this.SideCTextBox.Location = new System.Drawing.Point(167, 115);
            this.SideCTextBox.Name = "SideCTextBox";
            this.SideCTextBox.Size = new System.Drawing.Size(100, 20);
            this.SideCTextBox.TabIndex = 2;
            this.SideCTextBox.Visible = false;
            // 
            // RadiusTextBox
            // 
            this.RadiusTextBox.Location = new System.Drawing.Point(167, 28);
            this.RadiusTextBox.Name = "RadiusTextBox";
            this.RadiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.RadiusTextBox.TabIndex = 3;
            // 
            // AddFigureGroupBox
            // 
            this.AddFigureGroupBox.Controls.Add(this.TriangleRadioButton);
            this.AddFigureGroupBox.Controls.Add(this.RectangleRadioButton);
            this.AddFigureGroupBox.Controls.Add(this.CircleRadioButton);
            this.AddFigureGroupBox.Location = new System.Drawing.Point(12, 12);
            this.AddFigureGroupBox.Name = "AddFigureGroupBox";
            this.AddFigureGroupBox.Size = new System.Drawing.Size(133, 100);
            this.AddFigureGroupBox.TabIndex = 4;
            this.AddFigureGroupBox.TabStop = false;
            this.AddFigureGroupBox.Text = "Figures";
            // 
            // TriangleRadioButton
            // 
            this.TriangleRadioButton.AutoSize = true;
            this.TriangleRadioButton.Location = new System.Drawing.Point(22, 66);
            this.TriangleRadioButton.Name = "TriangleRadioButton";
            this.TriangleRadioButton.Size = new System.Drawing.Size(63, 17);
            this.TriangleRadioButton.TabIndex = 2;
            this.TriangleRadioButton.Text = "Triangle";
            this.TriangleRadioButton.UseVisualStyleBackColor = true;
            this.TriangleRadioButton.CheckedChanged += new System.EventHandler(this.RadioSelectTriangle_CheckedChanged);
            // 
            // RectangleRadioButton
            // 
            this.RectangleRadioButton.AutoSize = true;
            this.RectangleRadioButton.Location = new System.Drawing.Point(22, 43);
            this.RectangleRadioButton.Name = "RectangleRadioButton";
            this.RectangleRadioButton.Size = new System.Drawing.Size(74, 17);
            this.RectangleRadioButton.TabIndex = 1;
            this.RectangleRadioButton.Text = "Rectangle";
            this.RectangleRadioButton.UseVisualStyleBackColor = true;
            this.RectangleRadioButton.CheckedChanged += new System.EventHandler(this.RadioSelectRectangle_CheckedChanged);
            // 
            // CircleRadioButton
            // 
            this.CircleRadioButton.AutoSize = true;
            this.CircleRadioButton.Checked = true;
            this.CircleRadioButton.Location = new System.Drawing.Point(22, 20);
            this.CircleRadioButton.Name = "CircleRadioButton";
            this.CircleRadioButton.Size = new System.Drawing.Size(51, 17);
            this.CircleRadioButton.TabIndex = 0;
            this.CircleRadioButton.TabStop = true;
            this.CircleRadioButton.Text = "Circle";
            this.CircleRadioButton.UseVisualStyleBackColor = true;
            this.CircleRadioButton.CheckedChanged += new System.EventHandler(this.RadioSelectCircle_CheckedChanged);
            // 
            // SideALabel
            // 
            this.SideALabel.AutoSize = true;
            this.SideALabel.Location = new System.Drawing.Point(164, 12);
            this.SideALabel.Name = "SideALabel";
            this.SideALabel.Size = new System.Drawing.Size(38, 13);
            this.SideALabel.TabIndex = 5;
            this.SideALabel.Text = "Side A";
            this.SideALabel.Visible = false;
            // 
            // SideBLabel
            // 
            this.SideBLabel.AutoSize = true;
            this.SideBLabel.Location = new System.Drawing.Point(164, 55);
            this.SideBLabel.Name = "SideBLabel";
            this.SideBLabel.Size = new System.Drawing.Size(38, 13);
            this.SideBLabel.TabIndex = 6;
            this.SideBLabel.Text = "Side B";
            this.SideBLabel.Visible = false;
            // 
            // SideCLabel
            // 
            this.SideCLabel.AutoSize = true;
            this.SideCLabel.Location = new System.Drawing.Point(164, 99);
            this.SideCLabel.Name = "SideCLabel";
            this.SideCLabel.Size = new System.Drawing.Size(38, 13);
            this.SideCLabel.TabIndex = 7;
            this.SideCLabel.Text = "Side C";
            this.SideCLabel.Visible = false;
            // 
            // RadiusLabel
            // 
            this.RadiusLabel.AutoSize = true;
            this.RadiusLabel.Location = new System.Drawing.Point(164, 12);
            this.RadiusLabel.Name = "RadiusLabel";
            this.RadiusLabel.Size = new System.Drawing.Size(40, 13);
            this.RadiusLabel.TabIndex = 8;
            this.RadiusLabel.Text = "Radius";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(12, 154);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 9;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // AddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 200);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.RadiusLabel);
            this.Controls.Add(this.SideCLabel);
            this.Controls.Add(this.SideBLabel);
            this.Controls.Add(this.SideALabel);
            this.Controls.Add(this.AddFigureGroupBox);
            this.Controls.Add(this.RadiusTextBox);
            this.Controls.Add(this.SideCTextBox);
            this.Controls.Add(this.SideBTextBox);
            this.Controls.Add(this.SideATextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(325, 239);
            this.MinimumSize = new System.Drawing.Size(325, 239);
            this.Name = "AddingForm";
            this.Text = "Add Figure";
            this.AddFigureGroupBox.ResumeLayout(false);
            this.AddFigureGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SideATextBox;
        private System.Windows.Forms.TextBox SideBTextBox;
        private System.Windows.Forms.TextBox SideCTextBox;
        private System.Windows.Forms.TextBox RadiusTextBox;
        private System.Windows.Forms.GroupBox AddFigureGroupBox;
        private System.Windows.Forms.RadioButton TriangleRadioButton;
        private System.Windows.Forms.RadioButton RectangleRadioButton;
        private System.Windows.Forms.RadioButton CircleRadioButton;
        private System.Windows.Forms.Label SideALabel;
        private System.Windows.Forms.Label SideBLabel;
        private System.Windows.Forms.Label SideCLabel;
        private System.Windows.Forms.Label RadiusLabel;
        private System.Windows.Forms.Button OKButton;
    }
}