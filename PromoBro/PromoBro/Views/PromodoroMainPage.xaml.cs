using Android.Media;
using PromoBro.Models.ViewModels;

namespace PromoBro.Views;

public partial class PromodoroMainPage : ContentPage
{
    public PromodoroMainPageViewModel promodoroMainPageViewViewModel { get; set; }
    public PromodoroMainPage()
    {
        InitializeComponent();
        promodoroMainPageViewViewModel = new PromodoroMainPageViewModel(); 
        BindingContext = promodoroMainPageViewViewModel; //Bind the data of the ViewModel
    }
    

    private void btnHistory_Clicked(object sender, EventArgs e)
    {
        //navigate to corresponding Page
        Shell.Current.GoToAsync(nameof(PromodoroHistoryPage));
    }

    private void btnTimer_Clicked(object sender, EventArgs e)
    {
        promodoroMainPageViewViewModel.RemainingTime = 1; 
    }
}