using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace WebApplication1.Models
{
    public class patient
    {
        [JsonPropertyName("id")]
        public int patient_id { get; set; }

        [JsonPropertyName("name")]
        public string patient_name { get; set; }

        [JsonPropertyName("image")]
        public string patient_image { get; set; }


        //convert all data into string format (json string)

        public override string ToString()
        {

            //  return base.ToString(); by default
            return JsonSerializer.Serialize<patient>(this);   // for converting into json format string
        }
    }
}

