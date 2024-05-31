using SQLite;
using System;
using System.Collections.Generic;
using SQLite;
using Mobiilirakendus.Models;

namespace Services
{
    public class AsjadService : IAsjadService
    {
        private SQLiteAsyncConnection _dbConnection;

        private async Task SetUpDb()
        {
            if (_dbConnection == null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Student.db3");
                _dbConnection = new SQLiteAsyncConnection(dbPath);
                await _dbConnection.CreateTableAsync<Asjad>();
            }
        }

        public async Task<int> AddStudent(Asjad studentModel)
        {
            await SetUpDb();
            return await _dbConnection.InsertAsync(studentModel);
        }

        public async Task<int> DeleteStudent(Asjad studentModel)
        {
            await SetUpDb();
            return await _dbConnection.DeleteAsync(studentModel);
        }

        public async Task<List<Asjad>> GetStudentList()
        {
            await SetUpDb();
            var studentList = await _dbConnection.Table<Asjad>().ToListAsync();
            return studentList;
        }

        public async Task<int> UpdateStudent(Asjad studentModel)
        {
            await SetUpDb();
            return await _dbConnection.UpdateAsync(studentModel);
        }
    }
}
