using AlWahabAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;

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

        // GET api/<AlWahabAPIController>/Students/5
        [HttpGet("Students/{id}")]
        public async Task<ActionResult<IEnumerable<ViewStudent>>>  Get(string id)
        {
            var result = await _dbContext.ViewStudents.FromSqlRaw($"GetStudentsByCNIC {id}").ToListAsync();
            return Ok(result);
        }

        // GET api/<AlWahabAPIController>/Results/5
        [HttpGet("Results/{id}")]
        public async Task<ActionResult<IEnumerable<AlWahabAPI.Models.ViewResult>>> GetStudentResult(int id)
        {
            var result = await _dbContext.ViewResults.FromSqlRaw("EXEC GetStudentResultByID @stuID", new SqlParameter("@stuID", id))
                .ToListAsync();
            return Ok(result);
        }

        // GET api/<AlWahabAPIController>/PaidFee/5
        [HttpGet("PaidFee/{id}")]
        public async Task<ActionResult<IEnumerable<AlWahabAPI.Models.ViewFeePaidApi>>> GetStudentPaidFee(long id)
        {
            var result = await _dbContext.ViewFeePaidApis.FromSqlRaw("EXEC GetPaidFeeByID @stuID", new SqlParameter("@stuID", id))
                .ToListAsync();
            return Ok(result);
        }

        // GET api/<AlWahabAPIController>/UnPaidFee/5
        [HttpGet("UnPaidFee/{id}")]
        public async Task<ActionResult<IEnumerable<AlWahabAPI.Models.ViewFeeReceivableApi>>> GetStudentUnPaidFee(long id)
        {
            var result = await _dbContext.ViewFeeReceivableApis.FromSqlRaw("EXEC GetUnPaidFeeByID @stuID", new SqlParameter("@stuID", id))
                .ToListAsync();
            return Ok(result);
        }
    }
}
