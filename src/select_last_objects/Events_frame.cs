﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace select_last_objects
{
    public partial class Events_frame : Form
    {
        public Events_frame()
        {
            InitializeComponent();
            //Add data to DataGridView
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Время выделения";
            dataGridView1.Columns[0].Width = 250;
            dataGridView1.Columns[1].Name = "Кол-во выделенных объектов, шт.";
            dataGridView1.Columns[0].Width = 200;

            foreach (KeyValuePair<string, List<int>> one_time2ids in init_app.time2selected_objects)
            {
                object[] row_data = new object[2] { one_time2ids.Key, one_time2ids.Value.Count() };
                dataGridView1.Rows.Add(row_data);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void action_clear_Click(object sender, EventArgs e)
        {
            
            //Очистка событий
            DialogResult dialogResult = MessageBox.Show("Предупреждение",
                "Вы уверены, что хотите сбросить историю выделения объектов?",
                MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                init_app.time2selected_objects.Clear();
                this.Close();
                //Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                //nothing
            }
        }

        private void action_select_Click(object sender, EventArgs e)
        {
            //Запуск процедуры выбора объектов проекта по выбранным строкам таблицы
            List<int> indexes_of_table_rows = new List<int>();
            Int32 selectedRowCount =
        dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                for (int i = 0; i < selectedRowCount; i++)
                {
                    indexes_of_table_rows.Add(dataGridView1.SelectedRows[i].Index);
                }
            }
            else return;
            init_app.ShowSelectedObjects(indexes_of_table_rows);
            indexes_of_table_rows.Clear();
            this.Close();
        }
    }
}
