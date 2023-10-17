using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDobosz
{
    internal class Adress
    {
        //Dalem wszedzie public by zmienne byly dostepne wszedzie
        public string street;
        public string post_code;
        public string city;
        public string possesion_number;
        public string flat_number;
        //Konstruktor przypisuje zmienne do pseudozmiennych
        public Adress(string street,string post_code, string city, string possesion_number,string flat_number) 
        {
            this.street=street;
            this.post_code=post_code;
            this.city=city;
            this.possesion_number=possesion_number;
            this.flat_number=flat_number;
        }
    }
}
