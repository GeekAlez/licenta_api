using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicentaApp.Models
{
    public class Category
    {
       

        //adaugam constrcutorul clasei
        public Category(short id, string nume)
        {
            Id = id;
            Nume = nume;
        }
        public short Id { get; set; }
        public string  Nume { get; set; }
    }
}