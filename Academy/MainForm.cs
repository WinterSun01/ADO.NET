using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Academy
{
    public partial class MainForm : Form
    {
        AddGroupForm addGroup;
        public MainForm()
        {
            InitializeComponent();
            LoadStudents();
            LoadGroups();
            addGroup = new AddGroupForm();
            AllocConsole();
        }
        void LoadStudents()
        {
            dataGridViewStudents.Rows.CollectionChanged += new CollectionChangeEventHandler(SetStatusBarText);
            dataGridViewStudents.DataSource =
                Connector.Select(
                    "student_id, last_name, first_name, middle_name, birth_date, group_name, direction_name",
                    "Students, Groups, Directions",
                    "[group]=group_id AND direction=direction_id");
            comboBoxStudentsGroup.DataSource = Connector.Select("*", "Groups");
            comboBoxStudentsGroup.DisplayMember = "group_name";
            comboBoxStudentsGroup.SelectedIndex = -1;
            comboBoxStudentsGroup.ValueMember = "group_id";

            comboBoxStudentsDirection.DataSource = Connector.Select("*", "Directions");
            comboBoxStudentsDirection.DisplayMember = "direction_name";
            comboBoxStudentsDirection.SelectedIndex = -1;
            comboBoxStudentsDirection.ValueMember = "direction_id";
        }
        void LoadGroups()
        {
            dataGridViewGroups.Rows.CollectionChanged += new CollectionChangeEventHandler(SetStatusBarText);
            dataGridViewGroups.DataSource =
            
            Connector.Select
            (
                "group_id, group_name,start_date,learning_time,direction_name,form_name,learning_days",
                "Groups,Directions,LearningForms",
                "direction=direction_id AND learning_form=form_id"
                );

            comboBoxGroupDirection.Items.AddRange(Connector.SelectColumn("direction_name", "Directions").ToArray());
            for (int i = 0; i < dataGridViewGroups.RowCount; i++)
            {
                dataGridViewGroups.Rows[i].Cells["learning_days"].Value =
                    Week.ExtractDaysToString(Convert.ToByte(dataGridViewGroups.Rows[i].Cells["learning_days"].Value));
            }
        }
        void SetStatusBarText(object sender, EventArgs e)
        {
            toolStripStatusLabelStudentsCount.Text = $"Number of {tabControlMain.SelectedTab.Text.ToLower()}: {(sender as DataGridViewRowCollection).Count - 1}.";
        }

        private void textBoxSearchStudent_TextChanged(object sender, EventArgs e)
        {
            string[] values = (sender as TextBox).Text.Split(' ');
            if (values.Length > 1)
                values = values.Where(v => v != "").ToArray();
            string searchPattern = "";
            switch (values.Length)
            {
                case 1: searchPattern = $"(last_name LIKE ('{values[0]}%') OR first_name LIKE ('{values[0]}%') OR middle_name LIKE ('{values[0]}%'))"; break;
                case 2: searchPattern = $"((last_name LIKE ('{values[0]}%') OR first_name LIKE ('{values[0]}%')) AND (first_name LIKE  ('{values[1]}%') OR middle_name LIKE ('{values[1]}%')))"; break;
                case 3: searchPattern = $"(last_name LIKE ('{values[0]}%') AND first_name LIKE ('{values[1]}%') OR middle_name LIKE ('{values[2]}%'))"; break;
            }

            dataGridViewStudents.DataSource = Connector.Select
                (
                    "last_name, first_name, middle_name, birth_date, group_name, direction_name",
                    "Students, Directions, Groups",
                    $"[group]=group_id AND direction=direction_id AND {searchPattern};"
                );
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedTab.Text)
            {
                case "Students": SetStatusBarText(dataGridViewStudents.Rows, e); break;
                case "Groups": SetStatusBarText(dataGridViewGroups.Rows, e); break;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetStatusBarText(dataGridViewStudents.Rows, e);
        }

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            addGroup.ClearData();
            
            if (addGroup.ShowDialog() == DialogResult.OK)
            {
                Group group = new Group(addGroup);
                Connector.InsertGroup(group);
                LoadGroups();
            }
        }

        [DllImport("kernel32")]
        static extern bool AllocConsole();

        private void dataGridViewGroups_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Group group = new Group((sender as DataGridView).SelectedRows[0]);
            addGroup.Init(group);
            if (addGroup.ShowDialog() == DialogResult.OK)
            {
                int index = dataGridViewGroups.SelectedRows[0].Index;
                
                dataGridViewGroups.Rows[index].SetValues(Connector.UpdateGroup(addGroup.Group));
            }
        }
    }
}