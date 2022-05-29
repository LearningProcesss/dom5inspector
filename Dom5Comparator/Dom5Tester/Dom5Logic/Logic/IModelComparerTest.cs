using Xunit;
using Moq;
using Dom5Logic.Logic;
using Dom5Logic.Odm.Aggrator.Dto;
using Dom5Logic.Odm.Aggrator;
using Dom5Logic.Odm.Persistence.Models;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Dom5Tester.Dom5Logic.Logic;

public class IModelComparerTest
{
    [Fact]
    public void GetDifferenceOfBasicProperties()
    {
        var builderStub = new Mock<IGenericBuilder<BaseUAggregate>>();

        builderStub.Setup(stub => stub.Build(It.Is<int>(p => p == 1)))
                .Returns(new BaseUAggregate
                {
                    id = 1,
                    name = "Standard",
                    basecost = 10020,
                    rcost = 10000,
                    hp = 10
                });

        builderStub.Setup(stub => stub.Build(It.Is<int>(p => p == 2)))
                .Returns(new BaseUAggregate
                {
                    id = 2,
                    name = "Lorian",
                    basecost = 10920,
                    rcost = 10000,
                    hp = 15
                });

        BaseUAggregate leftUnit = builderStub.Object.Build(1);

        BaseUAggregate rightUnit = builderStub.Object.Build(2);

        IModelComparer comparer = new ModelComparer();

        IEnumerable<Variance> expectedVariances = new List<Variance>()
        {
            new Variance { Name = "id", LeftValue = "1", RightValue = "2" },
            new Variance { Name = "name", LeftValue = "Standard", RightValue = "Lorian" },
            new Variance { Name = "basecost", LeftValue = "10020", RightValue = "10920" },
            new Variance { Name = "hp", LeftValue = "10", RightValue = "15" }
        };

        IEnumerable<Variance> variances = comparer.Compare<BaseUAggregate>(leftUnit, rightUnit);

        Assert.True(expectedVariances.SequenceEqual(variances));
    }

    [Fact]
    public void GetDifferenceOfBasicPropertiesSkippingProperties()
    {
        var builderStub = new Mock<IGenericBuilder<BaseUAggregate>>();

        builderStub.Setup(stub => stub.Build(It.Is<int>(p => p == 1)))
                .Returns(new BaseUAggregate
                {
                    basecost = 10020,
                    rcost = 10000,
                    hp = 10
                });

        builderStub.Setup(stub => stub.Build(It.Is<int>(p => p == 2)))
                .Returns(new BaseUAggregate
                {
                    basecost = 10920,
                    rcost = 10000,
                    hp = 15
                });

        BaseUAggregate leftUnit = builderStub.Object.Build(1);

        BaseUAggregate rightUnit = builderStub.Object.Build(2);

        IModelComparer comparer = new ModelComparer();

        IEnumerable<Variance> expectedVariances = new List<Variance>()
        {
            new Variance { Name = "basecost", LeftValue = "10020", RightValue = "10920" },
            new Variance { Name = "hp", LeftValue = "10", RightValue = "15" }
        };

        IEnumerable<Variance> variances = comparer.Compare<BaseUAggregate>(leftUnit, rightUnit, "id", "name");

        Assert.True(expectedVariances.SequenceEqual(variances));
    }
}