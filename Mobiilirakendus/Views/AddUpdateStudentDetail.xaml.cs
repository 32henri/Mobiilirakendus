using Mobiilirakendus1.ViewModels;

namespace Mobiilirakendus1.Views;

public partial class AddUpdateStudentDetail : ContentPage
{
    public AddUpdateStudentDetail(AddUpdateStudentDetailViewModel viewModel)
    {
        InitializeComponent();
        this.BindingContext = viewModel;
    }
}