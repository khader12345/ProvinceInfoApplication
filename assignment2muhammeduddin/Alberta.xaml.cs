using assignment2muhammeduddin.ProvinceLogic;
namespace assignment2muhammeduddin;

public partial class Alberta : ContentPage
{
	public Alberta(Province province)
	{
		InitializeComponent();
		BindingContext = province;
	}
}