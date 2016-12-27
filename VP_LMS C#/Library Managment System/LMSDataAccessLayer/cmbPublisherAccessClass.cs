using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataAccessLayer
{
    public class cmbPublisherAccessClass
    {
        LMSDbContext objLmsDbConext;

        public cmbPublisherAccessClass()
        {
            objLmsDbConext = new LMSDbContext();
        }

        public List<PUBLISHER> SelectAllEntries()
        {
            return objLmsDbConext.PUBLISHERs.ToList();
        }
    }
}
