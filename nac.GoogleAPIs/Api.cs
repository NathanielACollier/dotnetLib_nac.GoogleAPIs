namespace nac.GoogleAPIs;

public class Api
{

    private nac.http.HttpClient http;
    
    public services.UserService User { get; private set; }

    public Api(string token)
    {
        this.setupWithToken(token);
    }

    private void setupWithToken(string token)
    {
        this.http = new nac.http.HttpClient(
            baseUrl: lib.settings.GoogleAPIBaseUrl,
            args: new nac.http.model.HttpClientConfigurationOptions{
                useWindowsAuth = false,
                useBearerTokenAuthentication = true,
                bearerToken = token
            });
        
        this.User = new services.UserService(this.http);
    }
    
    
}