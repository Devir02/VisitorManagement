//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VisitorManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_UK_Visitors
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PassportNumber { get; set; }
        public Nullable<bool> IsEUCitizen { get; set; }
        public Nullable<System.DateTime> PassportValidFrom { get; set; }
        public Nullable<System.DateTime> PassportValidTo { get; set; }
        public string CountryOfNationality { get; set; }
        public string VisaNumber { get; set; }
        public Nullable<System.DateTime> VisaValidFrom { get; set; }
        public Nullable<System.DateTime> VisaValidTo { get; set; }
        public Nullable<System.DateTime> EntryDate { get; set; }
        public Nullable<System.DateTime> ExitDate { get; set; }
        public string BiometricNumber { get; set; }
        public Nullable<int> NumberOfPreviousUKVisits { get; set; }
        public Nullable<bool> EntryApproved { get; set; }
    }
}