using RestService.Package.Models;

namespace RestService.Package;

internal class RestService : IRestService
{
    public async Task<JailConnectConfig> GetJailConnectConfig()
    {
        var githubApi = Refit.RestService.For<IGitHubApis>("https://nakullukan.github.io");
        return await githubApi.GetJailConnectConfig();
    }
}
