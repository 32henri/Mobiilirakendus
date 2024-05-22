namespace Mobiilirakendus
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnAsjadClicked(object sender, EventArgs e)
        {
            var asjadPage = new AsjadPage();
            await Navigation.PushAsync(asjadPage);
        }
    }

}
