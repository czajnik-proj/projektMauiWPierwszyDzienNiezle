using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektMauiWPierwszyDzienNiezle.Model
{
    [ObservableObject]
    public partial class Meal
    {
        [ObservableProperty]
        public string name;
        [ObservableProperty]
        public int kcal;
        [ObservableProperty]
        public int servings;

        public Meal(string name, int kcal, int servings)
        {
            Name = name;
            Kcal = kcal;
            Servings = servings;
        }
    }
}
