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
    public partial class ManagerForm : Form
    {
        ManagerClass CurrentManager;
        public ManagerForm(ManagerClass CurrentManager)
        {
            InitializeComponent();
            this.CurrentManager = CurrentManager;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Login profileForm = new Login();
            this.Hide();
            profileForm.ShowDialog();
            this.Close();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            using (dbContext db = new dbContext())
            {
                OFFERS_Table.DataSource = db.Zakaz.ToList();
            }
        }

        private void OFFERS_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void GivePrice_Click(object sender, EventArgs e)
        {
            GivePrice profileForm = new GivePrice(CurrentManager);
            profileForm.ShowDialog();
        }

        private void CloseOFFER_Click(object sender, EventArgs e)
        {
            CloseOFFER profileForm = new CloseOFFER(CurrentManager);
            profileForm.ShowDialog();
        }
    }
}
