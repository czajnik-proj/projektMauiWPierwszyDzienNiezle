using projektMauiWPierwszyDzienNiezle.Model;
using projektMauiWPierwszyDzienNiezle.ViewModel;

namespace projektMauiWPierwszyDzienNiezle.View;

public partial class Glowna : ContentPage
{
	public Glowna()
	{
		InitializeComponent();
		BindingContext = new ViewModel.MealViewModel();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Button sender1 = sender as Button;
		Meal meal = sender1.BindingContext as Meal;
		
		
		Navigation.PushAsync(new NewPage1(meal));
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
		Button sender1 = sender as Button;
		Meal meal = sender1.BindingContext as Meal;
		MealViewModel bin = BindingContext as MealViewModel;
		bin.DeleteMeal(meal);
    }
}