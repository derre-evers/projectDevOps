using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;



namespace projectDevOps
{
    class searchHistory : DB
    {

        public string Name { get; set; }
        public string Choice { get; set; }
        

        public searchHistory()
        {
            if (!DBExists())
            {
                CreateDatabase();
            }
        }
        public searchHistory(string name, string choice)
        {
            Name = name;
            Choice = choice;
            if (!DBExists())
            {
                CreateDatabase();
            }
            insert(name, choice);
           

        }

        public static void insert(string Name, string Choice){
            
            
            using (var connection = DbConnectionHistory())
            {
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = @"INSERT INTO History (name, fromAbout) Values ('"+ Name + "', '" + Choice + "');";
                cmd.ExecuteNonQuery();
            }

        }
        public static List<string> get()
        {
            
            var history = new List<string>() ;
            using (var connection = DbConnectionHistory())
            {
                
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = @"SELECT name ||  '   -   '  || fromAbout as 'history' from History;";
                using (var reader = cmd.ExecuteReader())
                {
                   

                    while (reader.Read())
                    {
                         
                        history.Add(reader.GetString(0));                      
                    }
                }
            }
            return history;
        }
        
    }
}
