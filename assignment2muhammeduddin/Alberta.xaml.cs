using assignment2muhammeduddin.ProvinceLogic;
namespace assignment2muhammeduddin;

public partial class Alberta : ContentPage
{
	public Alberta(Provinces province)
	{
		InitializeComponent();
		BindingContext = province;
	}
}