using System.Reflection;
using Xunit;

namespace DnsClient.Tests;

public class DnsRecordFactoryTestMethodCount
{
    [Fact]
    public void TestCountMethods()
    {
        var flags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly;
        var methods = typeof(DnsRecordFactoryTest).GetMethods(flags);
        Assert.Equal(34, methods.Length);
    }
}
