using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace LabCSharp2
{
    internal class SQLManager
    {
        private static readonly string connectionString = "Data Source=blockedwords.db";

        public static void InitDatabase()
        {
            using(var connection = new SqliteConnection(connectionString))
            {
                // Open the connection, set the query and run it.
                connection.Open();
                string createTable = @"
                    CREATE TABLE IF NOT EXISTS BlockedWords (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Word TEXT UNIQUE NOT NULL)";
                using (var command = new SqliteCommand(createTable, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void AddBlockedWord(string word)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                // Prevent SQL Injection
                string insertCommand = "INSERT OR IGNORE INTO BlockedWords (Word) VALUES (@word)";

                // Create the command then run it
                using (var command = new SqliteCommand(insertCommand, connection))
                {
                    command.Parameters.AddWithValue("@word", word);
                    command.ExecuteNonQuery();
                }
            }
        }
        public static List<string> GetBlockedWords()
        {
            var words = new List<string>();
            using (var connection = new SqliteConnection(connectionString))
            {
                // Open connection
                connection.Open();
                // Select all words, but not their ids
                string selectCommand = "SELECT Word FROM BlockedWords";

                // Create the command
                using (var command = new SqliteCommand(selectCommand, connection))
                // Execute the command to 
                using (var reader = command.ExecuteReader())
                {
                    // While there are rows to read
                    while (reader.Read())
                    {
                        // Get the first string from the row.
                        words.Add(reader.GetString(0));
                    }
                }
            }
            return words;
        }

        public static void deleteBlockedWord(string word)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM BlockedWords WHERE Word=@word";
                using (var command = new SqliteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@word",word);
                }
            }
        }
    }
}
