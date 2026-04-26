using System;
using System.IO;

namespace lb26.Utils
{
    public static class FileHelper
    {
        public static string GetTemplatesPath()
        {
            return Path.GetFullPath(
       Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Templates")
   );
        }
        public static string GetTemplatePath(string fileName)
        {
            return Path.Combine(GetTemplatesPath(), fileName);
        }
        public static bool FileExists(string path)
        {
            return File.Exists(path);
        }
    }
}