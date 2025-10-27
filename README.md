# SandVpn.cs
Mobile-API for [SandVPN](https://play.google.com/store/apps/details?id=com.sandvpn) an super optimized application that allows you to protect your privacy online 

## Example
```cs
using SandVpnApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new SandVpn();
            string proxies = await api.GetProxies();
            Console.WriteLine(proxies);
        }
    }
}
```
