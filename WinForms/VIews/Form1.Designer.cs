namespace WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            ClimaAppMenuStrip = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            EditorTextoMenuStrip = new FontAwesome.Sharp.IconMenuItem();
            PokeApiMenuStrip = new FontAwesome.Sharp.IconMenuItem();
            trabajosEnClaseToolStripMenuItem = new ToolStripMenuItem();
            películasAPIMenuStrip = new ToolStripMenuItem();
            películasADOMenuStrip = new ToolStripMenuItem();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            SalirMenuStrip = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            AcercadeMenuStrip = new FontAwesome.Sharp.IconMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem1, iconMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { ClimaAppMenuStrip, iconMenuItem3, trabajosEnClaseToolStripMenuItem });
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(81, 20);
            iconMenuItem1.Text = "Principal";
            // 
            // ClimaAppMenuStrip
            // 
            ClimaAppMenuStrip.IconChar = FontAwesome.Sharp.IconChar.None;
            ClimaAppMenuStrip.IconColor = Color.Black;
            ClimaAppMenuStrip.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ClimaAppMenuStrip.Name = "ClimaAppMenuStrip";
            ClimaAppMenuStrip.Size = new Size(163, 22);
            ClimaAppMenuStrip.Text = "Clima App";
            ClimaAppMenuStrip.Click += ClimaAppMenuStrip_Click;
            // 
            // iconMenuItem3
            // 
            iconMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { EditorTextoMenuStrip, PokeApiMenuStrip });
            iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem3.IconColor = Color.Black;
            iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem3.Name = "iconMenuItem3";
            iconMenuItem3.Size = new Size(163, 22);
            iconMenuItem3.Text = "Tareas";
            // 
            // EditorTextoMenuStrip
            // 
            EditorTextoMenuStrip.IconChar = FontAwesome.Sharp.IconChar.None;
            EditorTextoMenuStrip.IconColor = Color.Black;
            EditorTextoMenuStrip.IconFont = FontAwesome.Sharp.IconFont.Auto;
            EditorTextoMenuStrip.Name = "EditorTextoMenuStrip";
            EditorTextoMenuStrip.Size = new Size(176, 22);
            EditorTextoMenuStrip.Text = "Formulario Fuentes";
            EditorTextoMenuStrip.Click += EditorTextoMenuStrip_Click;
            // 
            // PokeApiMenuStrip
            // 
            PokeApiMenuStrip.IconChar = FontAwesome.Sharp.IconChar.None;
            PokeApiMenuStrip.IconColor = Color.Black;
            PokeApiMenuStrip.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PokeApiMenuStrip.Name = "PokeApiMenuStrip";
            PokeApiMenuStrip.Size = new Size(176, 22);
            PokeApiMenuStrip.Text = "Api Pokemon";
            PokeApiMenuStrip.Click += PokeApiMenuStrip_Click;
            // 
            // trabajosEnClaseToolStripMenuItem
            // 
            trabajosEnClaseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { películasAPIMenuStrip, películasADOMenuStrip });
            trabajosEnClaseToolStripMenuItem.Name = "trabajosEnClaseToolStripMenuItem";
            trabajosEnClaseToolStripMenuItem.Size = new Size(163, 22);
            trabajosEnClaseToolStripMenuItem.Text = "Trabajos en clase";
            // 
            // películasAPIMenuStrip
            // 
            películasAPIMenuStrip.Name = "películasAPIMenuStrip";
            películasAPIMenuStrip.Size = new Size(181, 22);
            películasAPIMenuStrip.Text = "Películas (API)";
            películasAPIMenuStrip.Click += películasAPIMenuStrip_Click;
            // 
            // películasADOMenuStrip
            // 
            películasADOMenuStrip.Name = "películasADOMenuStrip";
            películasADOMenuStrip.Size = new Size(181, 22);
            películasADOMenuStrip.Text = "Películas (ADO.NET)";
            películasADOMenuStrip.Click += películasADOMenuStrip_Click;
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { SalirMenuStrip, toolStripSeparator1, AcercadeMenuStrip });
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem2.IconColor = Color.Black;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new Size(57, 20);
            iconMenuItem2.Text = "Salir";
            // 
            // SalirMenuStrip
            // 
            SalirMenuStrip.Name = "SalirMenuStrip";
            SalirMenuStrip.Size = new Size(158, 22);
            SalirMenuStrip.Text = "Salir del sistema";
            SalirMenuStrip.Click += SalirMenuStrip_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(155, 6);
            // 
            // AcercadeMenuStrip
            // 
            AcercadeMenuStrip.IconChar = FontAwesome.Sharp.IconChar.None;
            AcercadeMenuStrip.IconColor = Color.Black;
            AcercadeMenuStrip.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AcercadeMenuStrip.Name = "AcercadeMenuStrip";
            AcercadeMenuStrip.Size = new Size(158, 22);
            AcercadeMenuStrip.Text = "Acerca de...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Pruebas en Windows Forms";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private ToolStripMenuItem SalirMenuStrip;
        private FontAwesome.Sharp.IconMenuItem ClimaAppMenuStrip;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private ToolStripSeparator toolStripSeparator1;
        private FontAwesome.Sharp.IconMenuItem AcercadeMenuStrip;
        private FontAwesome.Sharp.IconMenuItem EditorTextoMenuStrip;
        private FontAwesome.Sharp.IconMenuItem PokeApiMenuStrip;
        private ToolStripMenuItem trabajosEnClaseToolStripMenuItem;
        private ToolStripMenuItem películasAPIMenuStrip;
        private ToolStripMenuItem películasADOMenuStrip;
    }
}
