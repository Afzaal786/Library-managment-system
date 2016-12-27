using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataAccessLayer
{
    public class bookAccessClass
    {
        LMSDbContext objLmsDbContext;

        public bookAccessClass()
        {
            objLmsDbContext = new LMSDbContext();
        }

        public bool insert(BOOK tobjBook)
        {
            objLmsDbContext.BOOKs.Add(tobjBook);
            return objLmsDbContext.SaveChanges() > 0;
        }

        public List<BOOK> viewAllBooks()
        {
            return objLmsDbContext.BOOKs.ToList();
        }


        public List<BOOK> searchBookById(int id)
        {
            return (from c in objLmsDbContext.BOOKs
                    where c.bookId == id
                    select c).ToList();
        }

        public bool delete(int id)
        {
            BOOK ObjBookTable = objLmsDbContext.BOOKs.Where(x => x.bookId == id).FirstOrDefault();

            if (ObjBookTable != null)
            {
                objLmsDbContext.BOOKs.Remove(ObjBookTable);
            }

            return objLmsDbContext.SaveChanges() > 0;
        }

        public bool update(int id, string bkName, int bkPrice)
        {
            BOOK ObjBookTable = objLmsDbContext.BOOKs.Where(x => x.bookId == id).FirstOrDefault();
            if (ObjBookTable != null)
            {
                ObjBookTable.bookName = bkName;
                ObjBookTable.purchasePrice = bkPrice;
            }

            return objLmsDbContext.SaveChanges() > 0;
        }


    }
}
