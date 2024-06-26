using Mobiilirakendus1.ViewModels;

namespace Mobiilirakendus1.Views;

public partial class StudentListPage : ContentPage
{
    private StudentListPageViewModel _viewMode;
    public StudentListPage(StudentListPageViewModel viewModel)
	{
		InitializeComponent();
        _viewMode = viewModel;
        this.BindingContext = viewModel;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _viewMode.GetStudentListCommand.Execute(null);
    }
}