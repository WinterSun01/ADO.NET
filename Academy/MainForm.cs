using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace Academy
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            dataGridViewStudents.Rows.CollectionChanged += new CollectionChangeEventHandler(CountRows);
            dataGridViewStudents.DataSource =
                Connector.Select("last_name, first_name, middle_name, birth_date, group_name, direction_name, " +
                                "DATEDIFF(YEAR, birth_date, GETDATE()) AS age", //добавление возраста студентов
                                "Students, Groups, Directions",
                                "[group] = group_id AND direction = direction_id");

            //заполн. комбобокс группами
            comboBoxStudentsGroup.DataSource = Connector.GetDistinctValues("group_name", "Groups");
            comboBoxStudentsGroup.DisplayMember = "group_name";
            comboBoxStudentsGroup.SelectedIndex = -1;

            //заполн. комбобокс направлениями
            comboBoxStudentsDirection.DataSource = Connector.GetDistinctValues("direction_name", "Directions");
            comboBoxStudentsDirection.DisplayMember = "direction_name";
            comboBoxStudentsDirection.SelectedIndex = -1;

            //для автопримен. изменений при каждом измен. выбр. элемента в выпад. списках
            comboBoxStudentsGroup.SelectedIndexChanged += ApplyFilters;
            comboBoxStudentsDirection.SelectedIndexChanged += ApplyFilters;

            LoadStudentData();
        }
        void CountRows(object sender, EventArgs e)
        {
            toolStripStatusLabelStudentsCount.Text = $"Количество студентов: {dataGridViewStudents.RowCount}.";
        }

        //для перезагр. данных о студентах с учётом выбр. фильтров, нужен чтобы отобр. только тех, кто соотв. условиям
        private void ApplyFilters(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        //чтобы обновить DataGridView с сделанными изменениями
        private void LoadStudentData()
        {
            //получаем выбранные значения из комбобокс
            string selectedGroup = comboBoxStudentsGroup.Text;
            string selectedDirection = comboBoxStudentsDirection.Text;

            List<string> conditions = new List<string>();
            if (!string.IsNullOrEmpty(selectedGroup))
                conditions.Add($"group_name = '{selectedGroup}'");
            if (!string.IsNullOrEmpty(selectedDirection))
                conditions.Add($"direction_name = '{selectedDirection}'");

            string condition = string.Join(" AND ", conditions);

            dataGridViewStudents.DataSource = Connector.Select
                (
                "last_name, first_name, middle_name, birth_date, group_name, direction_name, " +
                "DATEDIFF(YEAR, birth_date, GETDATE()) AS age",
                "Students, Groups, Directions",
                "[group] = group_id AND direction = direction_id" + (condition != "" ? " AND " + condition : "")
                );

            toolStripStatusLabelStudentsCount.Text = $"Количество студентов: {dataGridViewStudents.RowCount}.";

        }

        private void textBoxSearchStudent_TextChanged(object sender, EventArgs e)
        {
            string[] values = (sender as TextBox).Text.Split(' ');
            if (values.Length > 1)
                values = values.Where(v => v != "").ToArray();
            string searchPattern = "";
            switch (values.Length)
            {
                case 1:
                    searchPattern = $"(last_name LIKE '%{values[0]}%' OR first_name LIKE '%{values[0]}%' OR middle_name LIKE '%{values[0]}%')";
                    break;
                case 2:
                    searchPattern = $"(last_name LIKE '%{values[0]}%' OR first_name LIKE '%{values[0]}%' OR middle_name LIKE '%{values[0]}%')" +
                                    $" AND (last_name LIKE '%{values[1]}%' OR first_name LIKE '%{values[1]}%' OR middle_name LIKE '%{values[1]}%')";
                    break;
                case 3:
                    searchPattern = $"(last_name LIKE '%{values[0]}%' OR first_name LIKE '%{values[0]}%' OR middle_name LIKE '%{values[0]}%')" +
                                    $" AND (last_name LIKE '%{values[1]}%' OR first_name LIKE '%{values[1]}%' OR middle_name LIKE '%{values[1]}%')" +
                                    $" AND (last_name LIKE '%{values[2]}%' OR first_name LIKE '%{values[2]}%' OR middle_name LIKE '%{values[2]}%')";
                    break;
            }
        dataGridViewStudents.DataSource = Connector.Select
            (
               "last_name, first_name, middle_name, birth_date, group_name, direction_name",
               "Students, Directions, Groups",
               $"[group]=group_id AND direction=direction_id AND {searchPattern}"
            );
        }
    }
}
