using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using projektMauiWPierwszyDzienNiezle.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void DeleteMeal(Meal MealItem)
        {
            int removeIndex = _MealCollection.IndexOf(MealItem);
            if (removeIndex != -1)
            {
                _MealCollection.RemoveAt(removeIndex);
            }
            updateCaloriesEaten();
        }
        [RelayCommand]
        public void EditMeal(Meal MealItem)
        {
            int editIndex = _MealCollection.IndexOf(MealItem);
            if (editIndex != -1)
            {
                Meal MealItemEdit = new Meal(nameBind, Convert.ToInt32(kcalBind), Convert.ToInt32(servingsBind));
                _MealCollection[editIndex] = MealItem;
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

            CaloriesEaten = totalTemp;
        }
    }
}
