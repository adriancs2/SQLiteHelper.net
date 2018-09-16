using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SQLiteHelperTestApp.Forms.Utilities
{
    public partial class AttachDatabase : Form
    {
        public AttachDatabase()
        {
            InitializeComponent();

            using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;

                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    ShowDatabase(sh);

                    conn.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Alias name cannot be empty.");
                return;
            }

            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;

                    SQLiteHelper sh = new SQLiteHelper(cmd);

                    sh.AttachDatabase(of.FileName, textBox1.Text);

                    ShowDatabase(sh);

                    conn.Close();
                }
            }
        }

        void ShowDatabase(SQLiteHelper sh)
        {
            dataGridView1.DataSource = sh.ShowDatabase();
        }
    }
}
