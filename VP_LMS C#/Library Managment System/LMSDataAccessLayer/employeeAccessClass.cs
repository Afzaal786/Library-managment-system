using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataAccessLayer
{
    public class employeeAccessClass
    {
        LMSDbContext objLmsDbContext;

        public employeeAccessClass()
        {
            objLmsDbContext = new LMSDbContext();
        }

        public bool insert(EMPLOYEE tobjEmployee)
        {
            objLmsDbContext.EMPLOYEEs.Add(tobjEmployee);
            return objLmsDbContext.SaveChanges() > 0;
        }

        public List<EMPLOYEE> viewAllEmployees()
        {
            return objLmsDbContext.EMPLOYEEs.ToList();
        }

        public List<EMPLOYEE> searchEmployeeById(int Id)
        {
            return (from c in objLmsDbContext.EMPLOYEEs
                    where c.employeeId == Id
                    select c).ToList();
        }

        public bool delete(int id)
        {
            EMPLOYEE ObjEmployeeTable = objLmsDbContext.EMPLOYEEs.Where(x => x.employeeId == id).FirstOrDefault();

            if (ObjEmployeeTable != null)
            {
                objLmsDbContext.EMPLOYEEs.Remove(ObjEmployeeTable);
            }

            return objLmsDbContext.SaveChanges() > 0;
        }

        public bool update(int id, string empName, string empDesignation, string empContact)
        {
            EMPLOYEE ObjEmployeeTable = objLmsDbContext.EMPLOYEEs.Where(x => x.employeeId == id).FirstOrDefault();
            if (ObjEmployeeTable != null)
            {
                ObjEmployeeTable.employeeName = empName;
                ObjEmployeeTable.Designation = empDesignation;
                ObjEmployeeTable.employeeContact = empContact;
            }

            return objLmsDbContext.SaveChanges() > 0;

        }

    }
}
