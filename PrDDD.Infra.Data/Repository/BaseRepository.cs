using PrDDD.Domain.Entities;
using PrDDD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace PrDDD.Infra.Data.Repository
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        private string _connectionString;

        public BaseRepository(IConfiguration configuration)
        {
            _connectionString = configuration
                .GetSection("ConnectionStrings")
                .GetSection("SqlServerConnection")
                .Value;
        }

        public void Delete(TEntity obj)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Delete(obj);
            }
        }

        public async Task DeleteAsync(TEntity obj)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.DeleteAsync(obj);
            }
        }

        public async Task DeleteAsync(IEnumerable<TEntity> obj)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.DeleteAsync(obj);
            }
        }

        public void Insert(TEntity obj)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Insert(obj);
            }
        }

        public async Task InsertAsync(TEntity obj)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.InsertAsync(obj);
            }
        }

        public async Task InsertAsync(IEnumerable<TEntity> obj)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.InsertAsync(obj);
            }
        }

        public void Update(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(IEnumerable<TEntity> obj)
        {
            throw new NotImplementedException();
        }
    }
}
