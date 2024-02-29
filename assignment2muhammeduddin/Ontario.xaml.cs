using assignment2muhammeduddin.ProvinceLogic;
namespace assignment2muhammeduddin;

public partial class Ontario : ContentPage
{
	public Ontario(Provinces province)
	{
		InitializeComponent();
        BindingContext = province;
    }
}