namespace WinForms.VIews
{
    partial class PeliculasView
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnBuscar = new Button();
            label1 = new Label();
            txtBuscar = new TextBox();
            picboxMovie = new PictureBox();
            btnSalir = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnModificar = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            dgvMovie = new DataGridView();
            tabPage2 = new TabPage();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxMovie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMovie).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(791, 390);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnBuscar);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtBuscar);
            tabPage1.Controls.Add(picboxMovie);
            tabPage1.Controls.Add(btnSalir);
            tabPage1.Controls.Add(btnEliminar);
            tabPage1.Controls.Add(btnModificar);
            tabPage1.Controls.Add(btnAgregar);
            tabPage1.Controls.Add(dgvMovie);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(783, 362);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(441, 19);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 16;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 21);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 15;
            label1.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(92, 18);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(266, 23);
            txtBuscar.TabIndex = 14;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // picboxMovie
            // 
            picboxMovie.Location = new Point(567, 6);
            picboxMovie.Name = "picboxMovie";
            picboxMovie.Size = new Size(214, 161);
            picboxMovie.SizeMode = PictureBoxSizeMode.Zoom;
            picboxMovie.TabIndex = 13;
            picboxMovie.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSalir.IconColor = Color.Black;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.Location = new Point(655, 322);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(122, 34);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.Location = new Point(567, 253);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(122, 34);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnModificar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnModificar.IconColor = Color.Black;
            btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModificar.Location = new Point(567, 213);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(122, 34);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.Location = new Point(567, 173);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(122, 34);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // dgvMovie
            // 
            dgvMovie.AllowUserToAddRows = false;
            dgvMovie.AllowUserToDeleteRows = false;
            dgvMovie.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMovie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMovie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovie.Location = new Point(1, 47);
            dgvMovie.MultiSelect = false;
            dgvMovie.Name = "dgvMovie";
            dgvMovie.ReadOnly = true;
            dgvMovie.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMovie.Size = new Size(560, 285);
            dgvMovie.TabIndex = 8;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(783, 362);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(110, 87);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(343, 23);
            textBox3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 87);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Portada:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(110, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(343, 23);
            textBox2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 41);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 0;
            label2.Text = "Pelicula:";
            // 
            // PeliculasView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 405);
            Controls.Add(tabControl1);
            Name = "PeliculasView";
            Text = "PeliculasViewcs";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picboxMovie).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMovie).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnBuscar;
        private Label label1;
        private TextBox txtBuscar;
        private PictureBox picboxMovie;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private DataGridView dgvMovie;
        private TabPage tabPage2;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
    }
}