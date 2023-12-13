using Dapper;
using MinhaAPI.Contracts.Repository;
using MinhaAPI.DTO;
using MinhaAPI.Entity;
using MinhaAPI.Infrastructure;

namespace MinhaAPI.Repository
{
    public class VehicleRepository : Connection, IVehicleRepository
    {
        public async Task Add(VehicleDTO veiculo)
        {
            string sql = @"
                INSERT INTO VEHICLE (LicensePlate, Name, Year, Capacity)
                    VALUE (@LicensePlate, @Name, @Year, @Capacity)
            ";

            await Execute(sql , veiculo);
        }

        public async Task Delete(int id)
        {
            string sql = "DELETE FROM VEHICLE WHERE Id = @id";

            await Execute(sql, new { id });
        }

        public async Task<IEnumerable<VehicleEntity>> Get()
        {
            string sql = "SELECT * FROM VEHICLE";
            return await GetConnection().QueryAsync<VehicleEntity>(sql);
        }

        public async Task<VehicleEntity> GetByLicensePlate(int id)
        {
            string sql = "SELECT * FROM VEHICLE WHERE Id = @id";
            return await GetConnection().QueryFirstAsync<VehicleEntity>(sql, new { id });
        }

        public async Task Update(VehicleEntity veiculo)
        {
            string sql = @"
                UPDATE VEHICLE 
                    SET 
                        LicensePlate = @LicensePlate,
                        Name = @Name,
                        Year = @Year,
                        Capacity = @Capacity
                    WHERE
                        Id = @Id
            ";

            await Execute(sql, veiculo);
        }
    }
}
