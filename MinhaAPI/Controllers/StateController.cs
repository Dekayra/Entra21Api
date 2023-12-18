using Microsoft.AspNetCore.Mvc;
using MinhaAPI.Contracts.Repository;
using MinhaAPI.DTO;
using MinhaAPI.Entity;
using MinhaAPI.Repository;

namespace MinhaAPI.Controllers
{
    [ApiController]
    [Route("state")]
    public class StateController : ControllerBase
    {
        private readonly IStateRepository _StateRepository;

        public StateController(IStateRepository StateRepository)
        {
            _StateRepository = StateRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _StateRepository.Get());
        }
    }
}
