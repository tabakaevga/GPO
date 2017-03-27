namespace ModelView
{
    partial class SearchingForm
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
            this.FigureSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.CircleRadioButton = new System.Windows.Forms.RadioButton();
            this.RectangleRadioButton = new System.Windows.Forms.RadioButton();
            this.TriangleRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AreaRadioButton = new System.Windows.Forms.RadioButton();
            this.LengthRadioButton = new System.Windows.Forms.RadioButton();
            this.AnyFigureRadioButton = new System.Windows.Forms.RadioButton();
            this.AreaLabel = new System.Windows.Forms.Label();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.AreaTextBox = new System.Windows.Forms.TextBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.AnyParamRadioButton = new System.Windows.Forms.RadioButton();
            this.OKButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.FigureSearchGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FigureSearchGroupBox
            // 
            this.FigureSearchGroupBox.Controls.Add(this.AnyFigureRadioButton);
            this.FigureSearchGroupBox.Controls.Add(this.TriangleRadioButton);
            this.FigureSearchGroupBox.Controls.Add(this.RectangleRadioButton);
            this.FigureSearchGroupBox.Controls.Add(this.CircleRadioButton);
            this.FigureSearchGroupBox.Location = new System.Drawing.Point(12, 12);
            this.FigureSearchGroupBox.Name = "FigureSearchGroupBox";
            this.FigureSearchGroupBox.Size = new System.Drawing.Size(108, 112);
            this.FigureSearchGroupBox.TabIndex = 0;
            this.FigureSearchGroupBox.TabStop = false;
            this.FigureSearchGroupBox.Text = "Фигуры";
            // 
            // CircleRadioButton
            // 
            this.CircleRadioButton.AutoSize = true;
            this.CircleRadioButton.Location = new System.Drawing.Point(6, 19);
            this.CircleRadioButton.Name = "CircleRadioButton";
            this.CircleRadioButton.Size = new System.Drawing.Size(87, 17);
            this.CircleRadioButton.TabIndex = 0;
            this.CircleRadioButton.TabStop = true;
            this.CircleRadioButton.Text = "Окружность";
            this.CircleRadioButton.UseVisualStyleBackColor = true;
            this.CircleRadioButton.CheckedChanged += new System.EventHandler(this.CircleRadioButton_CheckedChanged);
            // 
            // RectangleRadioButton
            // 
            this.RectangleRadioButton.AutoSize = true;
            this.RectangleRadioButton.Location = new System.Drawing.Point(6, 42);
            this.RectangleRadioButton.Name = "RectangleRadioButton";
            this.RectangleRadioButton.Size = new System.Drawing.Size(105, 17);
            this.RectangleRadioButton.TabIndex = 1;
            this.RectangleRadioButton.TabStop = true;
            this.RectangleRadioButton.Text = "Прямоугольник";
            this.RectangleRadioButton.UseVisualStyleBackColor = true;
            this.RectangleRadioButton.CheckedChanged += new System.EventHandler(this.RectangleRadioButton_CheckedChanged);
            // 
            // TriangleRadioButton
            // 
            this.TriangleRadioButton.AutoSize = true;
            this.TriangleRadioButton.Location = new System.Drawing.Point(6, 65);
            this.TriangleRadioButton.Name = "TriangleRadioButton";
            this.TriangleRadioButton.Size = new System.Drawing.Size(90, 17);
            this.TriangleRadioButton.TabIndex = 2;
            this.TriangleRadioButton.TabStop = true;
            this.TriangleRadioButton.Text = "Треугольник";
            this.TriangleRadioButton.UseVisualStyleBackColor = true;
            this.TriangleRadioButton.CheckedChanged += new System.EventHandler(this.TriangleRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AnyParamRadioButton);
            this.groupBox1.Controls.Add(this.LengthRadioButton);
            this.groupBox1.Controls.Add(this.AreaRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(157, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 92);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Площадь/Периметр";
            // 
            // AreaRadioButton
            // 
            this.AreaRadioButton.AutoSize = true;
            this.AreaRadioButton.Location = new System.Drawing.Point(6, 19);
            this.AreaRadioButton.Name = "AreaRadioButton";
            this.AreaRadioButton.Size = new System.Drawing.Size(72, 17);
            this.AreaRadioButton.TabIndex = 0;
            this.AreaRadioButton.TabStop = true;
            this.AreaRadioButton.Text = "Площадь";
            this.AreaRadioButton.UseVisualStyleBackColor = true;
            // 
            // LengthRadioButton
            // 
            this.LengthRadioButton.AutoSize = true;
            this.LengthRadioButton.Location = new System.Drawing.Point(6, 38);
            this.LengthRadioButton.Name = "LengthRadioButton";
            this.LengthRadioButton.Size = new System.Drawing.Size(76, 17);
            this.LengthRadioButton.TabIndex = 1;
            this.LengthRadioButton.TabStop = true;
            this.LengthRadioButton.Text = "Периметр";
            this.LengthRadioButton.UseVisualStyleBackColor = true;
            // 
            // AnyFigureRadioButton
            // 
            this.AnyFigureRadioButton.AutoSize = true;
            this.AnyFigureRadioButton.Location = new System.Drawing.Point(6, 88);
            this.AnyFigureRadioButton.Name = "AnyFigureRadioButton";
            this.AnyFigureRadioButton.Size = new System.Drawing.Size(74, 17);
            this.AnyFigureRadioButton.TabIndex = 3;
            this.AnyFigureRadioButton.TabStop = true;
            this.AnyFigureRadioButton.Text = "Не важно";
            this.AnyFigureRadioButton.UseVisualStyleBackColor = true;
            this.AnyFigureRadioButton.CheckedChanged += new System.EventHandler(this.AnyFigureRadioButton_CheckedChanged);
            // 
            // AreaLabel
            // 
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.Location = new System.Drawing.Point(154, 111);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(54, 13);
            this.AreaLabel.TabIndex = 2;
            this.AreaLabel.Text = "Площадь";
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(154, 157);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(58, 13);
            this.LengthLabel.TabIndex = 3;
            this.LengthLabel.Text = "Периметр";
            // 
            // AreaTextBox
            // 
            this.AreaTextBox.Location = new System.Drawing.Point(157, 130);
            this.AreaTextBox.Name = "AreaTextBox";
            this.AreaTextBox.Size = new System.Drawing.Size(100, 20);
            this.AreaTextBox.TabIndex = 4;
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(157, 176);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.LengthTextBox.TabIndex = 5;
            // 
            // AnyParamRadioButton
            // 
            this.AnyParamRadioButton.AutoSize = true;
            this.AnyParamRadioButton.Location = new System.Drawing.Point(6, 61);
            this.AnyParamRadioButton.Name = "AnyParamRadioButton";
            this.AnyParamRadioButton.Size = new System.Drawing.Size(74, 17);
            this.AnyParamRadioButton.TabIndex = 2;
            this.AnyParamRadioButton.TabStop = true;
            this.AnyParamRadioButton.Text = "Не важно";
            this.AnyParamRadioButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(12, 157);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(80, 23);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SearchingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 237);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.LengthTextBox);
            this.Controls.Add(this.AreaTextBox);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.AreaLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FigureSearchGroupBox);
            this.Name = "SearchingForm";
            this.Text = "Поиск фигуры";
            this.FigureSearchGroupBox.ResumeLayout(false);
            this.FigureSearchGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox FigureSearchGroupBox;
        private System.Windows.Forms.RadioButton TriangleRadioButton;
        private System.Windows.Forms.RadioButton RectangleRadioButton;
        private System.Windows.Forms.RadioButton CircleRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton LengthRadioButton;
        private System.Windows.Forms.RadioButton AreaRadioButton;
        private System.Windows.Forms.RadioButton AnyFigureRadioButton;
        private System.Windows.Forms.Label AreaLabel;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.TextBox AreaTextBox;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.RadioButton AnyParamRadioButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button button2;
    }
}