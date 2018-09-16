namespace SQLiteHelperTestApp
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openExistingSQLiteDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewSQLiteDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getTableStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getTableListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getColumnStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryExecutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeScalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastInsertRowIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAllDataBetweenTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTablesStructureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attachDetachDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbDB = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem,
            this.dBInfoToolStripMenuItem,
            this.queryExecutionToolStripMenuItem,
            this.utilitiesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(515, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openExistingSQLiteDatabaseToolStripMenuItem,
            this.createNewSQLiteDatabaseToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // openExistingSQLiteDatabaseToolStripMenuItem
            // 
            this.openExistingSQLiteDatabaseToolStripMenuItem.Name = "openExistingSQLiteDatabaseToolStripMenuItem";
            this.openExistingSQLiteDatabaseToolStripMenuItem.Size = new System.Drawing.Size(384, 22);
            this.openExistingSQLiteDatabaseToolStripMenuItem.Text = "Open Existing SQLite Database (For Testing Purpose ONLY)";
            this.openExistingSQLiteDatabaseToolStripMenuItem.Click += new System.EventHandler(this.openExistingSQLiteDatabaseToolStripMenuItem_Click);
            // 
            // createNewSQLiteDatabaseToolStripMenuItem
            // 
            this.createNewSQLiteDatabaseToolStripMenuItem.Name = "createNewSQLiteDatabaseToolStripMenuItem";
            this.createNewSQLiteDatabaseToolStripMenuItem.Size = new System.Drawing.Size(384, 22);
            this.createNewSQLiteDatabaseToolStripMenuItem.Text = "Create New SQLite Database";
            this.createNewSQLiteDatabaseToolStripMenuItem.Click += new System.EventHandler(this.createNewSQLiteDatabaseToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(381, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(384, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dBInfoToolStripMenuItem
            // 
            this.dBInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getTableStatusToolStripMenuItem,
            this.getTableListToolStripMenuItem,
            this.getColumnStatusToolStripMenuItem,
            this.showDatabaseToolStripMenuItem});
            this.dBInfoToolStripMenuItem.Name = "dBInfoToolStripMenuItem";
            this.dBInfoToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.dBInfoToolStripMenuItem.Text = "DB Info";
            // 
            // getTableStatusToolStripMenuItem
            // 
            this.getTableStatusToolStripMenuItem.Name = "getTableStatusToolStripMenuItem";
            this.getTableStatusToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.getTableStatusToolStripMenuItem.Text = "GetTableStatus";
            this.getTableStatusToolStripMenuItem.Click += new System.EventHandler(this.getTableStatusToolStripMenuItem_Click);
            // 
            // getTableListToolStripMenuItem
            // 
            this.getTableListToolStripMenuItem.Name = "getTableListToolStripMenuItem";
            this.getTableListToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.getTableListToolStripMenuItem.Text = "GetTableList";
            this.getTableListToolStripMenuItem.Click += new System.EventHandler(this.getTableListToolStripMenuItem_Click);
            // 
            // getColumnStatusToolStripMenuItem
            // 
            this.getColumnStatusToolStripMenuItem.Name = "getColumnStatusToolStripMenuItem";
            this.getColumnStatusToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.getColumnStatusToolStripMenuItem.Text = "GetColumnStatus";
            this.getColumnStatusToolStripMenuItem.Click += new System.EventHandler(this.getColumnStatusToolStripMenuItem_Click);
            // 
            // showDatabaseToolStripMenuItem
            // 
            this.showDatabaseToolStripMenuItem.Name = "showDatabaseToolStripMenuItem";
            this.showDatabaseToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.showDatabaseToolStripMenuItem.Text = "Show Database";
            this.showDatabaseToolStripMenuItem.Click += new System.EventHandler(this.showDatabaseToolStripMenuItem_Click);
            // 
            // queryExecutionToolStripMenuItem
            // 
            this.queryExecutionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem,
            this.executeToolStripMenuItem,
            this.executeScalarToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.lastInsertRowIdToolStripMenuItem});
            this.queryExecutionToolStripMenuItem.Name = "queryExecutionToolStripMenuItem";
            this.queryExecutionToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.queryExecutionToolStripMenuItem.Text = "Query";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.selectToolStripMenuItem.Text = "Select";
            this.selectToolStripMenuItem.Click += new System.EventHandler(this.selectToolStripMenuItem_Click);
            // 
            // executeToolStripMenuItem
            // 
            this.executeToolStripMenuItem.Name = "executeToolStripMenuItem";
            this.executeToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.executeToolStripMenuItem.Text = "Execute";
            this.executeToolStripMenuItem.Click += new System.EventHandler(this.executeToolStripMenuItem_Click);
            // 
            // executeScalarToolStripMenuItem
            // 
            this.executeScalarToolStripMenuItem.Name = "executeScalarToolStripMenuItem";
            this.executeScalarToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.executeScalarToolStripMenuItem.Text = "ExecuteScalar";
            this.executeScalarToolStripMenuItem.Click += new System.EventHandler(this.executeScalarToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.insertToolStripMenuItem.Text = "Insert";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            this.transactionsToolStripMenuItem.Click += new System.EventHandler(this.transactionsToolStripMenuItem_Click);
            // 
            // lastInsertRowIdToolStripMenuItem
            // 
            this.lastInsertRowIdToolStripMenuItem.Name = "lastInsertRowIdToolStripMenuItem";
            this.lastInsertRowIdToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.lastInsertRowIdToolStripMenuItem.Text = "Last Insert RowId";
            this.lastInsertRowIdToolStripMenuItem.Click += new System.EventHandler(this.lastInsertRowIdToolStripMenuItem_Click);
            // 
            // utilitiesToolStripMenuItem
            // 
            this.utilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTableToolStripMenuItem,
            this.renameTableToolStripMenuItem,
            this.copyAllDataBetweenTablesToolStripMenuItem,
            this.dropTableToolStripMenuItem,
            this.updateTablesStructureToolStripMenuItem,
            this.attachDetachDatabaseToolStripMenuItem});
            this.utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
            this.utilitiesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.utilitiesToolStripMenuItem.Text = "Utilities";
            // 
            // createTableToolStripMenuItem
            // 
            this.createTableToolStripMenuItem.Name = "createTableToolStripMenuItem";
            this.createTableToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.createTableToolStripMenuItem.Text = "Create Table";
            this.createTableToolStripMenuItem.Click += new System.EventHandler(this.createTableToolStripMenuItem_Click);
            // 
            // renameTableToolStripMenuItem
            // 
            this.renameTableToolStripMenuItem.Name = "renameTableToolStripMenuItem";
            this.renameTableToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.renameTableToolStripMenuItem.Text = "Rename Table";
            this.renameTableToolStripMenuItem.Click += new System.EventHandler(this.renameTableToolStripMenuItem_Click);
            // 
            // copyAllDataBetweenTablesToolStripMenuItem
            // 
            this.copyAllDataBetweenTablesToolStripMenuItem.Name = "copyAllDataBetweenTablesToolStripMenuItem";
            this.copyAllDataBetweenTablesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.copyAllDataBetweenTablesToolStripMenuItem.Text = "Copy All Data Between Tables";
            this.copyAllDataBetweenTablesToolStripMenuItem.Click += new System.EventHandler(this.copyAllDataBetweenTablesToolStripMenuItem_Click);
            // 
            // dropTableToolStripMenuItem
            // 
            this.dropTableToolStripMenuItem.Name = "dropTableToolStripMenuItem";
            this.dropTableToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.dropTableToolStripMenuItem.Text = "Drop Table";
            this.dropTableToolStripMenuItem.Click += new System.EventHandler(this.dropTableToolStripMenuItem_Click);
            // 
            // updateTablesStructureToolStripMenuItem
            // 
            this.updateTablesStructureToolStripMenuItem.Name = "updateTablesStructureToolStripMenuItem";
            this.updateTablesStructureToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.updateTablesStructureToolStripMenuItem.Text = "Update Table\'s Structure";
            this.updateTablesStructureToolStripMenuItem.Click += new System.EventHandler(this.updateTablesStructureToolStripMenuItem_Click);
            // 
            // attachDetachDatabaseToolStripMenuItem
            // 
            this.attachDetachDatabaseToolStripMenuItem.Name = "attachDetachDatabaseToolStripMenuItem";
            this.attachDetachDatabaseToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.attachDetachDatabaseToolStripMenuItem.Text = "Attach Database";
            this.attachDetachDatabaseToolStripMenuItem.Click += new System.EventHandler(this.attachDatabaseToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 130);
            this.panel1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbDB});
            this.statusStrip1.Location = new System.Drawing.Point(0, 154);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(515, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbDB
            // 
            this.lbDB.Name = "lbDB";
            this.lbDB.Size = new System.Drawing.Size(0, 17);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 176);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "SQLite Helper Test App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openExistingSQLiteDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewSQLiteDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbDB;
        private System.Windows.Forms.ToolStripMenuItem dBInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getTableStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getTableListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getColumnStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryExecutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeScalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAllDataBetweenTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dropTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastInsertRowIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateTablesStructureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attachDetachDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDatabaseToolStripMenuItem;
    }
}

