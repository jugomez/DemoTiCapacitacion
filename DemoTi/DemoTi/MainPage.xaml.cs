using Xamarin.Forms;

namespace DemoTi
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            try
            {
                busyInd.IsRunning = true;
                var service = new ProductService();
                var items = await service.GetAllProducts();
                Lista.ItemsSource = items;
                busyInd.IsRunning = false;
                base.OnAppearing();

            }
            catch (System.Exception ex)
            {
                await DisplayAlert("error", ex.Message, "OK");
            }
        }
    }
}
