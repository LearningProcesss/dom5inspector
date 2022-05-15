namespace Dom5Logic.Bl;

public interface IBaseUService {
    IEnumerable<BaseUDto> Get();

    BaseUDto? GetById(int id);
}