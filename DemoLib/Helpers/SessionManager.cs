using DemoLib.Models;

namespace DemoLib.Helpers
{
    public static class SessionManager
    {
        public static User CurrentUser
        {
            get;
            set;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}