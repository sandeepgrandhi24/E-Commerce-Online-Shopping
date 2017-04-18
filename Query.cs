using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class Query
    {
        public int QueryID { get; set; }
        public Nullable<int> LogiID { get; set; }
        public Nullable<System.DateTime> QueryDate { get; set; }
        public string Description { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}
