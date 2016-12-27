using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataAccessLayer
{
    public class bookIssuenceAccessClass
    {
        LMSDbContext objLmsDbContext;

        public bookIssuenceAccessClass()
        {
            objLmsDbContext = new LMSDbContext();
        }

        public bool insert(BOOK_ISSUENCE tobjBookIssuence)
        {
            objLmsDbContext.BOOK_ISSUENCE.Add(tobjBookIssuence);
            return objLmsDbContext.SaveChanges() > 0;
        }

        public List<BOOK_ISSUENCE> viewAllBooksIssued()
        {
            return objLmsDbContext.BOOK_ISSUENCE.ToList();
        }

        public List<BOOK_ISSUENCE> searchIssuedBookById(int id)
        {
            return (from c in objLmsDbContext.BOOK_ISSUENCE
                    where c.issueId == id
                    select c).ToList();
        }
        public bool delete(int id)
        {
            BOOK_ISSUENCE ObjBITable = objLmsDbContext.BOOK_ISSUENCE.Where(x => x.issueId == id).FirstOrDefault();

            if (ObjBITable != null)
            {
                objLmsDbContext.BOOK_ISSUENCE.Remove(ObjBITable);
            }

            return objLmsDbContext.SaveChanges() > 0;
        }
        public bool update(int id, DateTime IssuedOn, DateTime returndOn)
        {
            BOOK_ISSUENCE ObjBITable = objLmsDbContext.BOOK_ISSUENCE.Where(x => x.issueId == id).FirstOrDefault();
            if (ObjBITable != null)
            {
                ObjBITable.issuedOn = IssuedOn;
                ObjBITable.returnDate = returndOn;

            }
            return objLmsDbContext.SaveChanges() > 0;
        }
    }
}
