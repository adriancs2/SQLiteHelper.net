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
    public partial class CreateTable : Form
    {

        public CreateTable()
        {
            InitializeComponent();
        }

        private void btDropCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the table name is blank
                if (textBox1.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Table Name cannot be blank.");
                    return;
                }

                // Check if all the columns' name is filled
                foreach (Control c in flowLayoutPanel1.Controls)
                {
                    if (c is Column)
                    {
                        Column col = (Column)c;

                        if (col.ColumnName.Trim().Length == 0)
                        {
                            MessageBox.Show("Some column's name is blank. Cannot create table.");
                            return;
                        }
                    }
                }

                // Creating table....
                SQLiteTable tb = new SQLiteTable(textBox1.Text);

                foreach (Control c in flowLayoutPanel1.Controls)
                {
                    if (c is Column)
                    {
                        Column col = (Column)c;

                        tb.Columns.Add(new SQLiteColumn(col.ColumnName, col.ColumnType, col.PrimaryKey, col.AutoIncrement, col.NotNUll, col.DefaultValue));
                    }
                }

                // Execute Table Creation
                using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        conn.Open();
                        cmd.Connection = conn;

                        SQLiteHelper sh = new SQLiteHelper(cmd);

                        sh.DropTable(textBox1.Text);
                        sh.CreateTable(tb);

                        conn.Close();
                    }
                }

                MessageBox.Show("Table created.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btAddColumn_Click(object sender, EventArgs e)
        {
            Column c = new Column();
            c.DeleteClicked += c_DeleteClicked;
            flowLayoutPanel1.Controls.Add(c);
        }

        void c_DeleteClicked(object sender)
        {
            flowLayoutPanel1.Controls.Remove((Column)sender);
            ((Column)sender).Dispose();
        }

        private void CreateTable_Load(object sender, EventArgs e)
        {
            btAddColumn.PerformClick();
        }
    }
}
