using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataAccessLayer
{
    public class cmbMemberAccessClass
    {
        LMSDbContext objLmsDbConext;
         public cmbMemberAccessClass()
        {
            objLmsDbConext = new LMSDbContext();
        }

        public List<MEMBER> SelectAllEntries()
        {
            return objLmsDbConext.MEMBERs.ToList();
        }
    }
}
