using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataAccessLayer
{
    public class authorAccessClass
    {
        LMSDbContext objLmsDbContext;

        public authorAccessClass()
        {
            objLmsDbContext = new LMSDbContext();
        }

        public bool insert(AUTHOR tobjAuthor)
        {
            objLmsDbContext.AUTHORs.Add(tobjAuthor);
            return objLmsDbContext.SaveChanges() > 0;
        }

        public List<AUTHOR> viewAllAuthors()
        {
            return objLmsDbContext.AUTHORs.ToList();
        }

        public List<AUTHOR> searchAuthorById(int id)
        {
            return (from c in objLmsDbContext.AUTHORs
                    where c.authorId == id
                    select c).ToList();
        }

        public bool delete(int id)
        {
            AUTHOR ObjAuthorTable = objLmsDbContext.AUTHORs.Where(x => x.authorId == id).FirstOrDefault();

            if (ObjAuthorTable != null)
            {
                objLmsDbContext.AUTHORs.Remove(ObjAuthorTable);
            }

            return objLmsDbContext.SaveChanges() > 0;
        }
        public bool update(int id, string authName, string authContact)
        {
            AUTHOR ObjAuthorTable = objLmsDbContext.AUTHORs.Where(x => x.authorId == id).FirstOrDefault();
            if (ObjAuthorTable != null)
            {
                ObjAuthorTable.authorName = authName;
                ObjAuthorTable.authorContact = authContact;
            }

            return objLmsDbContext.SaveChanges() > 0;

        }
    }
}
