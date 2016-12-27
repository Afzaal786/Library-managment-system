using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataAccessLayer
{
    public class cmbEmployeeFactory
    {
         cmbEmployeeAccessClass objCmbEmployeeAccessClass;

        public cmbEmployeeFactory() 
        {
            objCmbEmployeeAccessClass = new cmbEmployeeAccessClass();       
        }

        public List<EMPLOYEE> getAllEntries()
        {
            return objCmbEmployeeAccessClass.SelectAllEntries();
        }
    }
}
