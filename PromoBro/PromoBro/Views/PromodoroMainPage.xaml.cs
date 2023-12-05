using PromoBro.Models.ViewModels;

namespace PromoBro.Views;

public partial class PromodoroMainPage : ContentPage
{
    public PromodoroMainPageViewModel promodoroMainPageViewViewModel { get; set; }

    private static System.Timers.Timer _timer;

    private const int BIG_PROMO = 25 * 60;

    private int _promodoroCountdown;

    private TimeSpan _convertedTime;


    public PromodoroMainPage()
    {
        InitializeComponent();
        promodoroMainPageViewViewModel = new PromodoroMainPageViewModel();

        //Bind the data of the ViewModel
        BindingContext = promodoroMainPageViewViewModel;
        _promodoroCountdown = BIG_PROMO; 
        
        promodoroMainPageViewViewModel.RemainingTime = ConvertTime(_promodoroCountdown); 

    }

    private string ConvertTime(int time)
    {
        _convertedTime = TimeSpan.FromSeconds(time);
        string convertedTimeFormat = _convertedTime.ToString(@"mm\:ss"); 
        return convertedTimeFormat;
    }
    

    private void btnHistory_Clicked(object sender, EventArgs e)
    {
        //navigate to corresponding Page
        Shell.Current.GoToAsync(nameof(PromodoroHistoryPage));
    }

    private void btnTimerStart_Clicked(object sender, EventArgs e)
    {
        SetTimer(); 
    }

    private void SetTimer()
    {
        //the timer should tick every second
        _timer = new System.Timers.Timer(1000);

        _timer.Elapsed += timerElapsed;

        _timer.Start();
    }

    public void timerElapsed(object sender, EventArgs e)
    {
        //decreas the coundtown by one second
        _promodoroCountdown--;
       
        //display the time in the MainPage
        promodoroMainPageViewViewModel.RemainingTime = ConvertTime(_promodoroCountdown);
    }

    private void btnTimerStop_Clicked(object sender, EventArgs e)
    {
        _timer.Stop();
        _promodoroCountdown = BIG_PROMO; 
        promodoroMainPageViewViewModel.RemainingTime = ConvertTime(_promodoroCountdown);
    }
}