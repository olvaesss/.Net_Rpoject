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
    public partial class CloseOFFER : Form
    {
        ManagerClass CurrentManager;
        public CloseOFFER(ManagerClass CurrentManager)
        {
            InitializeComponent();
            this.CurrentManager = CurrentManager;
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            var Manager = new ManagerClass();
            Manager.closeOFFER(Convert.ToInt32(this.ID_Input.Text), CurrentManager.ManagerID);
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
