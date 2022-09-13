using CaseStudy3_FoodDonationManagement.DataLayer;
using CaseStudy3_FoodDonationManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudy3_FoodDonationManagement.Core
{
    public class FoodDonar : IFoodDonar
    {
        readonly FoodDonarContext _foodDonarContext;
        public FoodDonar(FoodDonarContext foodDonarContext)
        {
            _foodDonarContext = foodDonarContext;
        }
        public void AddFoodDonar(SchoolModel schoolModel)
        {
            _foodDonarContext.schoolDonarModels.Add(schoolModel);
            _foodDonarContext.SaveChanges();
          
        }

        public IEnumerable<SchoolModel> GetAllDonars()
        {
            return _foodDonarContext.schoolDonarModels.ToList();
            
        }
    }
}
