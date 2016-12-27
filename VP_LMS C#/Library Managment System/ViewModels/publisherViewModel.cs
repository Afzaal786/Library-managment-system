using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class publisherViewModel:IDataErrorInfo
    {

        private int publisherId;
        private string publisherName;
        public int PublisherId { get { return publisherId; } set { publisherId = value; } }
        public string PublisherName { get { return publisherName; } set { publisherName = value; } }

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
