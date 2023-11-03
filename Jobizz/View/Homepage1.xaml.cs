using Jobizz.ViewModel;

namespace Jobizz.View;

public partial class Homepage1 : ContentPage
{
	public Homepage1()
	{
		InitializeComponent();
        this.BindingContext = new JobListViewModel();

    }

    private void Editor_TextChanged(object sender, TextChangedEventArgs e)
    {

    }
}