namespace ModelView.Controls.FigureControls
{
    partial class TriangleControl
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
            this.components = new System.ComponentModel.Container();
            this.SideCTextBox = new System.Windows.Forms.TextBox();
            this.SideATextBox = new System.Windows.Forms.TextBox();
            this.SideCLabel = new System.Windows.Forms.Label();
            this.SideALabel = new System.Windows.Forms.Label();
            this.SideBTextBox = new System.Windows.Forms.TextBox();
            this.SideBLabel = new System.Windows.Forms.Label();
            this.ToolTipTriangle = new System.Windows.Forms.ToolTip(this.components);
            this.TextBoxControl = new ModelView.Controls.TextBoxControl();
            this.SuspendLayout();
            // 
            // SideCTextBox
            // 
            this.SideCTextBox.Location = new System.Drawing.Point(6, 67);
            this.SideCTextBox.Name = "SideCTextBox";
            this.SideCTextBox.ShortcutsEnabled = false;
            this.SideCTextBox.Size = new System.Drawing.Size(74, 20);
            this.SideCTextBox.TabIndex = 13;
            this.SideCTextBox.TextChanged += new System.EventHandler(this.AllTriangleTextBox_TextChanged);
            // 
            // SideATextBox
            // 
            this.SideATextBox.Location = new System.Drawing.Point(6, 27);
            this.SideATextBox.Name = "SideATextBox";
            this.SideATextBox.ShortcutsEnabled = false;
            this.SideATextBox.Size = new System.Drawing.Size(74, 20);
            this.SideATextBox.TabIndex = 12;
            this.SideATextBox.TextChanged += new System.EventHandler(this.AllTriangleTextBox_TextChanged);
            // 
            // SideCLabel
            // 
            this.SideCLabel.AutoSize = true;
            this.SideCLabel.Location = new System.Drawing.Point(3, 51);
            this.SideCLabel.Name = "SideCLabel";
            this.SideCLabel.Size = new System.Drawing.Size(35, 13);
            this.SideCLabel.TabIndex = 9;
            this.SideCLabel.Text = "SideC";
            // 
            // SideALabel
            // 
            this.SideALabel.AutoSize = true;
            this.SideALabel.Location = new System.Drawing.Point(3, 11);
            this.SideALabel.Name = "SideALabel";
            this.SideALabel.Size = new System.Drawing.Size(35, 13);
            this.SideALabel.TabIndex = 8;
            this.SideALabel.Text = "SideA";
            // 
            // SideBTextBox
            // 
            this.SideBTextBox.Location = new System.Drawing.Point(93, 27);
            this.SideBTextBox.Name = "SideBTextBox";
            this.SideBTextBox.ShortcutsEnabled = false;
            this.SideBTextBox.Size = new System.Drawing.Size(74, 20);
            this.SideBTextBox.TabIndex = 17;
            this.SideBTextBox.TextChanged += new System.EventHandler(this.AllTriangleTextBox_TextChanged);
            // 
            // SideBLabel
            // 
            this.SideBLabel.AutoSize = true;
            this.SideBLabel.Location = new System.Drawing.Point(90, 11);
            this.SideBLabel.Name = "SideBLabel";
            this.SideBLabel.Size = new System.Drawing.Size(35, 13);
            this.SideBLabel.TabIndex = 16;
            this.SideBLabel.Text = "SideB";
            // 
            // TextBoxControl
            // 
            this.TextBoxControl.Location = new System.Drawing.Point(0, 93);
            this.TextBoxControl.Name = "TextBoxControl";
            this.TextBoxControl.Size = new System.Drawing.Size(90, 88);
            this.TextBoxControl.TabIndex = 18;
            // 
            // TriangleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextBoxControl);
            this.Controls.Add(this.SideBTextBox);
            this.Controls.Add(this.SideBLabel);
            this.Controls.Add(this.SideCTextBox);
            this.Controls.Add(this.SideATextBox);
            this.Controls.Add(this.SideCLabel);
            this.Controls.Add(this.SideALabel);
            this.Name = "TriangleControl";
            this.Size = new System.Drawing.Size(182, 193);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SideCTextBox;
        private System.Windows.Forms.TextBox SideATextBox;
        private System.Windows.Forms.Label SideCLabel;
        private System.Windows.Forms.Label SideALabel;
        private System.Windows.Forms.TextBox SideBTextBox;
        private System.Windows.Forms.Label SideBLabel;
        private System.Windows.Forms.ToolTip ToolTipTriangle;
        private TextBoxControl TextBoxControl;
    }
}
