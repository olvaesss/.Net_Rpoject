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
    public partial class GivePrice : Form
    {
        ManagerClass CurrentManager;
        public GivePrice(ManagerClass CurrentManager)
        {
            InitializeComponent();
            this.CurrentManager = CurrentManager;
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            var Manager = new ManagerClass();
            Manager.GivePrice(Convert.ToInt32(this.ID_Input.Text), Convert.ToInt32(this.Price_Input.Text), CurrentManager.ManagerID);
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
