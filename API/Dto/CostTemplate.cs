using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CostManagementAPI.Models;

namespace CostManagementAPI.Dto
{
    public class CostTemplate
    {
        public List<Imprint> Imprints {get; set;}
        public List<RoyaltyTemplate> RoyaltyTemplats {get; set;}
        public List<SalesTemplates>  SalesTemplates {get; set;}

    }
}
