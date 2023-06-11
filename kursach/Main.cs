using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kursach;
using static kursach.ApplicationContext;

namespace kursach
{
    public partial class Main : Form
    {
        User CurrentUser;
        public Main(User CurrentUser)
        {
            InitializeComponent();
            this.CurrentUser = CurrentUser;
        }

        private void Info_Click(object sender, EventArgs e)
        {
        }

        private void HomeCleanButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(CurrentUser);
            var newZakaz = new Zakaz()
            {
                UserID = CurrentUser.ID,
                Type = "HomeClean",
                Phone = CurrentUser.Phone,
                Price = 200,
                Closed = false,
            };
            using (dbContext db = new dbContext())
            {
                db.Zakaz.Add(newZakaz);
                db.SaveChanges();
                DialogResult result = MessageBox.Show("Заказ создан, оператор с вами свяжется(Ваша личная скидка:"+CurrentUser.Discount+"%)");
            }
        }

        private void History_Click(object sender, EventArgs e)
        {
            var Arr=CurrentUser.History();
            for(var i = 0; i <= Arr.Length; i++)
            {
                for(var j = 0; j <= 3; j++)
                {
                    DataGridViewTextBoxColumn Price = new DataGridViewTextBoxColumn();
                }
            }
        }

        private void Kovri_Click(object sender, EventArgs e)
        {
            var newZakaz = new Zakaz()
            {
                UserID = CurrentUser.ID,
                Type = "Kovri",
                Phone = CurrentUser.Phone,
                Price = 200,
                Closed = false,
            };
            using (dbContext db = new dbContext())
            {
                db.Zakaz.Add(newZakaz);
                db.SaveChanges();
                DialogResult result = MessageBox.Show("Заказ создан, оператор с вами свяжется(Ваша личная скидка:" + CurrentUser.Discount + "%)");

            }
        }

        private void Dry_Click(object sender, EventArgs e)
        {
            var newZakaz = new Zakaz()
            {
                UserID = CurrentUser.ID,
                Type = "Cleaning",
                Phone = CurrentUser.Phone,
                Price = 200,
                Closed = false,
            };
            using (dbContext db = new dbContext())
            {
                db.Zakaz.Add(newZakaz);
                db.SaveChanges();
                DialogResult result = MessageBox.Show("Заказ создан, оператор с вами свяжется(Ваша личная скидка:" + CurrentUser.Discount + "%)");

            }
        }

        private void history_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Login profileForm = new Login();
            this.Hide();
            profileForm.ShowDialog();
            this.Close();
        }

        private void help_Click(object sender, EventArgs e)
        {
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Чтобы оставить заявку просто нажмите на интересующую Вас услгу и свобоный менеджер свяжется с вами и сообшит вам о цене и другую информаию о заказе");
        }
    }
}
