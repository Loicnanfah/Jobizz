using Jobizz.ViewModel;

namespace Jobizz.View;

public partial class Homepage2 : ContentPage
{
	public Homepage2()
	{
		InitializeComponent();
        this.BindingContext = new JobListViewModel();
    }
}