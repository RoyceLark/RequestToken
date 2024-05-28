using System.Net.Http;
using System.Threading.Tasks;
using IdentityModel.Client;

namespace system;

/// <summary>
/// Provides extensions for the <see cref="TokenResponse"/>.
/// </summary>
public class RequestToken
{
    /// <summary>
    ///Request token from internal services using duende identity server
    /// </summary>   
    /// <returns>
    /// The updated <paramref name="TokenResponse"/>.
    /// </returns>
    public async Task<TokenResponse> GetToken(string hostEndpoint, string clientId, string clientSecret, string scope)
    {
        HttpClient client = new HttpClient();
        TokenResponse tokenResponse = await client.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
        {
            Address = hostEndpoint,
            ClientId = clientId,
            ClientSecret = clientSecret,
            Scope = scope
        });
        if (tokenResponse.IsError)
        {
            return new TokenResponse();
        }

        return tokenResponse;
    }

}
