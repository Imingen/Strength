using Strength.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;

namespace Strength.App.ViewModels
{
   public class WorkoutPageViewModel : ViewModelBase, INotifyPropertyChanged
    {
        public ObservableCollection<Workout> workouts { get; set; } = new ObservableCollection<Workout>();

        Workout pleb = new Workout("pleb");
        Excercise ko = new Excercise("he", "heheh", "hehehe");
        Excercise bench = new Excercise("Bench", "Be alpha", "Chest");

        public WorkoutPageViewModel()
        {
            gege();
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if(value != this.name)
                {
                    name = value;
                    NotifyPropertyChanged("Name");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public void gege()
        {


            pleb.Exercises.Add(bench);
        }
        public void createWorkout()
        {
            Workout hei = new Workout(name);
            workouts.Add(hei);
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
