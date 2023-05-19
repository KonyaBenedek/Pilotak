using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilotak
{
    public class Pilota
    {
        private string név;
        private string szültésiDátum;
        private string nemzetiség;
        private int rajtszám;
        private int év;

        public Pilota(string sor)
        {
            var splitSor = sor.Split(';');
            név = splitSor[0];
            szültésiDátum = splitSor[1];
            nemzetiség = splitSor[2];
            rajtszám = (splitSor[3].Length > 0) ? Convert.ToInt32(splitSor[3]): 0;
            év = Convert.ToInt32(splitSor[1].Substring(0,4));

        }

        public string Név { get => név; set => név = value; }
        public string SzültésiDátum { get => szültésiDátum; set => szültésiDátum = value; }
        public string Nemzetiség { get => nemzetiség; set => nemzetiség = value; }
        public int Rajtszám { get => rajtszám; set => rajtszám = value; }
        public int Év { get => év; set => év = value; }


    }
}
