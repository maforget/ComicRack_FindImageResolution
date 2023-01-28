using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindImageResolutionNET.Setting
{
    public static class Config
    {
        public static Fields ReadUserFromFile()
        {
            return Utility.ReadFromFile<Fields>();
        }

        public static void WriteUserToFile(this Fields user)
        {
            Utility.WriteToFile(user);
        } 
    }
}
