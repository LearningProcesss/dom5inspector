using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using Dom5Logic.Odm.Persistence.Models;
using Dom5Logic.Odm.Persistence.Context;

namespace Dom5Logic.Odm.Persistence.Repository;

public class GenericCsvRepository<T> : IGenericRepository<T> where T : IModel
{
    private readonly IContext context;
    private CsvConfiguration csvConfiguration;
    public GenericCsvRepository(IContext context)
    {
        this.context = context ?? throw new ArgumentNullException(nameof(context));
        
        csvConfiguration = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = "\t"
        };
    }
    public IEnumerable<T> Get()
    {
        IEnumerable<T>? result = null;

        using (var reader = new StreamReader(context.GetFileByType<T>()))
        using (var csv = new CsvReader(reader, csvConfiguration))
        {
            result = csv.GetRecords<T>().ToList();
        }

        return result;
    }

    public T? GetById(int id)
    {
        var all = Get();

        return all.FirstOrDefault(item => item.id == id);
    }
}