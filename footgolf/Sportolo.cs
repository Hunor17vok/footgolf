using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace footgolf
{
    internal class Sportolo
    {
        public string Nev { get; set; }
        public string Kategoria { get; set; }
        public string Egyesulet { get; set; }
        


        public Sportolo(string sor)
        {
            string[] D = sor.Split(';');
            Nev = D[0];
            Kategoria = D[1];
            Egyesulet = D[2];
            
        }
    }
}
