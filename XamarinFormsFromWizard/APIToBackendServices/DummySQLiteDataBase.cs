using System;
using System.Data.SQLite;
using System.IO;

namespace APIToBackendServices
{
    public class DummySQLiteDataBase
    {
        public DummySQLiteDataBase(
            string dbURL)
        {
            creatDB(
                dbURL: dbURL);
        }

        bool creatDB(
            string dbURL)
        {
            if (File.Exists(dbURL)) return true;
            SQLiteConnection.CreateFile(dbURL);

            var dbConnection = new SQLiteConnection($"Data Source={dbURL};Version=3;");
            dbConnection.Open();

            string sql = "create table highscores (name varchar(20), score int)";

            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
            command.ExecuteNonQuery();

            sql = "insert into highscores (name, score) values ('Me', 9001)";

            command = new SQLiteCommand(sql, dbConnection);
            command.ExecuteNonQuery();

            dbConnection.Close();
            return File.Exists(dbURL);
        }   
    }
}
