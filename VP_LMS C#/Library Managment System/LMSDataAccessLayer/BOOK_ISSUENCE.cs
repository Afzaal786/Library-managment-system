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
    
    public partial class BOOK_ISSUENCE
    {
        public int issueId { get; set; }
        public int bookId { get; set; }
        public int memberId { get; set; }
        public int employeeId { get; set; }
        public System.DateTime issuedOn { get; set; }
        public System.DateTime returnDate { get; set; }
    
        public virtual BOOK BOOK { get; set; }
        public virtual EMPLOYEE EMPLOYEE { get; set; }
        public virtual MEMBER MEMBER { get; set; }
    }
}
