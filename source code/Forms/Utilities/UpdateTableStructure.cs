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
    public partial class UpdateTableStructure : Form
    {
        SQLiteHelper sh = null;

        public UpdateTableStructure()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    conn.Open();
                    cmd.Connection = conn;

                    sh = new SQLiteHelper(cmd);

                    CreateSampleTable_OriginalTable();

                    SQLiteTable tb = new SQLiteTable("ori2");
                    tb.Columns.Add(new SQLiteColumn("id", true));
                    tb.Columns.Add(new SQLiteColumn("name"));
                    tb.Columns.Add(new SQLiteColumn("sku"));
                    tb.Columns.Add(new SQLiteColumn("code"));
                    tb.Columns.Add(new SQLiteColumn("category"));
                    tb.Columns.Add(new SQLiteColumn("remarks"));
                    sh.CreateTable(tb);

                    dgvTableUpdated.DataSource = sh.GetColumnStatus("ori2");

                    sh.DropTable("ori2");

                    sh.UpdateTableStructure("ori", tb);

                    dgvDataUpdated.DataSource = sh.Select("select * from ori;");

                    conn.Close();
                }
            }
        }

        void CreateSampleTable_OriginalTable()
        {
            sh.DropTable("ori");
            sh.DropTable("ori2");

            SQLiteTable tb = new SQLiteTable("ori");
            tb.Columns.Add(new SQLiteColumn("id", true));
            tb.Columns.Add(new SQLiteColumn("name"));
            tb.Columns.Add(new SQLiteColumn("code"));
            tb.Columns.Add(new SQLiteColumn("location"));
            tb.Columns.Add(new SQLiteColumn("category"));
            sh.CreateTable(tb);

            sh.BeginTransaction();

            for (int i = 0; i < 5; i++)
            {
                Dictionary<string, object> dic = new Dictionary<string, object>();
                dic["name"] = "aaaa";
                dic["code"] = "aaaa";
                dic["location"] = "aaaa";
                dic["category"] = "aaaa";

                sh.Insert("ori", dic);
            }

            sh.Commit();

            dgvTableOri.DataSource = sh.GetColumnStatus("ori");
            dgvDataOri.DataSource = sh.Select("select * from ori;");
        }

    }
}
