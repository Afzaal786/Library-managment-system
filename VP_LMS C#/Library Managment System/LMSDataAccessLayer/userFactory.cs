using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataAccessLayer
{
    public class userFactory
    {
        userAccessClass objUserAccessClass;

        public userFactory()
        {
            objUserAccessClass = new userAccessClass();
        }

        public bool insert(USER tobjUser)
        {
            return objUserAccessClass.insert(tobjUser);
        }

        public List<USER> getAllUsers()
        {
            return objUserAccessClass.viewAllUsers();
        }

        public List<USER> getAllUsersById(int id)
        {
            return objUserAccessClass.searchUserById(id);
        }

        public bool delete(int iD)
        {
            return objUserAccessClass.delete(iD);
        }

        public List<USER> userLogin(string uName, string uPassword)
        {
            return objUserAccessClass.userLogin(uName,uPassword);
        }

        public bool update(int id, string usrName, string usrPassword)
        {
            return objUserAccessClass.update(id, usrName, usrPassword);
        }
    }
}
