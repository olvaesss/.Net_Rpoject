using kursach;
using static kursach.ApplicationContext;

namespace kursach
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                using (dbContext db = new dbContext())
                {
                if (Email_Input.Text == "admin@admin.com" && Passwotd_Input.Text == "admin123")
                {
                    AdminForm profileForm = new AdminForm();
                    this.Hide();
                    profileForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    User User = null;
                    try
                    {
                        User = db.Users.Where(u => u.Email == Email_Input.Text).First();
                        if (User.Email == Email_Input.Text && User.Password == Passwotd_Input.Text)
                        {
                            Main profileForm = new Main(User);
                            this.Hide();
                            profileForm.ShowDialog();
                            this.Close();
                        }
                    }
                    catch
                    {
                        DialogResult result = MessageBox.Show("Пользователь не найден");
                    }
                }
                }
            }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register profileForm = new Register();
            this.Hide();
            profileForm.ShowDialog();
            this.Close();
        }

        private void SignManager_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ManagerLogin profileForm = new ManagerLogin();
            this.Hide();
            profileForm.ShowDialog();
            this.Close();
        }
    }
}