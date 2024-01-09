using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpaceAgencyado.Model;
using SpaceAgencyado.DAO;
using SpaceAgencyado.Interface;
using System.Data.SqlTypes;

namespace SpaceAgencyado.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgencyController : ControllerBase
    {
        private readonly IAgencyDA dal;
        public AgencyController(IAgencyDA dal)
        {
            this.dal = dal;
        }
        //AgencyDAL _ad = new AgencyDAL();
        //public AgencyController(AgencyDAL dal)
        //{
        //    _ad= dal;
        //}

        //[HttpGet]
        //public List<Agencies> Get()
        //{

        //    return dal.GetAgencies();
        //}
        [HttpGet]
        public IActionResult Get()
        {
            //List<Agencies> Ag = new List<Agencies>();
            try
            {

                List<Agencies> Ag =  dal.GetAgencies();
                return Ok(Ag);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        [HttpGet("{id}")]
        public List<Agencies> GetById(int id)
        {
           
            return dal.GetAgenciesById(id);
        }
       

        [HttpPost]
        public IActionResult Post(Agencies agency)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                dal.AddAgency(agency);
                return Ok("Agency Added Successfully !");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error Occured : {ex.Message}");
            }

        }

        [HttpPut("{id}")]
        public void Put(Agencies agency)
        {
            if (!ModelState.IsValid)
            {
                 BadRequest(ModelState);
            }
            try
            {
                dal.UpdateAgency(agency);
                 Ok("Agency Updated Successfully !");
            }
            catch (Exception ex)
            {
                 StatusCode(500, $"Error Occured : {ex.Message}");
            }
           

        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
           
            dal.DeleteAgency(id);
        }

        [Route("/GetMission")]
        [HttpGet]
        public List<MissionInfo> GetMission()
        {
         
            return dal.GetSpaceMission();
        }
    }
}
