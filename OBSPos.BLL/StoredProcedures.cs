


  
using System;
using SubSonic;
using SubSonic.Schema;
using SubSonic.DataProviders;
using System.Data;

namespace OBS.Pos.Business{
	public partial class PosDB{

        public StoredProcedure rptProdCurrentStock(){
            StoredProcedure sp=new StoredProcedure("rptProdCurrentStock",this.Provider);
            return sp;
        }
	
	}
	
}
 