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
    using System.ComponentModel;

    public partial class PAID_STAFF_VIEW
    {
        [DisplayName("PTO accrual rate")]
        public Nullable<double> pto_accrual_rate { get; set; }
        [DisplayName("Max PTO accrual")]
        public Nullable<double> max_pto_accrual { get; set; }
        [DisplayName("Total PTO accrued")]
        public Nullable<double> total_pto_accrued { get; set; }
        [DisplayName("Pay rate")]
        public Nullable<double> pay_rate { get; set; }
        [DisplayName("Pay schedule")]
        public string pay_schedule { get; set; }
        [DisplayName("User ID")]
        public int userID { get; set; }
        [DisplayName("First name")]
        public string fname { get; set; }
        [DisplayName("Last name")]
        public string lname { get; set; }
        [DisplayName("Active")]
        public bool active { get; set; }
        [DisplayName("Start date")]
        public Nullable<System.DateTime> start_date { get; set; }
        [DisplayName("Created")]
        public System.DateTime created_on { get; set; }
        [DisplayName("Created by")]
        public string created_by { get; set; }
        [DisplayName("Updated")]
        public Nullable<System.DateTime> updated_on { get; set; }
        [DisplayName("Updated by")]
        public Nullable<System.DateTime> updated_by { get; set; }
        [DisplayName("Manager")]
        public Nullable<int> manager { get; set; }
        [DisplayName("Location")]
        public Nullable<int> location { get; set; }
        [DisplayName("Email")]
        public string email { get; set; }
        [DisplayName("Is administrator")]
        public bool is_administrator { get; set; }
        [DisplayName("User type")]
        public string user_type { get; set; }
        [DisplayName("Total hours worked")]
        public Nullable<double> total_hours_worked { get; set; }
        [DisplayName("Can work foodservice")]
        public bool can_work_foodservice { get; set; }
    }
}
