using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataAccessLayer
{
    public class publisherFactory
    {
        publisherAccessClass objPublisherAccessClass;

        public publisherFactory()
        {
            objPublisherAccessClass = new publisherAccessClass();
        }

        public bool insert(PUBLISHER tobjPublisher)
        {
            return objPublisherAccessClass.insert(tobjPublisher);
        }

        public List<PUBLISHER> getAllPublishers()
        {
            return objPublisherAccessClass.viewAllPublishers();
        }

        public List<PUBLISHER> getAllPublishersById(int iD)
        {
            return objPublisherAccessClass.searchPublisherById(iD);
        }

        public bool delete(int iD)
        {
            return objPublisherAccessClass.delete(iD);
        }

        public bool update(int id, string pubName, string pubContact)
        {
            return objPublisherAccessClass.update(id, pubName, pubContact);
        }
    }
}
