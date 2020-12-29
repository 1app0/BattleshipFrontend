using System.Threading.Tasks;
using BattleShipFrontEnd.Models;

namespace BattleShipFrontEnd.Data.LoginData {
    public interface IUserService {
        Task<User> ValidateUserAsync(string username, string password);
        Task RegisterUserAsync(string username, string password);
    }
}