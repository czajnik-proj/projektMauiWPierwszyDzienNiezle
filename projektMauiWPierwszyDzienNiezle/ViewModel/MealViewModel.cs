using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using projektMauiWPierwszyDzienNiezle.Model;
using System.Collections.ObjectModel;

namespace projektMauiWPierwszyDzienNiezle.ViewModel
{
    internal partial class MealViewModel : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Meal> _MealCollection = new ObservableCollection<Meal>();
        [ObservableProperty]
        public string nameBind;
        [ObservableProperty]
        public int kcalBind;
        [ObservableProperty]
        public int servingsBind;
        [ObservableProperty]
        public double caloriesEaten;

        public MealViewModel() {}
        [RelayCommand]
        public void AddMeal()
        {
            Meal MealItem = new Meal(nameBind, Convert.ToInt32(kcalBind), Convert.ToInt32(servingsBind));
            _MealCollection.Add(MealItem);
            updateCaloriesEaten();
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
                _MealCollection.RemoveAt(removeIndex);
            }
            updateCaloriesEaten();
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
            updateCaloriesEaten();
        }
        public void updateCaloriesEaten()
        {
            double totalTemp = 0;
            foreach (var meal in _MealCollection)
            {
                double kcalTemp = Convert.ToDouble(meal.Kcal);
                double servingsTemp = Convert.ToDouble(meal.Servings);
                totalTemp += kcalTemp * servingsTemp;
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
            CaloriesEaten = totalTemp;
        }
    }
}
