//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace aesJuniorProjectT.Entities.Shared.Net45.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class JobHistory
    {
        public int jobHistory_id { get; set; }
        public string employer { get; set; }
        public string empAddress { get; set; }
        public string jobTitle { get; set; }
        public string reasonLeaving { get; set; }
        public Nullable<System.DateTime> dateStarted { get; set; }
        public Nullable<System.DateTime> dateEnded { get; set; }
        public Nullable<int> phone { get; set; }
        public Nullable<int> superviser { get; set; }
        public Nullable<decimal> startingSalary { get; set; }
        public string responsibilities { get; set; }
        public Nullable<decimal> endingSalary { get; set; }
    }
}
