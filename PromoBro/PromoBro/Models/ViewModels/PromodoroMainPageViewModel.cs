using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromoBro.Models.ViewModels
{
    public class PromodoroMainPageViewModel : INotifyPropertyChanged
    {
        private string? _remainingTime;

        private static System.Timers.Timer? _timer;

        private int _promodoroCountdown;

        public string RemainingTime 
        {
            get 
            { 
                return _remainingTime; 
            }
            set
            {
                _remainingTime = value;
                OnPropertyChanged(nameof(RemainingTime));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void SetTimer(int time)
        {
            _promodoroCountdown = time; 
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
            RemainingTime = ConvertTime(_promodoroCountdown);
        }

        public void StopTimer()
        {
            _timer?.Stop();
        }

        public string ConvertTime(int time)
        {
            TimeSpan convertedTime = TimeSpan.FromSeconds(time);
            string convertedTimeFormat = convertedTime.ToString(@"mm\:ss");
            return convertedTimeFormat;
        }
    }
}
