using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Models;

namespace WinForms.Views
{
    public partial class ClimaAppView : Form
    {
        public ClimaAppView()
        {
            InitializeComponent();
        }

        private async void btnObtenerClima_Click(object sender, EventArgs e)
        {
            const string apiUrl = "https://api.open-meteo.com/v1/forecast?latitude=-30.78362&longitude=-60.59115&current=temperature_2m";
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(apiUrl);
                    QueryTemperature queryTemperature = await response.Content.ReadFromJsonAsync<QueryTemperature>();

                    lblTemperatura.Text = $"{queryTemperature.current.temperature_2m} °C";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el clima: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void iconToolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Gracias por usar nuestra aplicación de clima!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
