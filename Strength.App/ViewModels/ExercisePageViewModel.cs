using Template10.Mvvm;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Template10.Services.NavigationService;
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;
using Strength.Models;
using System.ComponentModel;
using Strength.App.Views;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Strength.App.ViewModels
{
    public class ExercisePageViewModel : ViewModelBase, INotifyPropertyChanged
    {
        public ObservableCollection<Excercise> exercises { get; set; } = new ObservableCollection<Excercise>();
        public ObservableCollection<Category> categories { get; set; } = new ObservableCollection<Category>();
        
        public event PropertyChangedEventHandler PropertyChanged;


        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value != this.name)
                {
                    name = value;
                    NotifyPropertyChanged("Name");
                }
            }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set
            {
                if(value != this.description)
                {
                    description = value;
                    NotifyPropertyChanged("Description");
                }
            }
        }

        private string category;

        public string Category
        {
            get { return category; }
            set
            {
                if(value != category)
                {
                    category = value;
                    NotifyPropertyChanged("Category");
                }
            }
        }




        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    

        public void GotoDetailsPage() =>
          NavigationService.Navigate(typeof(Views.DetailPage));

        public void GotoSettings() =>
            NavigationService.Navigate(typeof(Views.SettingsPage), 0);

        public void GotoPrivacy() =>
            NavigationService.Navigate(typeof(Views.SettingsPage), 1);

        public void GotoAbout() =>
            NavigationService.Navigate(typeof(Views.SettingsPage), 2);
    }
}
