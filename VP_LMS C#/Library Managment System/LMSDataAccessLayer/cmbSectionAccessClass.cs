using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataAccessLayer
{
    public class cmbSectionAccessClass
    {
        LMSDbContext objLmsDbConext;

        public cmbSectionAccessClass()
        {
            objLmsDbConext = new LMSDbContext();
        }

        public List<SECTION> SelectAllEntries()
        {
            return objLmsDbConext.SECTIONs.ToList();
        }
    }
}
