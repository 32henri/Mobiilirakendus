using SQLite;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using Mobiilirakendus.Models;

namespace Mobiilirakendus.Data
{
    public class DatabaseContext
    {
        private static readonly string DbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "products.db");
        private readonly SQLiteAsyncConnection _database;

        public DatabaseContext()
        {
            _database = new SQLiteAsyncConnection(DbPath);
            _database.CreateTableAsync<Asjad>().Wait();
        }

        public Task<List<Asjad>> GetAllProductsAsync()
        {
            return _database.Table<Asjad>().ToListAsync();
        }

        public Task<Asjad> GetProductAsync(int id)
        {
            return _database.Table<Asjad>().Where(p => p.Id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveProductAsync(Asjad asjad)
        {
            if (asjad.Id != 0)
                return _database.UpdateAsync(asjad);
            else
                return _database.InsertAsync(asjad);
        }

        public Task<int> DeleteProductAsync(Asjad product)
        {
            return _database.DeleteAsync(product);
        }
    }
}