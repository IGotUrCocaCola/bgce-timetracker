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
    
    public partial class USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USER()
        {
            this.NOTIFICATIONs = new HashSet<NOTIFICATION>();
            this.NOTIFICATIONs1 = new HashSet<NOTIFICATION>();
            this.PTO_REQUEST = new HashSet<PTO_REQUEST>();
            this.PTO_REQUEST1 = new HashSet<PTO_REQUEST>();
            this.TIME_SHEET = new HashSet<TIME_SHEET>();
            this.TIME_SHEET1 = new HashSet<TIME_SHEET>();
            this.TIME_SHEET_ENTRY = new HashSet<TIME_SHEET_ENTRY>();
            this.USER1 = new HashSet<USER>();
        }
    
        public int userID { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public bool active { get; set; }
        public Nullable<System.DateTime> start_date { get; set; }
        public System.DateTime created_on { get; set; }
        public string created_by { get; set; }
        public Nullable<System.DateTime> updated_on { get; set; }
        public Nullable<System.DateTime> updated_by { get; set; }
        public Nullable<int> manager { get; set; }
        public Nullable<int> location { get; set; }
        public string email { get; set; }
        public bool is_administrator { get; set; }
        public string user_type { get; set; }
        public Nullable<double> total_hours_worked { get; set; }
        public bool can_work_foodservice { get; set; }
    
        public virtual LOCATION LOCATION1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTIFICATION> NOTIFICATIONs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTIFICATION> NOTIFICATIONs1 { get; set; }
        public virtual PAID_STAFF PAID_STAFF { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PTO_REQUEST> PTO_REQUEST { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PTO_REQUEST> PTO_REQUEST1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TIME_SHEET> TIME_SHEET { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TIME_SHEET> TIME_SHEET1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TIME_SHEET_ENTRY> TIME_SHEET_ENTRY { get; set; }
        public virtual UNIT_DIRECTOR UNIT_DIRECTOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USER> USER1 { get; set; }
        public virtual USER USER2 { get; set; }
        public virtual VOLUNTEER VOLUNTEER { get; set; }
        public virtual LOGIN LOGIN { get; set; }
    }
}
