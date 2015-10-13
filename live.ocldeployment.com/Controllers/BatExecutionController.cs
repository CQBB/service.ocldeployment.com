using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using live.ocldeployment.com.DAL;
using live.ocldeployment.com.Models;
namespace live.ocldeployment.com.Controllers
{
    public class BatExecutionController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

      
        public IHttpActionResult Get(int id)
        {
            BatExecution batexecution = new BatExecution();
            BatExecInfo batinfo = batexecution.findBat(id);

            
            if (batinfo.BatExecResult.Count==0)
                return NotFound();

            return Ok(batinfo);
        }

    
    }
}