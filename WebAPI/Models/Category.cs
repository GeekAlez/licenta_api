namespace WebAPI.Models
{
    public class Category
    {
        public Category(short id, string nume)
        {
            Id = id;
            Nume = nume;
            

        }
        public short Id { get; set; }
        public string Nume { get; set; }
       
    }
}
