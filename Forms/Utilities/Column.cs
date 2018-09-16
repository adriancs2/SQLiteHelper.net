using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SQLiteHelperTestApp.Forms.Utilities
{
    public partial class Column : UserControl
    {
        public string ColumnName { get { return textBox1.Text; } }
        public ColType ColumnType { get { return (ColType)comboBox1.SelectedValue; } }
        public string DefaultValue { get { return textBox2.Text; } }
        public bool NotNUll { get { return checkBox2.Checked; } }
        public bool PrimaryKey { get { return checkBox1.Checked; } }
        public bool AutoIncrement { get { return checkBox3.Checked; } }
        public SQLiteColumn SQLiteCol
        {
            get
            {
                return new SQLiteColumn(ColumnName, ColumnType, PrimaryKey, AutoIncrement, NotNUll, DefaultValue);
            }
        }
        
        public delegate void deleteClick(object sender);
        public event deleteClick DeleteClicked;

        public Column()
        {
            InitializeComponent();

            DataTable dt = new DataTable();
            dt.Columns.Add("name");
            dt.Columns.Add("id", typeof(ColType));

            dt.Rows.Add("Text", ColType.Text);
            dt.Rows.Add("Integer", ColType.Integer);
            dt.Rows.Add("DateTime", ColType.DateTime);
            dt.Rows.Add("Decimal", ColType.Decimal);
            dt.Rows.Add("Blob", ColType.BLOB);

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DeleteClicked != null)
                DeleteClicked(this);
        }
    }
}
