using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CostManagementAPI.Data;
using CostManagementAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CostManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContributorController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ContributorController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Contributors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contributor>>> GetProduct()
        {
            return await _context.Contributors.ToListAsync();
        }

        // GET: api/Contributors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Contributor>> GetProduct(int id)
        {
            var product = await _context.Contributors.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

    }
}
