using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class employeeViewModel:IDataErrorInfo
    {
        private int employeeId;
        private string employeeName;

        public int EmployeeId { get { return employeeId; } set { employeeId = value; } }
        public string EmployeeName { get { return employeeName; } set { employeeName = value; } }

        public string Error
        {
            get
            {
                return null;
                throw new NotImplementedException();
            }
        }

        public string this[string propertyName]
        {

            get
            {

                string result = "";
                return result;
                throw new NotImplementedException();
            }
        }
    }
}
