using assignment2muhammeduddin.ProvinceLogic;
namespace assignment2muhammeduddin;

public partial class NewfoundlandAndLabrador : ContentPage
{
	public NewfoundlandAndLabrador(Provinces province)
	{
		InitializeComponent();
        BindingContext = province;
    }
}