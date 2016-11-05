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
        public ObservableCollection<string> categories { get; set; } = new ObservableCollection<string>();



        public ExercisePageViewModel()
        {
            halla();
            Excercise pullup = new Excercise("Pullup", "Fuck the bar lil nigg nigg", "Back");
            Excercise deadlift = new Excercise("Deadlift", "Be alpha", "Back");
            Excercise bench = new Excercise("Bench", "Be alpha", "Chest");

            exercises.Add(pullup);
            exercises.Add(deadlift);
            exercises.Add(bench);
        }

        public void halla()
        {
            categories.Add("Back");
            categories.Add("Chest");
            categories.Add("Shoulder");
            categories.Add("Legs");
            categories.Add("Arms");
        }

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
    

    public void Create_btnClick1(string name, string description, string categ)
        {
            Excercise koko = new Excercise(name, description, categ);
            exercises.Add(koko);
        }

        public void Create_btnClick(object sender, RoutedEventArgs e)
        {
            Excercise koko = new Excercise(Name, Description, Category);
            exercises.Add(koko);
        }

        public async void ShowDialog_Click(object sender, RoutedEventArgs e)
        {
            CreateExercise_PopUp dialog = new CreateExercise_PopUp();
            await dialog.ShowAsync();
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
