using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalityTestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CCChargeController : ControllerBase
    {
        
        private readonly ApiDbContext _context;
        
        public CCChargeController(ApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<CCChargeViewModel> Get(int id)
        {
            // id is CustomerId

            return _context.CreditCardCharges.Where(c => c.CustomerId == id).Select(c =>
                new CCChargeViewModel { CustomerId = c.CustomerId, Amount = c.Amount }).ToList();
        }

        [HttpPost]
        public int CreateCCCharge(CCChargeViewModel model)
        {
            var ccc = new CreditCardCharge();
            ccc.CustomerId = model.CustomerId;
            ccc.Amount = model.Amount;
            ccc.ChargeDateTime = DateTime.UtcNow;

            _context.CreditCardCharges.Add(ccc);
            _context.SaveChanges();

            return ccc.CreditCardChargeId;

        }
    }
}
