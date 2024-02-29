using assignment2muhammeduddin.ProvinceLogic;
namespace assignment2muhammeduddin;

public partial class NovaScotia : ContentPage
{
	public NovaScotia(Province porvince)
	{
		InitializeComponent();
		BindingContext = porvince;
	}
}