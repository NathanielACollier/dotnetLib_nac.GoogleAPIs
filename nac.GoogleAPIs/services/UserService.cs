using System.Threading.Tasks;

namespace nac.GoogleAPIs.services;

public class UserService
{
    private nac.http.HttpClient http;

    public UserService(nac.http.HttpClient http)
    {
        this.http = http;
    }



    public async Task<object> GetCurrentUser()
    {
        var response = await http.GetJSONAsync<System.Text.Json.Nodes.JsonNode>("oauth2/v1/userinfo");
        
        return response;
    }
    
    
}