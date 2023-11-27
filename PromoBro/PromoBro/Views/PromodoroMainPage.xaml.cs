namespace PromoBro.Views;

public partial class PromodoroMainPage : ContentPage
{
	public PromodoroMainPage()
	{
		InitializeComponent();
	}

    private void btnHistory_Clicked(object sender, EventArgs e)
    {
		//navigate to corresponding Page
		Shell.Current.GoToAsync(nameof(PromodoroHistoryPage));
    }
}