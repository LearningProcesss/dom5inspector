using Xunit;
using Moq;
using Dom5Logic.Odm.Aggrator;
using System.Collections.Generic;
using Dom5Logic.Odm.Persistence.Models;
using Dom5Logic.Odm.Persistence.Repository;
using Dom5Logic.Odm.Aggrator.Dto;

namespace Dom5Tester.Dom5Logic.Aggregator;

public class IGenericAggregatorTest
{
    [Fact]
    public void ProduceRightAggregationForBaseU()
    {
        var baseURepoStub = new Mock<IGenericRepository<BaseU>>();

        baseURepoStub.Setup(stub => stub.GetById(1)).Returns(new BaseU { id = 1, name = "dummy", wpn1 = 1 });

        IGenericBaseUAggregator aggregator = new BaseUAggre(baseURepoStub.Object);

        BaseUAggregate baseUAggregate = aggregator.Aggregate(1);
    }

}