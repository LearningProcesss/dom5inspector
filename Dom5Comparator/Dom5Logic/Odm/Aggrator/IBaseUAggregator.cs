using Dom5Logic.Odm.Aggrator.Dto;
using Dom5Logic.Odm.Persistence.Models;

namespace Dom5Logic.Odm.Aggrator;

public interface IBaseUAggregator
{
    BaseUAggregate Aggregate(int id);
}

public interface IGenericAggregator<Tout>
{
    Tout Aggregate(int id);
}

public interface IGenericBaseUAggregator : IGenericAggregator<BaseUAggregate>
{

}