
using Jobizz.Model;
using Jobizz.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Jobizz.ViewModel
{
    public class JobListViewModel : BaseViewModel
    {
        private JobSearchService _jobSearchService;
        private ObservableCollection<JobModel> _jobs;
        public ICommand LoadJobsCommand { get; private set; }

        public ObservableCollection<JobModel> Jobs
        {
            get => _jobs;
            set => SetProperty(ref _jobs, value);
        }

        public JobListViewModel()
        {
            _jobSearchService = new JobSearchService();
            Jobs = new ObservableCollection<JobModel>();
            LoadJobs();

            // Initialisez la commande LoadJobsCommand
            
        }

        private async void LoadJobs()
        {
            IsBusy = true;
            var query = "developper, USA";
            var page = 1;
            var numPages = 10;

            Debug.WriteLine("Début du chargement des emplois...");

            var jobs = await _jobSearchService.GetAvailableJobsAsync(query, page, numPages);

            Debug.WriteLine($"Nombre d'emplois chargés : {jobs.Count}");


            Jobs.Clear();

            foreach (var job in jobs)
            {
                Jobs.Add(new JobModel
                {
                    JobTitle = job.JobTitle,
                    EmployerName = job.EmployerName,
                    EmployerLogo = job.EmployerLogo,
                    jobcity = job.jobcity,
                    jobstate = job.jobstate,
                    jobcountry = job.jobcountry,
                    JobEmploymentType = job.JobEmploymentType,
                });
            }

            IsBusy = false;

            Debug.WriteLine("Chargement des emplois terminé.");
        }
    }

        


}


