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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();

            using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteTable tb = new SQLiteTable("player");
                    tb.Columns.Add(new SQLiteColumn("id", true));
                    tb.Columns.Add(new SQLiteColumn("lvl", ColType.Integer));
                    tb.Columns.Add(new SQLiteColumn("weaponid", ColType.Integer));
                    tb.Columns.Add(new SQLiteColumn("teamid", ColType.Integer));
                    tb.Columns.Add(new SQLiteColumn("location"));
                    tb.Columns.Add(new SQLiteColumn("team_name"));
                    tb.Columns.Add(new SQLiteColumn("remarks"));

                    SQLiteHelper sh = new SQLiteHelper(cmd);

                    sh.DropTable("player");

                    sh.CreateTable(tb);

                    List<Dictionary<string, object>> lst = new List<Dictionary<string, object>>();

                    var dic1 = new Dictionary<string, object>();
                    dic1["lvl"] = 1;
                    dic1["weaponid"] = 2;
                    dic1["teamid"] = 2;
                    lst.Add(dic1);

                    sh.Insert("player", dic1);

                    var dic2 = new Dictionary<string, object>();
                    dic2["lvl"] = 1;
                    dic2["weaponid"] = 1;
                    dic2["teamid"] = 2;
                    lst.Add(dic2);

                    sh.Insert("player", dic2);

                    var dic3 = new Dictionary<string, object>();
                    dic3["lvl"] = 1;
                    dic3["weaponid"] = 1;
                    dic3["teamid"] = 1;
                    lst.Add(dic3);

                    sh.Insert("player", dic3);

                    ReloadData(sh);

                    conn.Close();
                }
            }
        }

        private void bt_lvl_weapon_team_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);

                    Dictionary<string, object> dicData = new Dictionary<string, object>();
                    dicData["team_name"] = "cccccccccccc";
                    dicData["location"] = "cccccccccccc";
                    dicData["remarks"] = "cccccccccccc";

                    var dicCond = new Dictionary<string, object>();
                    dicCond["lvl"] = 1;
                    dicCond["weaponid"] = 1;
                    dicCond["teamid"] = 1;

                    sh.Update("player", dicData, dicCond);

                    ReloadData(sh);

                    conn.Close();
                }
            }
        }

        private void bt_lvl_weapon_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);

                    Dictionary<string, object> dicData = new Dictionary<string, object>();
                    dicData["team_name"] = "bbbbbbbb";
                    dicData["location"] = "bbbbbbbb";
                    dicData["remarks"] = "bbbbbbbb";

                    var dicCond = new Dictionary<string, object>();
                    dicCond["lvl"] = 1;
                    dicCond["weaponid"] = 1;

                    sh.Update("player", dicData, dicCond);

                    ReloadData(sh);

                    conn.Close();
                }
            }
        }

        private void bt_lvl_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    SQLiteHelper sh = new SQLiteHelper(cmd);

                    Dictionary<string, object> dicData = new Dictionary<string, object>();
                    dicData["team_name"] = "aaaa";
                    dicData["location"] = "aaaa";
                    dicData["remarks"] = "aaaa";

                    sh.Update("player", dicData, "lvl", 1);

                    ReloadData(sh);

                    conn.Close();
                }
            }
        }

        void ReloadData(SQLiteHelper sh)
        {
            dataGridView1.DataSource = sh.Select("select * from player order by id;");
        }
    }
}