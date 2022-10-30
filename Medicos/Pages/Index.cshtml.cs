using DemoApplicationWeb_A.Models;
using Medicos.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Medicos.Pages
{
    public class IndexModel : PageModel
    {
        public IEnumerable<Medicine> Medicines { get; private set; }
        public JsonFileMedicineService MedicineService;

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, JsonFileMedicineService MedicineService)
        {
            if (MedicineService is null)
            {
                throw new ArgumentNullException(nameof(MedicineService));
            }

            _logger = logger;
            this.MedicineService = MedicineService;
        }

        public void OnGet()
        {
            Medicines = MedicineService.getMedicineRecord();
        }
    }
}
