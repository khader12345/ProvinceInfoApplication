using assignment2muhammeduddin.ProvinceLogic;
namespace assignment2muhammeduddin;

public partial class BritishColumbia : ContentPage
{
	public BritishColumbia(Provinces province)
	{
		InitializeComponent();
        BindingContext = province;
    }
}