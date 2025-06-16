using System.Collections.ObjectModel;
using System.Net.Http.Json;
using MauiApp1.Models;

namespace MauiApp1.Views;

public partial class MovieView : ContentPage
{
    HttpClient client = new HttpClient();
    ObservableCollection<Movie> movies = new ObservableCollection<Movie>();
    string apiUrl = "https://test01-b728.restdb.io/rest/movies?apikey=babe9772b258e7fb57cc9f74e99f56993bce3";
    public MovieView()
	{
		InitializeComponent();
        GetMovie();
    }
    private async void GetMovie()
    {

        var response = await client.GetAsync(apiUrl);
        movies = await response.Content.ReadFromJsonAsync<ObservableCollection<Movie>>();
        MoviesListView.ItemsSource = movies;
    }
}