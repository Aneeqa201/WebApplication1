using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        //service patient
        JsonPatientFile patientService;

        // patient record
        public IEnumerable<patient> patients { get; private set; }
        
        //use of service
        
        public IndexModel
            (ILogger<IndexModel> logger,
            JsonPatientFile service)
        {
            _logger = logger;
            patientService = service;
        }
        //bring record when someone access


        public void OnGet() => patients = patientService.getpatientRecords();
    }
}
