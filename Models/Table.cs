//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarInsurance.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table
    {
        public int Id { get; set; }
        public string FirstNAme { get; set; }
        public string LastNAme { get; set; }
        public string EmailAddress { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public int CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public bool DUI { get; set; }
        public int SpeedingTickets { get; set; }
        public bool CiverageTYpe { get; set; }
        public decimal Quote { get; set; }
    }
}
