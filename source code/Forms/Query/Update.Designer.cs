namespace SQLiteHelperTestApp.Forms.Query
{
    partial class Update
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bt_lvl = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_lvl_weapon = new System.Windows.Forms.Button();
            this.bt_lvl_weapon_team = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_lvl
            // 
            this.bt_lvl.Location = new System.Drawing.Point(3, 3);
            this.bt_lvl.Name = "bt_lvl";
            this.bt_lvl.Size = new System.Drawing.Size(132, 23);
            this.bt_lvl.TabIndex = 0;
            this.bt_lvl.Text = "Update (where lvl = 1)";
            this.bt_lvl.UseVisualStyleBackColor = true;
            this.bt_lvl.Click += new System.EventHandler(this.bt_lvl_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_lvl_weapon_team);
            this.panel1.Controls.Add(this.bt_lvl_weapon);
            this.panel1.Controls.Add(this.bt_lvl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 32);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(746, 358);
            this.dataGridView1.TabIndex = 2;
            // 
            // bt_lvl_weapon
            // 
            this.bt_lvl_weapon.Location = new System.Drawing.Point(141, 3);
            this.bt_lvl_weapon.Name = "bt_lvl_weapon";
            this.bt_lvl_weapon.Size = new System.Drawing.Size(214, 23);
            this.bt_lvl_weapon.TabIndex = 1;
            this.bt_lvl_weapon.Text = "Update (where lvl = 1 and weaponid = 1)";
            this.bt_lvl_weapon.UseVisualStyleBackColor = true;
            this.bt_lvl_weapon.Click += new System.EventHandler(this.bt_lvl_weapon_Click);
            // 
            // bt_lvl_weapon_team
            // 
            this.bt_lvl_weapon_team.Location = new System.Drawing.Point(361, 3);
            this.bt_lvl_weapon_team.Name = "bt_lvl_weapon_team";
            this.bt_lvl_weapon_team.Size = new System.Drawing.Size(281, 23);
            this.bt_lvl_weapon_team.TabIndex = 2;
            this.bt_lvl_weapon_team.Text = "Update (where lvl = 1 and weaponid = 1 and teamid = 1)";
            this.bt_lvl_weapon_team.UseVisualStyleBackColor = true;
            this.bt_lvl_weapon_team.Click += new System.EventHandler(this.bt_lvl_weapon_team_Click);
            // 
            // Update
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(746, 390);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Update";
            this.Text = "Update";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_lvl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_lvl_weapon_team;
        private System.Windows.Forms.Button bt_lvl_weapon;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}