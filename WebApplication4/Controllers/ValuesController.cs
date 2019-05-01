using Microsoft.AspNetCore.Mvc;
using System.Data;
using WebApplication4.DataService;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        Models.DataServiceModel dataServiceModel = new Models.DataServiceModel();
        // GET: api/DataHelper
        [HttpGet]
        public DataTable Get()
        {
            DataTable Studenttbl = new DataHelper().GetResults("SELECT * FROM UserRegistration");
            return Studenttbl;
        }


        // POST: api/DataHelper
        [HttpPost]
        public DataTable Post(DataServiceModel dataServiceModel)
        {
            DataTable Studenttbl = new DataHelper().PostValues("INSERT INTO UserRegistration VALUES ('" + dataServiceModel.Name + "' , '" + dataServiceModel.Address + "','" + dataServiceModel.PhoneNo + "','" + dataServiceModel.Email + "','" + dataServiceModel.State + "','" + dataServiceModel.Approved + "')");
            return Studenttbl;
        }
    }
}
