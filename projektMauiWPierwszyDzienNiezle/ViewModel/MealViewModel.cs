using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using projektMauiWPierwszyDzienNiezle.Model;
using System.Collections.ObjectModel;

namespace projektMauiWPierwszyDzienNiezle.ViewModel
{
    internal partial class MealViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Meal> mealCollection = new();

        [ObservableProperty]
        private string nameBind;

        [ObservableProperty]
        private int kcalBind;

        [ObservableProperty]
        private int servingsBind;

        [ObservableProperty]
        private Meal selectedMeal;

        public MealViewModel() { }

        [RelayCommand]
        public void AddMeal()
        {
          //  mealCollection = new ObservableCollection<Meal>();
            var mealItem = new Meal(NameBind, KcalBind, ServingsBind);
            MealCollection.Add(mealItem);
            ClearForm();
        }

        [RelayCommand]
        public void DeleteMeall()
        {
            if (SelectedMeal != null && MealCollection.Contains(SelectedMeal))
            {
                MealCollection.Remove(SelectedMeal);
            }
        }

        [RelayCommand]
        public async Task StartEditt()
        {
            if (SelectedMeal == null) return;

            // ustaw dane formularza
            NameBind = SelectedMeal.Name;
            KcalBind = SelectedMeal.Kcal;
            ServingsBind = SelectedMeal.Servings;

            await Shell.Current.GoToAsync("Edycja");
        }

        [RelayCommand]
        public void SaveEdit()
        {
            if (SelectedMeal != null)
            {
                int index = MealCollection.IndexOf(SelectedMeal);
                if (index != -1)
                {
                    MealCollection[index] = new Meal(NameBind, KcalBind, ServingsBind);
                }
            }

            ClearForm();
            Shell.Current.GoToAsync("..");
        }

        private void ClearForm()
        {
            NameBind = string.Empty;
            KcalBind = 0;
            ServingsBind = 0;
            SelectedMeal = null;
        }
    }
}
