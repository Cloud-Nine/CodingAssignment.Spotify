﻿using Newtonsoft.Json;

namespace CodingAssignment.Spotify.ApiClient.Models
{
    public class AuthenticationResponse
    {

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }
       
    }
}
