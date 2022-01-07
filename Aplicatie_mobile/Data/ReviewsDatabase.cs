using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Aplicatie_mobile.Models;
using SQLite;

namespace Aplicatie_mobile.Data
{
    public class ReviewsDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public ReviewsDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Reviews>().Wait();
        }
        public Task<List<Reviews>> GetReviewsAsync()
        {
            return _database.Table<Reviews>().ToListAsync();
        }
        public Task<Reviews> GetReviewsAsync(int id)
        {
            return _database.Table<Reviews>()
            .Where(i => i.ID == id)
            .FirstOrDefaultAsync();
        }
        public Task<int> SaveReviewsAsync(Reviews rlist)
        {
            if (rlist.ID != 0)
            {
                return _database.UpdateAsync(rlist);
            }
            else
            {
                return _database.InsertAsync(rlist);
            }
        }
        public Task<int> DeleteReviewsAsync(Reviews rlist)
        {
            return _database.DeleteAsync(rlist);
        }
    }
}
