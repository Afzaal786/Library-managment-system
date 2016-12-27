using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataAccessLayer
{
    public class cmbEmployeeAccessClass
    {
        LMSDbContext objLmsDbConext;

        public cmbEmployeeAccessClass()
        {
            objLmsDbConext = new LMSDbContext();
        }

        public List<EMPLOYEE> SelectAllEntries()
        {
            return objLmsDbConext.EMPLOYEEs.ToList();
        }
    }
}
