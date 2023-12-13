using MinhaAPI.DTO;
using MinhaAPI.Entity;

namespace MinhaAPI.Contracts.Repository
{
    public interface IVehicleRepository
    {
        Task<IEnumerable<VehicleEntity>> Get();
        Task Add(VehicleDTO Veiculo);
        Task Update(VehicleEntity Veiculo);
        Task Delete(int id);
        Task<VehicleEntity> GetByLicensePlate(int id);
    }
}
