using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using estacionamento_csharp.Models;

namespace estacionamento_csharp
{
    public class Moto : Veiculo
    {
        private double valorInicial;

        public Moto(string tipo, string placa) : base (tipo, placa)
        {
            this.valorInicial = 5.00;
        }

        public override double GetValorInicial()
        {
            return this.valorInicial;
        }
        
    }

}