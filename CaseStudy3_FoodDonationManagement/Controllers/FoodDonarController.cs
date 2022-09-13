using CaseStudy3_FoodDonationManagement.Core;
using CaseStudy3_FoodDonationManagement.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudy3_FoodDonationManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodDonarController : ControllerBase
    {
        private readonly IFoodDonar _foodDonar;
        public FoodDonarController(IFoodDonar foodDonar)
        {
            _foodDonar = foodDonar;
        }

        //post: api/FoodDonar
        public IActionResult Post([FromBody] SchoolModel schoolModel)
        {
            if (schoolModel == null)
            {
                return BadRequest("Donar Details is Empty");
            }
            _foodDonar.AddFoodDonar(schoolModel);
            return Ok();
        }

        //Get : api/FoodDonar
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<SchoolModel> school = _foodDonar.GetAllDonars();

            return Ok(school);
        }


    }
}
