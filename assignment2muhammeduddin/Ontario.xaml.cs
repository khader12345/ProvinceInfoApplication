using assignment2muhammeduddin.ProvinceLogic;
namespace assignment2muhammeduddin;

public partial class Ontario : ContentPage
{
	public Ontario(Provinces porvince)
	{
		InitializeComponent();
        BindingContext = porvince;
    }
}