using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobizz.ViewModel
{
   public class JobViewModel
    {
        public string employer_name { get; set; }
        public string employer_id { get; set; }
        public string employer_logo { get; set; }
        public string employer_company_type { get; set; }
        public string job_employment_type { get; set; }
        public string job_title { get; set; }
        public string job_description { get; set; }

        public bool job_is_remote { get; set; }
        public DateTime job_posted_at_datetime_utc { get; set; }
        public string job_city { get; set; }
        public string job_state { get; set; }
        public string job_country { get; set; }
        public string job_posting_language { get; set; }
    }
}
