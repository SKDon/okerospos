using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OBS.Pos.Enumerations
{
    public enum PaymentType : short
    {
        Cash = 1,
        CreditCard,
        Complimentary,
        Note,
        Terms
    }
}
