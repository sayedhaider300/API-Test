//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APITest.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        public long Id { get; set; }
        public Nullable<long> Author_Id { get; set; }
        public string Title { get; set; }
    
        public virtual Author Author { get; set; }
    }
}
