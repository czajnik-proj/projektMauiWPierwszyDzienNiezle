using CommunityToolkit.Mvvm.ComponentModel;
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
        public MealViewModel() {}

        public void AddMeal(Meal MealItem)
        {
            _MealCollection.Add(MealItem);
        }
        public void DeleteMeal(Meal MealItem)
        {
            int removeIndex = _MealCollection.IndexOf(MealItem);
            if (removeIndex != -1)
            {
                _MealCollection.RemoveAt(removeIndex);
            }
        }
        public void EditMeal(Meal MealItem, string name, int kcal, int servings)
        {
            int editIndex = _MealCollection.IndexOf(MealItem);
            if (editIndex != -1)
            {
                _MealCollection[editIndex] = new Meal(name, kcal, servings);
            }
        }

    }
}
