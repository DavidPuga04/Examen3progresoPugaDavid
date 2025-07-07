using Examen3progresoPugaDavid.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen3progresoPugaDavid.Services
{
    class DatabaseService
    {
        private readonly SQLiteAsyncConnection _db;

        public DatabaseService(string dbPath)
        {
            _db = new SQLiteAsyncConnection(dbPath);
            _db.CreateTableAsync<Producto>().Wait();
        }

        public Task<int> AddProductoAsync(Producto producto)
        {
            return _db.InsertAsync(producto);
        }

        public Task<List<Producto>> GetProductosAsync()
        {
            return _db.Table<Producto>().ToListAsync();
        }
    }
}





