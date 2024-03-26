using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicentaApp.Models
{
    public class Category
    {
        public Category()
        {
        }

        //adaugam constructorul clasei
        public Category(int id, string nume)
        {
            Id = id;
            Nume = nume;
        }
        public int Id { get; set; }
        public string  Nume { get; set; }
    }
}