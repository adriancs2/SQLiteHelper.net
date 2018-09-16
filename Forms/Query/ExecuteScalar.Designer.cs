namespace SQLiteHelperTestApp.Forms.Query
{
    partial class ExecuteScalar
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
            this.btStr = new System.Windows.Forms.Button();
            this.btInt = new System.Windows.Forms.Button();
            this.btDecimal = new System.Windows.Forms.Button();
            this.btBlob = new System.Windows.Forms.Button();
            this.btDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btStr
            // 
            this.btStr.Location = new System.Drawing.Point(75, 26);
            this.btStr.Name = "btStr";
            this.btStr.Size = new System.Drawing.Size(75, 23);
            this.btStr.TabIndex = 0;
            this.btStr.Text = "string";
            this.btStr.UseVisualStyleBackColor = true;
            this.btStr.Click += new System.EventHandler(this.btStr_Click);
            // 
            // btInt
            // 
            this.btInt.Location = new System.Drawing.Point(75, 55);
            this.btInt.Name = "btInt";
            this.btInt.Size = new System.Drawing.Size(75, 23);
            this.btInt.TabIndex = 1;
            this.btInt.Text = "int";
            this.btInt.UseVisualStyleBackColor = true;
            this.btInt.Click += new System.EventHandler(this.btInt_Click);
            // 
            // btDecimal
            // 
            this.btDecimal.Location = new System.Drawing.Point(75, 84);
            this.btDecimal.Name = "btDecimal";
            this.btDecimal.Size = new System.Drawing.Size(75, 23);
            this.btDecimal.TabIndex = 2;
            this.btDecimal.Text = "decimal";
            this.btDecimal.UseVisualStyleBackColor = true;
            this.btDecimal.Click += new System.EventHandler(this.btDecimal_Click);
            // 
            // btBlob
            // 
            this.btBlob.Location = new System.Drawing.Point(75, 113);
            this.btBlob.Name = "btBlob";
            this.btBlob.Size = new System.Drawing.Size(75, 23);
            this.btBlob.TabIndex = 3;
            this.btBlob.Text = "blob";
            this.btBlob.UseVisualStyleBackColor = true;
            this.btBlob.Click += new System.EventHandler(this.btBlob_Click);
            // 
            // btDate
            // 
            this.btDate.Location = new System.Drawing.Point(75, 142);
            this.btDate.Name = "btDate";
            this.btDate.Size = new System.Drawing.Size(75, 23);
            this.btDate.TabIndex = 4;
            this.btDate.Text = "datetime";
            this.btDate.UseVisualStyleBackColor = true;
            this.btDate.Click += new System.EventHandler(this.btDate_Click);
            // 
            // ExecuteScalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 197);
            this.Controls.Add(this.btDate);
            this.Controls.Add(this.btBlob);
            this.Controls.Add(this.btDecimal);
            this.Controls.Add(this.btInt);
            this.Controls.Add(this.btStr);
            this.Name = "ExecuteScalar";
            this.Text = "ExecuteScalar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btStr;
        private System.Windows.Forms.Button btInt;
        private System.Windows.Forms.Button btDecimal;
        private System.Windows.Forms.Button btBlob;
        private System.Windows.Forms.Button btDate;
    }
}