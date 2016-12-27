using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataAccessLayer
{
    public class fineAccessClass
    {
        LMSDbContext objLmsDbContext;

        public fineAccessClass()
        {
            objLmsDbContext = new LMSDbContext();
        }

        public bool insert(FINE tobjFine)
        {
            objLmsDbContext.FINEs.Add(tobjFine);
            return objLmsDbContext.SaveChanges() > 0;
        }

        public List<FINE> viewAllFines()
        {
            return objLmsDbContext.FINEs.ToList();
        }

        public List<FINE> searchFineById(int id)
        {
            return (from c in objLmsDbContext.FINEs
                    where c.fineId == id
                    select c).ToList();
        }
        public bool delete(int id)
        {
            FINE ObjFineTable = objLmsDbContext.FINEs.Where(x => x.fineId == id).FirstOrDefault();

            if (ObjFineTable != null)
            {
                objLmsDbContext.FINEs.Remove(ObjFineTable);
            }

            return objLmsDbContext.SaveChanges() > 0;
        }
        public bool update(int id, int amount, int memId, DateTime pdOn)
        {
            FINE ObjFineTable = objLmsDbContext.FINEs.Where(x => x.fineId == id).FirstOrDefault();
            if (ObjFineTable != null)
            {
                ObjFineTable.fineAmount = amount;
                ObjFineTable.memberId = memId;
                ObjFineTable.paidOn = pdOn;
            }

            return objLmsDbContext.SaveChanges() > 0;

        }

    }
}
