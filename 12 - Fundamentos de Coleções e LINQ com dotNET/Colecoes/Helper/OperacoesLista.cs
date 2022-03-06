using static System.Console;

namespace Colecoes.Helper
{
    public class OperacoesLista
    {
        public void ImprimirListaStrings(List<string> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                WriteLine($"Índice: {i}, Valor: {lista[i]}");
            }
        }

    }
}
