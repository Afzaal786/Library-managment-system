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
    
    public partial class CATAGORY
    {
        public CATAGORY()
        {
            this.BOOKs = new HashSet<BOOK>();
        }
    
        public int catagoryId { get; set; }
        public string catagoryName { get; set; }
    
        public virtual ICollection<BOOK> BOOKs { get; set; }
    }
}
