using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataAccessLayer
{
    public class cmbBookFactory
    {
        cmbBookAccessClass objCmbBookAccessClass;

         public cmbBookFactory() 
        {
            objCmbBookAccessClass = new cmbBookAccessClass();       
        }

        public List<BOOK> getAllEntries()
        {
            return objCmbBookAccessClass.SelectAllEntries();
        }
    }
}
