using System;
using System.Collections.Generic;

namespace Tests.lib;

public static class settings
{
    public static string OAUTH_Google_ClientId = Get("googleOAUTH_YoutubePlaylist_ClientID");
    public static string OAUTH_Google_ClientSecret = Get("googleOAUTH_YoutubePlaylist_ClientSecret");
    
    private static string Get(string key)
    {
        string userProfileFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

        string settingsFilePath = System.IO.Path.Combine(userProfileFolderPath, "settings.json");
        string settingsJsonText = System.IO.File.ReadAllText(settingsFilePath);
        var settingsModel = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string,object>>(json: settingsJsonText);

        return Convert.ToString(settingsModel[key]);
    }
}