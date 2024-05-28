## Disclaimer

<h4 align="center">:warning: This package/product is **not** affiliated with Duende Identity. :warning:</h4><br>

the package has been developed for a project of Royce Lark pvt,ltd which suits our use case. It includes a way to get the token from identity server hosted in diffrent host.


<h4 align="center">:warning: if you want help/support you must buy a support licence. to buy a licence contact web.html123@gmail.com:warning:</h4><br>
<h4 align="center"> If You Would Like To Buy Me A Coffee... You Can Donate Via Paypal: https://www.paypal.me/Mohang2 </h4><br>

## How to install

Install the package from [NuGet](https://www.nuget.org/) or from the `Package Manager Console` :
```powershell
PM> Install-Package Identity.RequestToken
```


## How it works 



var client = new HttpClient();
var disco = await client.GetDiscoveryDocumentAsync("idetity APi endpoint");
if (disco.IsError)
{
    Console.WriteLine(disco.Error);
    return;
}
#region creds
string clientSecret = "clietSecret";
string clientId = "Client Id";
string scope = "scope";
#endregion
if (!string.IsNullOrEmpty(disco.TokenEndpoint))
{
    var tokenResponse = new RequestToken.RequestToken().GetToken(disco.TokenEndpoint, clientId, clientSecret, scope).Result;

    if (tokenResponse.IsError)
    {
        Console.WriteLine(tokenResponse.Error);
        return;
    }

}



## Thanks

Royce Lark would like to thank all the people that supports and contributes to the project and helped to improve the library. 

<h4 align="center"> If You Would Like To Buy Me A Coffee... You Can Donate Via Paypal: https://www.paypal.me/Mohang2 </h4><br>


