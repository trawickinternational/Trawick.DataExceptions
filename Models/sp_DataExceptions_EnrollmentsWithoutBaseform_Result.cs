//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Trawick.DataExceptions.Models
{
    using System;
    
    public partial class sp_DataExceptions_EnrollmentsWithoutBaseform_Result
    {
        public int master_enrollment_id { get; set; }
        public Nullable<int> roster_id { get; set; }
        public Nullable<int> school_id { get; set; }
        public Nullable<int> policy_id { get; set; }
        public Nullable<int> rate_id { get; set; }
        public Nullable<System.DateTime> dt_cr { get; set; }
        public string school_name { get; set; }
        public Nullable<int> enrollment_status_id { get; set; }
        public string description { get; set; }
        public Nullable<System.DateTime> enrollment_date { get; set; }
        public string group_no { get; set; }
        public string cert_no { get; set; }
        public string cov_key { get; set; }
        public string enroll_class { get; set; }
        public string enroll_type { get; set; }
        public Nullable<System.DateTime> date_id_card_sent { get; set; }
        public string bill_mode { get; set; }
        public Nullable<bool> tempReconciled { get; set; }
        public Nullable<int> claim_payment_status { get; set; }
        public Nullable<System.DateTime> dt_reconcile { get; set; }
        public Nullable<int> enrollment_type_id { get; set; }
        public Nullable<System.DateTime> date_id_card_print { get; set; }
        public Nullable<System.DateTime> date_member_login { get; set; }
        public Nullable<System.DateTime> date_book_marked { get; set; }
        public int agent_id { get; set; }
        public string agent_ref_no { get; set; }
        public Nullable<int> parent_master_enrollment_id { get; set; }
        public Nullable<int> plan_id { get; set; }
    }
}