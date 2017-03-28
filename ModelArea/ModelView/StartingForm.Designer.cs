namespace ModelView
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
            this.AddObjectButton = new System.Windows.Forms.Button();
            this.RemoveObjectButton = new System.Windows.Forms.Button();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.FileToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.GenerateRandomButton = new System.Windows.Forms.Button();
            this.SearchingObjectsButton = new System.Windows.Forms.Button();
            this.GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddObjectButton
            // 
            this.AddObjectButton.Location = new System.Drawing.Point(12, 213);
            this.AddObjectButton.Name = "AddObjectButton";
            this.AddObjectButton.Size = new System.Drawing.Size(86, 33);
            this.AddObjectButton.TabIndex = 0;
            this.AddObjectButton.Text = "AddObject";
            this.AddObjectButton.UseVisualStyleBackColor = true;
            this.AddObjectButton.Click += new System.EventHandler(this.AddObjectButton_Click);
            // 
            // RemoveObjectButton
            // 
            this.RemoveObjectButton.Location = new System.Drawing.Point(104, 213);
            this.RemoveObjectButton.Name = "RemoveObjectButton";
            this.RemoveObjectButton.Size = new System.Drawing.Size(86, 33);
            this.RemoveObjectButton.TabIndex = 1;
            this.RemoveObjectButton.Text = "Delete Objects";
            this.RemoveObjectButton.UseVisualStyleBackColor = true;
            this.RemoveObjectButton.Click += new System.EventHandler(this.RemoveObjectButton_Click);
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.DataGridView);
            this.GroupBox.Location = new System.Drawing.Point(12, 28);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(354, 167);
            this.GroupBox.TabIndex = 14;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Figures:";
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(6, 19);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(346, 143);
            this.DataGridView.TabIndex = 0;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "fg";
            this.saveFileDialog.Filter = "fg Файлы|*.fg";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripDropDownButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(386, 25);
            this.toolStrip.TabIndex = 15;
            this.toolStrip.Text = "toolStrip1";
            // 
            // FileToolStripDropDownButton
            // 
            this.FileToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FileToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveAsToolStripMenuItem,
            this.OpenToolStripMenuItem});
            this.FileToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FileToolStripDropDownButton.Name = "FileToolStripDropDownButton";
            this.FileToolStripDropDownButton.Size = new System.Drawing.Size(38, 22);
            this.FileToolStripDropDownButton.Tag = "";
            this.FileToolStripDropDownButton.Text = "File";
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SaveAsToolStripMenuItem.Text = "Save as..";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.OpenToolStripMenuItem.Text = "Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "FigureGrid files|*.fg";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // GenerateRandomButton
            // 
            this.GenerateRandomButton.Location = new System.Drawing.Point(12, 252);
            this.GenerateRandomButton.Name = "GenerateRandomButton";
            this.GenerateRandomButton.Size = new System.Drawing.Size(270, 33);
            this.GenerateRandomButton.TabIndex = 16;
            this.GenerateRandomButton.Text = "Generate Random Data";
            this.GenerateRandomButton.UseVisualStyleBackColor = true;
            this.GenerateRandomButton.Visible = false;
            this.GenerateRandomButton.Click += new System.EventHandler(this.GenerateRandomButton_Click);
            // 
            // SearchingObjectsButton
            // 
            this.SearchingObjectsButton.Location = new System.Drawing.Point(196, 213);
            this.SearchingObjectsButton.Name = "SearchingObjectsButton";
            this.SearchingObjectsButton.Size = new System.Drawing.Size(86, 33);
            this.SearchingObjectsButton.TabIndex = 17;
            this.SearchingObjectsButton.Text = "Find Objects";
            this.SearchingObjectsButton.UseVisualStyleBackColor = true;
            this.SearchingObjectsButton.Click += new System.EventHandler(this.SearchingObjectsButton_Click);
            // 
            // StartingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 320);
            this.Controls.Add(this.SearchingObjectsButton);
            this.Controls.Add(this.GenerateRandomButton);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.RemoveObjectButton);
            this.Controls.Add(this.AddObjectButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StartingForm";
            this.Text = "Model View";
            this.GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddObjectButton;
        private System.Windows.Forms.Button RemoveObjectButton;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton FileToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button GenerateRandomButton;
        private System.Windows.Forms.Button SearchingObjectsButton;
    }
}

