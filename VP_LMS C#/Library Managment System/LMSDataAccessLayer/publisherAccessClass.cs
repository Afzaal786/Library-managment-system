using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataAccessLayer
{
    public class publisherAccessClass
    {
        LMSDbContext objLmsDbContext;

        public publisherAccessClass()
        {
            objLmsDbContext = new LMSDbContext();
        }

        public bool insert(PUBLISHER tobjPublisher)
        {
            objLmsDbContext.PUBLISHERs.Add(tobjPublisher);
            return objLmsDbContext.SaveChanges() > 0;
        }

        public List<PUBLISHER> viewAllPublishers()
        {
            return objLmsDbContext.PUBLISHERs.ToList();
        }

        public List<PUBLISHER> searchPublisherById(int id)
        {
            return (from c in objLmsDbContext.PUBLISHERs
                    where c.publisherId == id
                    select c).ToList();
        }

        public bool delete(int id)
        {
            PUBLISHER ObjPublisherTable = objLmsDbContext.PUBLISHERs.Where(x => x.publisherId == id).FirstOrDefault();

            if (ObjPublisherTable != null)
            {
                objLmsDbContext.PUBLISHERs.Remove(ObjPublisherTable);
            }

            return objLmsDbContext.SaveChanges() > 0;
        }
        public bool update(int id, string publName, string publContact)
        {
            PUBLISHER ObjPublisherTable = objLmsDbContext.PUBLISHERs.Where(x => x.publisherId == id).FirstOrDefault();
            if (ObjPublisherTable != null)
            {
                ObjPublisherTable.publisherName = publName;
                ObjPublisherTable.publisherContact = publContact;
            }

            return objLmsDbContext.SaveChanges() > 0;

        }

    }
}
