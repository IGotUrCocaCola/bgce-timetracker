//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bgce_timetracker.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UNIT_DIRECTOR_VIEW
    {
        public Nullable<double> pto_accrual_rate { get; set; }
        public Nullable<double> max_pto_accrual { get; set; }
        public Nullable<double> total_pto_accrued { get; set; }
        public Nullable<double> pay_rate { get; set; }
        public string pay_schedule { get; set; }
        public int userID { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public byte[] active { get; set; }
        public Nullable<System.DateTime> start_date { get; set; }
        public System.DateTime created_on { get; set; }
        public string created_by { get; set; }
        public Nullable<System.DateTime> updated_on { get; set; }
        public Nullable<System.DateTime> updated_by { get; set; }
        public Nullable<int> manager { get; set; }
        public Nullable<int> location { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string passwrd { get; set; }
        public Nullable<System.DateTime> passwrd_last_set { get; set; }
        public byte[] passwrd_expired { get; set; }
        public string passwd_salt { get; set; }
        public byte[] is_administrator { get; set; }
        public string user_type { get; set; }
        public Nullable<double> total_hours_worked { get; set; }
    }
}
