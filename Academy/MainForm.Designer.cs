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
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.tabPageGroups = new System.Windows.Forms.TabPage();
            this.tabPageDisciplines = new System.Windows.Forms.TabPage();
            this.tabPageTeachers = new System.Windows.Forms.TabPage();
            this.comboBoxDirection = new System.Windows.Forms.ComboBox();
            this.textBoxSearchGroup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.dataGridViewGroups = new System.Windows.Forms.DataGridView();
            this.toolStripStatusLabelStudentsCount = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusStudentsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripLabelCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControlMain.SuspendLayout();
            this.tabPageStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.tabPageGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
            this.toolStripStatusLabelStudentsCount.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.tabPageStudents.Controls.Add(this.toolStripStatusLabelStudentsCount);
            this.tabPageStudents.Controls.Add(this.comboBoxStudentsDirection);
            this.tabPageStudents.Controls.Add(this.labelStudentsDirection);
            this.tabPageStudents.Controls.Add(this.labelStudentsGroup);
            this.tabPageStudents.Controls.Add(this.comboBoxStudentsGroup);
            this.tabPageStudents.Controls.Add(this.labelSearchStudent);
            this.tabPageStudents.Controls.Add(this.textBoxSearchStudent);
            this.tabPageStudents.Controls.Add(this.dataGridViewStudents);
            this.tabPageStudents.Location = new System.Drawing.Point(4, 25);
            this.tabPageStudents.Name = "tabPageStudents";
            this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudents.Size = new System.Drawing.Size(838, 479);
            this.tabPageStudents.TabIndex = 0;
            this.tabPageStudents.Text = "Students";
            this.tabPageStudents.UseVisualStyleBackColor = true;
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
            this.labelStudentsDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStudentsDirection.AutoSize = true;
            this.labelStudentsDirection.Location = new System.Drawing.Point(522, 10);
            this.labelStudentsDirection.Name = "labelStudentsDirection";
            this.labelStudentsDirection.Size = new System.Drawing.Size(100, 16);
            this.labelStudentsDirection.TabIndex = 6;
            this.labelStudentsDirection.Text = "Направление:";
            // 
            // labelStudentsGroup
            // 
            this.labelStudentsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.textBoxSearchStudent.TextChanged += new System.EventHandler(this.textBoxSearchStudent_TextChanged);
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(8, 52);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.RowTemplate.Height = 24;
            this.dataGridViewStudents.Size = new System.Drawing.Size(822, 395);
            this.dataGridViewStudents.TabIndex = 0;
            // 
            // tabPageGroups
            // 
            this.tabPageGroups.Controls.Add(this.statusStrip1);
            this.tabPageGroups.Controls.Add(this.dataGridViewGroups);
            this.tabPageGroups.Controls.Add(this.buttonAddGroup);
            this.tabPageGroups.Controls.Add(this.label2);
            this.tabPageGroups.Controls.Add(this.label1);
            this.tabPageGroups.Controls.Add(this.textBoxSearchGroup);
            this.tabPageGroups.Controls.Add(this.comboBoxDirection);
            this.tabPageGroups.Location = new System.Drawing.Point(4, 25);
            this.tabPageGroups.Name = "tabPageGroups";
            this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGroups.Size = new System.Drawing.Size(838, 479);
            this.tabPageGroups.TabIndex = 1;
            this.tabPageGroups.Text = "Groups";
            this.tabPageGroups.UseVisualStyleBackColor = true;
            // 
            // tabPageDisciplines
            // 
            this.tabPageDisciplines.Location = new System.Drawing.Point(4, 25);
            this.tabPageDisciplines.Name = "tabPageDisciplines";
            this.tabPageDisciplines.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDisciplines.Size = new System.Drawing.Size(838, 479);
            this.tabPageDisciplines.TabIndex = 2;
            this.tabPageDisciplines.Text = "Disciplines";
            this.tabPageDisciplines.UseVisualStyleBackColor = true;
            // 
            // tabPageTeachers
            // 
            this.tabPageTeachers.Location = new System.Drawing.Point(4, 25);
            this.tabPageTeachers.Name = "tabPageTeachers";
            this.tabPageTeachers.Size = new System.Drawing.Size(838, 479);
            this.tabPageTeachers.TabIndex = 3;
            this.tabPageTeachers.Text = "Teachers";
            this.tabPageTeachers.UseVisualStyleBackColor = true;
            // 
            // comboBoxDirection
            // 
            this.comboBoxDirection.FormattingEnabled = true;
            this.comboBoxDirection.Location = new System.Drawing.Point(514, 23);
            this.comboBoxDirection.Name = "comboBoxDirection";
            this.comboBoxDirection.Size = new System.Drawing.Size(215, 24);
            this.comboBoxDirection.TabIndex = 0;
            // 
            // textBoxSearchGroup
            // 
            this.textBoxSearchGroup.Location = new System.Drawing.Point(138, 21);
            this.textBoxSearchGroup.Name = "textBoxSearchGroup";
            this.textBoxSearchGroup.Size = new System.Drawing.Size(184, 22);
            this.textBoxSearchGroup.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Направление обучения:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поиск по имени:";
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.Location = new System.Drawing.Point(745, 24);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(85, 23);
            this.buttonAddGroup.TabIndex = 4;
            this.buttonAddGroup.Text = "Добавить";
            this.buttonAddGroup.UseVisualStyleBackColor = true;
            // 
            // dataGridViewGroups
            // 
            this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroups.Location = new System.Drawing.Point(11, 53);
            this.dataGridViewGroups.Name = "dataGridViewGroups";
            this.dataGridViewGroups.RowHeadersWidth = 51;
            this.dataGridViewGroups.RowTemplate.Height = 24;
            this.dataGridViewGroups.Size = new System.Drawing.Size(819, 393);
            this.dataGridViewGroups.TabIndex = 5;
            // 
            // toolStripStatusLabelStudentsCount
            // 
            this.toolStripStatusLabelStudentsCount.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripStatusLabelStudentsCount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusStudentsCount});
            this.toolStripStatusLabelStudentsCount.Location = new System.Drawing.Point(3, 450);
            this.toolStripStatusLabelStudentsCount.Name = "toolStripStatusLabelStudentsCount";
            this.toolStripStatusLabelStudentsCount.Size = new System.Drawing.Size(832, 26);
            this.toolStripStatusLabelStudentsCount.TabIndex = 8;
            this.toolStripStatusLabelStudentsCount.Text = "statusStrip2";
            // 
            // toolStripStatusStudentsCount
            // 
            this.toolStripStatusStudentsCount.Name = "toolStripStatusStudentsCount";
            this.toolStripStatusStudentsCount.Size = new System.Drawing.Size(203, 20);
            this.toolStripStatusStudentsCount.Text = "toolStripStatusStudentsCount";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelCount});
            this.statusStrip1.Location = new System.Drawing.Point(3, 450);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(832, 26);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripLabelCount
            // 
            this.toolStripLabelCount.Name = "toolStripLabelCount";
            this.toolStripLabelCount.Size = new System.Drawing.Size(142, 20);
            this.toolStripLabelCount.Text = "toolStripLabelCount";
            this.toolStripLabelCount.Click += new System.EventHandler(this.toolStripLabelCount_Click);
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
            this.tabControlMain.ResumeLayout(false);
            this.tabPageStudents.ResumeLayout(false);
            this.tabPageStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.tabPageGroups.ResumeLayout(false);
            this.tabPageGroups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
            this.toolStripStatusLabelStudentsCount.ResumeLayout(false);
            this.toolStripStatusLabelStudentsCount.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageStudents;
        private System.Windows.Forms.TabPage tabPageGroups;
        private System.Windows.Forms.TabPage tabPageDisciplines;
        private System.Windows.Forms.TabPage tabPageTeachers;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.ComboBox comboBoxStudentsDirection;
        private System.Windows.Forms.Label labelStudentsDirection;
        private System.Windows.Forms.Label labelStudentsGroup;
        private System.Windows.Forms.ComboBox comboBoxStudentsGroup;
        private System.Windows.Forms.Label labelSearchStudent;
        private System.Windows.Forms.TextBox textBoxSearchStudent;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearchGroup;
        private System.Windows.Forms.ComboBox comboBoxDirection;
        private System.Windows.Forms.DataGridView dataGridViewGroups;
        private System.Windows.Forms.StatusStrip toolStripStatusLabelStudentsCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusStudentsCount;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabelCount;
    }
}

