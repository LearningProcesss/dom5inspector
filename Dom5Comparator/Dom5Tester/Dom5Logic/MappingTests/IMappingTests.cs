using Xunit;
using Moq;
using Dom5Logic.Odm.Mapper;

namespace Dom5Tester.Dom5Logic.MappingTests;

public class IMappingTests
{
    public IMappingTests()
    {

    }

    [Fact]
    public void CreateMapperConfiguration()
    {
        IMapping mapping = new Mapping();

        var mapper = mapping.Configure();

        Assert.NotNull(mapper);
    }
}