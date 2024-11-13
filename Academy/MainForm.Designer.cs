﻿namespace Academy
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
            this.statusStripStudents = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPageTeachers = new System.Windows.Forms.TabPage();
            this.tabPageDisciplines = new System.Windows.Forms.TabPage();
            this.tabPageGroups = new System.Windows.Forms.TabPage();
            this.comboBoxGroupDirection = new System.Windows.Forms.ComboBox();
            this.textBoxSearchGroup = new System.Windows.Forms.TextBox();
            this.labelSearchGroup = new System.Windows.Forms.Label();
            this.labelDirection = new System.Windows.Forms.Label();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.dataGridViewGroups = new System.Windows.Forms.DataGridView();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.textBoxSearchStudent = new System.Windows.Forms.TextBox();
            this.labelSearchStudent = new System.Windows.Forms.Label();
            this.comboBoxStudentsGroup = new System.Windows.Forms.ComboBox();
            this.labelStudentsGroup = new System.Windows.Forms.Label();
            this.labelStudentsDirection = new System.Windows.Forms.Label();
            this.comboBoxStudentsDirection = new System.Windows.Forms.ComboBox();
            this.tabPageStudents = new System.Windows.Forms.TabPage();
            this.statusStripStudents.SuspendLayout();
            this.tabPageGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
            this.tabControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.tabPageStudents.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStripStudents
            // 
            this.statusStripStudents.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripStudents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStripStudents.Location = new System.Drawing.Point(0, 564);
            this.statusStripStudents.Name = "statusStripStudents";
            this.statusStripStudents.Size = new System.Drawing.Size(1073, 26);
            this.statusStripStudents.TabIndex = 6;
            this.statusStripStudents.Text = "statusStripStudents";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // tabPageTeachers
            // 
            this.tabPageTeachers.Location = new System.Drawing.Point(4, 25);
            this.tabPageTeachers.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageTeachers.Name = "tabPageTeachers";
            this.tabPageTeachers.Size = new System.Drawing.Size(1065, 508);
            this.tabPageTeachers.TabIndex = 3;
            this.tabPageTeachers.Text = "Teachers";
            this.tabPageTeachers.UseVisualStyleBackColor = true;
            // 
            // tabPageDisciplines
            // 
            this.tabPageDisciplines.Location = new System.Drawing.Point(4, 25);
            this.tabPageDisciplines.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageDisciplines.Name = "tabPageDisciplines";
            this.tabPageDisciplines.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageDisciplines.Size = new System.Drawing.Size(1065, 508);
            this.tabPageDisciplines.TabIndex = 2;
            this.tabPageDisciplines.Text = "Disciplines";
            this.tabPageDisciplines.UseVisualStyleBackColor = true;
            // 
            // tabPageGroups
            // 
            this.tabPageGroups.Controls.Add(this.dataGridViewGroups);
            this.tabPageGroups.Controls.Add(this.buttonAddGroup);
            this.tabPageGroups.Controls.Add(this.labelDirection);
            this.tabPageGroups.Controls.Add(this.labelSearchGroup);
            this.tabPageGroups.Controls.Add(this.textBoxSearchGroup);
            this.tabPageGroups.Controls.Add(this.comboBoxGroupDirection);
            this.tabPageGroups.Location = new System.Drawing.Point(4, 25);
            this.tabPageGroups.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageGroups.Name = "tabPageGroups";
            this.tabPageGroups.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageGroups.Size = new System.Drawing.Size(1065, 508);
            this.tabPageGroups.TabIndex = 1;
            this.tabPageGroups.Text = "Groups";
            this.tabPageGroups.UseVisualStyleBackColor = true;
            // 
            // comboBoxGroupDirection
            // 
            this.comboBoxGroupDirection.FormattingEnabled = true;
            this.comboBoxGroupDirection.Location = new System.Drawing.Point(618, 8);
            this.comboBoxGroupDirection.Name = "comboBoxGroupDirection";
            this.comboBoxGroupDirection.Size = new System.Drawing.Size(301, 24);
            this.comboBoxGroupDirection.TabIndex = 0;
            // 
            // textBoxSearchGroup
            // 
            this.textBoxSearchGroup.Location = new System.Drawing.Point(135, 9);
            this.textBoxSearchGroup.Name = "textBoxSearchGroup";
            this.textBoxSearchGroup.Size = new System.Drawing.Size(243, 22);
            this.textBoxSearchGroup.TabIndex = 1;
            // 
            // labelSearchGroup
            // 
            this.labelSearchGroup.AutoSize = true;
            this.labelSearchGroup.Location = new System.Drawing.Point(4, 12);
            this.labelSearchGroup.Name = "labelSearchGroup";
            this.labelSearchGroup.Size = new System.Drawing.Size(113, 16);
            this.labelSearchGroup.TabIndex = 2;
            this.labelSearchGroup.Text = "Поиск по имени:";
            // 
            // labelDirection
            // 
            this.labelDirection.AutoSize = true;
            this.labelDirection.Location = new System.Drawing.Point(444, 12);
            this.labelDirection.Name = "labelDirection";
            this.labelDirection.Size = new System.Drawing.Size(166, 16);
            this.labelDirection.TabIndex = 3;
            this.labelDirection.Text = "Направление обучения:";
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.Location = new System.Drawing.Point(949, 9);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(102, 24);
            this.buttonAddGroup.TabIndex = 4;
            this.buttonAddGroup.Text = "Добавить";
            this.buttonAddGroup.UseVisualStyleBackColor = true;
            // 
            // dataGridViewGroups
            // 
            this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroups.Location = new System.Drawing.Point(7, 54);
            this.dataGridViewGroups.Name = "dataGridViewGroups";
            this.dataGridViewGroups.RowHeadersWidth = 51;
            this.dataGridViewGroups.RowTemplate.Height = 24;
            this.dataGridViewGroups.Size = new System.Drawing.Size(1043, 412);
            this.dataGridViewGroups.TabIndex = 5;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageStudents);
            this.tabControlMain.Controls.Add(this.tabPageGroups);
            this.tabControlMain.Controls.Add(this.tabPageDisciplines);
            this.tabControlMain.Controls.Add(this.tabPageTeachers);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1073, 590);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(8, 67);
            this.dataGridViewStudents.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.Size = new System.Drawing.Size(1048, 490);
            this.dataGridViewStudents.TabIndex = 0;
            // 
            // textBoxSearchStudent
            // 
            this.textBoxSearchStudent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxSearchStudent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.textBoxSearchStudent.Location = new System.Drawing.Point(75, 18);
            this.textBoxSearchStudent.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearchStudent.Name = "textBoxSearchStudent";
            this.textBoxSearchStudent.Size = new System.Drawing.Size(261, 22);
            this.textBoxSearchStudent.TabIndex = 2;
            this.textBoxSearchStudent.TextChanged += new System.EventHandler(this.textBoxSearchStudent_TextChanged);
            // 
            // labelSearchStudent
            // 
            this.labelSearchStudent.AutoSize = true;
            this.labelSearchStudent.Location = new System.Drawing.Point(11, 23);
            this.labelSearchStudent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearchStudent.Name = "labelSearchStudent";
            this.labelSearchStudent.Size = new System.Drawing.Size(50, 16);
            this.labelSearchStudent.TabIndex = 3;
            this.labelSearchStudent.Text = "Поиск:";
            // 
            // comboBoxStudentsGroup
            // 
            this.comboBoxStudentsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStudentsGroup.FormattingEnabled = true;
            this.comboBoxStudentsGroup.Location = new System.Drawing.Point(461, 18);
            this.comboBoxStudentsGroup.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxStudentsGroup.Name = "comboBoxStudentsGroup";
            this.comboBoxStudentsGroup.Size = new System.Drawing.Size(217, 24);
            this.comboBoxStudentsGroup.TabIndex = 4;
            // 
            // labelStudentsGroup
            // 
            this.labelStudentsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStudentsGroup.AutoSize = true;
            this.labelStudentsGroup.Location = new System.Drawing.Point(393, 23);
            this.labelStudentsGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStudentsGroup.Name = "labelStudentsGroup";
            this.labelStudentsGroup.Size = new System.Drawing.Size(57, 16);
            this.labelStudentsGroup.TabIndex = 5;
            this.labelStudentsGroup.Text = "Группа:";
            // 
            // labelStudentsDirection
            // 
            this.labelStudentsDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStudentsDirection.AutoSize = true;
            this.labelStudentsDirection.Location = new System.Drawing.Point(725, 23);
            this.labelStudentsDirection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStudentsDirection.Name = "labelStudentsDirection";
            this.labelStudentsDirection.Size = new System.Drawing.Size(100, 16);
            this.labelStudentsDirection.TabIndex = 6;
            this.labelStudentsDirection.Text = "Направление:";
            // 
            // comboBoxStudentsDirection
            // 
            this.comboBoxStudentsDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxStudentsDirection.FormattingEnabled = true;
            this.comboBoxStudentsDirection.Location = new System.Drawing.Point(837, 18);
            this.comboBoxStudentsDirection.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxStudentsDirection.Name = "comboBoxStudentsDirection";
            this.comboBoxStudentsDirection.Size = new System.Drawing.Size(213, 24);
            this.comboBoxStudentsDirection.TabIndex = 7;
            // 
            // tabPageStudents
            // 
            this.tabPageStudents.Controls.Add(this.comboBoxStudentsDirection);
            this.tabPageStudents.Controls.Add(this.labelStudentsDirection);
            this.tabPageStudents.Controls.Add(this.labelStudentsGroup);
            this.tabPageStudents.Controls.Add(this.comboBoxStudentsGroup);
            this.tabPageStudents.Controls.Add(this.labelSearchStudent);
            this.tabPageStudents.Controls.Add(this.textBoxSearchStudent);
            this.tabPageStudents.Controls.Add(this.dataGridViewStudents);
            this.tabPageStudents.Location = new System.Drawing.Point(4, 25);
            this.tabPageStudents.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageStudents.Name = "tabPageStudents";
            this.tabPageStudents.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageStudents.Size = new System.Drawing.Size(1065, 561);
            this.tabPageStudents.TabIndex = 0;
            this.tabPageStudents.Text = "Students";
            this.tabPageStudents.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 590);
            this.Controls.Add(this.statusStripStudents);
            this.Controls.Add(this.tabControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Academy";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStripStudents.ResumeLayout(false);
            this.statusStripStudents.PerformLayout();
            this.tabPageGroups.ResumeLayout(false);
            this.tabPageGroups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.tabPageStudents.ResumeLayout(false);
            this.tabPageStudents.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStripStudents;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabPage tabPageTeachers;
        private System.Windows.Forms.TabPage tabPageDisciplines;
        private System.Windows.Forms.TabPage tabPageGroups;
        private System.Windows.Forms.DataGridView dataGridViewGroups;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.Label labelDirection;
        private System.Windows.Forms.Label labelSearchGroup;
        private System.Windows.Forms.TextBox textBoxSearchGroup;
        private System.Windows.Forms.ComboBox comboBoxGroupDirection;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageStudents;
        private System.Windows.Forms.ComboBox comboBoxStudentsDirection;
        private System.Windows.Forms.Label labelStudentsDirection;
        private System.Windows.Forms.Label labelStudentsGroup;
        private System.Windows.Forms.ComboBox comboBoxStudentsGroup;
        private System.Windows.Forms.Label labelSearchStudent;
        private System.Windows.Forms.TextBox textBoxSearchStudent;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
    }
}