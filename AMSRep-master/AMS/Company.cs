//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace AMS
{
    public partial class Company
    {
        public Company()
        {
            this.Users = new HashSet<User>();
        }
    
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyPhone { get; set; }
        public byte[] CompanyLogo { get; set; }
        public Nullable<bool> CompanyStatus { get; set; }
    
        public virtual ICollection<User> Users { get; set; }
    }
    
}