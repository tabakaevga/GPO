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
            this.components = new System.ComponentModel.Container();
            this.SideATextBox = new System.Windows.Forms.TextBox();
            this.SideBTextBox = new System.Windows.Forms.TextBox();
            this.SideCTextBox = new System.Windows.Forms.TextBox();
            this.RadiusTextBox = new System.Windows.Forms.TextBox();
            this.SideALabel = new System.Windows.Forms.Label();
            this.SideBLabel = new System.Windows.Forms.Label();
            this.SideCLabel = new System.Windows.Forms.Label();
            this.RadiusLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.FiguresComboBox = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.TipsForInput = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // SideATextBox
            // 
            this.SideATextBox.Location = new System.Drawing.Point(15, 71);
            this.SideATextBox.Name = "SideATextBox";
            this.SideATextBox.Size = new System.Drawing.Size(100, 20);
            this.SideATextBox.TabIndex = 0;
            this.SideATextBox.Visible = false;
            // 
            // SideBTextBox
            // 
            this.SideBTextBox.Location = new System.Drawing.Point(122, 71);
            this.SideBTextBox.Name = "SideBTextBox";
            this.SideBTextBox.Size = new System.Drawing.Size(100, 20);
            this.SideBTextBox.TabIndex = 1;
            this.TipsForInput.SetToolTip(this.SideBTextBox, "Enter Real numbers above 0");
            this.SideBTextBox.Visible = false;
            // 
            // SideCTextBox
            // 
            this.SideCTextBox.Location = new System.Drawing.Point(229, 71);
            this.SideCTextBox.Name = "SideCTextBox";
            this.SideCTextBox.Size = new System.Drawing.Size(100, 20);
            this.SideCTextBox.TabIndex = 2;
            this.TipsForInput.SetToolTip(this.SideCTextBox, "Enter Real numbers above 0");
            this.SideCTextBox.Visible = false;
            // 
            // RadiusTextBox
            // 
            this.RadiusTextBox.Location = new System.Drawing.Point(15, 71);
            this.RadiusTextBox.Name = "RadiusTextBox";
            this.RadiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.RadiusTextBox.TabIndex = 3;
            this.TipsForInput.SetToolTip(this.RadiusTextBox, "Enter Real numbers above 0");
            // 
            // SideALabel
            // 
            this.SideALabel.AutoSize = true;
            this.SideALabel.Location = new System.Drawing.Point(12, 55);
            this.SideALabel.Name = "SideALabel";
            this.SideALabel.Size = new System.Drawing.Size(38, 13);
            this.SideALabel.TabIndex = 5;
            this.SideALabel.Text = "Side A";
            this.SideALabel.Visible = false;
            // 
            // SideBLabel
            // 
            this.SideBLabel.AutoSize = true;
            this.SideBLabel.Location = new System.Drawing.Point(119, 55);
            this.SideBLabel.Name = "SideBLabel";
            this.SideBLabel.Size = new System.Drawing.Size(38, 13);
            this.SideBLabel.TabIndex = 6;
            this.SideBLabel.Text = "Side B";
            this.SideBLabel.Visible = false;
            // 
            // SideCLabel
            // 
            this.SideCLabel.AutoSize = true;
            this.SideCLabel.Location = new System.Drawing.Point(226, 55);
            this.SideCLabel.Name = "SideCLabel";
            this.SideCLabel.Size = new System.Drawing.Size(38, 13);
            this.SideCLabel.TabIndex = 7;
            this.SideCLabel.Text = "Side C";
            this.SideCLabel.Visible = false;
            // 
            // RadiusLabel
            // 
            this.RadiusLabel.AutoSize = true;
            this.RadiusLabel.Location = new System.Drawing.Point(12, 55);
            this.RadiusLabel.Name = "RadiusLabel";
            this.RadiusLabel.Size = new System.Drawing.Size(40, 13);
            this.RadiusLabel.TabIndex = 8;
            this.RadiusLabel.Text = "Radius";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(12, 119);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 9;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // FiguresComboBox
            // 
            this.FiguresComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiguresComboBox.FormattingEnabled = true;
            this.FiguresComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.FiguresComboBox.Items.AddRange(new object[] {
            "Circle",
            "Triangle",
            "Rectangle"});
            this.FiguresComboBox.Location = new System.Drawing.Point(12, 21);
            this.FiguresComboBox.Name = "FiguresComboBox";
            this.FiguresComboBox.Size = new System.Drawing.Size(121, 21);
            this.FiguresComboBox.TabIndex = 10;
            this.FiguresComboBox.SelectedIndexChanged += new System.EventHandler(this.FiguresComboBox_SelectedIndexChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(103, 119);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.TipsForInput.SetToolTip(this.CancelButton, "Cancells Adding");
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 180);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.FiguresComboBox);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.RadiusLabel);
            this.Controls.Add(this.SideCLabel);
            this.Controls.Add(this.SideBLabel);
            this.Controls.Add(this.SideALabel);
            this.Controls.Add(this.RadiusTextBox);
            this.Controls.Add(this.SideCTextBox);
            this.Controls.Add(this.SideBTextBox);
            this.Controls.Add(this.SideATextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(360, 239);
            this.MinimumSize = new System.Drawing.Size(325, 180);
            this.Name = "AddingForm";
            this.Text = "Add Figure";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddingForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddingForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AddingForm_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SideATextBox;
        private System.Windows.Forms.TextBox SideBTextBox;
        private System.Windows.Forms.TextBox SideCTextBox;
        private System.Windows.Forms.TextBox RadiusTextBox;
        private System.Windows.Forms.Label SideALabel;
        private System.Windows.Forms.Label SideBLabel;
        private System.Windows.Forms.Label SideCLabel;
        private System.Windows.Forms.Label RadiusLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.ComboBox FiguresComboBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ToolTip TipsForInput;
    }
}