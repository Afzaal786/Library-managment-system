using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataAccessLayer
{
    public class rackFactory
    {
        rackAccessClass objRackAccessClass;

        public rackFactory()
        {
            objRackAccessClass = new rackAccessClass();
        }

        public bool insert(RACK tobjRack)
        {
            return objRackAccessClass.insert(tobjRack);
        }
        public List<RACK> getAllRacks()
        {
            return objRackAccessClass.viewAllRacks();
        }

        public List<RACK> getAllRacksById(int id)
        {
            return objRackAccessClass.searchRackById(id);
        }
        public bool delete(int iD)
        {
            return objRackAccessClass.delete(iD);
        }

        public bool update(int id,  int recSectionId)
        {
            return objRackAccessClass.update(id, recSectionId);
        }
    }
}
