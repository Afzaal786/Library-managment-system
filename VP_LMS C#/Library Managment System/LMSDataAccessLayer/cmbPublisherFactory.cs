using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataAccessLayer
{
    public class cmbPublisherFactory
    {
         cmbPublisherAccessClass objCmbPublisherAccessClass;

        public cmbPublisherFactory() 
        {
            objCmbPublisherAccessClass = new cmbPublisherAccessClass();       
        }

        public List<PUBLISHER> getAllEntries()
        {
            return objCmbPublisherAccessClass.SelectAllEntries();
        }
    }
}
