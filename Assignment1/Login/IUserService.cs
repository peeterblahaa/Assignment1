using LoginExample.Models;
using Models;

namespace FileData
{
    public interface IUserService
    {
        User ValidateUser(string userName, string Password);
    }
}