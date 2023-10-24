using RestService.Package.Models;

namespace RestService.Package;

public interface IRestService
{
    public Task<JailConnectConfig> GetJailConnectConfig();
    public static IRestService New()
    {
        return new RestService();
    }
}
