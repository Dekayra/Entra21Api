using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MinhaAPI.Contracts.Repository;
using MinhaAPI.DTO;
using MinhaAPI.Entity;
using MinhaAPI.Repository;

namespace MinhaAPI.Controllers
{
    [ApiController]
    [Route("veiculo")]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleRepository _VehicleRepository;

        public VehicleController(IVehicleRepository VehicleRepository)
        {
            _VehicleRepository = VehicleRepository;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Get()
        {
            return Ok(await _VehicleRepository.Get());
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Add(VehicleDTO user)
        {
            await _VehicleRepository.Add(user);
            return Ok();
        }

        [HttpPut]
        [Authorize]
        public async Task<IActionResult> Update(VehicleEntity user)
        {
            await _VehicleRepository.Update(user);
            return Ok();
        }

        [HttpDelete]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            await _VehicleRepository.Delete(id);
            return Ok();
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<IActionResult> GetByLicensePlate(int id)
        {
            return Ok(await _VehicleRepository.GetByLicensePlate(id));
        }
    }
}
