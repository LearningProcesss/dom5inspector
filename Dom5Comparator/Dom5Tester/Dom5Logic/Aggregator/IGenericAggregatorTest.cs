using Xunit;
using Moq;
using Dom5Logic.Odm.Aggrator;
using System.Collections.Generic;
using Dom5Logic.Odm.Persistence.Models;
using Dom5Logic.Odm.Persistence.Repository;
using Dom5Logic.Odm.Aggrator.Dto;
using Dom5Logic.Odm.Mapper;
using ObjectDumping;
using System;
using System.Linq;
using FluentAssertions;

namespace Dom5Tester.Dom5Logic.Aggregator;

public class IGenericAggregatorTest
{
    public IEnumerable<WeaponsAggregate> WeaponsAggregateFixture(int take, int total)
    {
        List<WeaponsAggregate> result = new List<WeaponsAggregate>();

        for (int i = 1; i <= total; i++)
        {
            result.Add(new WeaponsAggregate
            {
                id = i <= take ? i : 0
            });
        }

        return result;
    }

    [Fact]
    public void ThrowsWhenParameterIsNull() {
        Assert.Throws<ArgumentNullException>(() => new BaseUBuilder(null, null, null));
    }

    [Fact]
    public void BaseUAggregationWithOneWeapon()
    {
        IMapping mapping = new Mapping();

        var baseURepoStub = new Mock<IGenericRepository<BaseU>>();

        baseURepoStub.Setup(stub => stub.GetById(It.Is<int>(p => p == 1))).Returns(new BaseU
        {
            id = 1,
            name = "dummy",
            wpn1 = 1
        });

        var weaponBuilderStub = new Mock<IGenericBuilder<WeaponsAggregate>>();

        weaponBuilderStub.Setup(stub => stub.Build(It.Is<int>(p => p == 1)))
        .Returns(new WeaponsAggregate { id = 1 }).Verifiable();

        IGenericBuilder<BaseUAggregate> builder = new BaseUBuilder(mapping, baseURepoStub.Object, weaponBuilderStub.Object);

        BaseUAggregate baseUAggregateExpected = new BaseUAggregate
        {
            id = 1,
            name = "dummy",
            weapons = WeaponsAggregateFixture(1, 7)
        };
        
        BaseUAggregate baseUAggregate = builder.Build(1);

        // Console.WriteLine(ObjectDumper.Dump(baseUAggregate));

        baseURepoStub.Verify(stub => stub.GetById(It.Is<int>(p => p == 1)), Times.Exactly(1));

        weaponBuilderStub.Verify(stub => stub.Build(It.Is<int>(p => p == 1)), Times.Once());

        baseUAggregate.Should().BeEquivalentTo(baseUAggregateExpected);
    }

    [Fact]
    public void BaseUAggregationWithMultipleWeapon()
    {
        IMapping mapping = new Mapping();

        var weaponStub = new Mock<IGenericRepository<Weapons>>();
        var baseURepoStub = new Mock<IGenericRepository<BaseU>>();

        baseURepoStub.Setup(stub => stub.GetById(It.IsAny<int>())).Returns(new BaseU
        {
            id = 1,
            name = "dummy",
            wpn1 = 1,
            wpn2 = 2,
            wpn3 = 3,
            wpn4 = 4,
            wpn5 = 5,
            wpn6 = 6,
            wpn7 = 7
        });

        var weaponBuilderStub = new Mock<IGenericBuilder<WeaponsAggregate>>();

        weaponBuilderStub.Setup(stub => stub.Build(It.Is<int>(p => p == 1)))
        .Returns(new WeaponsAggregate { id = 1 });

        weaponBuilderStub.Setup(stub => stub.Build(It.Is<int>(p => p == 2)))
        .Returns(new WeaponsAggregate { id = 2 });

        weaponBuilderStub.Setup(stub => stub.Build(It.Is<int>(p => p == 3)))
        .Returns(new WeaponsAggregate { id = 3 });

        weaponBuilderStub.Setup(stub => stub.Build(It.Is<int>(p => p == 4)))
        .Returns(new WeaponsAggregate { id = 4 });

        weaponBuilderStub.Setup(stub => stub.Build(It.Is<int>(p => p == 5)))
        .Returns(new WeaponsAggregate { id = 5 });

        weaponBuilderStub.Setup(stub => stub.Build(It.Is<int>(p => p == 6)))
        .Returns(new WeaponsAggregate { id = 6 });

        weaponBuilderStub.Setup(stub => stub.Build(It.Is<int>(p => p == 7)))
        .Returns(new WeaponsAggregate { id = 7 });

        IGenericBuilder<BaseUAggregate> builder = new BaseUBuilder(mapping, baseURepoStub.Object, weaponBuilderStub.Object);

        BaseUAggregate baseUAggregateExpected = new BaseUAggregate
        {
            id = 1,
            name = "dummy",
            weapons = WeaponsAggregateFixture(7, 7)
        };

        BaseUAggregate baseUAggregate = builder.Build(1);

        // Console.WriteLine(ObjectDumper.Dump(baseUAggregate));

        baseURepoStub.Verify(stub => stub.GetById(It.Is<int>(p => p == 1)), Times.Exactly(1));

        weaponBuilderStub.Verify(stub => stub.Build(It.IsAny<int>()), Times.Exactly(7));

        baseUAggregate.Should().BeEquivalentTo(baseUAggregateExpected);
    }

}