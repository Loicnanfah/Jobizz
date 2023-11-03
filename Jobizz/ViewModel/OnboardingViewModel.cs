using Jobizz.Model;
using Jobizz.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Jobizz.ViewModel
{
    public class OnboardingViewModel:BaseViewModel
    {
        #region Properties

        private string _buttonText = "Next";
        public string ButtonText
        {
            get => _buttonText;
            set => SetProperty(ref _buttonText, value);
        }

        private int _position;
        public int Position
        {
            get => _position;
            set => SetProperty(ref _position, value, onChanged: (() =>
            {
                if (value == IntroOnboarding.Count - 1)
                {
                    ButtonText = "Start";
                }
                else
                {
                    ButtonText = "Next";
                }
            }));
        }
       
        public ObservableCollection<OnboardingModel> IntroOnboarding { get; set; } = new ObservableCollection<OnboardingModel>();
        #endregion

        public OnboardingViewModel()
        {
            IntroOnboarding.Add(new OnboardingModel()
            {
                IntroTitle = "Sear you job",
                IntroDescription = "Figure out your top five priorities whether it is company culture, salary.",
                IntroImage = "searyou"

            });

            IntroOnboarding.Add(new OnboardingModel()
            {
                IntroTitle = "Browse jobs list",
                IntroDescription = "Our job list include several  industries, so you can find the best job for you.",
                IntroImage = "browser"

            });

            IntroOnboarding.Add(new OnboardingModel()
            {
                IntroTitle = "Apply to best jobs",
                IntroDescription = "You can apply to your desirable jobs very quickly and easily with ease.",
                IntroImage = "apply"

            });

            IntroOnboarding.Add(new OnboardingModel()
            {
                IntroTitle = "Make you career",
                IntroDescription = "We help you find your dream job       based on your skillset,    location demand.",
                IntroImage = "makeyou"

            });

            IntroOnboarding.Add(new OnboardingModel()
            {
                IntroTitle = "Search you dream job fast and ease",
                IntroDescription = "Figure out you top five priorities --    whether it is compagny culture,    salary or a specific job position ",
                IntroImage = "progress"

            });

            IntroOnboarding.Add(new OnboardingModel()
            {
                IntroTitle = "Make you dream career with job",
                IntroDescription = "We help you find dream job according to you skillset,  location & preference to build you career.",
                IntroImage = "work"

            });

        }

        public ICommand NextCommand => new Command(async () =>
        {
            if (Position >= IntroOnboarding.Count - 1)
            {
                await AppShell.Current.GoToAsync($"//{nameof(Homepage1)}");
            }
            else
            {
                Position += 1;
            }
        });

    }
}
