using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CostManagementAPI.Dto;

namespace CostManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoyaltyTemplateController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RoyaltyTemplateController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("saveRoyaltyTemplateData")]
        public async Task<IActionResult>  SaveRoyaltyTemplateData(string royaltyTemplateName, string royaltyType)
        {

                 var royaltyTemplate = new CostManagementAPI.Models.RoyaltyTemplate
                     {
                             RoyaltyTemplateName = royaltyTemplateName,
                             RoyaltyType = royaltyType

                     };
                      await _context.RoyaltyTemplates.AddAsync(royaltyTemplate);
            await _context.SaveChangesAsync();

        var response = await _context.RoyaltyTemplates.ToListAsync();
        return Ok(response);
        }

         [HttpGet("getCostTemplate")]
        public ActionResult GetCostTemplate()
        {
            CostTemplate costTemplate = new CostTemplate();

                 costTemplate.Imprints =  _context.Imprint.ToList();
                 costTemplate.RoyaltyTemplats = _context.RoyaltyTemplates.ToList();
                 costTemplate.SalesTemplates = _context.SalesTemplates.ToList();
        return Ok(costTemplate);
        }

        [HttpPost("saveRoyaltyTemplateData")]
        public async Task<IActionResult>  SaveCostTemplateData(int ImprintId, int RoyaltyTemplateId, int SalesTemplateId)
        {

                 var costTemplate = new CostManagementAPI.Models.CostTemplete
                     {
                             RoyaltyTemplateId = RoyaltyTemplateId,
                              ImprintId= ImprintId,
                              SalesTemplateId = SalesTemplateId

                     }; 
                      await _context.CostTempletes.AddAsync(costTemplate);
            await _context.SaveChangesAsync();

        var response = await _context.CostTempletes.ToListAsync();
        return Ok(response);
        }
        
    }
}
