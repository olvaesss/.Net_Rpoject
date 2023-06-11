namespace kursach
{
    partial class AdminForm
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
            this.UsersTable = new System.Windows.Forms.DataGridView();
            this.ManagersTable = new System.Windows.Forms.DataGridView();
            this.Exit = new System.Windows.Forms.Button();
            this.AddManager = new System.Windows.Forms.Button();
            this.DeleteManager = new System.Windows.Forms.Button();
            this.DeleteUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsersTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManagersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersTable
            // 
            this.UsersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersTable.Location = new System.Drawing.Point(26, 12);
            this.UsersTable.Name = "UsersTable";
            this.UsersTable.RowHeadersWidth = 51;
            this.UsersTable.RowTemplate.Height = 29;
            this.UsersTable.Size = new System.Drawing.Size(447, 188);
            this.UsersTable.TabIndex = 0;
            this.UsersTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersTable_CellContentClick_1);
            // 
            // ManagersTable
            // 
            this.ManagersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ManagersTable.Location = new System.Drawing.Point(26, 223);
            this.ManagersTable.Name = "ManagersTable";
            this.ManagersTable.RowHeadersWidth = 51;
            this.ManagersTable.RowTemplate.Height = 29;
            this.ManagersTable.Size = new System.Drawing.Size(447, 188);
            this.ManagersTable.TabIndex = 1;
            this.ManagersTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ManagersTable_CellContentClick);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(548, 295);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(240, 45);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Выйти";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click_1);
            // 
            // AddManager
            // 
            this.AddManager.Location = new System.Drawing.Point(548, 72);
            this.AddManager.Name = "AddManager";
            this.AddManager.Size = new System.Drawing.Size(240, 45);
            this.AddManager.TabIndex = 3;
            this.AddManager.Text = "Добавить менеджера";
            this.AddManager.UseVisualStyleBackColor = true;
            this.AddManager.Click += new System.EventHandler(this.AddManager_Click_1);
            // 
            // DeleteManager
            // 
            this.DeleteManager.Location = new System.Drawing.Point(548, 132);
            this.DeleteManager.Name = "DeleteManager";
            this.DeleteManager.Size = new System.Drawing.Size(240, 45);
            this.DeleteManager.TabIndex = 4;
            this.DeleteManager.Text = "Удалить менеджера";
            this.DeleteManager.UseVisualStyleBackColor = true;
            this.DeleteManager.Click += new System.EventHandler(this.DeleteManager_Click);
            // 
            // DeleteUser
            // 
            this.DeleteUser.Location = new System.Drawing.Point(548, 199);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(240, 45);
            this.DeleteUser.TabIndex = 5;
            this.DeleteUser.Text = "Удалить пользователя";
            this.DeleteUser.UseVisualStyleBackColor = true;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.DeleteManager);
            this.Controls.Add(this.AddManager);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ManagersTable);
            this.Controls.Add(this.UsersTable);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManagersTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView UsersTable;
        private DataGridView ManagersTable;
        private Button Exit;
        private Button AddManager;
        private Button DeleteManager;
        private Button DeleteUser;
    }
}