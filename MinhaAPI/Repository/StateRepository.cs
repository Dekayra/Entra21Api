using Dapper;
using MinhaAPI.Contracts.Repository;
using MinhaAPI.DTO;
using MinhaAPI.Entity;
using MinhaAPI.Infrastructure;

namespace MinhaAPI.Repository
{
    public class StateRepository : Connection, IStateRepository
    {
        public async Task<IEnumerable<StateEntity>> Get()
        {
            string sql = "SELECT * FROM STATE";
            return await GetConnection().QueryAsync<StateEntity>(sql);
        }

        public async Task<StateEntity> GetById(int id)
        {
            string sql = "SELECT * FROM STATE WHERE Id = @id";
            return await GetConnection().QueryFirstAsync<StateEntity>(sql, new {id});
        }
    }
}
