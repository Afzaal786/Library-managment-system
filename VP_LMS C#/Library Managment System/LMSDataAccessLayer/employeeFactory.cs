using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataAccessLayer
{
    public class employeeFactory
    {
        employeeAccessClass objEmployeeAccessClass;

        public employeeFactory()
        {
            objEmployeeAccessClass = new employeeAccessClass();
        }

        public bool insert(EMPLOYEE tobjEmployee)
        {
            return objEmployeeAccessClass.insert(tobjEmployee);
        }

        public List<EMPLOYEE> getAllEmployees()
        {
            return objEmployeeAccessClass.viewAllEmployees();
        }
        public List<EMPLOYEE> getAllEmployeesById(int id)
        {
            return objEmployeeAccessClass.searchEmployeeById(id);
        }

        public bool delete(int iD)
        {
            return objEmployeeAccessClass.delete(iD);
        }

        public bool update(int id, string empeName, string empeDesignation, string empeContact)
        {
            return objEmployeeAccessClass.update(id, empeName, empeDesignation, empeContact);
        }
    }
}
