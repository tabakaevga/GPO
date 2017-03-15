namespace WindowsFormsApplication1
{
    partial class StartingForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FigureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FigureArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FigureLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SideA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SideB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SideC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Object";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Remove Object";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(12, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 168);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фигуры:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FigureName,
            this.FigureArea,
            this.FigureLength,
            this.SideA,
            this.SideB,
            this.SideC});
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(460, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // FigureName
            // 
            this.FigureName.HeaderText = "FigureName";
            this.FigureName.Name = "FigureName";
            this.FigureName.ReadOnly = true;
            this.FigureName.Width = 70;
            // 
            // FigureArea
            // 
            this.FigureArea.HeaderText = "FigureArea";
            this.FigureArea.Name = "FigureArea";
            this.FigureArea.ReadOnly = true;
            this.FigureArea.Width = 70;
            // 
            // FigureLength
            // 
            this.FigureLength.HeaderText = "FigureLength";
            this.FigureLength.Name = "FigureLength";
            this.FigureLength.ReadOnly = true;
            this.FigureLength.Width = 72;
            // 
            // SideA
            // 
            this.SideA.HeaderText = "SideA/Radius";
            this.SideA.Name = "SideA";
            this.SideA.ReadOnly = true;
            this.SideA.Width = 75;
            // 
            // SideB
            // 
            this.SideB.HeaderText = "SideB";
            this.SideB.Name = "SideB";
            this.SideB.ReadOnly = true;
            this.SideB.Width = 65;
            // 
            // SideC
            // 
            this.SideC.HeaderText = "SideC";
            this.SideC.Name = "SideC";
            this.SideC.ReadOnly = true;
            this.SideC.Width = 65;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 282);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Расчет площадей";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FigureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FigureArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn FigureLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn SideA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SideB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SideC;
    }
}

