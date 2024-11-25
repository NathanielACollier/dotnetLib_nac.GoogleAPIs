using System.Threading.Tasks;

namespace nac.GoogleAPIs.services;

public class UserService
{
    private nac.http.HttpClient http;

    public UserService(nac.http.HttpClient http)
    {
        this.http = http;
    }



    public async Task<model.oauth2.UserInfo> GetCurrentUser()
    {
        var response = await http.GetJSONAsync<model.oauth2.UserInfo>("oauth2/v1/userinfo");
        
        return response;
    }
    
    
}