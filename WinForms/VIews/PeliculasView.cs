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
        HttpClient client = new HttpClient();
        List<Movie> movies = new List<Movie>();
        string apiUrl = "https://test01-b728.restdb.io/rest/movies?apikey=babe9772b258e7fb57cc9f74e99f56993bce3";
        public PeliculasView()
        {
            InitializeComponent();
            GetMovie();
        }
        private async void GetMovie()
        {

            var response = await client.GetAsync(apiUrl);
            movies = await response.Content.ReadFromJsonAsync<List<Movie>>();

            dgvMovie.DataSource = movies;

        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            Movie movieSelected = (Movie)dgvMovie.SelectedRows[0].DataBoundItem;
            if (dgvMovie.RowCount > 0 && dgvMovie.SelectedRows.Count > 0)
            {
                var response = MessageBox.Show($"¿Seguro que desea eliminar la película \"{movieSelected.title}\" seleccionada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (response == DialogResult.Yes)
                {
                    string apiUrl = $"https://test01-b728.restdb.io/rest/movies/{movieSelected._id}?apikey=babe9772b258e7fb57cc9f74e99f56993bce3";
                    var responseDelete = await client.DeleteAsync(apiUrl);
                    if (!responseDelete.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Error al eliminar la película", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show($"Película {movieSelected.title} eliminada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Actualizar la lista de películas
                    GetMovie();
                }
            }
            else
            {
                var response = MessageBox.Show("Debe seleccionar una película para eliminar", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMovie_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMovie.RowCount > 0 && dgvMovie.SelectedRows.Count > 0)
            {
                MessageBox.Show("Hello");
            }
        }

        private void dgvMovie_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMovie.RowCount > 0 && dgvMovie.SelectedRows.Count > 0)
            {
                Movie movieSelected = (Movie)dgvMovie.SelectedRows[0].DataBoundItem;
                picboxMovie.ImageLocation = movieSelected.cover;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvMovie.DataSource = movies.Where(m => m.title.ToLower().Contains(txtBuscar.Text, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                btnBuscar.PerformClick();
            }
        }
    }
}
