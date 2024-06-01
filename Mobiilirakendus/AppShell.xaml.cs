using Mobiilirakendus1.Views;

namespace Mobiilirakendus1;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(AddUpdateStudentDetail), typeof(AddUpdateStudentDetail));
    }
}
