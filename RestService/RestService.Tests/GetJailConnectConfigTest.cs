using RestService.Package;

namespace RestService.Tests;

public class GetJailConnectConfigTest
{
    [Fact]
    public async Task GetConfig()
    {
        var api = IRestService.New();
        var result = await api.GetJailConnectConfig();
        Assert.NotNull(result);
    }
}
