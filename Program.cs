using System;

namespace parImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroParImpar, restoDivisao;
            string textoNumeroParImpar;
            bool numeroParImparValido;

            Console.Clear();
            Console.WriteLine("--- Número par ou impar");

            Console.Write("Digite um número: ");
            textoNumeroParImpar = Console.ReadLine();

            numeroParImparValido = Int32.TryParse(textoNumeroParImpar, out numeroParImpar);
            restoDivisao = numeroParImpar % 2;
            
            if (!numeroParImparValido)
            {
                Console.WriteLine("Valor inválido");
                Environment.Exit(-1);
            }
            else if (restoDivisao > 0)
            {
                Console.WriteLine($"{numeroParImpar} é impar");
            }
            else
            {
                Console.WriteLine($"{numeroParImpar} é par");
            }

        }
    }
}
