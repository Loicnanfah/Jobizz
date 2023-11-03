using Jobizz.ViewModel;

namespace Jobizz.View;

public partial class OnboardingView : ContentPage
{
	public OnboardingView()
	{
		InitializeComponent();
        this.BindingContext = new OnboardingViewModel();

    }
}