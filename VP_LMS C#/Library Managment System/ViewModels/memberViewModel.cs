using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class memberViewModel: IDataErrorInfo
    {

        private int memberId;
        private string memberName;
        public int MemberId { get { return memberId; } set { memberId = value; } }
        public string MemberName { get { return memberName; } set { memberName = value; } }

        public string Error
        {
            get
            {
                return null;
                throw new NotImplementedException();
            }
        }

        public string this[string propertyName]
        {

            get
            {

                string result = "";
                return result;
                throw new NotImplementedException();
            }
        }
    }
}
