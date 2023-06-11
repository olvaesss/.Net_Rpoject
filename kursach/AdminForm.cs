using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using static kursach.ApplicationContext;

namespace kursach
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {

            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Login profileForm = new Login();
            this.Hide();
            profileForm.ShowDialog();
            this.Close();
        }

        private void AddManager_Click(object sender, EventArgs e)
        {
            AddManager profileForm = new AddManager();
            this.Hide();
            profileForm.ShowDialog();
            this.Close();
        }

        private void UsersTable_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            using (dbContext db = new dbContext())
            {
                
                UsersTable.DataSource = db.Users.ToList();
                ManagersTable.DataSource = db.Managers.ToList();
            }
        }

        private void ManagersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Exit_Click_1(object sender, EventArgs e)
        {
            Login profileForm = new Login();
            this.Hide();
            profileForm.ShowDialog();
            this.Close();
        }

        private void AddManager_Click_1(object sender, EventArgs e)
        {
            AddManager profileForm = new AddManager();
            this.Hide();
            profileForm.ShowDialog();
            this.Close();
        }

        private void DeleteManager_Click(object sender, EventArgs e)
        {
            DeleteManager profileForm = new DeleteManager();
            profileForm.ShowDialog();
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            DeleteUser profileForm = new DeleteUser();
            profileForm.ShowDialog();
        }
    }
}
