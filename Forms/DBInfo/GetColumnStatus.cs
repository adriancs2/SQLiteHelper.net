using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SQLiteHelperTestApp.Forms.DBInfo
{
    public partial class GetColumnStatus : Form
    {
        public GetColumnStatus()
        {
            InitializeComponent();
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        conn.Open();
                        cmd.Connection = conn;

                        SQLiteHelper sh = new SQLiteHelper(cmd);

                        DataTable dt = sh.GetTableList();
                        comboBox1.DataSource = dt;
                        comboBox1.ValueMember = dt.Columns[0].ColumnName;

                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetStatus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetStatus();
        }

        private void GetColumnStatus_Load(object sender, EventArgs e)
        {
            GetStatus();
        }

        void GetStatus()
        {
            try
            {
                string tableName = comboBox1.SelectedValue + "";

                using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        conn.Open();
                        cmd.Connection = conn;

                        SQLiteHelper sh = new SQLiteHelper(cmd);

                        DataTable dt = sh.GetColumnStatus(tableName);
                        dataGridView1.DataSource = dt;

                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
