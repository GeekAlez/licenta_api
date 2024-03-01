namespace WebAPI.Models
{
    public class Rezervare
    {
        public long Id { get; set; }
        public IEnumerable<Pachet> Pachets { get; set; } = Enumerable.Empty<Pachet>();
        public DateTime Data { get; set; }
    }
}
