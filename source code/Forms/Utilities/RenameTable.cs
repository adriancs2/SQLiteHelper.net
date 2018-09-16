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
    public partial class RenameTable : Form
    {
        public RenameTable()
        {
            InitializeComponent();

            using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
            {
                using (var cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    var sh = new SQLiteHelper(cmd);

                    sh.DropTable("product");

                    SQLiteTable tb = new SQLiteTable("product");
                    tb.Columns.Add(new SQLiteColumn("id", true));
                    tb.Columns.Add(new SQLiteColumn("name"));
                    tb.Columns.Add(new SQLiteColumn("qty", ColType.Integer));

                    sh.CreateTable(tb);

                    GetTableStatus(sh);

                    conn.Close();
                }
            }
        }

        void GetTableStatus(SQLiteHelper sh)
        {
            dataGridView1.DataSource = sh.GetTableStatus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
            {
                using (var cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    var sh = new SQLiteHelper(cmd);

                    sh.RenameTable("product", "product_backup");

                    GetTableStatus(sh);

                    conn.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
            {
                using (var cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    var sh = new SQLiteHelper(cmd);

                    sh.RenameTable("product_backup", "product");

                    GetTableStatus(sh);

                    conn.Close();
                }
            }
        }

    }
}
