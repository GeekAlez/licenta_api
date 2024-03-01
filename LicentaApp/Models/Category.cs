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
        public Category(short id, string nume, short parentId, string poza, string credit)
        {
            Id = id;
            Nume = nume;
            Poza = poza;
            ParentId = parentId;

        }
        public short Id { get; set; }
        public string Nume { get; set; }
        public string Poza { get; set; }
        public short ParentId { get; set; }
        public string Credit { get; set; }
        public bool IsMainCategory => ParentId == 0;//aici se verifica daca avem de a face cu o categorie principala sau secundara


    }
}