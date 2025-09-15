using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektMauiWPierwszyDzienNiezle.Model
{
    internal partial class Meal
    {
        public string Name { get; set; }
        public int Kcal {  get; set; }
        public int Servings { get; set; }

        public Meal(string name, int kcal, int servings)
        {
            Name = name;
            Kcal = kcal;
            Servings = servings;
        }
    }
}
