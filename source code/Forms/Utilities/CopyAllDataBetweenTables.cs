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
    public partial class CopyAllDataBetweenTables : Form
    {
        public CopyAllDataBetweenTables()
        {
            InitializeComponent();
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

                    CreateTablePerson(sh);
                    CreateTablePerson_Backup(sh);
                    CopyData(sh);
                    LoadData(sh);

                    conn.Close();
                }
            }
        }

        void CreateTablePerson(SQLiteHelper sh)
        {
            sh.DropTable("person");

            SQLiteTable tb = new SQLiteTable("person");
            tb.Columns.Add(new SQLiteColumn("id", true));
            tb.Columns.Add(new SQLiteColumn("name"));
            tb.Columns.Add(new SQLiteColumn("code"));
            tb.Columns.Add(new SQLiteColumn("tel"));
            sh.CreateTable(tb);

            sh.BeginTransaction();

            for (int i = 0; i < 5; i++)
            {
                Dictionary<string, object> dic = new Dictionary<string, object>();
                dic["name"] = "Hello hello";
                dic["code"] = "########";
                dic["tel"] = "11111111111";

                sh.Insert("person", dic);
            }

            sh.Commit();
        }

        void CreateTablePerson_Backup(SQLiteHelper sh)
        {
            sh.DropTable("person_backup");

            SQLiteTable tb = new SQLiteTable("person_backup");
            tb.Columns.Add(new SQLiteColumn("id", true));
            tb.Columns.Add(new SQLiteColumn("name"));
            tb.Columns.Add(new SQLiteColumn("tel"));
            tb.Columns.Add(new SQLiteColumn("address"));
            tb.Columns.Add(new SQLiteColumn("remarks"));
            sh.CreateTable(tb);
        }

        void CopyData(SQLiteHelper sh)
        {
            sh.CopyAllData("person", "person_backup");
        }

        void LoadData(SQLiteHelper sh)
        {
            dataGridView1.DataSource = sh.Select("select * from person order by id;");
            dataGridView2.DataSource = sh.Select("select * from person_backup order by id;");
        }
    }
}
