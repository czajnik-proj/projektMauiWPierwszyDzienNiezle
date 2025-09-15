using projektMauiWPierwszyDzienNiezle.Model;
using projektMauiWPierwszyDzienNiezle.ViewModel;

namespace projektMauiWPierwszyDzienNiezle.View;

public partial class NewPage1 : ContentPage
{
	Meal meal_to_edit = null;
	public NewPage1(Meal meal)
	{
		
		InitializeComponent();
        meal_to_edit = meal;
        name_entry.Text = meal_to_edit.Name;
        servings_entry.Text = meal_to_edit.Servings.ToString();
        kcal_entry.Text = meal_to_edit.Kcal.ToString();
    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        
		meal_to_edit.Name = name_entry.Text;

        int.TryParse(servings_entry.Text, out int value1);
        meal_to_edit.Servings = value1;

        int.TryParse(kcal_entry.Text, out int value2);
        meal_to_edit.Kcal = value2;
        
        
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        MealViewModel vm = new MealViewModel();
        vm.EditMeal(meal_to_edit);
        Shell.Current.GoToAsync("..");
    }
}