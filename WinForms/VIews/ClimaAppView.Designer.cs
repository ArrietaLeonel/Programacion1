namespace WinForms.VIews
{
    partial class ClimaAppView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            toolStrip1 = new ToolStrip();
            iconToolStripButton1 = new FontAwesome.Sharp.IconToolStripButton();
            iconToolStripButton2 = new FontAwesome.Sharp.IconToolStripButton();
            btnObtenerClima = new Button();
            label1 = new Label();
            lblTemperatura = new Label();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem1, iconMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { iconMenuItem3 });
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.House;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(87, 20);
            iconMenuItem1.Text = "Acerca de";
            // 
            // iconMenuItem3
            // 
            iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            iconMenuItem3.IconColor = Color.Black;
            iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem3.Name = "iconMenuItem3";
            iconMenuItem3.Size = new Size(165, 22);
            iconMenuItem3.Text = "¿Quiénes somos?";
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            iconMenuItem2.IconColor = Color.Black;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new Size(57, 20);
            iconMenuItem2.Text = "Salir";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { iconToolStripButton1, iconToolStripButton2 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 43);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // iconToolStripButton1
            // 
            iconToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            iconToolStripButton1.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            iconToolStripButton1.IconColor = Color.Black;
            iconToolStripButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconToolStripButton1.IconSize = 36;
            iconToolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
            iconToolStripButton1.ImageTransparentColor = Color.Magenta;
            iconToolStripButton1.Name = "iconToolStripButton1";
            iconToolStripButton1.Size = new Size(40, 40);
            iconToolStripButton1.Text = "iconToolStripButton1";
            // 
            // iconToolStripButton2
            // 
            iconToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            iconToolStripButton2.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            iconToolStripButton2.IconColor = Color.Black;
            iconToolStripButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconToolStripButton2.IconSize = 36;
            iconToolStripButton2.ImageScaling = ToolStripItemImageScaling.None;
            iconToolStripButton2.ImageTransparentColor = Color.Magenta;
            iconToolStripButton2.Name = "iconToolStripButton2";
            iconToolStripButton2.Size = new Size(40, 40);
            iconToolStripButton2.Text = "iconToolStripButton2";
            iconToolStripButton2.Click += iconToolStripButton2_Click;
            // 
            // btnObtenerClima
            // 
            btnObtenerClima.Location = new Point(12, 70);
            btnObtenerClima.Name = "btnObtenerClima";
            btnObtenerClima.Size = new Size(110, 23);
            btnObtenerClima.TabIndex = 2;
            btnObtenerClima.Text = "Obtener Clima";
            btnObtenerClima.UseVisualStyleBackColor = true;
            btnObtenerClima.Click += btnObtenerClima_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(244, 188);
            label1.Name = "label1";
            label1.Size = new Size(168, 25);
            label1.TabIndex = 3;
            label1.Text = "Tempratura actual:";
            // 
            // lblTemperatura
            // 
            lblTemperatura.AutoSize = true;
            lblTemperatura.Font = new Font("Segoe UI", 14F);
            lblTemperatura.Location = new Point(418, 188);
            lblTemperatura.Name = "lblTemperatura";
            lblTemperatura.Size = new Size(0, 25);
            lblTemperatura.TabIndex = 4;
            // 
            // ClimaAppView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTemperatura);
            Controls.Add(label1);
            Controls.Add(btnObtenerClima);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "ClimaAppView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ClimaApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStrip toolStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton1;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton2;
        private Button btnObtenerClima;
        private Label label1;
        private Label lblTemperatura;
    }
}