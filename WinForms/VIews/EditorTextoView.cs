using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Views
{
    public partial class EditorTextoView : Form
    {
        public EditorTextoView()
        {
            InitializeComponent();
            LoadFontFamily();
        }

        private void LoadFontFamily()
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                cbxFontFamily.Items.Add(font.Name);

            }
        }

        public void btnAlignLeft_Click(object sender, EventArgs e)
        {
            btnAlignRight.FlatStyle = FlatStyle.Standard;
            btnAlignCenter.FlatStyle = FlatStyle.Standard;
            btnAlignLeft.FlatStyle = FlatStyle.Flat;

            rtxtbxText.SelectionAlignment = HorizontalAlignment.Left;

        }
        public void btnAlignCenter_Click(object sender, EventArgs e)
        {
            btnAlignRight.FlatStyle = FlatStyle.Standard;
            btnAlignCenter.FlatStyle = FlatStyle.Flat;
            btnAlignLeft.FlatStyle = FlatStyle.Standard;

            rtxtbxText.SelectionAlignment = HorizontalAlignment.Center;
        }
        public void btnAlignRight_Click(object sender, EventArgs e)
        {
            btnAlignRight.FlatStyle = FlatStyle.Flat;
            btnAlignCenter.FlatStyle = FlatStyle.Standard;
            btnAlignLeft.FlatStyle = FlatStyle.Standard;

            rtxtbxText.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void txtbxText_TextChanged(object sender, EventArgs e)
        {
            rtxtbxText.Text = txtbxText.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            float Size;
            if (float.TryParse(cbxSize.SelectedItem.ToString(), out Size))
            {
                rtxtbxText.Font = new Font(txtbxText.Font.FontFamily, Size);
            }
        }

        private void cbxFontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtxtbxText.Font = new Font(cbxFontFamily.SelectedItem.ToString(), rtxtbxText.Font.Size);
        }

        private void ibtbBold_Click(object sender, EventArgs e)
        {

            ToggleSelectionStyle(FontStyle.Bold);
        }

        private void ibtbunderlined_Click(object sender, EventArgs e)
        {
            ToggleSelectionStyle(FontStyle.Underline);
        }

        private void ibtbItalic_Click(object sender, EventArgs e)
        {
            ToggleSelectionStyle(FontStyle.Italic);
        }
        private void ToggleSelectionStyle(FontStyle style)
        {
            if (rtxtbxText.SelectionLength > 0 && rtxtbxText.SelectionFont != null)
            {
                Font currentFont = rtxtbxText.SelectionFont;
                FontStyle newStyle;

                if (currentFont.Style.HasFlag(style))
                {
                    newStyle = currentFont.Style & ~style;
                }
                else
                {
                    newStyle = currentFont.Style | style;
                }

                rtxtbxText.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);
            }
            else
            {
                MessageBox.Show("Selecciona el texto que quieres formatear.", "Atención");
            }
        }
    }
}
