using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataAccessLayer
{
    public class rackAccessClass
    {
        LMSDbContext objLmsDbContext;

        public rackAccessClass()
        {
            objLmsDbContext = new LMSDbContext();
        }

        public bool insert(RACK tobjRack)
        {
            objLmsDbContext.RACKs.Add(tobjRack);
            return objLmsDbContext.SaveChanges() > 0;
        }

        public List<RACK> viewAllRacks()
        {
            return objLmsDbContext.RACKs.ToList();
        }

        public List<RACK> searchRackById(int id)
        {

            return (from c in objLmsDbContext.RACKs
                    where c.rackId == id
                    select c).ToList();
        }
        public bool delete(int id)
        {
            RACK ObjRackTable = objLmsDbContext.RACKs.Where(x => x.rackId == id).FirstOrDefault();

            if (ObjRackTable != null)
            {
                objLmsDbContext.RACKs.Remove(ObjRackTable);
            }

            return objLmsDbContext.SaveChanges() > 0;
        }

        public bool update(int id, int recSectionId)
        {
            RACK ObjRackTable = objLmsDbContext.RACKs.Where(x => x.rackId == id).FirstOrDefault();
            if (ObjRackTable != null)
            {
                ObjRackTable.sectionId = recSectionId;

            }

            return objLmsDbContext.SaveChanges() > 0;

        }

    }
}
