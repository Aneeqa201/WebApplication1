using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class JsonPatientFile
    {

        // path -from  
        public JsonPatientFile(IWebHostEnvironment webHostEnvironment)
        {
             WebHostEnvironment = webHostEnvironment;
        }
        public IWebHostEnvironment WebHostEnvironment { get; }
        public string JsonFilePath 
        {

            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "patients.json");
            }
        }


        public IEnumerable<patient> getpatientRecords()
        {
            using (var file_stream = File.OpenText(JsonFilePath)) 
            {
                return JsonSerializer.Deserialize<patient[]>(file_stream.ReadToEnd());
            }

        }
    }
}
