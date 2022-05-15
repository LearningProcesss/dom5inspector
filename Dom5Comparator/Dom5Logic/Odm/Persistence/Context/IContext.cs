
namespace Dom5Logic.Odm.Persistence.Context;

public interface IContext {
    bool BuildGameData();
    string GetFileByType<T>();
}