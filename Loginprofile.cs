using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class Loginprofile
    {
        public int Id { get; set; }
        public Nullable<int> LoginId { get; set; }
        public string Birthdate { get; set; }
        public string Hno { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Pincode { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }

        public string Loginname { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Logintype { get; set; }
        public Nullable<int> Squestionid { get; set; }
        public string Sanswer { get; set; }
        public Nullable<int> Firstlogin { get; set; }
        public Nullable<System.DateTime> Passmodifieddate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}
