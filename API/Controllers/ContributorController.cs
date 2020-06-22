using System;
using System.Collections.Generic;
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
    public class ContributorController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private IAuthRepository _authRepository { get; set; }

        public ContributorController(ApplicationDbContext context, IAuthRepository authRepository)
        {
            _context = context;
            _authRepository = authRepository;
        }

        // GET: api/Contributors
        [HttpGet("getContributor")]
        public async Task<IEnumerable<Contributor>> GetContributor()
        {
            var contributors =  await _context.Contributors.ToListAsync();

            return contributors;
        }

        // GET: api/Contributors/5
        [HttpGet("GetContributor/{id}")]
        public async Task<IActionResult> GetContributor(int id)
        {
            var contributor = await _context.Contributors.FindAsync(id);
            
            if(contributor == null){
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

        [HttpPost("saveImprintData")]
        public async Task<IActionResult> SaveImprintData(Imprint imprint)
        {
            var imprints = new Imprint
            {
                ContriutorId = imprint.ContriutorId,
                EditorId = imprint.EditorId,
             //   ImprintId = 3,
                ISBN = _authRepository.GenerateIsbn(imprint.ISBN),
                Type = imprint.Type
            };

            await _context.Imprint.AddAsync(imprints);
            await _context.SaveChangesAsync();

            var response = await _context.Imprint.ToListAsync();

            return Ok(response);
        }
        
    }
}
