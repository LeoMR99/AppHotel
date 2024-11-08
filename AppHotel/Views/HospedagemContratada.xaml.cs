namespace AppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();
	}

    private void VoltarAv_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PopAsync();
		}
		catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "OK");
			
		}
    }
}