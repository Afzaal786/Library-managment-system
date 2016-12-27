using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class catagoryViewModel:IDataErrorInfo
    {
        private int catagoryId;
        private string catagoryName;
        public int CatagoryId { get { return catagoryId; } set { catagoryId = value; } }
        public string CatagoryName { get { return catagoryName; } set { catagoryName = value; } }

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
