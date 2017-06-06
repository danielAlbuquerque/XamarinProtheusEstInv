using System;
using SQLite;
using SigaMATA270.Models;

namespace SigaMATA270.Util
{
    public class Database
    {
        protected SQLiteAsyncConnection database;

        public Database(string dbPath)
        {
			database = new SQLiteAsyncConnection(dbPath);
			database.CreateTableAsync<Param>().Wait();
        }
    }
}
