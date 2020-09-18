using System.Threading.Tasks;
using TIMDESKTOPUSERINTERFACE.Models;

namespace TIMDESKTOPUSERINTERFACE.Helper
{
    public interface IAPIHalper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}