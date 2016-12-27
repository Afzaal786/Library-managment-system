using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataAccessLayer
{
    public class cmbCatagoryFactory
    {
         cmbCatagoryAccessClass objCmbCatagoryAccessClass;

         public cmbCatagoryFactory() 
        {
            objCmbCatagoryAccessClass = new cmbCatagoryAccessClass();       
        }

        public List<CATAGORY> getAllEntries()
        {
            return objCmbCatagoryAccessClass.SelectAllEntries();
        }
    }
}
