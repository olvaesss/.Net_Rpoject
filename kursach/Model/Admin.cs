using static kursach.ApplicationContext;

namespace kursach
{
    public class AdminClass
    {
        public void DeleteUser(int ID)
        {
            using (dbContext db = new dbContext())
            {
                User User = db.Users.Where(u => u.ID == ID).First();
                db.Users.Remove(User);
                db.SaveChanges();
            }
        }
        public void DeleteManager(int ID)
        {
            using (dbContext db = new dbContext())
            {
                ManagerClass Manager = db.Managers.Where(u => u.ManagerID == ID).First();
                db.Managers.Remove(Manager);
                db.SaveChanges();
            }
        }
        public void AddManager(ManagerClass Manager)
        {
            using (dbContext db = new dbContext())
            {
                db.Managers.Add(Manager);
                db.SaveChanges();
            }
        }
    }
}