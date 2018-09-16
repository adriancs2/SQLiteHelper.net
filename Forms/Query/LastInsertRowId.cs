using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SQLiteHelperTestApp.Forms.Query
{
    public partial class LastInsertRowId : Form
    {
        public LastInsertRowId()
        {
            InitializeComponent();

            using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);

                    sh.DropTable("product");

                    SQLiteTable tb = new SQLiteTable("product");
                    tb.Columns.Add(new SQLiteColumn("id", true));
                    tb.Columns.Add(new SQLiteColumn("name"));

                    sh.CreateTable(tb);

                    LoadData(sh);

                    conn.Close();
                }
            }
        }

        void LoadData(SQLiteHelper sh)
        {
            dataGridView1.DataSource = sh.Select("select * from product order by id;");
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

                    Dictionary<string, object> dic = new Dictionary<string, object>();
                    dic["name"] = "hello";

                    sh.Insert("product", dic);

                    lbRowId.Text = sh.LastInsertRowId().ToString();

                    LoadData(sh);

                    conn.Close();
                }
            }
        }
    }
}
