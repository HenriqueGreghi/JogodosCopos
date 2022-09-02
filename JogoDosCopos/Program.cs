using System;

namespace JogoDosCopos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com a quantidade de movimentos :");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a posição da moeda (Copo A, B ou C: ");
            String copos = Console.ReadLine();

            Jogadas jogada = new Jogadas(n,copos);
            jogada.Jogada();
            
        }
    }
}
