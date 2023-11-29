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
        private int _remainingTime;
        public int RemainingTime 
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

        public string Description { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
