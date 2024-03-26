namespace WebAPI.Models
{
    public class Category
    {
        public Category(int id, string nume)
        {
            Id = id;
            Nume = nume;
            

        }
        public int Id { get; set; }
        public string Nume { get; set; }
       
    }
}
