using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataAccessLayer
{
    public class sectionFactory
    {

        sectionAccessClass objSectionAccessClass;

        public sectionFactory()
        {
            objSectionAccessClass = new sectionAccessClass();
        }

        public bool insert(SECTION tobjSection)
        {
            return objSectionAccessClass.insert(tobjSection);
        }

        public List<SECTION> getAllSections()
        {
            return objSectionAccessClass.viewAllSections();
        }

        public List<SECTION> getAllSectionsById(int id)
        {
            return objSectionAccessClass.searchSectionById(id);
        }
        public bool delete(int iD)
        {
            return objSectionAccessClass.delete(iD);
        }

        public bool update(int id, string sectName)
        {
            return objSectionAccessClass.update(id, sectName);
        }
    }
}
