using static System.Console;
using Colecoes.Helper;
using System.Collections.Generic;


int[] arrayNumeros = new int[10] { 100, 1, 4, 0, 8, 15, 19, 19, 4, 100 };

var soma = arrayNumeros.Sum();
var arrayUnico = arrayNumeros.Distinct().ToArray();

// var minimo = arrayNumeros.Min();
// var maximo = arrayNumeros.Max();
// var medio = arrayNumeros.Average();

// WriteLine($"Mínimo: {minimo}");
// WriteLine($"Máximo: {maximo}");
// WriteLine($"Médio: {medio}");
WriteLine($"Soma: {soma}");
WriteLine("Array original: " + string.Join(", ", arrayNumeros));
WriteLine("Array distintos: " + string.Join(", ", arrayUnico));

// var numerosParesQuery =
//         from num in arrayNumeros
//         where num % 2 == 0
//         orderby num
//         select num;

// var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

// WriteLine("Numeros pares Query: " + string.Join(", ", numerosParesQuery));
// WriteLine("Numeros pares Método: " + string.Join(", ", numerosParesMetodo));


// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("MG", "Minas Gerais");
// estados.Add("BA", "Bahia");

// foreach (KeyValuePair<string, string> item in estados)
// {
//     WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
// }

// string valorProcurado = "SC";

// if (estados.TryGetValue(valorProcurado, out string estadoEncontrado))
//     WriteLine($"Foi encontrado o valor: {estadoEncontrado}");
// else
//     WriteLine($"Chave: {valorProcurado} não existe no dicionário.");

// WriteLine($"Removendo o valor: {valorProcurado}");
// estados.Remove(valorProcurado);

// foreach (KeyValuePair<string, string> item in estados)
// {
//     WriteLine($"Chave: {item.Key} - Valor: {item.Value}");
// }



// Stack<string> pilhaLivros = new Stack<string>();
// pilhaLivros.Push(".NET");
// pilhaLivros.Push("DDD");
// pilhaLivros.Push("Código limpo");

// WriteLine($"Livros na pilha: {pilhaLivros.Count}");
// while (pilhaLivros.Count > 0)
// {
//     WriteLine($"Proximo livro para leitura: {pilhaLivros.Peek()}");
//     WriteLine($"{pilhaLivros.Pop()} retirado.");
// }
// WriteLine($"Livros na pilha: {pilhaLivros.Count}");



// Queue<string> fila = new Queue<string>();

// fila.Enqueue("Leonardo");
// fila.Enqueue("Eduardo");
// fila.Enqueue("André");

// WriteLine($"Pessoas na fila: {fila.Count}");
// while (fila.Count > 0)
// {
//     WriteLine($"Vez de: {fila.Peek()}");
//     WriteLine($"{fila.Dequeue()} atendido.");
// }

// WriteLine($"Pessoas na fila: {fila.Count}");

// OperacoesLista opLista = new OperacoesLista();
// List<string> estados = new List<string>() { "SP", "MG", "BA" };
// string[] estadosArray = new string[2] { "SC", "MT" };

// WriteLine($"Quantidade de elementos na lista: {estados.Count}");
// opLista.ImprimirListaStrings(estados);

// WriteLine("\nAdicionando elemento:");
// estados.Insert(1, "RJ");
// opLista.ImprimirListaStrings(estados);
// WriteLine("\nAdicionando elementos:");
// estados.AddRange(estadosArray);
// opLista.ImprimirListaStrings(estados);

// WriteLine("Removendo o elemento.");
// estados.Remove("MG");
// opLista.ImprimirListaStrings(estados);

// foreach (var item in estados)
// {
//     WriteLine(item);
// }



// OperacoesArray op = new OperacoesArray();

// int[] array = new int[5] { 6, 3, 9, 1, 8 };
// int[] arrayCopia = new int[10];

// string[] arrayString = op.ConverterParaArrayString(array);

//nt valorProcurado = 0;

// WriteLine($"A capacidade atual do array é de: {array.Length}");

// op.RedimensionarArray(ref array, array.Length * 2);

// WriteLine($"A nova capacidade do array é de: {array.Length}");

// int indice = op.ObterIndice(array, valorProcurado);

// if (indice > -1)
//     WriteLine("O indice do elemento {0} é: {1}", valorProcurado, indice);
// else
//     WriteLine("Valor não existente no array.");

// bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

// if (todosMaiorQue)
//     WriteLine("Todos os valores são maior que {0}.", valorProcurado);
// else
//     WriteLine("Nem todos os valores são maior que {0}.", valorProcurado);

// bool existe = op.Existe(array, valorProcurado);

// if (existe)
//     WriteLine("Encontrei o valor: {0}.", valorProcurado);
// else
//     WriteLine("Não encontrei o valor: {0}", valorProcurado);


// WriteLine("Array original:");
// op.ImprimirArrays(array);

// op.OrdenarBubbleSort(ref array);
// op.Ordenar(ref array);

// WriteLine("Array ordenado: ");
// op.ImprimirArrays(array);

// WriteLine("Array antes da cópia:");
// op.ImprimirArrays(arrayCopia);

// op.Copiar(ref array, ref arrayCopia);

// WriteLine("Array depois da cópia:");
// op.ImprimirArrays(arrayCopia);

// int[,] matriz = new int[4, 2]
// {
//     {8, 8},
//     {10, 20},
//     {50, 100},
//     {90, 200}
// };

// for (int i = 0; i < matriz.GetLength(0); i++)
// {
//     for (int j = 0; j < matriz.GetLength(1); j++)
//     {
//         Write($"{matriz[i, j]} ");
//     }
//     WriteLine();
// }

// int[] arrayInteiros = new int[3];
// arrayInteiros[0] = 10;
// arrayInteiros[1] = 20;
// arrayInteiros[2] = int.Parse("30");
// WriteLine("Percorrendo o array pelo for:");
// for (int i = 0; i < arrayInteiros.Length; i++)
// {
//     WriteLine(arrayInteiros[i]);
// }
// WriteLine("Percorrendo o array pelo foreach:");
// foreach (var item in arrayInteiros)
// {
//     WriteLine(item);
// }