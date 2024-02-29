using assignment2muhammeduddin.ProvinceLogic;
namespace assignment2muhammeduddin;

public partial class Manitoba : ContentPage
{
	public Manitoba(Provinces province)
	{
		InitializeComponent();
        BindingContext = province;
    }
}