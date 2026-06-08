using System.Reflection;
using Xunit;

namespace DnsClient.Tests;

public class ThreadSafeBitArrayTestMethodCount
{
    [Fact]
    public void TestCountMethods()
    {
        var flags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly;
        var methods = typeof(ThreadSafeBitArrayTest).GetMethods(flags);
        Assert.Equal(11, methods.Length);
    }
}
