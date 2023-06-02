using System;
using System.Linq;

namespace ConsoleApplication5
{
    
    internal class Program
    {

        public static void Main(string[] args)
        {
            Console.Write("Quantos valores você vai adicionar: ");
            var size = int.Parse(Console.ReadLine());
            
            var array = new int[size];
            
            for (var i = 1; i <= size; i++)
            {
                Console.Write("Escreva o {0} número: ", i);
                array[i - 1] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Soma de todos os elementos é {0}", array.Sum());
            Console.WriteLine("Média de todos os elementos é {0}", array.Sum() / array.Length);
            Console.WriteLine("O valor mais alto da array é {0}", array.Max());
            Console.WriteLine("O valor mais baixo da array é {0}", array.Min());
        }
    }
}