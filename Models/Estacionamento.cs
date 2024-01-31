using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace estacionamento_csharp.Models
{
    public class Estacionamento
    {
        public double valorHora = 8.00;
        private List<Veiculo> veiculos = new List<Veiculo>();
        public void AdicionarVeiculo()
        {
          
            Console.Write("Digite o tipo do veículo (carro / moto): ");
            string tipo = Console.ReadLine();

            Console.Write("Digite a placa do veículo: ");
            string placa = Console.ReadLine();

            if(tipo == "carro")
            {
                veiculos.Add(new Carro(tipo, placa));
            }
            else if(tipo == "moto")
            {
                veiculos.Add(new Moto(tipo, placa));
            }
            else
            {
                Console.WriteLine("Tipo invalido - Digite carro ou moto");

            }
            Console.WriteLine();
        }

        public void Buscar(string placa)
        {
            bool encontrado = false;
             
            foreach(Veiculo v in veiculos)
            {
                if( v.Placa == placa)
                {
                    Console.WriteLine("Dados do veículo: ");
                    Console.WriteLine(v.horaDia);
                    Console.WriteLine(v.Tipo + " - " + v.Placa);

                    encontrado = true;
                }

            }
            if(!encontrado)
            {
                
                Console.WriteLine("Veículo não encontrado");
            }
           
        }

        public void ListarVeiculos()
        {
            Console.WriteLine();
            Console.WriteLine("Total " + veiculos.Count + " veículo(s) estacionado(s)");
            Console.WriteLine("Dados dos veículos: ");
            int count = 1;
                        
            foreach(Veiculo v in veiculos)
            {
                Console.WriteLine();
                Console.WriteLine("nº " + count + " " + v.Tipo + " - " + v.Placa + " - " + v.horaDia);
                count++;
            }

        }

        public void RemoverVeiculo(string placa)
        {

            veiculos.Remove(veiculos.First(v => v.Placa == placa));
            Console.WriteLine("Veículo removido com sucesso");
            
        }

        public void Pagar(string placa, int horas)
        {
            foreach(Veiculo v in veiculos)
            {
                if(v.Placa == placa)
                {
                   double valorTotal = v.GetValorInicial() + (valorHora * (horas - 1 ));
                   Console.WriteLine("Valor a Pagar R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
                   this.RemoverVeiculo(placa);
                   Console.WriteLine("Pagamento realizado com sucesso!");
                   break;

                }
                
            }
            
        }
        
    }
}