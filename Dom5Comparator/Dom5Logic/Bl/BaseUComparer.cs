
namespace Dom5Logic.Bl;

public class BaseUComparer : IBaseUComparer
{
    private readonly IBaseUService baseUService;

    public BaseUComparer(IBaseUService baseUService)
    {
        this.baseUService = baseUService ?? throw new ArgumentNullException(nameof(baseUService));
    }

    public void Compare(int leftId, int rightId)
    {
        var leftUnit = baseUService.GetById(leftId);

        var rightUnit = baseUService.GetById(rightId);

        if (leftUnit is null || rightUnit is null)
        {
            throw new Exception();
        }

        foreach (var leftProp in typeof(BaseUDto).GetProperties())
        {
            
        }
    }
}