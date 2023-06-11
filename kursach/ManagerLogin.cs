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
    public partial class ManagerLogin : Form
    {
        public ManagerLogin()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            using (dbContext db = new dbContext()) 
            {
                ManagerClass Manager = null;
                try
                {
                    Manager = db.Managers.Where(u => u.Email == Email_Input.Text).First();
                    if (Password_Input.Text == Manager.Password)
                    {
                        ManagerForm profileForm = new ManagerForm(Manager);
                        this.Hide();
                        profileForm.ShowDialog();
                        this.Close();
                    }
                }
                catch
                {
                     DialogResult result = MessageBox.Show("Менеджер не найден");
                }

            }
        }
    }
}
