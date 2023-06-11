using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kursach;
using static kursach.ApplicationContext;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

namespace kursach
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LoginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login profileForm = new Login();
            this.Hide();
            profileForm.ShowDialog();
            this.Close();
        }


        private void test_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Email_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_Repeat_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Phone_Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Button_Click(object sender, EventArgs e)
        {
            var validationFunc = new ValidattionFunc();
            if(validationFunc.validateCredentials(this.Email_Input.Text, this.Password_Input.Text, this.Password_Repeat_Input.Text)==true) {
                {
                    var User = new User(this.Name_Input.Text, this.Password_Input.Text, this.Email_Input.Text, this.Phone_Input.Text);
                    using (dbContext db = new dbContext())
                    {
                        Console.WriteLine(User);
                        db.Users.Add(User);
                        db.SaveChanges();
                        DialogResult result = MessageBox.Show("Пользователь успешно зарегистрирован");
                        Main profileForm = new Main(User);
                        this.Hide();
                        profileForm.ShowDialog();
                        this.Close();
                    }
                }
            }
        }
    }
}
