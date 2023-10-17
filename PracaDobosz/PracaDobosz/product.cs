using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDobosz
{
    internal class product
    {
        //Dalem wszedzie public by zmienne byly dostepne wszedzie
        public string producer_name;
        public string product_name;
        public string category;
        public int product_code;
        public int price;
        public string description;
        //Konstruktor przypisuje zmienne do pseudozmiennych
        public product(string producer_name,string product_name,string category,int product_code,int price,string description) 
        {
            this.producer_name = producer_name;
            this.product_name = product_name;
            this.category = category;
            this.product_code = product_code;
            this.price = price;
            this.description = description;

        }
    }
}
