using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CostManagementAPI.Data;
using CostManagementAPI.Models;
using Microsoft.AspNetCore.Cors;
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
        [HttpGet("getContributor")]
        public async Task<IActionResult> GetContributor()
        {
            var contributors =  await _context.Contributors.ToListAsync();

            return Ok(contributors);
        }

        // GET: api/Contributors/5
        [HttpGet("GetContributor/{id}")]
        public async Task<IActionResult> GetContributor(int id)
        {
            var contributor = await _context.Contributors.FindAsync(id);

            if (contributor == null)
            {
                return NotFound();
            }

            return Ok(contributor);
        }

        [HttpGet("getMaterial")]
        public async Task<IActionResult> GetMaterials()
        {
            var materials =  await _context.Materials.ToListAsync();

            return Ok(materials);
        }

    }
}
