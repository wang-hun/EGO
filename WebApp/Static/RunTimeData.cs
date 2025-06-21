using WebApp.Model;

namespace WebApp.Static
{
    public static class RunTimeData
    {
        private static readonly AsyncLocal<UserData> _userData= new AsyncLocal<UserData>();
        public static UserData userData => _userData.Value;

        private static bool init=false;

        public static void SetUser(UserData user) 
        {
            if (!init) 
            { 
                _userData.Value= user;
                init=true;
            }
        }

    }
}
