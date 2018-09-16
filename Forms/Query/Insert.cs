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
    public partial class Insert : Form
    {
        Random rd = new Random();

        public Insert()
        {
            InitializeComponent();

            using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteTable tb = new SQLiteTable("product");
                    tb.Columns.Add(new SQLiteColumn("id", true));
                    tb.Columns.Add(new SQLiteColumn("name"));
                    tb.Columns.Add(new SQLiteColumn("datepurchase", ColType.DateTime));
                    tb.Columns.Add(new SQLiteColumn("price", ColType.Decimal));
                    tb.Columns.Add(new SQLiteColumn("qty", ColType.Integer));

                    SQLiteHelper sh = new SQLiteHelper(cmd);

                    sh.DropTable("product");

                    sh.CreateTable(tb);

                    dataGridView1.DataSource = sh.Select("select * from product;");

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

                    int count = sh.ExecuteScalar<int>("select count(*) from product;") + 1;

                    var dic = new Dictionary<string, object>();
                    dic["name"] = txtProductName.Text;
                    dic["datepurchase"] = dateTimePicker1.Value;
                    dic["qty"] = numericUpDown_Quantity.Value;
                    dic["price"] = numericUpDown_Price.Value;

                    sh.Insert("product", dic);

                    dataGridView1.DataSource = sh.Select("select * from product order by id;");

                    conn.Close();
                }
            }
        }
    }
}
