using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estacionamento_csharp.Models
{
    public class Veiculo
    {
        public string Tipo;

        public string Placa;

        private double valorInicial;

        public DateTime horaDia = DateTime.Now;


        //construtor
        public Veiculo()
        {
            this.valorInicial = 0.0;

        }

        public Veiculo(string tipo, string placa)
        {
            this.Tipo = tipo;
            this.Placa = placa;
        }

        public virtual double GetValorInicial()
        {
            return this.valorInicial;
        }
      
    }
    
}