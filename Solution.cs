using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
  public  class Solution
    {
        public int SolutionID { get; set; }
        public Nullable<int> QueryId { get; set; }
        public Nullable<System.DateTime> SolvedDate { get; set; }
        public string Solution1 { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}
