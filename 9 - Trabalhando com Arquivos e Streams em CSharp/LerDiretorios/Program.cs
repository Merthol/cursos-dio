var path = @"C:\Users\guilh\OneDrive\Documentos\Workspace\cursos-dio\9 - Trabalhando com Arquivos e Streams em CSharp\Directory_And_DirectoryInfo\globo";
//LerDiretorios(path);
LerArquivos(path);
Console.WriteLine("Digite ENTER para finalizar.");
Console.ReadLine();

static void LerDiretorios(string path)
{
    if (Directory.Exists(path))
    {
        var diretorios = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
        foreach (var dir in diretorios)
        {
            var dirInfo = new DirectoryInfo(dir);
            Console.WriteLine($"[Nome]: {dirInfo.Name}");
            Console.WriteLine($"[Raiz]: {dirInfo.Root}");
            if (dirInfo.Parent != null)
                Console.WriteLine($"[Pai]: {dirInfo.Parent.Name}");

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Digite ENTER para continuar.");
            Console.ReadLine();
        }
        return;
    }
    Console.WriteLine("Diretório não existe.");
}

static void LerArquivos(string path)
{
    var arquivos = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
    foreach (var arquivo in arquivos)
    {
        var fileInfo = new FileInfo(arquivo);
        Console.WriteLine($"[Nome]: {fileInfo.Name}");
        Console.WriteLine($"[Tamanho]: {fileInfo.Length}");
        Console.WriteLine($"[Ultimo acesso]: {fileInfo.LastAccessTime}");
        Console.WriteLine($"[Pasta]: {fileInfo.DirectoryName}");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Digite ENTER para continuar.");
        Console.ReadLine();
    }
}