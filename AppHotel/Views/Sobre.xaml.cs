namespace AppHotel.Views;

public partial class Sobre : ContentPage
{
	public Sobre()
	{
		InitializeComponent();
	}

    private void VoltarTela_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}