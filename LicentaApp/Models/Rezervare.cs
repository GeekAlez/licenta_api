using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicentaApp.Models
{
    public class Rezervare
    {
        public long Id { get; set; }
        public IEnumerable<Pachet> Pachets { get; set; } = Enumerable.Empty<Pachet>();
        public DateTime Data { get; set; }

    }
}
