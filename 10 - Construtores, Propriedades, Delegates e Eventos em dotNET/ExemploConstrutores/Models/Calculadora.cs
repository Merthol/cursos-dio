using static System.Console;

namespace ExemploConstrutores.Models
{
    public class Calculadora
    {
        public delegate void DelegateCalculadora();

        public static event DelegateCalculadora EventoCalculadora;

        public static void Somar(int x, int y)
        {
            if (EventoCalculadora != null)
            {
                WriteLine($"Adição: {x + y}");
                EventoCalculadora();
            }
            else
            {
                WriteLine("Nenhum inscrito.");
            }
        }

        public static void Subtrair(int x, int y)
        {
            WriteLine($"Subtração: {x - y}");
        }
    }
}