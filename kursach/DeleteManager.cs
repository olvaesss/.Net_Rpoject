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
    public partial class DeleteManager : Form
    {
        AdminClass Admin = new AdminClass();
        public DeleteManager()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            Admin.DeleteManager(Convert.ToInt32(this.ID_Input.Text));
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
