using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using DemoApplicationWeb_A.Models;
using System;

namespace Medicos.Services
{
    public class JsonFileMedicineService
    {
        
        public IWebHostEnvironment WebHostEnvironment { get; set; }

        public JsonFileMedicineService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public string FileAddress
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "medicine.json");
            }
        }

        public IEnumerable<Medicine>getMedicineRecord()
        {
            using (var filestream = File.OpenText(FileAddress))
            {
                return JsonSerializer.Deserialize<Medicine[]>(filestream.ReadToEnd());
            }
        }

        
    }
}