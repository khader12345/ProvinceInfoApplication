using assignment2muhammeduddin.ProvinceLogic;

namespace assignment2muhammeduddin;

public partial class ProvinceListPage : ContentPage
{
	public List<Province> Provinces {  get; set; }

	public ProvinceListPage()
	{
		InitializeComponent();
		Provinces = GetProvinces();
		BindingContext = this;

	}
	
	private List<Province> GetProvinces()
	{
		return new List<Province>
		{
			new Province { Name = "Ontario", Capital = "Toronto", FlagImagePath = "ontario.png" },
			new Province { Name = "Quebec", Capital = "Quebec City", FlagImagePath = "quebec.png" },
			new Province {Name = "Nova Scotia", Capital = "Halifax",
			FlagImagePath = "nova_scotia.png"},
			new Province {Name = "Manitoba", Capital = "Winnipeg", FlagImagePath = "manitoba.png"},
			new Province {Name = "Prince Edward Islands", Capital = "Charlottetown", FlagImagePath = "prince_edward_island.png"},
			new Province {Name  = "Saskatchewan", Capital = "Regina", FlagImagePath = "saskatchewan.png"},
			new Province {Name  = "Alberta", Capital = "Edmonton", FlagImagePath = "alberta.png"},
			new Province {Name  = "British Columbia", Capital = "Victoria", FlagImagePath = "british_columbia.png"},
			new Province {Name = "Newfoundland and Labrador", Capital = "St. Johns", FlagImagePath = "newfoundland_and_labrador.png"}



		};

    }
    private async void OnProvinceTapped(object sender, TappedEventArgs e)
    {
        if (e.Parameter is Province tappedProvince)
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
                    detailPage = new PrinceEdwardIslands(tappedProvince);
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

                    detailPage = new MainPage();
                    break;
            }

            if (detailPage != null)
            {
                await Navigation.PushAsync(detailPage);
            }

        }

    }

    private void DisplayList(Object sender, EventArgs e)
    {
        Navigation.PushAsync(new ProvinceListPage());
    }
}