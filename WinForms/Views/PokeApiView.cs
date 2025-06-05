using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using WinForms.Models.PokeApi;

namespace WinForms.Views
{
    public partial class PokeApiView : Form
    {
        string url = "https://pokeapi.co/api/v2/pokemon?limit=10000";
        HttpClient _httpClient;
        Root _lstPokemon;
        bool _cbxCargado = false;

        public PokeApiView()
        {
            InitializeComponent();
            _lstPokemon = new();
            _httpClient = new HttpClient();
        }

        private async void PokeApiView_Load(object sender, EventArgs e)
        {
           await ObtenerPokemon();
        }

        private async Task ObtenerPokemon()
        {
            try
            {
                var response = await _httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    _lstPokemon = await response.Content.ReadFromJsonAsync<Root>();
                    if (_lstPokemon?.results != null)
                    {
                        cbxPokemons.DataSource = _lstPokemon.results;
                        cbxPokemons.DisplayMember = "name";
                        cbxPokemons.ValueMember = "url";
                        _cbxCargado = true;
                        cbxPokemons.SelectedIndex = 0;
                        await CargarPokemon();
                        var autoComplete = new AutoCompleteStringCollection();
                        autoComplete.AddRange(_lstPokemon.results.Select(p => p.name).ToArray());
                        cbxPokemons.AutoCompleteCustomSource = autoComplete;
                    }

                }
                else
                {
                    MessageBox.Show("Error al obtener la lista de Pokémon");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private async Task CargarPokemon()
        {
            
            try
            {
                var urlPokemon = cbxPokemons.SelectedValue?.ToString();
                if (string.IsNullOrWhiteSpace(urlPokemon)) return;

                var response = await _httpClient.GetAsync(urlPokemon);
                if (response.IsSuccessStatusCode)
                {
                    var pokemon = await response.Content.ReadFromJsonAsync<Pokemon>();
                    pictureBox1.Load(pokemon?.Sprites?.front_default);
                    lblAbility1.Text = pokemon.Abilities.Count > 1 ? pokemon.Abilities[0].ability.name : "N/A";
                    lblAbility2.Text = pokemon.Abilities.Count > 2 ? pokemon.Abilities[1].ability.name : "N/A";
                    lblAbility3.Text = pokemon.Abilities.Count > 3 ? pokemon.Abilities[2].ability.name : "N/A";
                    lblAbility4.Text = pokemon.Abilities.Count > 4 ? pokemon.Abilities[3].ability.name : "N/A";
                    lblAbility5.Text = pokemon.Abilities.Count > 5 ? pokemon.Abilities[4].ability.name : "N/A";



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el Pokémon: {ex.Message}");
            }

        }

        private async void cbxPokemons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_cbxCargado) return;
            await CargarPokemon();

        }

    }
 }

