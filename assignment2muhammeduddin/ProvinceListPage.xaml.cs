using assignment2muhammeduddin.ProvinceLogic;

namespace assignment2muhammeduddin;

public partial class ProvinceListPage : ContentPage
{
    public List<Provinces> Provinces { get; set; }

    public ProvinceListPage()
    {
        InitializeComponent();
        Provinces = GetProvinces(); // This method should return a list of Province objects with populated data
        BindingContext = this;
    }

    private List<Provinces> GetProvinces()
    {
        return new List<Provinces>
        {
            new Provinces {Name = "Ontario", Capital = "Toronto", FlagImagePath = "ontario.png" },
            new Provinces {Name = "Quebec", Capital = "Quebec City", FlagImagePath = "quebec.png" },
            new Provinces {Name = "Nova Scotia", Capital = "Halifax",
                FlagImagePath = "nova_scotia.png"},
            new Provinces {Name = "Manitoba", Capital = "Winnipeg", FlagImagePath = "manitoba.png"},
            new Provinces {Name = "Prince Edward Islands", Capital = "Charlottetown", FlagImagePath = "prince_edward_island.png"},
            new Provinces {Name  = "Saskatchewan", Capital = "Regina", FlagImagePath = "saskatchewan.png"},
            new Provinces {Name  = "Alberta", Capital = "Edmonton", FlagImagePath = "alberta.png"},
            new Provinces {Name  = "British Columbia", Capital = "Victoria", FlagImagePath = "british_columbia.png"},
            new Provinces {Name = "Newfoundland and Labrador", Capital = "St. Johns", FlagImagePath = "newfoundland_and_labrador.png"}



        };
    }
    private async void OnProvinceTapped(object sender, TappedEventArgs e)
    {
        if (e.Parameter is Provinces tappedProvince)
        {
            ContentPage detailPage = null;

            switch (tappedProvince.Name)
            {
                case "Ontario":
                    detailPage = new Ontario(tappedProvince);
                    break;
                case "Quebec":
                    detailPage = new Quebec(tappedProvince);
                    break;
                case "Nova Scotia":
                    detailPage = new NovaScotia(tappedProvince);
                    break;
                case "Manitoba":
                    detailPage = new Manitoba(tappedProvince);
                    break;
                case "Prince Edward Islands":
                    detailPage = new PrinceEdwardIsland(tappedProvince);
                    break;
                case "Saskatchewan":
                    detailPage = new Saskatchewan(tappedProvince);
                    break;
                case "Alberta":
                    detailPage = new Alberta(tappedProvince);
                    break;
                case "British Columbia":
                    detailPage = new BritishColumbia(tappedProvince);
                    break;
                case "Newfoundland and Labrador":
                    detailPage = new NewfoundlandAndLabrador(tappedProvince);
                    break;
                default:
                    // Optionally handle any other province that doesn't have a specific detail page
                    detailPage = new MainPage();
                    break;
            }

            if (detailPage != null)
            {
                await Navigation.PushAsync(detailPage);
            }


        }
    }

    private void DisplayList(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ProvinceListPage());
    }
}