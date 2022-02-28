using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma;
            int x = int.Parse(Console.ReadLine());

            while (x != 0)
            {
                soma = 0;
                if ((x % 2) == 1)
                {
                    x++;
                }

                for (int y = 0; y < 5; y++)
                {
                    soma = soma + x;
                    x = x + 2;
                }

                Console.WriteLine(soma);
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}