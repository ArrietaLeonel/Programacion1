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
using WinForms.Services;

namespace WinForms.Views
{
    public partial class PeliculasADOView : Form
    {
        PeliculaADOService service = new();
        Movie movie = new Movie();
        List<Movie>? movies;
        public PeliculasADOView()
        {
            InitializeComponent();
            GetMovie();
        }
        private async void GetMovie()
        {   
            movies = await service.GetAllAsync();
            dgvMovie.DataSource = movies;
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            movie = (Movie)dgvMovie.SelectedRows[0].DataBoundItem;
            if (dgvMovie.RowCount > 0 && dgvMovie.SelectedRows.Count > 0)
            {
                var response = MessageBox.Show($"¿Seguro que desea eliminar la película \"{movie.title}\" seleccionada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (response == DialogResult.Yes)
                {

                    if (!await service.DeleteAsync(movie.id))
                    {
                        MessageBox.Show("Error al eliminar la película", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    lblStatusMessage.Text = $"Película {movie.title} eliminada correctamente.";
                    timerStatusBar.Enabled = true;

                    GetMovie();
                }
            }
            else
            {
                var response = MessageBox.Show("Debe seleccionar una película para eliminar", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
            limpiarCampos();
            limpiarObjeto();
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dgvMovie_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMovie.RowCount > 0 && dgvMovie.SelectedRows.Count > 0)
            {
                movie = (Movie)dgvMovie.SelectedRows[0].DataBoundItem;
                picboxMovie.ImageLocation = movie.cover;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            limpiarObjeto();
            tabControl1.SelectedTab = tabPageAgrMod;


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            tabControl1.SelectedTab = tabPageLista;

        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbTitle.Text) || string.IsNullOrEmpty(txtbCover.Text) || numericUpDownDuration.Value == 0)
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            movie.title = txtbTitle.Text;
            movie.cover = txtbCover.Text;
            movie.duration = (int)numericUpDownDuration.Value;
            movie.qualification = (float)numericUpDownQualification.Value;
            if (string.IsNullOrEmpty(movie._id))
            {
                
                if (!await service.AddAsync(movie))
                {
                    MessageBox.Show("Error al agregar la película", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                lblStatusMessage.Text = $"Pelicula modificada correctamente";
                timerStatusBar.Enabled = true;
            }
            else
            {
                
                
                if (!await service.UpdateAsync(movie))
                {
                    MessageBox.Show("Error al actualizar la película", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                lblStatusMessage.Text = $"Pelicula agregada correctamente";
                timerStatusBar.Enabled = true;
            }
            limpiarCampos();
            limpiarObjeto();
            GetMovie();
            tabControl1.SelectedTab = tabPageLista;

        }



        private void btnModificar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageAgrMod;
            if (dgvMovie.RowCount > 0 && dgvMovie.SelectedRows.Count > 0)
            {
                movie = (Movie)dgvMovie.SelectedRows[0].DataBoundItem;
                txtbTitle.Text = movie.title;
                txtbCover.Text = movie.cover;
                numericUpDownDuration.Value = movie.duration;
                numericUpDownQualification.Value = (decimal)movie.qualification;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una película para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void limpiarCampos()
        {
            txtbTitle.Text = string.Empty;
            txtbCover.Text = string.Empty;
            numericUpDownDuration.Value = 0;
            numericUpDownQualification.Value = 0;
            picboxMovie.ImageLocation = string.Empty;
            txtbSearch.Text = string.Empty;

        }
        private void limpiarObjeto()
        {
            movie._id = null;
            movie.title = string.Empty;
            movie.cover = string.Empty;
            movie.duration = 0;
            movie.qualification = 0;
        }

        private void txtbSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbSearch.Text))
            {
                GetMovie();
            }
            btnBuscar.PerformClick();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (movies == null)
            {
                MessageBox.Show("No hay películas cargadas para buscar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvMovie.DataSource = movies.Where(m => m.title.ToLower().Contains(txtbSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        private void timerStatusBar_Tick(object sender, EventArgs e)
        {
            lblStatusMessage.Text = string.Empty;
            timerStatusBar.Enabled = false;
        }
    }
}
