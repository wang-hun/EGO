using Newtonsoft.Json.Linq;

namespace EGO
{
    public class Configuration
    {
        static Configuration instance;
        public static Configuration Instance //单例
        {
            get
            {
                if (instance == null) instance = new Configuration();
                return instance;
            }
        }
        public bool ReadUser()
        {
            var userPath = Path.Combine(Settings.AppSavePath, "Master.data");
            if (!File.Exists(userPath))
            {
                return false;
            }
            ///todo  文件存在，读取用户信息
            var userData = JObject.Parse(File.ReadAllText(userPath))["user"]?.ToObject<UserData>();
            if (userData != null)
            {
                //RunTimeData.SetUser(userData);
                return true;
            }
            else
            {
                return false;
            }


        }

    }
    public static class Settings
    {
        static string SavePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        public static string AppSavePath = Path.Combine(SavePath, "White Lotus", "E.G.O.");
    }
}