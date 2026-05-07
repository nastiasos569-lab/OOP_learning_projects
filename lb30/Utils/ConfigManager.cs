using lb30.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lb30.Utils
{
    public static class ConfigManager
    {
        private static string path = "config.txt";

        public static void Save(AppSettings s)
        {
            File.WriteAllLines(path, new string[]
            {
            s.Host,
            s.User,
            s.Password,
            s.Port.ToString(),
            s.DefaultPath
            });
        }

        public static AppSettings Load()
        {
            try
            {
                if (!File.Exists(path))
                    return new AppSettings();

                var lines = File.ReadAllLines(path);

                if (lines.Length < 5)
                    return new AppSettings();

                return new AppSettings
                {
                    Host = lines[0],
                    User = lines[1],
                    Password = lines[2],
                    Port = int.Parse(lines[3]),
                    DefaultPath = lines[4]
                };
            }
            catch
            {
                return new AppSettings();
            }
        }
    }
}
