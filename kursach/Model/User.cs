using Microsoft.EntityFrameworkCore;
using static kursach.ApplicationContext;

namespace kursach
{
    public class User
    {
        public User(string Name, string Password, string Email, string Phone)
        {
            this.Name = Name;
            this.Password = Password;
            this.Email = Email;
            Discount = 0;
            this.Phone = Phone;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Discount { get; set; }
        public string Phone { get; set; }

        public Array History()
        {
            using (dbContext db = new dbContext())
            {
                return db.Zakaz.Where(u => u.UserID == ID).ToArray();
            }
        }
    }
}