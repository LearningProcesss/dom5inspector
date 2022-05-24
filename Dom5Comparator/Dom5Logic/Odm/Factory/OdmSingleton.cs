using Dom5Logic.Odm.Persistence.Context;

namespace Dom5Logic.Odm.Factory;

public class OdmSingleton : IOdmSingleton
{
    private static IOdmSingleton instance;
    private OdmSingleton()
    {
        
    }

    public IOdmSingleton Create()
    {
        if(OdmSingleton.instance == null) {

            IContext context = new ContextData("");

            context.BuildGameData();

            

            OdmSingleton.instance = new OdmSingleton();
        }

        return OdmSingleton.instance;
    }
}