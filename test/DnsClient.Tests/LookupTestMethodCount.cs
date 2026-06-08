using System.Reflection;
using Xunit;

namespace DnsClient.Tests;

public class LookupTestMethodCount
{
    [Fact]
    public void TestCountMethods()
    {
        var flags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly;
        var methods = typeof(LookupTest).GetMethods(flags);
        Assert.Equal(70, methods.Length);
    }
}
