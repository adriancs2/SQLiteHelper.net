using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SQLiteHelperTestApp
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            HideAllMenu();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void openExistingSQLiteDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                config.DatabaseFile = f.FileName;
                lbDB.Text = config.DataSource;
                if (TestConnection())
                    RevealAllMenu();
                else
                    HideAllMenu();
            }
        }

        private void createNewSQLiteDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                config.DatabaseFile = f.FileName;
                lbDB.Text = config.DataSource;
                if (TestConnection())
                    RevealAllMenu();
                else
                    HideAllMenu();
            }
        }

        void RevealAllMenu()
        {
            for (int i = 0; i < menuStrip1.Items.Count; i++)
            {
                menuStrip1.Items[i].Visible = true;
            }
        }

        void HideAllMenu()
        {
            for (int i = 1; i < menuStrip1.Items.Count; i++)
            {
                menuStrip1.Items[i].Visible = false;
            }
        }

        bool TestConnection()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
                {
                    conn.Open();
                    conn.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private void getTableStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.DBInfo.GetTableStatus f = new Forms.DBInfo.GetTableStatus();
            f.Show();
        }

        private void getTableListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.DBInfo.GetTableList f = new Forms.DBInfo.GetTableList();
            f.Show();
        }

        private void getColumnStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.DBInfo.GetColumnStatus f = new Forms.DBInfo.GetColumnStatus();
            f.Show();
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Query.Select f = new Forms.Query.Select();
            f.Show();
        }

        private void executeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Query.Execute f = new Forms.Query.Execute();
            f.Show();
        }

        private void executeScalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Query.ExecuteScalar f = new Forms.Query.ExecuteScalar();
            f.Show();
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Query.Insert f = new Forms.Query.Insert();
            f.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Query.Update f = new Forms.Query.Update();
            f.Show();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Query.Transaction f = new Forms.Query.Transaction();
            f.Show();
        }

        private void lastInsertRowIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Query.LastInsertRowId f = new Forms.Query.LastInsertRowId();
            f.Show();
        }

        private void renameTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Utilities.RenameTable f = new Forms.Utilities.RenameTable();
            f.Show();
        }

        private void dropTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Utilities.DropTable f = new Forms.Utilities.DropTable();
            f.Show();
        }

        private void copyAllDataBetweenTablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Utilities.CopyAllDataBetweenTables f = new Forms.Utilities.CopyAllDataBetweenTables();
            f.Show();
        }

        private void createTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Utilities.CreateTable f = new Forms.Utilities.CreateTable();
            f.Show();
        }

        private void updateTablesStructureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Utilities.UpdateTableStructure f = new Forms.Utilities.UpdateTableStructure();
            f.Show();
        }

        private void showDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.DBInfo.ShowDatabase f = new Forms.DBInfo.ShowDatabase();
            f.Show();
        }

        private void attachDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.Utilities.AttachDatabase f = new Forms.Utilities.AttachDatabase();
            f.Show();
        }
    }
}
