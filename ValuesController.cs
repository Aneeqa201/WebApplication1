using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        JsonPatientFile PatientService;

        public ValuesController(JsonPatientFile patientService)
        {
            this.PatientService = patientService;

        }
        [HttpGet]
       public IEnumerable<patient> Get()
        {
            return PatientService.getpatientRecords();
        }
    }
}
