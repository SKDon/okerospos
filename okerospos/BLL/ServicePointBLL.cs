using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace OBS.Pos.BLL
{
    public class ServicePointBLL
    {
        public static DataRowView SetServicePointDefault(DataRowView servicepoint)
        {
            var row = servicepoint;
            row["ServicePointId"] = Guid.NewGuid();
            return row;
        }
    }
}
