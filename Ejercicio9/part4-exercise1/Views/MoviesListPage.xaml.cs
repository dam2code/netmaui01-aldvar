namespace MovieCatalog.Views
{
    public partial class MoviesListPage : ContentPage
    {
        public MoviesListPage()
        {
            InitializeComponent();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            // Obtén el objeto MovieViewModel de la selección de la lista
            ViewModels.MovieViewModel movie = (ViewModels.MovieViewModel)e.Item;

            // Navega a la página de detalle pasando el objeto movie
            await Navigation.PushAsync(new Views.MovieDetailPage(movie));
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            // Obtén el contexto del menu item (el modelo de película)
            MenuItem menuItem = (MenuItem)sender;
            ViewModels.MovieViewModel movie = (ViewModels.MovieViewModel)menuItem.BindingContext;

            // Llama al método para eliminar la película
            App.MainViewModel?.DeleteMovie(movie);
        }
    }
}
