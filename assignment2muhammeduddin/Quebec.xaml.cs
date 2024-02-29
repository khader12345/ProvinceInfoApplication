using assignment2muhammeduddin.ProvinceLogic;
namespace assignment2muhammeduddin;

public partial class Quebec : ContentPage
{
	public Quebec(Province province)
	{
		InitializeComponent();
		BindingContext = province;
	}
}