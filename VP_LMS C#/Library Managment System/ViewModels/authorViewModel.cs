using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class authorViewModel:IDataErrorInfo
    {

        private int authorId;
        private string authorName;

        public int AuthorId { get { return authorId; } set { authorId = value; } }
        public string AuthorName { get { return authorName; } set { authorName = value; } }

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
