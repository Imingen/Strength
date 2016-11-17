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
using System.Net.Http;
using Newtonsoft.Json;

namespace Strength.App.ViewModels
{
    public class ExercisePageViewModel : ViewModelBase, INotifyPropertyChanged
    {
        
        public ObservableCollection<Excercise> Exercises { get; set; } = new ObservableCollection<Excercise>();
        public ObservableCollection<Category> categories { get; set; } = new ObservableCollection<Category>();
        
        public event PropertyChangedEventHandler PropertyChanged;

        public ExercisePageViewModel()
        {
            LoadExercises();
        }

        private async void LoadExercises()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(@"http://localhost:34117/api/");

                var json = await client.GetStringAsync("Excercises");

                Excercise[] exercises = JsonConvert.DeserializeObject<Excercise[]>(json);

                Exercises.Clear();
                foreach (var excercise in exercises)
                {
                    Exercises.Add(excercise);
                }
            }
        }
        
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


        public void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {

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
