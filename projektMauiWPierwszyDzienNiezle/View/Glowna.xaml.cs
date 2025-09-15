namespace projektMauiWPierwszyDzienNiezle.View;

public partial class Glowna : ContentPage
{
	public Glowna()
	{
		InitializeComponent();
		BindingContext = new ViewModel.MealViewModel();
	}
}