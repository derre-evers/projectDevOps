using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

using System.IO;
using Microsoft.Data.Sqlite;

namespace projectDevOps
{
    class DB
    {
        public static SqliteConnection DbConnectionHistory()
        {

           return new SqliteConnection(@"DataSource=searchHistory.sqlite");
        }

        protected static bool DBExists()
        {
            return File.Exists(@"searchHistory.sqlite");
        }

        protected static void CreateDatabase()
        {
            using (var connection = DbConnectionHistory())
            {
                connection.Open();
                connection.Execute(
                    @"create table History( id integer PRIMARY KEY AUTOINCREMENT,
                    name varchar(45) NOT NULL,
                    fromAbout varchar(10) NOT NULL)"
                    );
            }
        }
    }
}
