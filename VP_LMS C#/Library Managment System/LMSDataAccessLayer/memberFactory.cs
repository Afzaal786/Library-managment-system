using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataAccessLayer
{
    public class memberFactory
    {
        memberAcessClass objMemberAccessClass;

        public memberFactory()
        {
            objMemberAccessClass = new memberAcessClass();
        }

        public bool insert(MEMBER tobjMember)
        {
            return objMemberAccessClass.insert(tobjMember);
        }

        public List<MEMBER> getAllMembers()
        {
            return objMemberAccessClass.viewAllMembers();
        }

        public List<MEMBER> getAllMembersById(int Id)
        {
            return objMemberAccessClass.searchMemberById(Id);
        }
        public bool delete(int iD)
        {
            return objMemberAccessClass.delete(iD);
        }

        public bool update(int id, string membName, string membContact)
        {
            return objMemberAccessClass.update(id, membName, membContact);
        }

    }
}
