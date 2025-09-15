using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektMauiWPierwszyDzienNiezle.Model
{
    public partial class Meal
    {
        string name;
        int kcal;
        int servings;

        public string Name { get => name; set => name = value; }
        public int Kcal { get => kcal; set => kcal = value; }
        public int Servings { get => servings; set => servings = value; }


        public Meal(string name, int kcal, int servings)
        {
            Name = name;
            Kcal = kcal;
            Servings = servings;
        }
    }
}
