
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobizz.Model
{
    public class JobModel
    {
        [JsonProperty("employer_name")]
        public string EmployerName { get; set; }

        [JsonProperty("employer_logo")]
        public string EmployerLogo { get; set; }

        [JsonProperty("employer_website")]
        public string EmployerWebsite { get; set; }

        [JsonProperty("employer_company_type")]
        public string EmployerCompanyType { get; set; }

        [JsonProperty("job_publisher")]
        public string JobPublisher { get; set; }

        [JsonProperty("job_id")]
        public string JobId { get; set; }

        [JsonProperty("job_employment_type")]
        public string JobEmploymentType { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }

        [JsonProperty("job_apply_link")]
        public string JobApplyLink { get; set; }

        [JsonProperty("job_apply_is_direct")]
        public bool JobApplyIsDirect { get; set; }

        [JsonProperty("job_apply_quality_score")]
        public double JobApplyQualityScore { get; set; }

        [JsonProperty("job_description")]
        public string JobDescription { get; set; }

        [JsonProperty("job_city")]
        public string jobcity { get; set; }

        [JsonProperty("job_state")]
        public string jobstate { get; set; }

        [JsonProperty("job_country")]
        public string jobcountry { get; set; }
    }
}
