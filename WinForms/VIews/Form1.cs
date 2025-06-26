using WinForms.Views;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SalirMenuStrip_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClimaAppMenuStrip_Click(object sender, EventArgs e)
        {
            var climaView = new ClimaAppView();
            climaView.Show();
        }

        private void EditorTextoMenuStrip_Click(object sender, EventArgs e)
        {
            var editorView = new EditorTextoView();
            editorView.Show();
        }

        private void PokeApiMenuStrip_Click(object sender, EventArgs e)
        {
            var pokeApiView = new PokeApiView();
            pokeApiView.Show();
        }

        private void películasAPIMenuStrip_Click(object sender, EventArgs e)
        {
            var peliculasApiView = new PeliculasView();
            peliculasApiView.Show();
        }

        private void películasADOMenuStrip_Click(object sender, EventArgs e)
        {
            var peliculasADOView = new PeliculasADOView();
            peliculasADOView.Show();
        }
    }
}
