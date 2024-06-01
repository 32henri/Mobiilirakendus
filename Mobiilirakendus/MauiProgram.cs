using Mobiilirakendus1.Services;
using Mobiilirakendus1.ViewModels;
using Mobiilirakendus1.Views;

namespace Mobiilirakendus1;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        // Services
        builder.Services.AddSingleton<IStudentService, StudentService>();


        //Views Registration
        builder.Services.AddSingleton<StudentListPage>();
        builder.Services.AddTransient<AddUpdateStudentDetail>();


        //View Modles 
        builder.Services.AddSingleton<StudentListPageViewModel>();
        builder.Services.AddTransient<AddUpdateStudentDetailViewModel>();


        return builder.Build();
    }
}
