using static System.Console;

WriteLine("Digite o nome do arquivo:");

var nome = ReadLine();

nome = LimparNome(nome);

var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");

CriarArquivo(path);

WriteLine("Digite ENTER para finalizar...");
ReadLine();

static void CriarArquivo(string path)
{
    try
    {
        using var sw = File.CreateText(path);
        {
            // Ao utilizar o using, vc força o encerramento, fazendo com que as linhas sejam escritas sem a necessidade do flush
            sw.WriteLine("Esta é a linha 1 do arquivo.");
            sw.WriteLine("Esta é a linha 2 do arquivo.");
            sw.WriteLine("Esta é a linha 3 do arquivo.");
            sw.WriteLine("Esta é a linha 4 do arquivo.");
            sw.WriteLine("Esta é a linha 5 do arquivo.");
            //    sw.Flush();
        }
    }
    catch
    {
        WriteLine("O nome do arquivo está inválido.");
    }
}

static string LimparNome(string nome)
{
    foreach (var @char in Path.GetInvalidFileNameChars())
    {
        nome = nome.Replace(@char, '_');
    }
    return nome;
}
