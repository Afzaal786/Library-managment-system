using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataAccessLayer
{
    public class catagoryFactory
    {
        catagoryAccessClass objCatagoryAccessClass;

        public catagoryFactory()
        {
            objCatagoryAccessClass = new catagoryAccessClass();
        }

        public bool insert(CATAGORY tobjCatagory)
        {
            return objCatagoryAccessClass.insert(tobjCatagory);
        }

        public List<CATAGORY> getAllCatagorys()
        {
            return objCatagoryAccessClass.viewAllCtagorys();
        }

        public List<CATAGORY> getAllCatagorysById(int Id)
        {
            return objCatagoryAccessClass.searchCatagoryById(Id);
        }
        public bool delete(int iD)
        {
            return objCatagoryAccessClass.delete(iD);
        }

        public bool update(int id, string CATEName)
        {
            return objCatagoryAccessClass.update(id, CATEName);
        }

    }
}
