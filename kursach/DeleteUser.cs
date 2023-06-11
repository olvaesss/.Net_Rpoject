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
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            AdminClass Admin=new AdminClass();
            Admin.DeleteUser(Convert.ToInt32(ID_Input.Text));
            this.Hide();
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
