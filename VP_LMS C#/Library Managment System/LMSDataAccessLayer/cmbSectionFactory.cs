using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataAccessLayer
{
    public class cmbSectionFactory
    {
        cmbSectionAccessClass objCmbSectionAccessClass;

        public cmbSectionFactory() 
        {
            objCmbSectionAccessClass = new cmbSectionAccessClass();       
        }

        public List<SECTION> getAllEntries()
        {
            return objCmbSectionAccessClass.SelectAllEntries();
        }


    }
}
