using DemoLib.Helpers;
using DemoLib.Models;
using DemoLib.Repositories;

namespace DemoLib.Services
{
    public class AuthService
    {
        private readonly UserRepository repository;

        public AuthService()
        {
            repository =
                new UserRepository();
        }

        public bool Login(
            string login,
            string password)
        {
            User user =
                repository.GetByCredentials(
                    login,
                    password);

            if (user == null)
            {
                return false;
            }

            SessionManager.CurrentUser =
                user;

            return true;
        }
    }
}