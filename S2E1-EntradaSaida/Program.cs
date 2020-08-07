using System;

namespace S2E1_EntradaSaida
{
    class Program
    {
        static void Main(string[] args)
        {
            string EntradaNome, EntradaIdade;

            Console.Write("Digite o seu nome: ");
            EntradaNome = Console.ReadLine();
            Console.Write("Digite a sua idade: ");
            EntradaIdade = Console.ReadLine();

            int IdadeNumero = int.Parse(EntradaIdade);
            int AnoNascimento =  DateTime.Now.Year - IdadeNumero;

            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Seu nome é: " + EntradaNome);
            Console.WriteLine("O Ano aproximado de seu nascimento é: " + AnoNascimento + ", e sua idade é de: " + EntradaIdade);

            Console.ReadKey();
        }
    }
}
