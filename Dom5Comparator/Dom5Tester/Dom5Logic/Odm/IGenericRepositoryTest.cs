using Xunit;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Dom5Logic.Odm.Persistence.Repository;
using Dom5Logic.Odm.Persistence.Models;
using Dom5Logic.Odm.Persistence.Context;

namespace Dom5Tester.Dom5Logic.Odm;

public class IGenericRepositoryTest
{
    public IGenericRepositoryTest()
    {

    }

    [Fact]
    public void GetAllBaseU()
    {
        var contextStub = new Mock<IContext>();

        contextStub.Setup(stub => stub.GetFileByType<BaseU>())
                   .Returns("/workspaces/dom5inspector/Dom5Comparator/Dom5Logic/Odm/Persistence/gamedata/BaseU.csv");

        IGenericRepository<BaseU> repository = new GenericCsvRepository<BaseU>(contextStub.Object);

        IEnumerable<BaseU> dataList = repository.Get();

        Assert.True(dataList.Count() > 0);
        contextStub.Verify(stub => stub.GetFileByType<BaseU>(), Times.Exactly(1));
    }

    [Fact]
    public void GetBaseUById()
    {
        var contextStub = new Mock<IContext>();

        contextStub.Setup(stub => stub.GetFileByType<BaseU>())
                   .Returns("/workspaces/dom5inspector/Dom5Comparator/Dom5Logic/Odm/Persistence/gamedata/BaseU.csv");

        IGenericRepository<BaseU> repository = new GenericCsvRepository<BaseU>(contextStub.Object);

        BaseU? data = repository.GetById(1);

        Assert.True(data != null);
        contextStub.Verify(stub => stub.GetFileByType<BaseU>(), Times.Exactly(1));
    }

    [Fact]
    public void GetAllWeapon()
    {
        var contextStub = new Mock<IContext>();

        contextStub.Setup(stub => stub.GetFileByType<Weapons>())
                   .Returns("/workspaces/dom5inspector/Dom5Comparator/Dom5Logic/Odm/Persistence/gamedata/weapons.csv");

        IGenericRepository<Weapons> repository = new GenericCsvRepository<Weapons>(contextStub.Object);

        IEnumerable<Weapons> dataList = repository.Get();

        Assert.True(dataList.Count() > 0);
        contextStub.Verify(stub => stub.GetFileByType<Weapons>(), Times.Exactly(1));
    }

    [Fact]
    public void GetWeaponById()
    {
        var contextStub = new Mock<IContext>();

        contextStub.Setup(stub => stub.GetFileByType<Weapons>())
                   .Returns("/workspaces/dom5inspector/Dom5Comparator/Dom5Logic/Odm/Persistence/gamedata/weapons.csv");

        IGenericRepository<Weapons> repository = new GenericCsvRepository<Weapons>(contextStub.Object);

        Weapons? data = repository.GetById(1);

        Assert.True(data != null);
        contextStub.Verify(stub => stub.GetFileByType<Weapons>(), Times.Exactly(1));
    }
}