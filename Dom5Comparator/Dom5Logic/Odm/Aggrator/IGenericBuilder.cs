using Dom5Logic.Odm.Aggrator.Dto;
using Dom5Logic.Odm.Persistence.Models;

namespace Dom5Logic.Odm.Aggrator;

public interface IGenericBuilder<Tout>
{
    Tout Build(int id);
}