using Jobizz.Model;

public class RootObject
{
    public string status { get; set; }
    public string request_id { get; set; }
    public SearchParameters parameters { get; set; }
    public List<JobModel> data { get; set; }
}

public class SearchParameters
{
    public string query { get; set; }
    public int page { get; set; }
    public int num_pages { get; set; }
}
