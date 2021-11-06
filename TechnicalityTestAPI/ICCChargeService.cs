using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalityTestAPI
{
    public interface ICCChargeService
    {
        List<CCChargeViewModel> GetCharges(int customerId);
        int CreateCCCharge(int customerId, decimal amount);
        void UpdateCCCharge(int chargeId, decimal amount);
    }
}
