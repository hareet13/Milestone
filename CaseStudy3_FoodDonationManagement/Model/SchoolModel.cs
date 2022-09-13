using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudy3_FoodDonationManagement.Model
{
    public class SchoolModel
    {
        [Key]
        public int StudentDonarId { get; set; }
        public string StudentDonarName { get; set; }
        public string StudentDonarCity { get; set; }
        public string StudentDonarAddress { get; set; }
    }
}
