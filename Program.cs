using System.Collections;
using estacionamento_csharp.Models;


Console.WriteLine("Bem vindo ao estacionamento STOP");

Estacionamento estacionamento = new Estacionamento();

bool exibirMemu = true;
while(exibirMemu)
{
    Console.WriteLine("1 - Cadastrar");
    Console.WriteLine("2 - Buscar");
    Console.WriteLine("3 - Listar Veículos");
    Console.WriteLine("4 - Remover Veículo");
    Console.WriteLine("5 - Pagar/Baixa");
    Console.WriteLine("6 - Encerrar");
    Console.Write("Digite a sua opção: ");

    switch(Console.ReadLine())
    {
         case "1":
         estacionamento.AdicionarVeiculo();
         break;

         case "2":
         Console.Write("Buscar a placa do veículo estacionado: ");
         string placa = Console.ReadLine();
         estacionamento.Buscar(placa);
         break;

         case "3":
         Console.WriteLine("Lista de veículos estacionados ");
         estacionamento.ListarVeiculos();
         break;

         case "4":
         Console.Write("Digite a placa do veículo a ser removido: ");
         string placaRemove = Console.ReadLine();
         estacionamento.RemoverVeiculo(placaRemove);
         break;

         case "5":
         Console.Write("Digite a placa do veículo para dar baixa: ");
         string placaPagar = Console.ReadLine();
         Console.Write("Digite a quantidade de horas: ");
         int hora = int.Parse(Console.ReadLine());
         estacionamento.Pagar(placaPagar, hora);
         break;

         case "6":
         Console.WriteLine("Obrigado por utilizar nosso sistema!");
         Console.WriteLine("Sistema encerrado");
         exibirMemu = false;
         break;

         default:
         Console.WriteLine("Opção inválida, digite novamente.");
         break;

    }
   
    Console.WriteLine("Digite uma tecla para continuar");
    Console.ReadLine();

}

    

