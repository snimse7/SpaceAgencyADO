using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpaceAgencyado.DAO;
using SpaceAgencyado.Interface;

using SpaceAgencyado.Model;

namespace SpaceAgencyado.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DDController : ControllerBase
    {
        private readonly IAgencyDA dal;
        public DDController(IAgencyDA dal)
        {
            this.dal = dal;
        }
        [Route("GetAllCountries")]
        [HttpGet]
        public List<countries> GetAllCountries()
        {
            return dal.GetCountries();
        }

        [Route("GetAllSpace_st/{nm}")]
        [HttpGet]
        public ActionResult<List<space_station>> GetAllSpace_st(string nm)
        {
           
            return dal.GetSp(nm);
        }
    }
}
