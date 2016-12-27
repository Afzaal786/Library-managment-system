using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataAccessLayer
{
    public class catagoryAccessClass
    {
        LMSDbContext objLmsDbContext;

        public catagoryAccessClass()
        {
            objLmsDbContext = new LMSDbContext();
        }

        public bool insert(CATAGORY tobjCatagory)
        {
            objLmsDbContext.CATAGORies.Add(tobjCatagory);
            return objLmsDbContext.SaveChanges() > 0;
        }

        public List<CATAGORY> viewAllCtagorys()
        {
            return objLmsDbContext.CATAGORies.ToList();
        }

        public List<CATAGORY> searchCatagoryById(int iD)
        {
            return (from c in objLmsDbContext.CATAGORies
                    where c.catagoryId == iD
                    select c).ToList();
        }
        public bool delete(int id)
        {
            CATAGORY ObjCatagoryTable = objLmsDbContext.CATAGORies.Where(x => x.catagoryId == id).FirstOrDefault();

            if (ObjCatagoryTable != null)
            {
                objLmsDbContext.CATAGORies.Remove(ObjCatagoryTable);
            }

            return objLmsDbContext.SaveChanges() > 0;
        }

        public bool update(int id, string catName)
        {
            CATAGORY ObjCatagoryTable = objLmsDbContext.CATAGORies.Where(x => x.catagoryId == id).FirstOrDefault();
            if (ObjCatagoryTable != null)
            {
                ObjCatagoryTable.catagoryName = catName;
            }

            return objLmsDbContext.SaveChanges() > 0;

        }

    }
}
