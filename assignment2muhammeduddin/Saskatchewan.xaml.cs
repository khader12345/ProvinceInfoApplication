using assignment2muhammeduddin.ProvinceLogic;
namespace assignment2muhammeduddin;

public partial class Saskatchewan : ContentPage
{
	public Saskatchewan(Provinces province)
	{
		InitializeComponent();
        BindingContext = province;
    }
}