using MinhaAPI.DTO;
using MinhaAPI.Entity;

namespace MinhaAPI.Contracts.Repository
{
    public interface IStateRepository
    {
        Task<StateEntity> GetById(int id);
        Task<IEnumerable<StateEntity>> Get();
    }
}
