using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDobosz
{
    internal class warehouse
    {
        //Dalem wszedzie public by zmienne byly dostepne wszedzie
        public List<product> products1;
        public Adress warehouse_adress;
        //Konstruktor przypisuje zmienne do pseudozmiennych
        public warehouse(List<product> products1, Adress warehouse_adress)
        {
            this.products1 = products1 ?? new List<product>();
            this.warehouse_adress = warehouse_adress;
        }
    }
}
