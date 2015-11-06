using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace OBS.Pos.BLL
{
    public class CustomerBLL
    {
        public static DataRowView SetCustomerDefault(DataRowView customer)
        {
            var row = customer;
            row["CustomerName"] = "";
            row["PaymentModeId"] = 0;
            row["MinBalance"] = 0;
            row["MinCredit"] = 0;
            row["OpenBalance"] = 0;
            row["CreatedOn"] = DateTime.Now.ToUniversalTime();
            if (System.Threading.Thread.CurrentPrincipal != null)
            { row["CreatedBy"] = System.Threading.Thread.CurrentPrincipal.Identity.Name; }

            return row;
        }
    }
}
