using assignment2muhammeduddin.ProvinceLogic;
namespace assignment2muhammeduddin;

public partial class PrinceEdwardIsland : ContentPage
{
	public PrinceEdwardIsland(Provinces province)
	{
		InitializeComponent();
		BindingContext = province;
    }
}