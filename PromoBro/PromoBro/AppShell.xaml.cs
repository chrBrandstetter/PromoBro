using PromoBro.Views;

namespace PromoBro
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            //Routing between Pages
            Routing.RegisterRoute(nameof(PromodoroMainPage), typeof(PromodoroMainPage));
            Routing.RegisterRoute(nameof(PromodoroHistoryPage), typeof(PromodoroHistoryPage));
        }
    }
}
