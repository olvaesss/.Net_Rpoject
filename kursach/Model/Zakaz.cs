namespace kursach
{
    public class Zakaz
    {
        public int ID { get; set; }
        public int UserID { get; set; }
         public int ManagerId { get; set; }
        public string Type { get; set; }
        public string Phone { get; set; }
        public int Price { get; set; }

        public Boolean Closed { get; set; }
    }
}
