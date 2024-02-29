namespace assignment2muhammeduddin
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnDisplayClicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new ProvinceListPage());  
        }
    }

}
