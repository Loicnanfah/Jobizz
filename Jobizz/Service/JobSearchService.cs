using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Jobizz.Model;
using Newtonsoft.Json;

public class JobSearchService
{
    private HttpClient _httpClient;

    public JobSearchService()
    {
        // Initialisez HttpClient avec l'URL de base de l'API RapidAPI.
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri("https://jsearch.p.rapidapi.com/");
        _httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Key", "c30011fc96mshf54e01fc16d71a0p190dbbjsna557b0fa3efc");
        _httpClient.DefaultRequestHeaders.Add("X-RapidAPI-Host", "jsearch.p.rapidapi.com");
    }

    public async Task<List<JobModel>> GetAvailableJobsAsync(string query, int page, int numPages)
    {
        try
        {
            var requestUri = $"search?query={query}&page={page}&num_pages={numPages}";

            var response = await _httpClient.GetStringAsync(requestUri);

            // Désérialisez l'objet JSON racine.
            var rootObject = JsonConvert.DeserializeObject<RootObject>(response);

            // Récupérez le tableau d'offres d'emploi à partir de l'objet JSON racine.
            var jobs = rootObject.data;

            return jobs;
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Erreur lors de la récupération des offres d'emploi : {ex.Message}");
            return new List<JobModel>();
        }
    }

}
