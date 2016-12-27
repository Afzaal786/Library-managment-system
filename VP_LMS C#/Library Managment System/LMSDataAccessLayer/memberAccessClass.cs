using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataAccessLayer
{
    public class memberAcessClass
    {
        LMSDbContext objLmsDbContext;

        public memberAcessClass()
        {
            objLmsDbContext = new LMSDbContext();
        }

        public bool insert(MEMBER tobjMember)
        {
            objLmsDbContext.MEMBERs.Add(tobjMember);
            return objLmsDbContext.SaveChanges() > 0;
        }

        public List<MEMBER> viewAllMembers()
        {
            return objLmsDbContext.MEMBERs.ToList();
        }

        public List<MEMBER> searchMemberById(int id)
        {

            return (from c in objLmsDbContext.MEMBERs
                    where c.memberId == id
                    select c).ToList();
        }
        public bool delete(int id)
        {
            MEMBER ObjMemberTable = objLmsDbContext.MEMBERs.Where(x => x.memberId == id).FirstOrDefault();

            if (ObjMemberTable != null)
            {
                objLmsDbContext.MEMBERs.Remove(ObjMemberTable);
            }

            return objLmsDbContext.SaveChanges() > 0;
        }

        public bool update(int id, string memName, string memContact)
        {
            MEMBER ObjMemberTable = objLmsDbContext.MEMBERs.Where(x => x.memberId == id).FirstOrDefault();
            if (ObjMemberTable != null)
            {
                ObjMemberTable.memberName = memName;
                ObjMemberTable.memberContact = memContact;
            }

            return objLmsDbContext.SaveChanges() > 0;

        }

    }
}
