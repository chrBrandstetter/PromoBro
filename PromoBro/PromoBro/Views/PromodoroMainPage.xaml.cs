using PromoBro.Models.ViewModels;

namespace PromoBro.Views;

public partial class PromodoroMainPage : ContentPage
{
    public PromodoroMainPageViewModel promodoroMainPageViewViewModel { get; set; }

    private const int BIG_PROMO = 25 * 60;

    private string _defaultStartingTime; 

    public PromodoroMainPage()
    {
        InitializeComponent();
        promodoroMainPageViewViewModel = new PromodoroMainPageViewModel();

        _defaultStartingTime = promodoroMainPageViewViewModel.ConvertTime(BIG_PROMO);
        promodoroMainPageViewViewModel.RemainingTime = _defaultStartingTime;
        
        //Bind the data of the ViewModel
        BindingContext = promodoroMainPageViewViewModel;
    }

    private void btnHistory_Clicked(object sender, EventArgs e)
    {
        //navigate to corresponding Page
        Shell.Current.GoToAsync(nameof(PromodoroHistoryPage));
    }

    private void btnTimerStart_Clicked(object sender, EventArgs e)
    {
       promodoroMainPageViewViewModel.SetTimer(BIG_PROMO); 
    }

    private void btnTimerStop_Clicked(object sender, EventArgs e)
    {
        promodoroMainPageViewViewModel.StopTimer();
        promodoroMainPageViewViewModel.RemainingTime = _defaultStartingTime; 
    }
}