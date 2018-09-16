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
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();

            using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;

                    SQLiteHelper sh = new SQLiteHelper(cmd);

                    sh.DropTable("product");

                    SQLiteTable tb = new SQLiteTable("product");
                    tb.Columns.Add(new SQLiteColumn("id", true));
                    tb.Columns.Add(new SQLiteColumn("name"));
                    tb.Columns.Add(new SQLiteColumn("description"));
                    tb.Columns.Add(new SQLiteColumn("status"));
                    sh.CreateTable(tb);

                    LoadData(sh);

                    conn.Close();
                }
            }
        }

        private void btRollback_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;

                    SQLiteHelper sh = new SQLiteHelper(cmd);

                    int count = sh.ExecuteScalar<int>("select count(*) from product;") + 1;

                    sh.BeginTransaction();

                    for (int i = 0; i < 5; i++)
                    {
                        var dic = new Dictionary<string, object>();
                        dic["name"] = "Product " + (count + i);
                        dic["description"] = "Some description";
                        dic["status"] = "Active";

                        sh.Insert("product", dic);
                    }

                    sh.Rollback();

                    LoadData(sh);

                    conn.Close();
                }
            }
        }

        private void btCommit_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;

                    SQLiteHelper sh = new SQLiteHelper(cmd);

                    int count = sh.ExecuteScalar<int>("select count(*) from product;") + 1;

                    sh.BeginTransaction();

                    for (int i = 0; i < 5; i++)
                    {
                        var dic = new Dictionary<string, object>();
                        dic["name"] = "Product " + (count + i);
                        dic["description"] = "Some description";
                        dic["status"] = "Active";

                        sh.Insert("product", dic);
                    }

                    sh.Commit();

                    LoadData(sh);

                    conn.Close();
                }
            }
        }

        void LoadData(SQLiteHelper sh)
        {
            dataGridView1.DataSource = sh.Select("select * from product order by id;");
        }
    }
}
