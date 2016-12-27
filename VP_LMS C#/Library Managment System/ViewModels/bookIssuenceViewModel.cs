using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class bookIssuenceViewModel:IDataErrorInfo
    {
        private int issueId ;
        private int bookId ;
       

        public int IssueId { get{return issueId;} 
            set{ IssueId = value; } 
        }
        public int BookId { get{return bookId;} set{bookId = value;} }
      

        public string Error
        {
            get {
                return null;
                throw new NotImplementedException(); }
        }

        public string this[string propertyName]
        {
            
            get {

                string result = "";
                return result;
                throw new NotImplementedException(); }
        }
    }
}
