using ListaMovil.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ListaMovil.Data
{
    public class DatabaseContext
    {
        private readonly SQLiteAsyncConnection Connection;
        public DatabaseContext(string dbPath)
        {
            Connection= new SQLiteAsyncConnection(dbPath);
            Connection.CreateTableAsync<ToDoItem>().Wait();
        }

        public async Task<int> InsertItemAsyn(ToDoItem item)
        {
            return await Connection.InsertAsync(item);
        }

        public async Task<List<ToDoItem>> GetItemsAsync()
        {
            return await Connection.Table<ToDoItem>().ToListAsync();
        }

        public async Task<int> DeleteItemAsync(ToDoItem item)
        {
            return await Connection.DeleteAsync(item);
        }
    }
}
