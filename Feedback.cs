using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class Feedback
    {
        public int Feedbackid { get; set; }
        public Nullable<int> LoginID { get; set; }
        public Nullable<int> Brandid { get; set; }
        public Nullable<int> Categoryid { get; set; }
        public Nullable<int> Itemid { get; set; }
        public string Feedbackdesc1 { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}
