using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicentaApp.Models
{
    public partial class SumarRezervare : ObservableObject
    {
        public int Id { get; set; }
        public int PachetId { get; set; }
        public string PachetNume { get; set; }
    }
}
