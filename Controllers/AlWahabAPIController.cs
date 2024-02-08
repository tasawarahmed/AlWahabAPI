using AlWahabAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlWahabAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlWahabAPIController : ControllerBase
    {
        private readonly ApidbContext _dbContext;

        public AlWahabAPIController(ApidbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/<AlWahabAPIController>
        [HttpGet]
        public IEnumerable<ViewStudent> Get()
        {
            return _dbContext.ViewStudents;
        }

        // GET api/<AlWahabAPIController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
    }
}
