using Dom5Logic.Odm.Persistence.Models;

namespace Dom5Logic.Odm.Persistence.Context;

public class ContextData : IContext
{
    private string[]? gameDataFiles;
    private readonly string baseDir;

    public ContextData(string baseDir)
    {
        if (string.IsNullOrWhiteSpace(baseDir))
        {
            throw new ArgumentException($"'{nameof(baseDir)}' cannot be null or whitespace.", nameof(baseDir));
        }

        this.baseDir = baseDir;
        
        BuildGameData();
    }

    public string GetFileByType<T>()
    {
        string typeName = typeof(T).Name;

        var file = gameDataFiles?
        .Select(file => new FileInfo(file))
        .FirstOrDefault(file => file.Name.ToLower().Equals($"{typeName.ToLower()}.csv")).FullName;
    
        // Console.WriteLine($"file {file}");
        
        if (file is null)
        {
            throw new Exception();    
        }

        return file;
    }

    public bool BuildGameData()
    {
        gameDataFiles = Directory.GetFiles(baseDir, "*.csv", SearchOption.AllDirectories);

        return gameDataFiles.Length > 0;
    }
}