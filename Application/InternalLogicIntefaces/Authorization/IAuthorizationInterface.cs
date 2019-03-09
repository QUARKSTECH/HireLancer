using DataEntities.Core;
using System.Threading.Tasks;

namespace InternalLogicIntefaces.Authorization
{
    public interface IAuthorizationInterface
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}
