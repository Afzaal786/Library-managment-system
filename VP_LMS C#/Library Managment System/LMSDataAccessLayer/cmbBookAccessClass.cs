using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataAccessLayer
{
    public class cmbBookAccessClass
    {
        LMSDbContext objLmsDbConext;

        public cmbBookAccessClass()
        {
            objLmsDbConext = new LMSDbContext();
        }

        public List<BOOK> SelectAllEntries()
        {
            return objLmsDbConext.BOOKs.ToList();
        }
    }
}
