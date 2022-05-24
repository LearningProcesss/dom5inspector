using Dom5Logic.Odm.Aggrator.Dto;
using Dom5Logic.Odm.Mapper;
using Dom5Logic.Odm.Persistence.Models;
using Dom5Logic.Odm.Persistence.Repository;

namespace Dom5Logic.Odm.Aggrator;

public class WeaponBuilder : IGenericBuilder<WeaponsAggregate>
{
    private readonly IMapping mapping;
    private readonly IGenericRepository<Weapons> repository;

    public WeaponBuilder(IMapping mapping, IGenericRepository<Weapons> repository)
    {
        this.mapping = mapping ?? throw new ArgumentNullException(nameof(mapping));
        this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    public WeaponsAggregate Build(int id)
    {
        var model = repository.GetById(id);

        if (model is null)
        {
            throw new Exception();
        }

        // Console.WriteLine($"model {ObjectDumper.Dump(model)}");
        
        WeaponsAggregate aggregate = mapping.Mapper.Map<WeaponsAggregate>(model);

        return aggregate;
    }
}