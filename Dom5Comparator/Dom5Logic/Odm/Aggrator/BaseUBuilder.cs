using Dom5Logic.Odm.Aggrator.Dto;
using Dom5Logic.Odm.Mapper;
using Dom5Logic.Odm.Persistence.Models;
using Dom5Logic.Odm.Persistence.Repository;
using System;

namespace Dom5Logic.Odm.Aggrator;
public class BaseUBuilder : IGenericBuilder<BaseUAggregate>
{
    private readonly IMapping mapping;
    private readonly IGenericRepository<BaseU> repository;
    private readonly IGenericBuilder<WeaponsAggregate> weaponBuilder;

    public BaseUBuilder(IMapping mapping, IGenericRepository<BaseU> repository, IGenericBuilder<WeaponsAggregate> weaponBuilder)
    {
        this.mapping = mapping ?? throw new ArgumentNullException(nameof(mapping));
        this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
        this.weaponBuilder = weaponBuilder ?? throw new ArgumentNullException(nameof(weaponBuilder));
    }
    public BaseUAggregate Build(int id)
    {
        var model = repository.GetById(id);

        if (model is null)
        {
            throw new Exception();
        }

        BaseUAggregate aggregate = mapping.Mapper.Map<BaseUAggregate>(model);

        // Console.WriteLine($"model {ObjectDumper.Dump(model)}");

        aggregate.weapons = model.GetType().GetProperties()
             .Where(prop => prop.Name.Contains("wpn"))
             .Select(prop => prop.GetValue(model) != null
                             ?
                            //  mapping.Mapper.Map<WeaponsAggregate>(Weapons.WeaponNotUsedByUnit())
                             weaponBuilder.Build(int.Parse(prop.GetValue(model).ToString()))
                             :
                             mapping.Mapper.Map<WeaponsAggregate>(Weapons.WeaponNotUsedByUnit())
            );

        // Console.WriteLine($"aggregate {ObjectDumper.Dump(aggregate)}");
        
        return aggregate;
    }
}