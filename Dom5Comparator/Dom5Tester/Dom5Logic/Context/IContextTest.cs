using System;
using System.Collections.Generic;
using System.Linq;
using Dom5Logic.Odm.Persistence.Context;
using Dom5Logic.Odm.Persistence.Models;
using Xunit;

namespace Dom5Tester.Dom5Logic.Context;

public class Dummy {

}

public class IContextTest {
    public IContextTest()
    {
        
    }

    [Fact]
    public void ReadGameDataFile() {
        
        IContext context = new ContextData("/workspaces/dom5inspector/Dom5Comparator/Dom5Logic/Odm/Persistence/gamedata");

        bool dataReaded = context.BuildGameData();

        Assert.True(dataReaded);
    }

    [Theory]
    [InlineData(" ")]
    [InlineData(null)]
    [InlineData("")]
    public void ThrowExceptionWhenPathIsNullOrEmptyOrSpace(string basePath) {
        Assert.Throws<ArgumentException>(() => new ContextData(basePath));    
    }

    [Fact]
    public void RightFileByGivenType() {
        IContext context = new ContextData("/workspaces/dom5inspector/Dom5Comparator/Dom5Logic/Odm/Persistence/gamedata");

        string v = context.GetFileByType<BaseU>();

        Assert.True(v.EndsWith($"{typeof(BaseU).Name}.csv"));
    }

    [Fact]
    public void ThrowExceptionIfTypeNotRecognised() {
        IContext context = new ContextData("/workspaces/dom5inspector/Dom5Comparator/Dom5Logic/Odm/Persistence/gamedata");

        Assert.Throws<Exception>(() => context.GetFileByType<Dummy>());
    }
}