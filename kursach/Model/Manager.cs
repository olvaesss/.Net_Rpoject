using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using static kursach.ApplicationContext;

namespace kursach
{
    public class ManagerClass
    {
        [Key]
        public int ManagerID { get; set; }
        public string ManagerFIO { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public void closeOFFER(int ID, int ManagerID)
        {
            using (dbContext db = new dbContext())
            {
                var UpdateOFFER = db.Zakaz.Where(u => u.ID == ID).First();
                UpdateOFFER.Closed = true;
                UpdateOFFER.ManagerId =ManagerID;
                db.Zakaz.Update(UpdateOFFER);
                var User = db.Users.Where(u => u.ID == UpdateOFFER.UserID).First();
                User.Discount += 1;
                db.Users.Update(User);
                db.SaveChanges();
                DialogResult result = MessageBox.Show("Заказ закрыт");
            }
        }
        public void DeleteOFFER(int ID)
        {
            using (dbContext db = new dbContext())
            {
                var OFFER =db.Zakaz.Where(u => u.ID == ID).First();
                db.Zakaz.Remove(OFFER);
                db.SaveChanges();
                DialogResult result = MessageBox.Show("Заказ удален");

            }
        }
        public void GivePrice(int ID, int Price, int ManagerID)
        {
            using (dbContext db = new dbContext())
            {
                var UpdateOFFER = db.Zakaz.Where(u => u.ID == ID).First();
                var User = db.Users.Where(u => u.ID == UpdateOFFER.UserID).First();
                int Discount= User.Discount; 
                UpdateOFFER.Price = Price-Price*(Discount/100);
                if(User.Discount == 50)
                {
                    User.Discount = 0;
                }
                UpdateOFFER.ManagerId = ManagerID;
                db.Users.Update(User);
                db.Zakaz.Update(UpdateOFFER);
                db.SaveChanges();
                DialogResult result = MessageBox.Show("Заказ обновлен, цена составляет:"+UpdateOFFER.Price);
            }
        }
    }
}
