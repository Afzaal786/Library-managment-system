using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataAccessLayer
{
    public class sectionAccessClass
    {

        LMSDbContext objLmsDbContext;

        public sectionAccessClass()
        {
            objLmsDbContext = new LMSDbContext();
        }

        public bool insert(SECTION tobjSection)
        {
            objLmsDbContext.SECTIONs.Add(tobjSection);
            return objLmsDbContext.SaveChanges() > 0;
        }

        public List<SECTION> viewAllSections()
        {
            return objLmsDbContext.SECTIONs.ToList();
        }

        public List<SECTION> searchSectionById(int id)
        {

            return (from c in objLmsDbContext.SECTIONs
                    where c.sectionId == id
                    select c).ToList();
        }
        public bool delete(int id)
        {
            SECTION ObjSectionTable = objLmsDbContext.SECTIONs.Where(x => x.sectionId == id).FirstOrDefault();

            if (ObjSectionTable != null)
            {
                objLmsDbContext.SECTIONs.Remove(ObjSectionTable);
            }

            return objLmsDbContext.SaveChanges() > 0;
        }

        public bool update(int id, string secName)
        {
            SECTION ObjSectionTable = objLmsDbContext.SECTIONs.Where(x => x.sectionId == id).FirstOrDefault();
            if (ObjSectionTable != null)
            {
                ObjSectionTable.sectionName = secName;
            }

            return objLmsDbContext.SaveChanges() > 0;

        }
    }
}
