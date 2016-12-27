using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class bookViewModel : IDataErrorInfo
    {
        private int BookId;
        private string BookName;
        private int PurchasePrice;
        public int bookId {
            set { BookId = value; }
            get { return BookId; }
           
        }
        public string bookName {
            set { BookName = value; }
            get { return BookName; }
        }
        public int purchasePrice
        {
            set { PurchasePrice = value; }
            get { return PurchasePrice; }
        }

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
