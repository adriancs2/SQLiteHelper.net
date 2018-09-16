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
    public partial class ExecuteScalar : Form
    {
        enum dtype
        {
            text,
            integer,
            blob,
            datetime,
            dec
        }

        public ExecuteScalar()
        {
            InitializeComponent();
        }

        private void btDate_Click(object sender, EventArgs e)
        {
            GetData(dtype.datetime);
        }

        private void btBlob_Click(object sender, EventArgs e)
        {
            GetData(dtype.blob);
        }

        private void btDecimal_Click(object sender, EventArgs e)
        {
            GetData(dtype.dec);
        }

        private void btInt_Click(object sender, EventArgs e)
        {
            GetData(dtype.integer);
        }

        private void btStr_Click(object sender, EventArgs e)
        {
            GetData(dtype.text);
        }

        void GetData(dtype t)
        {
            try
            {
                object ob = null;

                using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        conn.Open();
                        cmd.Connection = conn;

                        SQLiteHelper sh = new SQLiteHelper(cmd);

                        switch (t)
                        {
                            case dtype.text:
                                ob = sh.ExecuteScalar<string>("select 'Hello!';");
                                break;
                            case dtype.integer:
                                ob = sh.ExecuteScalar<int>("select 1000;");
                                break;
                            case dtype.datetime:
                                ob = sh.ExecuteScalar<DateTime>("select date('now');");
                                break;
                            case dtype.dec:
                                ob = sh.ExecuteScalar<decimal>("select 4.4;");
                                break;
                            case dtype.blob:
                                ob = sh.ExecuteScalar<byte[]>("select randomblob(16);");
                                break;
                            default:
                                break;
                        }

                        conn.Close();
                    }
                }
                MessageBox.Show("Type: " + ob.GetType() + Environment.NewLine +
                    "Value: " + ob.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
