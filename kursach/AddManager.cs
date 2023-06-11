using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach
{
    public partial class AddManager : Form
    {
        AdminClass admin= new AdminClass();
        public AddManager()
        {   
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            var Manager = new ManagerClass()
            {
                Email = Email_Input.Text,
                ManagerFIO = Name_Input.Text,
                Phone = Phone_Input.Text,   
                Password = Password_Input.Text,
            };
            admin.AddManager(Manager);
            DialogResult result = MessageBox.Show("Менеджер создан");
            AdminForm profileForm = new AdminForm();
            this.Hide();
            profileForm.ShowDialog();
            this.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            AdminForm profileForm = new AdminForm();
            this.Hide();
            profileForm.ShowDialog();
            this.Close();
        }
    }
}
