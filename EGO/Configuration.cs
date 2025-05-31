using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGO
{
    public class Configuration
    {
        static Configuration instance;
        public static Configuration Instance //单例
        {
            get 
            {
            if (instance == null)instance= new Configuration();
                return instance;
            }
        }
        bool ReadUser() 
        {
            var userPath = Path.Combine(Settings.AppSavePath,"Master.xml");
            if (!File.Exists(userPath)) 
            { 
                
            }
            return true;
        }
        
    }
    public static class Settings
    {
        static string SavePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        public static string AppSavePath = Path.Combine(SavePath, "White Lotus", "E.G.O.");
    }
}