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
            dgvMovie = new DataGridView();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            btnModificar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnSalir = new FontAwesome.Sharp.IconButton();
            picboxMovie = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvMovie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picboxMovie).BeginInit();
            SuspendLayout();
            // 
            // dgvMovie
            // 
            dgvMovie.AllowUserToAddRows = false;
            dgvMovie.AllowUserToDeleteRows = false;
            dgvMovie.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMovie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMovie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovie.Location = new Point(13, 12);
            dgvMovie.MultiSelect = false;
            dgvMovie.Name = "dgvMovie";
            dgvMovie.ReadOnly = true;
            dgvMovie.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMovie.Size = new Size(560, 341);
            dgvMovie.TabIndex = 0;
            dgvMovie.SelectionChanged += dgvMovie_SelectionChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.Location = new Point(579, 194);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(122, 34);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnModificar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnModificar.IconColor = Color.Black;
            btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModificar.Location = new Point(579, 234);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(122, 34);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.Location = new Point(579, 274);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(122, 34);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSalir.IconColor = Color.Black;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.Location = new Point(671, 359);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(122, 34);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // picboxMovie
            // 
            picboxMovie.Location = new Point(579, 12);
            picboxMovie.Name = "picboxMovie";
            picboxMovie.Size = new Size(214, 176);
            picboxMovie.SizeMode = PictureBoxSizeMode.Zoom;
            picboxMovie.TabIndex = 5;
            picboxMovie.TabStop = false;
            // 
            // PeliculasView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 405);
            Controls.Add(picboxMovie);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvMovie);
            Name = "PeliculasView";
            Text = "PeliculasViewcs";
            ((System.ComponentModel.ISupportInitialize)dgvMovie).EndInit();
            ((System.ComponentModel.ISupportInitialize)picboxMovie).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMovie;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnSalir;
        private PictureBox picboxMovie;
    }
}