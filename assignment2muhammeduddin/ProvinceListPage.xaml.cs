using assignment2muhammeduddin.ProvinceLogic;

namespace assignment2muhammeduddin;

public partial class ProvinceListPage : ContentPage
{

    // A public property to hold a list of provinces
    public List<Provinces> Provinces { get; set; }

    public ProvinceListPage()
    {
        InitializeComponent(); // Initializes the page components
        Provinces = GetProvinces(); // Retrieves and assigns a list of Province objects
        BindingContext = this; // Sets the current instance as the context for data binding
    }

    // Method to create and return a list of Provinces with predefined data
    private List<Provinces> GetProvinces()
    {

        // Returns a list of hardcoded Provinces objects

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

    // Event handler for tapping on a province item
    private async void OnProvinceTapped(object sender, TappedEventArgs e)
    {
        if (e.Parameter is Provinces tappedProvince)
        {
            ContentPage detailPage = null;

            // Switch statement to navigate to the appropriate page based on the province selected

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

                // Case block for each province name that initializes a new page

                default:

                    // Default case to handle unspecified provinces, navigates to the main page

                    detailPage = new MainPage();
                    break;
            }

            // If a detail page has been created, navigate to that page

            if (detailPage != null)
            {
                await Navigation.PushAsync(detailPage);
            }


        }
    }

    // Event handler to display the list of provinces
    private void DisplayList(object sender, EventArgs e)
    {
        // Navigation to push a new instance of ProvinceListPage onto the navigation stack

        Navigation.PushAsync(new ProvinceListPage());
    }
}