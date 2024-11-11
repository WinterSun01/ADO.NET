namespace Academy
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageStudents = new System.Windows.Forms.TabPage();
            this.comboBoxStudentsDirection = new System.Windows.Forms.ComboBox();
            this.labelStudentsDirection = new System.Windows.Forms.Label();
            this.labelStudentsGroup = new System.Windows.Forms.Label();
            this.comboBoxStudentsGroup = new System.Windows.Forms.ComboBox();
            this.labelSearchStudent = new System.Windows.Forms.Label();
            this.textBoxSearchStudent = new System.Windows.Forms.TextBox();
            this.toolStripStatusLabelStudentsCount = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.tabPageGroups = new System.Windows.Forms.TabPage();
            this.tabPageDisciplines = new System.Windows.Forms.TabPage();
            this.tabPageTeachers = new System.Windows.Forms.TabPage();
            this.tabControlMain.SuspendLayout();
            this.tabPageStudents.SuspendLayout();
            this.toolStripStatusLabelStudentsCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageStudents);
            this.tabControlMain.Controls.Add(this.tabPageGroups);
            this.tabControlMain.Controls.Add(this.tabPageDisciplines);
            this.tabControlMain.Controls.Add(this.tabPageTeachers);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(846, 508);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageStudents
            // 
            this.tabPageStudents.Controls.Add(this.comboBoxStudentsDirection);
            this.tabPageStudents.Controls.Add(this.labelStudentsDirection);
            this.tabPageStudents.Controls.Add(this.labelStudentsGroup);
            this.tabPageStudents.Controls.Add(this.comboBoxStudentsGroup);
            this.tabPageStudents.Controls.Add(this.labelSearchStudent);
            this.tabPageStudents.Controls.Add(this.textBoxSearchStudent);
            this.tabPageStudents.Controls.Add(this.toolStripStatusLabelStudentsCount);
            this.tabPageStudents.Controls.Add(this.dataGridViewStudents);
            this.tabPageStudents.Location = new System.Drawing.Point(4, 25);
            this.tabPageStudents.Name = "tabPageStudents";
            this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudents.Size = new System.Drawing.Size(838, 479);
            this.tabPageStudents.TabIndex = 0;
            this.tabPageStudents.Text = "Students";
            this.tabPageStudents.UseVisualStyleBackColor = true;
            this.tabPageStudents.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // comboBoxStudentsDirection
            // 
            this.comboBoxStudentsDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStudentsDirection.FormattingEnabled = true;
            this.comboBoxStudentsDirection.Location = new System.Drawing.Point(628, 8);
            this.comboBoxStudentsDirection.Name = "comboBoxStudentsDirection";
            this.comboBoxStudentsDirection.Size = new System.Drawing.Size(202, 24);
            this.comboBoxStudentsDirection.TabIndex = 7;
            // 
            // labelStudentsDirection
            // 
            this.labelStudentsDirection.AutoSize = true;
            this.labelStudentsDirection.Location = new System.Drawing.Point(522, 10);
            this.labelStudentsDirection.Name = "labelStudentsDirection";
            this.labelStudentsDirection.Size = new System.Drawing.Size(100, 16);
            this.labelStudentsDirection.TabIndex = 6;
            this.labelStudentsDirection.Text = "Направление:";
            // 
            // labelStudentsGroup
            // 
            this.labelStudentsGroup.AutoSize = true;
            this.labelStudentsGroup.Location = new System.Drawing.Point(234, 14);
            this.labelStudentsGroup.Name = "labelStudentsGroup";
            this.labelStudentsGroup.Size = new System.Drawing.Size(57, 16);
            this.labelStudentsGroup.TabIndex = 5;
            this.labelStudentsGroup.Text = "Группа:";
            // 
            // comboBoxStudentsGroup
            // 
            this.comboBoxStudentsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStudentsGroup.FormattingEnabled = true;
            this.comboBoxStudentsGroup.Location = new System.Drawing.Point(306, 8);
            this.comboBoxStudentsGroup.Name = "comboBoxStudentsGroup";
            this.comboBoxStudentsGroup.Size = new System.Drawing.Size(210, 24);
            this.comboBoxStudentsGroup.TabIndex = 4;
            // 
            // labelSearchStudent
            // 
            this.labelSearchStudent.AutoSize = true;
            this.labelSearchStudent.Location = new System.Drawing.Point(8, 14);
            this.labelSearchStudent.Name = "labelSearchStudent";
            this.labelSearchStudent.Size = new System.Drawing.Size(50, 16);
            this.labelSearchStudent.TabIndex = 3;
            this.labelSearchStudent.Text = "Поиск:";
            // 
            // textBoxSearchStudent
            // 
            this.textBoxSearchStudent.Location = new System.Drawing.Point(64, 11);
            this.textBoxSearchStudent.Name = "textBoxSearchStudent";
            this.textBoxSearchStudent.Size = new System.Drawing.Size(144, 22);
            this.textBoxSearchStudent.TabIndex = 2;
            // 
            // toolStripStatusLabelStudentsCount
            // 
            this.toolStripStatusLabelStudentsCount.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripStatusLabelStudentsCount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.toolStripStatusLabelStudentsCount.Location = new System.Drawing.Point(3, 450);
            this.toolStripStatusLabelStudentsCount.Name = "toolStripStatusLabelStudentsCount";
            this.toolStripStatusLabelStudentsCount.Size = new System.Drawing.Size(832, 26);
            this.toolStripStatusLabelStudentsCount.TabIndex = 1;
            this.toolStripStatusLabelStudentsCount.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(8, 38);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.RowTemplate.Height = 24;
            this.dataGridViewStudents.Size = new System.Drawing.Size(822, 424);
            this.dataGridViewStudents.TabIndex = 0;
            // 
            // tabPageGroups
            // 
            this.tabPageGroups.Location = new System.Drawing.Point(4, 25);
            this.tabPageGroups.Name = "tabPageGroups";
            this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGroups.Size = new System.Drawing.Size(792, 417);
            this.tabPageGroups.TabIndex = 1;
            this.tabPageGroups.Text = "Groups";
            this.tabPageGroups.UseVisualStyleBackColor = true;
            // 
            // tabPageDisciplines
            // 
            this.tabPageDisciplines.Location = new System.Drawing.Point(4, 25);
            this.tabPageDisciplines.Name = "tabPageDisciplines";
            this.tabPageDisciplines.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDisciplines.Size = new System.Drawing.Size(792, 417);
            this.tabPageDisciplines.TabIndex = 2;
            this.tabPageDisciplines.Text = "Disciplines";
            this.tabPageDisciplines.UseVisualStyleBackColor = true;
            // 
            // tabPageTeachers
            // 
            this.tabPageTeachers.Location = new System.Drawing.Point(4, 25);
            this.tabPageTeachers.Name = "tabPageTeachers";
            this.tabPageTeachers.Size = new System.Drawing.Size(792, 417);
            this.tabPageTeachers.TabIndex = 3;
            this.tabPageTeachers.Text = "Teachers";
            this.tabPageTeachers.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 508);
            this.Controls.Add(this.tabControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Academy";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageStudents.ResumeLayout(false);
            this.tabPageStudents.PerformLayout();
            this.toolStripStatusLabelStudentsCount.ResumeLayout(false);
            this.toolStripStatusLabelStudentsCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageStudents;
        private System.Windows.Forms.TabPage tabPageGroups;
        private System.Windows.Forms.TabPage tabPageDisciplines;
        private System.Windows.Forms.TabPage tabPageTeachers;
        private System.Windows.Forms.StatusStrip toolStripStatusLabelStudentsCount;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ComboBox comboBoxStudentsDirection;
        private System.Windows.Forms.Label labelStudentsDirection;
        private System.Windows.Forms.Label labelStudentsGroup;
        private System.Windows.Forms.ComboBox comboBoxStudentsGroup;
        private System.Windows.Forms.Label labelSearchStudent;
        private System.Windows.Forms.TextBox textBoxSearchStudent;
    }
}

