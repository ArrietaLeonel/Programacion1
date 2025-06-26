using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using WinForms.Models.Pelicula;

namespace WinForms.Services
{
    public class PeliculaService
    {

        string apiUrl = "https://test01-b728.restdb.io/rest/movies?apikey=babe9772b258e7fb57cc9f74e99f56993bce3";

        public async Task<List<Movie>?> GetAllAsync()
        {
            using (HttpClient client = new())
            {
                var response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<List<Movie>>();
                }
                else
                {
                    throw new Exception("Error al obtener las películas");
                }
            }
        }
        public async Task<bool> DeleteAsync(string? id)
        {
            using (HttpClient client = new())
            {
                string deleteUrl = $"https://test01-b728.restdb.io/rest/movies/{id}?apikey=babe9772b258e7fb57cc9f74e99f56993bce3";
                var responseDelete = await client.DeleteAsync(deleteUrl);
                if (responseDelete.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al borrar película");
                }

            }
        }
        public async Task<bool> UpdateAsync(Movie movie)
        {
            using (HttpClient client = new())
            {
                string updateUrl = $"https://test01-b728.restdb.io/rest/movies/{movie._id}?apikey=babe9772b258e7fb57cc9f74e99f56993bce3";
                var response = await client.PutAsJsonAsync(updateUrl, movie);
                if (response.IsSuccessStatusCode)
                    return true;
                else
                    throw new Exception("Ah ocurrido un error al modificar");
            }
        }
        public async Task<bool> AddAsync(Movie movie)
        {
            string AddUrl = $"https://test01-b728.restdb.io/rest/movies/?apikey=babe9772b258e7fb57cc9f74e99f56993bce3";
            using(HttpClient client = new())
            {
                var response = await client.PostAsJsonAsync(AddUrl, movie);
                if (response.IsSuccessStatusCode)
                    return true;
                else
                    throw new Exception("Ah ocurrido un error al agregar");
            }
        }
    }
}
