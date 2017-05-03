namespace ModelView.Controls.FigureControls
{
    partial class FigureControl
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
            this.FiguresComboBox = new System.Windows.Forms.ComboBox();
            this.FigureParams = new System.Windows.Forms.GroupBox();
            this.TriangleControl = new ModelView.Controls.FigureControls.TriangleControl();
            this.RectangleControl = new ModelView.Controls.FigureControls.RectangleControl();
            this.CircleControl = new ModelView.Controls.FigureControls.CircleControl();
            this.FigureParams.SuspendLayout();
            this.SuspendLayout();
            // 
            // FiguresComboBox
            // 
            this.FiguresComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiguresComboBox.FormattingEnabled = true;
            this.FiguresComboBox.Items.AddRange(new object[] {
            "Circle",
            "Triangle",
            "Rectangle"});
            this.FiguresComboBox.Location = new System.Drawing.Point(14, 13);
            this.FiguresComboBox.Name = "FiguresComboBox";
            this.FiguresComboBox.Size = new System.Drawing.Size(121, 21);
            this.FiguresComboBox.TabIndex = 0;
            this.FiguresComboBox.SelectedIndexChanged += new System.EventHandler(this.FiguresComboBox_SelectedIndexChanged);
            // 
            // FigureParams
            // 
            this.FigureParams.Controls.Add(this.TriangleControl);
            this.FigureParams.Controls.Add(this.RectangleControl);
            this.FigureParams.Controls.Add(this.CircleControl);
            this.FigureParams.Location = new System.Drawing.Point(14, 40);
            this.FigureParams.Name = "FigureParams";
            this.FigureParams.Size = new System.Drawing.Size(256, 217);
            this.FigureParams.TabIndex = 1;
            this.FigureParams.TabStop = false;
            this.FigureParams.Text = "Figure Parameters";
            // 
            // TriangleControl
            // 
            this.TriangleControl.Location = new System.Drawing.Point(6, 19);
            this.TriangleControl.Name = "TriangleControl";
            this.TriangleControl.ReadOnly = false;
            this.TriangleControl.Size = new System.Drawing.Size(229, 193);
            this.TriangleControl.TabIndex = 2;
            this.TriangleControl.Visible = false;
            // 
            // RectangleControl
            // 
            this.RectangleControl.Location = new System.Drawing.Point(6, 19);
            this.RectangleControl.Name = "RectangleControl";
            this.RectangleControl.ReadOnly = false;
            this.RectangleControl.Size = new System.Drawing.Size(164, 180);
            this.RectangleControl.TabIndex = 1;
            this.RectangleControl.Visible = false;
            // 
            // CircleControl
            // 
            this.CircleControl.Location = new System.Drawing.Point(6, 19);
            this.CircleControl.Name = "CircleControl";
            this.CircleControl.ReadOnly = false;
            this.CircleControl.Size = new System.Drawing.Size(117, 162);
            this.CircleControl.TabIndex = 0;
            this.CircleControl.Visible = false;
            // 
            // FigureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FigureParams);
            this.Controls.Add(this.FiguresComboBox);
            this.Name = "FigureControl";
            this.Size = new System.Drawing.Size(283, 267);
            this.FigureParams.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox FiguresComboBox;
        private System.Windows.Forms.GroupBox FigureParams;
        private TriangleControl TriangleControl;
        private RectangleControl RectangleControl;
        private CircleControl CircleControl;
    }
}
