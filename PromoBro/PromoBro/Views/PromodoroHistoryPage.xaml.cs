namespace PromoBro.Views;

public partial class PromodoroHistoryPage : ContentPage
{
	public PromodoroHistoryPage()
	{
		InitializeComponent();
	}

    private void btnBack_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync($"//{nameof(PromodoroMainPage)}"); //navigates back to the parent page
    }
}