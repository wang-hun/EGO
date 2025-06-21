using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Model
{
    public class UserData
    {
        public string Name { get; set; }

        public UserData(string name) 
        { 
           Name = name;
        }
    }
}
