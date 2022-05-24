using AutoMapper;

namespace Dom5Logic.Odm.Mapper;

public interface IMapping
{
    public IMapper Mapper { get; }
    IMapper Configure();
}

public class Mapping : IMapping
{
    private readonly IMapper mapper;
    public IMapper Mapper => mapper;

    public Mapping()
    {
        this.mapper = Configure();
    }

    public IMapper Configure()
    {
        var config = new MapperConfiguration(cfg => {
            cfg.AddProfile<BaseUProfile>();
            cfg.AddProfile<WeaponProfile>();
        });

       return config.CreateMapper();
    }
}