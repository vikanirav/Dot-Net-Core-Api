using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalityTestAPI
{
    public interface ICCChargeRepository
    {
        List<CreditCardCharge> GetCharges(int customerId);
        CreditCardCharge Get(int chargeId);
        int CreateCharge(CreditCardCharge model);
        void UpdateCharge(int id, CreditCardCharge model);
        void DeleteCharge(int chargeId);
    }
}
