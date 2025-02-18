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
            // Obt�n el objeto MovieViewModel de la selecci�n de la lista
            ViewModels.MovieViewModel movie = (ViewModels.MovieViewModel)e.Item;

            // Navega a la p�gina de detalle pasando el objeto movie
            await Navigation.PushAsync(new Views.MovieDetailPage(movie));
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            // Obt�n el contexto del menu item (el modelo de pel�cula)
            MenuItem menuItem = (MenuItem)sender;
            ViewModels.MovieViewModel movie = (ViewModels.MovieViewModel)menuItem.BindingContext;

            // Llama al m�todo para eliminar la pel�cula
            App.MainViewModel?.DeleteMovie(movie);
        }
    }
}
