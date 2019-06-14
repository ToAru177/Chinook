using System;
using System.IO;

namespace Chinook.Data
{
    public class DbContextFactory
    {
        private const string FilePath = @"d:\Iot\C#\20190610\EF.log";

        private static void Write(string log)
        {
            string contents;
            if (File.Exists(FilePath))
                contents = File.ReadAllText(FilePath);

            else
                contents = "";

            string time = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            string formattedLog = $"[{time}]\r\n{log}\r\n------------------------\r\n\r\n";

            contents = formattedLog + contents; // 성능 구림

            File.WriteAllText(FilePath, contents);

                  
        }

        public static ChinookEntities Create()
        {
            ChinookEntities context = new ChinookEntities();

            context.Database.Log = Write;

            return context;
        }
    }
}
