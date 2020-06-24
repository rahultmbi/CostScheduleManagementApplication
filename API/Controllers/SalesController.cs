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
    public class SalesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private IAuthRepository _authRepository { get; set; }

        public SalesController(ApplicationDbContext context, IAuthRepository authRepository)
        {
            _context = context;
            _authRepository = authRepository;
        }       


        /*[HttpGet("getSalesTypes")]
        public async Task<IActionResult> GetSalesTypes()
        {
            var salesTypes =  await _context.SalesTypes.ToListAsync();

            return Ok(salesTypes);
        }*/

        // GET: api/SalesTemplates
        [HttpGet("getSalesTemplates")]
        public async Task<IActionResult> GetSalesTemplates()
        {
            var saleTemplates =  await _context.SalesTemplates.ToListAsync();

            return Ok(saleTemplates);
        }

       

         [HttpPost("saveSalesTemplate")]
        public async Task<IActionResult> SaveSalesTemplate()
        {
            //SalesTemplates salesTemplates
            var salesTemplatesp = new SalesTemplates
            {
                SalesTemplateName = "APAC Market",
                SalesType = "Competitors"
            };

            await _context.SalesTemplates.AddAsync(salesTemplatesp);
            await _context.SaveChangesAsync();

            var response = await _context.Imprint.ToListAsync();

            return Ok(response);
        }   

        
    }
}
