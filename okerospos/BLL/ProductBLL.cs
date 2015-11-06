using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace OBS.Pos.BLL
{
    public class ProductBLL
    {
        public static DataRowView SetProductDefault(DataRowView product)
        {
            var row = product;
            row["ProductName"] = "";
            row["UnitPrice"] = 0;
            row["CostPrice"] = 0;
            row["ApplyVAT"] = true;
            row["ApplyNHIL"] = true;
            row["UsedInSales"] = true;
            row["UseIfNotInStock"] = false;
            row["UsedInProduction"] = false;
            row["MinLevel"] = 0;
            row["ReOrderLevel"] = 0;

            return row;
        }
    }
}
