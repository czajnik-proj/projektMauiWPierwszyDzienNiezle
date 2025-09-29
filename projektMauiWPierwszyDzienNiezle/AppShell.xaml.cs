using projektMauiWPierwszyDzienNiezle.View;

namespace projektMauiWPierwszyDzienNiezle
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("Edycja", typeof(Edycja));
        }
    }
}
