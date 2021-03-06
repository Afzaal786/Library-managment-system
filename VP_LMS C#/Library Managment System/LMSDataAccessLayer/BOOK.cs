//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMSDataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class BOOK
    {
        public BOOK()
        {
            this.BOOK_ISSUENCE = new HashSet<BOOK_ISSUENCE>();
            this.AUTHORs = new HashSet<AUTHOR>();
        }
    
        public int bookId { get; set; }
        public string bookName { get; set; }
        public int purchasePrice { get; set; }
        public Nullable<int> publisherId { get; set; }
        public Nullable<int> catagoryId { get; set; }
        public Nullable<int> rackId { get; set; }
        public Nullable<int> sectionId { get; set; }
    
        public virtual CATAGORY CATAGORY { get; set; }
        public virtual ICollection<BOOK_ISSUENCE> BOOK_ISSUENCE { get; set; }
        public virtual PUBLISHER PUBLISHER { get; set; }
        public virtual RACK RACK { get; set; }
        public virtual SECTION SECTION { get; set; }
        public virtual ICollection<AUTHOR> AUTHORs { get; set; }
    }
}
