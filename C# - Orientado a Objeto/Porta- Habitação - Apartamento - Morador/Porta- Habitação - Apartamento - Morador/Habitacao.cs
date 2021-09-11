using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porta__Habitação___Apartamento___Morador
{
    public class Habitacao
    {
        public double area { get; set; }
        public Porta porta;
        public Habitacao (Porta porta, double area)
        {
            this.area = area;
            this.porta = porta;
        }

        public void MostarHabitacao()
        {
            Console.WriteLine($"Eu sou uma habitação, minha area é {this.area} m², e a cor da minha porta é {this.porta.cor}");
        }
    }
}
