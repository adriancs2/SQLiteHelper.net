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
    public partial class DropTable : Form
    {
        public DropTable()
        {
            InitializeComponent();

            using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);
                    GetTableStatus(sh);

                    conn.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);

                    SQLiteTable tb = new SQLiteTable("AAAA");
                    tb.Columns.Add(new SQLiteColumn("id", true));
                    tb.Columns.Add(new SQLiteColumn("name"));
                    sh.CreateTable(tb);

                    GetTableStatus(sh);

                    conn.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);

                    sh.DropTable("AAAA");

                    GetTableStatus(sh);

                    conn.Close();
                }
            }
        }

        void GetTableStatus(SQLiteHelper sh)
        {
            dataGridView1.DataSource = sh.GetTableStatus();
        }
    }
}
