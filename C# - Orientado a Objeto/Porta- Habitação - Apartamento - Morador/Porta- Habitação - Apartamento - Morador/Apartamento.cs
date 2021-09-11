using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porta__Habitação___Apartamento___Morador
{
    public class Apartamento : Habitacao
    {
        public int numApe { get; set; }

        public Apartamento(Porta porta, double area, int numApe) : base(porta, area)
        {
            this.area = area;
        }
    }
}
