CriarDiretoriosGlobo();
CriarArquivo();
var origem = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
var destino = Path.Combine(Environment.CurrentDirectory,
                            "globo",
                            "América do Sul",
                            "Argentina",
                            "argentina.txt");
//MoverArquivo(origem, destino);
CopiarArquivo(origem, destino);

static void CriarDiretoriosGlobo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "globo");

    if (!Directory.Exists(path))
    {
        var dirGlobo = Directory.CreateDirectory(path); // Retorna uma instância de DirectoryInfo

        var dirAmNorte = dirGlobo.CreateSubdirectory("América do Norte");
        var dirAmCentral = dirGlobo.CreateSubdirectory("América do Central");
        var dirAmSul = dirGlobo.CreateSubdirectory("América do Sul");

        dirAmNorte.CreateSubdirectory("USA");
        dirAmNorte.CreateSubdirectory("Mexico");
        dirAmNorte.CreateSubdirectory("Canada");

        dirAmCentral.CreateSubdirectory("Costa Rica");
        dirAmCentral.CreateSubdirectory("Panama");

        dirAmSul.CreateSubdirectory("Brasil");
        dirAmSul.CreateSubdirectory("Argentina");
        dirAmSul.CreateSubdirectory("Paraguai");
    }
}

static void CriarArquivo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
    if (!File.Exists(path))
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("População: 213MM");
        sw.WriteLine("IDH: 0,901");
        sw.WriteLine("Dados atualizados em 01/03/2022");
    }
}

static void MoverArquivo(string pathOrigen, string pathDestino)
{
    if (!File.Exists(pathOrigen))
    {
        Console.WriteLine("Arquivo de origen não existe");
        return;
    }
    if (File.Exists(pathDestino))
    {
        Console.WriteLine("Arquivo já existe na pasta de destino");
        return;
    }
    File.Move(pathOrigen, pathDestino);
}

static void CopiarArquivo(string pathOrigen, string pathDestino)
{
    if (!File.Exists(pathOrigen))
    {
        Console.WriteLine("Arquivo de origen não existe");
        return;
    }
    if (File.Exists(pathDestino))
    {
        Console.WriteLine("Arquivo já existe na pasta de destino");
        return;
    }
    File.Copy(pathOrigen, pathDestino);
}
