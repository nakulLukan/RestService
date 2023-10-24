using Refit;
using RestService.Package.Models;

namespace RestService.Package;

[Headers("Content-Type: application/json; charset=UTF-8")]
internal interface IGitHubApis
{
    [Get("/RestService/data/json/jc.json")]
    public Task<JailConnectConfig> GetJailConnectConfig();
}
