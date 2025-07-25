﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Models.FavGames;

namespace WinForms.Views
{
    public partial class FavGamesView : Form
    {
        HttpClient client = new HttpClient();
        string Url = "https://favgames-5d9a.restdb.io/rest/games?apikey=73b01da2bd6e85dd1edb5be519d86352de207";
        List<Game> games = new List<Game>();
        Game game = new Game();

        public FavGamesView()
        {
            InitializeComponent();
            GetGames();
        }

        private async void GetGames()
        {
            try
            {
                games = await client.GetFromJsonAsync<List<Game>>(Url);
               
                dgvGames.DataSource = games;
            }
            catch
            {
                MessageBox.Show("Error al obtener los juegos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            CleanFields();
            CleanObject();
            tabControlFavGames.SelectTab(AgregarEditar);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvGames.RowCount > 0 && dgvGames.SelectedRows.Count > 0)
            {
                game = (Game)dgvGames.SelectedRows[0].DataBoundItem;
                txtTitle.Text = game.title;
                txtPlatform.Text = game.platform;
                txtGenre.Text = game.genre;
                txtImageUrl.Text = game.imageUrl;
                nUDReleaseYear.Value = game.releaseYear;
                tabControlFavGames.SelectTab(AgregarEditar);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un juego para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvGames.RowCount > 0 && dgvGames.SelectedRows.Count > 0)
            {
                game = (Game)dgvGames.SelectedRows[0].DataBoundItem;
                var response = MessageBox.Show($"¿Seguro que desea eliminar el juego \"{game.title}\" seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (response == DialogResult.Yes)
                {
                    string apiUrl = $"https://favgames-5d9a.restdb.io/rest/games/{game._id}?apikey=73b01da2bd6e85dd1edb5be519d86352de207";
                    var responseDelete = await client.DeleteAsync(apiUrl);
                    if (!responseDelete.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Error al eliminar el juego", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show($"Juego {game.title} eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetGames();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un juego para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dgvGames_SelectionChanged(object sender, EventArgs e)
        {
            pictureBoxList.ImageLocation = dgvGames.SelectedRows.Count > 0 ? ((Game)dgvGames.SelectedRows[0].DataBoundItem).imageUrl : null;
        }
        private void txtbSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbSearch.Text))
            {
                GetGames();
            }
            else
            {
                var filteredGames = games.Where(g => g.title.Contains(txtbSearch.Text, StringComparison.OrdinalIgnoreCase)).ToList();
                dgvGames.DataSource = filteredGames;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            games = games.Where(g => g.title.Contains(txtbSearch.Text)).ToList();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CleanFields()
        {
            txtTitle.Text = string.Empty;
            txtPlatform.Text = string.Empty;
            txtGenre.Text = string.Empty;
            txtImageUrl.Text = string.Empty;
            nUDReleaseYear.Value = 0;
        }
        private void CleanObject()
        {
            game = new Game();
        }

        private void txtImageUrl_TextChanged(object sender, EventArgs e)
        {
            pictureBoxAddEdit.ImageLocation = txtImageUrl.Text;

        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                game.title = txtTitle.Text;
                game.platform = txtPlatform.Text;
                game.genre = txtGenre.Text;
                game.imageUrl = txtImageUrl.Text;
                game.releaseYear = (int)nUDReleaseYear.Value;
                if (string.IsNullOrEmpty(game._id))
                {

                    var response = await client.PostAsJsonAsync(Url, game);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Juego agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el juego", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {

                    string apiUrl = $"https://favgames-5d9a.restdb.io/rest/games/{game._id}?apikey=73b01da2bd6e85dd1edb5be519d86352de207";
                    var response = client.PutAsJsonAsync(apiUrl, game).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Juego actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el juego", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                GetGames();
                CleanFields();
                CleanObject();
                tabControlFavGames.SelectTab(Lista);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            CleanFields();
            CleanObject();
            tabControlFavGames.SelectTab(Lista);
        }

    }
}
