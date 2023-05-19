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
        private string szültési_dátum;
        private string nemzetiség;
        private int rajtszám;
        private int év;

        public string Név { get => név; set => név = value; }
        public string Szültési_dátum { get => szültési_dátum; set => szültési_dátum = value; }
        public string Nemzetiség { get => nemzetiség; set => nemzetiség = value; }
        public int Rajtszám { get => rajtszám; set => rajtszám = value; }
        public int Év { get => év; set => év = value; }
    }
}
