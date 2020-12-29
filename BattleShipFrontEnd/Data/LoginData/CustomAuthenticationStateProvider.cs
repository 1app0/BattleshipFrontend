using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;
using BattleShipFrontEnd.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;

namespace BattleShipFrontEnd.Data.LoginData {
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider {
        private readonly IJSRuntime jsRuntime;
        private readonly IUserService userService;
        private NavigationManager navigationManager;

        private User cachedUser;

        public CustomAuthenticationStateProvider(IJSRuntime jsRuntime, IUserService userService, NavigationManager navigationManager) {
            this.jsRuntime = jsRuntime;
            this.userService = userService;
            this.navigationManager = navigationManager;
        }
        
        public override async Task<AuthenticationState> GetAuthenticationStateAsync() {
            var identity = new ClaimsIdentity();
            if (cachedUser == null) {
                string userAsJson = await jsRuntime.InvokeAsync<string>("sessionStorage.getItem", "currentUser");
                if (!string.IsNullOrEmpty(userAsJson)) {
                    cachedUser = JsonSerializer.Deserialize<User>(userAsJson);
                    identity = SetupClaimsForUser(cachedUser);
                }
            }
            else {
                identity = SetupClaimsForUser(cachedUser);
            }

            ClaimsPrincipal cachedClaimsPrincipal = new ClaimsPrincipal(identity);
            return await Task.FromResult(new AuthenticationState(cachedClaimsPrincipal));
        }

        public async Task ValidateLogin(string username, string password) {
            if (string.IsNullOrEmpty(username)) {
                throw new Exception("Enter username");
            }

            if (string.IsNullOrEmpty(password)) {
                throw new Exception("Enter password");
            }
            ClaimsIdentity identity = new ClaimsIdentity();
            try {
                User user = await userService.ValidateUserAsync(username, password);
                identity = SetupClaimsForUser(user);
                string serialisedData = JsonSerializer.Serialize(user);
                jsRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", serialisedData);
                cachedUser = user;
            }
            catch (Exception e) {
                throw e;
            }
            
            NotifyAuthenticationStateChanged(Task.FromResult(
                new AuthenticationState(new ClaimsPrincipal(identity))));
        }

        public void Logout() {
            cachedUser = null;
            var user = new ClaimsPrincipal(new ClaimsIdentity());
            jsRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", "");
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
            navigationManager.NavigateTo("/");
        }

        private ClaimsIdentity SetupClaimsForUser(User user) {
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, user.Username));
            claims.Add(new Claim("AccessType", user.AccessType));
            ClaimsIdentity identity = new ClaimsIdentity(claims, "apiauth_type");
            return identity;
        }
    }
}