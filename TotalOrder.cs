using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class TotalOrder
    {
        public int OrderID { get; set; }
        public Nullable<int> LoginID { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<int> TotalAmount { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> ItemOrderId { get; set; }
    
    }
}
