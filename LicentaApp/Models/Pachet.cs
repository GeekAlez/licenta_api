using System;
using System.Collections.Generic;
using System.Linq;
using LicentaApp.Data;
using LicentaApp.Models;  // Asigură-te că acest using există și conține clasa RestaurantService

namespace LicentaApp.Models
{
    public class Pachet
    {

        public int Id { get; set; }
        public string Nume { get; set; }
        public string Eveniment { get; set; }
        public string Locatie { get; set; }
        public string Pret { get; set; }
        public string InformatiiSuplimentare { get; set; }
    
    }
}