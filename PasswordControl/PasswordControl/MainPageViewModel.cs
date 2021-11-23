using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PasswordControl
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand StamCmd { get; set; }

        public MainPageViewModel()
        {
            StamCmd = new Command(stam);
        }
        public void OnPropertyChanged(string propertyName)
        { 

            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public async void stam()
        {
            await ((App)Application.Current).MainPage.DisplayAlert("OK", "OK", "OK");
        }
    }
}
