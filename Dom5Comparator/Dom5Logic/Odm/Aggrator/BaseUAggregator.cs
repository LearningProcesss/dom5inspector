using Dom5Logic.Odm.Aggrator.Dto;
using Dom5Logic.Odm.Persistence.Models;
using Dom5Logic.Odm.Persistence.Repository;

namespace Dom5Logic.Odm.Aggrator;

public class BaseUAggregator : IBaseUAggregator
{
    public BaseUAggregate Aggregate(int id)
    {
        throw new NotImplementedException();
    }
}

public class BaseUAggre : IGenericBaseUAggregator
{
    private readonly IGenericRepository<BaseU> repository;

    public BaseUAggre(IGenericRepository<BaseU> repository)
    {
        this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }
    public BaseUAggregate Aggregate(int id)
    {
        var model = repository.GetById(id);

        if (model is null)
        {
            throw new Exception();
        }

        model.GetType().GetProperties()
             .Where(prop => prop.Name.Contains("wpn"))
             .Select(prop => new { name = prop.Name, value = prop.GetValue(model) });
        
        return new BaseUAggregate
        {
            
        };
    }
}