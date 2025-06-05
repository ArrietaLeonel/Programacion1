using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Models.Clima;
using WinForms.Models.Pelicula;

namespace WinForms.VIews
{
    public partial class PeliculasView : Form
    {
        public PeliculasView()
        {
            InitializeComponent();
            GetMovie();
        }
        private async void  GetMovie()
        {
            const string apiUrl = "https://test01-b728.restdb.io/rest/movies?apikey=babe9772b258e7fb57cc9f74e99f56993bce3";
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(apiUrl);
                    List<Movie> movies = await response.Content.ReadFromJsonAsync<List<Movie>>();

                    dgvMovie.DataSource = movies;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener películas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
