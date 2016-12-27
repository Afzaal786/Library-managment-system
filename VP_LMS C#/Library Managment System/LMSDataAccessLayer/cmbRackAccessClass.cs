using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataAccessLayer
{
    public class cmbRackAccessClass
    {
        LMSDbContext objLmsDbConext;

        public cmbRackAccessClass()
        {
            objLmsDbConext = new LMSDbContext();
        }

        public List<RACK> SelectAllEntries()
        {
            return objLmsDbConext.RACKs.ToList();
        }
    }
}
