using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BattleShipFrontEnd.Models;

namespace BattleShipFrontEnd.Data.LoginData {
    public class CloudUserAccess : IUserService {
        public async Task<User> ValidateUserAsync(string username, string password) {
            User newUser = new User {
                Username = username,
                Password = password,
                AccessType = "shrek"
            };
            HttpClient client = new HttpClient();
            string userSerialized = JsonSerializer.Serialize(newUser);
            StringContent content = new StringContent(
                userSerialized,
                Encoding.UTF8,
                "application/json"
            );
            HttpResponseMessage response = await client.PostAsync("http://localhost:8080/user/validateUser", content);
            int statusResponse = (int) response.StatusCode;
            if (statusResponse == 404) {
                throw new Exception("User not found");
            }
            if (statusResponse == 417) {
                throw new Exception("Wrong password");
            }
            return JsonSerializer.Deserialize<User>(await response.Content.ReadAsStringAsync());
        }

        public async Task RegisterUserAsync(string username, string password) {
            User newUser = new User {
                Username = username,
                Password = password,
                AccessType = "registeredUser"
            };
            HttpClient client = new HttpClient();
            string userSerialized = JsonSerializer.Serialize(newUser);
            StringContent content = new StringContent(
                userSerialized,
                Encoding.UTF8,
                "application/json"
                );
            HttpResponseMessage response = await client.PostAsync("http://localhost:8080/user/registerUser", content);
            int statusResponse = (int) response.StatusCode;
            if (statusResponse == 409) {
                throw new Exception("Username taken");
            }
        }
    }
}