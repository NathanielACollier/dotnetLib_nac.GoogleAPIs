using System.Threading.Tasks;

namespace Tests.lib;

public static class shared
{
    
    public static nac.GoogleAPIs.Api google { get; private set; }


    public static async Task setup()
    {
        var oauthSettings = nac.OAUTHLogin.repositories.VendorOAUTHSettings.GetGoogleOAUTHSettings();
        oauthSettings.ClientId = lib.settings.OAUTH_Google_ClientId;
        oauthSettings.ClientSecret = lib.settings.OAUTH_Google_ClientSecret;
        oauthSettings.Scope = "email";
        
        // get a token via browser
        string token = await nac.OAUTHLogin.OAUTH.GetAuthTokenViaDefaultBrowser(oauthSettings);

        google = new nac.GoogleAPIs.Api(token);
    }
}