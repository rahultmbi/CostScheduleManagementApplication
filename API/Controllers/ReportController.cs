using System;
using System.Threading.Tasks;
using API.Data;
using CostManagementAPI.Data;
using CostManagementAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CostManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private IAuthRepository _authRepository { get; set; }

        public ReportController(ApplicationDbContext context, IAuthRepository authRepository)
        {
            _context = context;
            _authRepository = authRepository;
        }       


        [HttpGet("getCostTempletes")]
        public async Task<IActionResult> GetCostTempletes()
        {
            var costTempletes =  await _context.CostTempletes.ToListAsync();

            return Ok(costTempletes);
        }

        
        [HttpGet("getScheduleTemplates")]
        public async Task<IActionResult> GetScheduleTemplates()
        {
            var saleTemplates =  await _context.ScheduleTemplates.ToListAsync();

            return Ok(saleTemplates);
        }

          [HttpGet("getCostTemplates")]
        public async Task<IActionResult> GetCostTemplates()
        {
            var costTempletes =  await _context.CostTempletes.ToListAsync();

            return Ok(costTempletes);
        }

         public async Task<IActionResult> GetReports()
        {
            var costTempletes =  await _context.CostTempletes.ToListAsync();

            return Ok(costTempletes);
        }

       

        
    }
}
