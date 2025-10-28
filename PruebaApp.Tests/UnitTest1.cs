using Xunit;
using DotnetTestApp;

namespace DotnetTestApp.Tests;

public class UnitTest1
{
    [Fact]
    public void TestAdd()
    {
        Assert.Equal(5, Program.Add(2, 3));
    }
}

