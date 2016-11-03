using Template10.Mvvm;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Template10.Services.NavigationService;
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;
using Strength.Models;
using static Strength.Models.Excercise;

namespace Strength.App.ViewModels
{
   public class ExercisePageViewModel :ViewModelBase
    {
        public ObservableCollection<Excercise> exercises { get; set; } = new ObservableCollection<Excercise>();

        public ObservableCollection<Category> categories { get; set; } = new ObservableCollection<Category>(Enum.GetValues(typeof(Category)).Cast<Category>().ToList());



        Excercise pullup = new Excercise(1, "Pullup", "Fuck the bar lil nigg nigg", Excercise.Category.Back);
        Excercise deadlift = new Excercise(2, "Deadlift", "Be alpha", Excercise.Category.Back);

        public ExercisePageViewModel()
        {
            halla();
        }


        public void halla()
        {
            exercises.Add(pullup);
            exercises.Add(deadlift);
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
