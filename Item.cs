using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Item : Inventory
    {
        public int ItemID { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public string ItemName { get; set; }
        public string ItemDesc { get; set; }
        public string ImageURL { get; set; }        
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}
