using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataAccessLayer
{
    public class cmbCatagoryAccessClass
    {
        LMSDbContext objLmsDbConext;

        public cmbCatagoryAccessClass()
        {
            objLmsDbConext = new LMSDbContext();
        }

        public List<CATAGORY> SelectAllEntries()
        {
            return objLmsDbConext.CATAGORies.ToList();
        }
    }
}
