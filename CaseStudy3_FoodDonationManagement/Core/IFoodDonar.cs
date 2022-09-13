using CaseStudy3_FoodDonationManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudy3_FoodDonationManagement.Core
{
   public interface IFoodDonar
    {
       
        void AddFoodDonar(SchoolModel schoolModel);
        IEnumerable<SchoolModel> GetAllDonars();
    }
}
