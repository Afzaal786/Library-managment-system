using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMSDataAccessLayer
{
    public class userAccessClass
    {
        LMSDbContext objLmsDbContext;

        public userAccessClass()
        {
            objLmsDbContext = new LMSDbContext();
        }

        public bool insert(USER tobjUser)
        {
            objLmsDbContext.USERs.Add(tobjUser);
            return objLmsDbContext.SaveChanges() > 0;
        }

        public List<USER> viewAllUsers()
        {
            return objLmsDbContext.USERs.ToList();
        }

        public List<USER> searchUserById(int id)
        {
            return (from c in objLmsDbContext.USERs
                    where c.userId == id
                    select c).ToList();
        }

        public List<USER> userLogin(string name, string password)
        {
            return (from c in objLmsDbContext.USERs
                    where (c.userName == name && c.userPassword == password)
                    select c).ToList();
        }

        public bool delete(int id)
        {
            USER ObjUserTable = objLmsDbContext.USERs.Where(x => x.userId == id).FirstOrDefault();

            if (ObjUserTable != null)
            {
                objLmsDbContext.USERs.Remove(ObjUserTable);
            }

            return objLmsDbContext.SaveChanges() > 0;
        }

        public bool update(int id, string urName, string urPassword)
        {
            USER ObjUserTable = objLmsDbContext.USERs.Where(x => x.userId == id).FirstOrDefault();
            if (ObjUserTable != null)
            {
                ObjUserTable.userName = urName;
                ObjUserTable.userPassword = urPassword;
            }

            return objLmsDbContext.SaveChanges() > 0;

        }

    }
}
