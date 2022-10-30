using System.Text.Json;

namespace DemoApplicationWeb_A.Models
{
    public class Medicine
    {
        public int  medicine_id { get; set; }

        private string medicine_name1;

        public string Getmedicine_name()
        {
            return medicine_name1;
        }

        public void Setmedicine_name(string value)
        {
            medicine_name1 = value;
        }

        public string company_name { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize<Medicine>(this);
        }
    }
}
