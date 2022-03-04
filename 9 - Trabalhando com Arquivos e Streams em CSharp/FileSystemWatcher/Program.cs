var path = @"C:\Users\guilh\OneDrive\Documentos\Workspace\cursos-dio\9 - Trabalhando com Arquivos e Streams em CSharp\Directory_And_DirectoryInfo\globo";
using var fsw = new FileSystemWatcher(path);
Console.WriteLine(path);
fsw.Created += OnCreated;
fsw.Renamed += OnRenamed;
fsw.Deleted += OnDeleted;

fsw.EnableRaisingEvents = true;
fsw.IncludeSubdirectories = true;

Console.WriteLine($"Monitorando eventos na pasta {path}");
Console.WriteLine("Pressione [enter] para finalizar....");
Console.ReadLine();

void OnCreated(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Foi criado o {e.GetType()} {e.Name}");
}

void OnDeleted(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Foi excluído o arquivo {e.Name}");
}

void OnRenamed(object sender, RenamedEventArgs e)
{
    Console.WriteLine($"O arquivo {e.OldName} foi renomeado para {e.Name}");
}