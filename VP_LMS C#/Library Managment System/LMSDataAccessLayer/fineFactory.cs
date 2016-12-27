using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataAccessLayer
{
    public class fineFactory
    {
        fineAccessClass objFineAccessClass;

        public fineFactory()
        {
            objFineAccessClass = new fineAccessClass();
        }

        public bool insert(FINE tobjFine)
        {
            return objFineAccessClass.insert(tobjFine);
        }

        public List<FINE> getAllFines()
        {
            return objFineAccessClass.viewAllFines();
        }

        public List<FINE> getAllFInesById(int iD)
        {
            return objFineAccessClass.searchFineById(iD);
        }

        public bool delete(int iD)
        {
            return objFineAccessClass.delete(iD);
        }

        public bool update(int id, int amount, int memId, DateTime pdOn)
        {
            return objFineAccessClass.update(id, amount, memId, pdOn);
        }
    }
}
