using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SQLITE_DEMO
{
    public static class Constants
    {
        private const string DatabaseFileNam = "SQLite.db3";
        
        //Como se va a comportar nuestro fichero cuando trabajemos con el
        public const SQLite.SQLiteOpenFlags Flags = 
            SQLite.SQLiteOpenFlags.ReadWrite |
            SQLite.SQLiteOpenFlags.Create |
            SQLite.SQLiteOpenFlags.SharedCache;

        //nos arroja la ruta de la base de datos
        public static string DatabasePath
        {
            get
            {
                var basePath =
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                return Path.Combine(basePath, DatabaseFileNam);
            }
        }
    }
}
