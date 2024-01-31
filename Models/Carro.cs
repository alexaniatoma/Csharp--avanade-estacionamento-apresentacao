using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estacionamento_csharp.Models
{
    public class Carro : Veiculo
    {
         private double valorInicial;

        public Carro(string tipo, string placa) : base (tipo, placa)
        {
            this.valorInicial = 10.00;
        }

        public override double GetValorInicial()
        {
         return this.valorInicial;
        }
    }
}