using AutoMapper;
using Dom5Logic.Odm.Aggrator.Dto;
using Dom5Logic.Odm.Persistence.Models;

namespace Dom5Logic.Odm.Mapper;

public class BaseUProfile : Profile
{
    public BaseUProfile()
    {
        CreateMap<BaseUAggregate, BaseU>();
        CreateMap<BaseU, BaseUAggregate>();
    }
}

public class WeaponProfile : Profile
{
    public WeaponProfile()
    {
        CreateMap<WeaponsAggregate, Weapons>();
        CreateMap<Weapons, WeaponsAggregate>();
    }
}