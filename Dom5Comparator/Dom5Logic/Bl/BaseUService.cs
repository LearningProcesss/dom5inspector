using Dom5Logic.Odm.Persistence.Models;
using Dom5Logic.Odm.Persistence.Repository;
using System.Linq;

namespace Dom5Logic.Bl;

public class BaseUService : IBaseUService
{
    private readonly IGenericRepository<BaseU> repository;
    private readonly IWeaponService weaponService;

    public BaseUService(IGenericRepository<BaseU> repository, IWeaponService weaponService)
    {
        this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
        this.weaponService = weaponService ?? throw new ArgumentNullException(nameof(weaponService));
    }

    public IEnumerable<BaseUDto> Get()
    {
        return repository.Get().Select(baseu => new BaseUDto
        {
            id = baseu.id,
            name = baseu.name,
            weapons = typeof(BaseU)
                      .GetProperties()
                      .Where(prop => prop.Name.StartsWith("wpn"))
                      .Select(prop => weaponService.GetById(prop.GetValue(baseu) == null ? -1 : int.Parse(prop.GetValue(baseu).ToString())))
        });
    }

    public BaseUDto? GetById(int id)
    {
        BaseU? baseU = repository.GetById(id);

        if (baseU is null) { return null; }
        
        return new BaseUDto
         {
             id = baseU.id,
             name = baseU.name,
             weapons = typeof(BaseU)
                      .GetProperties()
                      .Where(prop => prop.Name.StartsWith("wpn"))
                      .Select(prop => weaponService.GetById(prop.GetValue(baseU) == null ? -1 : int.Parse(prop.GetValue(baseU).ToString())))
         };
    }
}