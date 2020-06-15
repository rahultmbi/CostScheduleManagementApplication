using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
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

        [HttpGet("getRoyaltyTypes")]
        public async Task<IActionResult> GetRoyaltyTypes()
        {
            var royaltyTypes =  await _context.RoyaltyTypes.ToListAsync();

            return Ok(royaltyTypes);
        }

        [HttpGet("getSalesTypes")]
        public async Task<IActionResult> GetSalesTypes()
        {
            var salesTypes =  await _context.SalesTypes.ToListAsync();

            return Ok(salesTypes);
        }

        [HttpGet("getEditorilType")]
        public async Task<IActionResult> GetEditorilType()
        {
            var editionType =  await _context.EditionTypes.ToListAsync();

            return Ok(editionType);
        }

        [HttpGet("getEditors")]
        public async Task<IActionResult> GetEditors()
        {
            var editors =  await _context.Editors.ToListAsync();

            return Ok(editors);
        }

    }
}
