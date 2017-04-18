using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class CraditCard
    {
        public int CraditCardsID { get; set; }
        public Nullable<int> LoginID { get; set; }
        public Nullable<int> OrderID { get; set; }
        public string Type { get; set; }
        public string CcNumber { get; set; }
        public string Qunt { get; set; }
        public string CName { get; set; }
        public string Cvv { get; set; }
        public string Exp { get; set; }
        public string Street { get; set; }
        public string CityID { get; set; }
        public string StateID { get; set; }
        public string CountryID { get; set; }
        public Nullable<int> Zipcode { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}
