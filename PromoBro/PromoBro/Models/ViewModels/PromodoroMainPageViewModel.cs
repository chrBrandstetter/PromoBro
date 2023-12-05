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
    }
}
