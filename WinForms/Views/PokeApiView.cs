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
        Ability habilidadDesc;
        bool _cbxCargado = false;
        List<Label> _lstlabelAbility;
        List<Label> _lstlabelStatValue;
        List<Label> _lstlabelStat2Name;
        List<FlavorTextEntry> _description;

        public PokeApiView()
        {
            InitializeComponent();
            _lstPokemon = new();
            _httpClient = new HttpClient();
            _lstlabelAbility = new List<Label>()
            {
                lblAbility1,
                lblAbility2,
                lblAbility3,
                lblAbility4,
                lblStat
            };
            _lstlabelStatValue = new List<Label>()
            {
                lblStat1b,
                lblStat2b,
                lblStat3b,
                lblStat4b,
                lblStat5b,
                lblStat6b
            };
            _lstlabelStat2Name = new List<Label>()
            {
                lblStat1,
                lblStat2,
                lblStat3,
                lblStat4,
                lblStat5,
                lblStat6
            };
        }

        private async void PokeApiView_Load(object sender, EventArgs e)
        {
            await ObtenerPokemonAsync();
        }

        private async Task ObtenerPokemonAsync()
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
                        await CargarPokemonAsync();
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
        private async Task CargarPokemonAsync()
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

                    for (int i = 0; i < pokemon.Abilities.Count; i++)
                    {


                        _lstlabelAbility[i].Text = pokemon.Abilities[i].ability.name;
                    }
                    for (int i = 0; i < pokemon.Stats.Count; i++)
                    {
                        _lstlabelStat2Name[i].Text = pokemon.Stats[i].stat.name;
                        _lstlabelStatValue[i].Text = pokemon.Stats[i].base_stat.ToString();
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el Pokémon: {ex.Message}");
            }

        }
        private async Task ObtenerHabilidad(string abilityName)
        {
            try
            {
                var urlAbility = $"https://pokeapi.co/api/v2/ability/{abilityName}";
                var response = await _httpClient.GetAsync(urlAbility);

                if (response.IsSuccessStatusCode)
                {
                    var habilidad = await response.Content.ReadFromJsonAsync<Ability>();

                    if (habilidad == null)
                        return;

                    habilidadDesc = habilidad;

                }
                else
                {
                    MessageBox.Show("Error al obtener la habilidad del Pokémon");
                }
            }
            catch (Exception ex)
            {

            }
        }
        private async void cbxPokemons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_cbxCargado) return;
            await CargarPokemonAsync();

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            cbxPokemons.SelectedIndex = new Random().Next(0, cbxPokemons.Items.Count);
        }

        private async void lblAbility1_MouseHover(object sender, EventArgs e)
        {
            await ObtenerHabilidad(lblAbility1.Text);
            // Devuelve desc español
            var descripcion = string.Join(
                Environment.NewLine,
                habilidadDesc.flavor_text_entries
                .Where(x => x.language.name == "es")
                .Select(x => x.flavor_text)
                .Distinct()
            );
            ToolTip toolTipDescripcionEspañol = new ToolTip();
            toolTipDescripcionEspañol.SetToolTip(lblAbility1, descripcion);
        }

        private async void lblAbility2_MouseHover(object sender, EventArgs e)
        {
            await ObtenerHabilidad(lblAbility2.Text);
            // Devuelve desc español
            var descripcion = string.Join(
                Environment.NewLine,
                habilidadDesc.flavor_text_entries
                .Where(x => x.language.name == "es")
                .Select(x => x.flavor_text)
                .Distinct()
            );
            ToolTip toolTipDescripcionEspañol = new ToolTip();
            toolTipDescripcionEspañol.SetToolTip(lblAbility2, descripcion);
        }

        private async void lblAbility3_MouseHover(object sender, EventArgs e)
        {
            await ObtenerHabilidad(lblAbility3.Text);
            // Devuelve desc español
            var descripcion = string.Join(
                Environment.NewLine,
                habilidadDesc.flavor_text_entries
                .Where(x => x.language.name == "es")
                .Select(x => x.flavor_text)
                .Distinct()
            );
            ToolTip toolTipDescripcionEspañol = new ToolTip();
            toolTipDescripcionEspañol.SetToolTip(lblAbility3, descripcion);
        }



        private async void lblAbility4_MouseHover(object sender, EventArgs e)
        {
            await ObtenerHabilidad(lblAbility4.Text);
            // Devuelve desc español
            var descripcion = string.Join(
                Environment.NewLine,
                habilidadDesc.flavor_text_entries
                .Where(x => x.language.name == "es")
                .Select(x => x.flavor_text)
                .Distinct()
            );
            ToolTip toolTipDescripcionEspañol = new ToolTip();
            toolTipDescripcionEspañol.SetToolTip(lblAbility4, descripcion);
        }

        private void iconPictureBoxCircleQuestion_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTipDescripcion = new ToolTip();
            toolTipDescripcion.SetToolTip(iconPictureBoxCircleQuestion,"Para acceder a informacion detallada de las habilidades coloque el mouse encima de ellas.");
        }
    }
}

