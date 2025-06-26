namespace WinForms.Views
{
    partial class PeliculasADOView
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PeliculasView));
            tabControl1 = new TabControl();
            tabPageLista = new TabPage();
            statusStrip1 = new StatusStrip();
            lblStatusMessage = new ToolStripStatusLabel();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            txtbSearch = new TextBox();
            label1 = new Label();
            picboxMovie = new PictureBox();
            btnSalir = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnModificar = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            dgvMovie = new DataGridView();
            tabPageAgrMod = new TabPage();
            numericUpDownQualification = new NumericUpDown();
            numericUpDownDuration = new NumericUpDown();
            txtbCover = new TextBox();
            txtbTitle = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            timerStatusBar = new System.Windows.Forms.Timer(components);
            tabControl1.SuspendLayout();
            tabPageLista.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picboxMovie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMovie).BeginInit();
            tabPageAgrMod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQualification).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDuration).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageLista);
            tabControl1.Controls.Add(tabPageAgrMod);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(938, 527);
            tabControl1.TabIndex = 0;
            // 
            // tabPageLista
            // 
            tabPageLista.Controls.Add(statusStrip1);
            tabPageLista.Controls.Add(btnBuscar);
            tabPageLista.Controls.Add(txtbSearch);
            tabPageLista.Controls.Add(label1);
            tabPageLista.Controls.Add(picboxMovie);
            tabPageLista.Controls.Add(btnSalir);
            tabPageLista.Controls.Add(btnEliminar);
            tabPageLista.Controls.Add(btnModificar);
            tabPageLista.Controls.Add(btnAgregar);
            tabPageLista.Controls.Add(dgvMovie);
            tabPageLista.Location = new Point(4, 24);
            tabPageLista.Name = "tabPageLista";
            tabPageLista.Padding = new Padding(3);
            tabPageLista.Size = new Size(930, 499);
            tabPageLista.TabIndex = 0;
            tabPageLista.Text = "Lista";
            tabPageLista.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatusMessage });
            statusStrip1.Location = new Point(3, 474);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(924, 22);
            statusStrip1.TabIndex = 15;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusMessage
            // 
            lblStatusMessage.Name = "lblStatusMessage";
            lblStatusMessage.Size = new Size(0, 17);
            // 
            // btnBuscar
            // 
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.Black;
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 18;
            btnBuscar.Location = new Point(341, 16);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(32, 23);
            btnBuscar.TabIndex = 14;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtbSearch
            // 
            txtbSearch.Location = new Point(101, 16);
            txtbSearch.Name = "txtbSearch";
            txtbSearch.Size = new Size(234, 23);
            txtbSearch.TabIndex = 13;
            txtbSearch.TextChanged += txtbSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 19);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 12;
            label1.Text = "Buscar:";
            // 
            // picboxMovie
            // 
            picboxMovie.Location = new Point(608, 6);
            picboxMovie.Name = "picboxMovie";
            picboxMovie.Size = new Size(314, 266);
            picboxMovie.SizeMode = PictureBoxSizeMode.Zoom;
            picboxMovie.TabIndex = 11;
            picboxMovie.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            btnSalir.IconColor = Color.Black;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.IconSize = 26;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(826, 458);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(96, 33);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleRight;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 26;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(812, 278);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(96, 34);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnModificar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btnModificar.IconColor = Color.Black;
            btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnModificar.IconSize = 26;
            btnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificar.Location = new Point(710, 278);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(96, 34);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "Modificar";
            btnModificar.TextAlign = ContentAlignment.MiddleRight;
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregar.IconSize = 26;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(608, 278);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(96, 34);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvMovie
            // 
            dgvMovie.AllowUserToAddRows = false;
            dgvMovie.AllowUserToDeleteRows = false;
            dgvMovie.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMovie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMovie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovie.Location = new Point(-4, 51);
            dgvMovie.MultiSelect = false;
            dgvMovie.Name = "dgvMovie";
            dgvMovie.ReadOnly = true;
            dgvMovie.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMovie.Size = new Size(606, 417);
            dgvMovie.TabIndex = 6;
            dgvMovie.SelectionChanged += dgvMovie_SelectionChanged;
            // 
            // tabPageAgrMod
            // 
            tabPageAgrMod.Controls.Add(numericUpDownQualification);
            tabPageAgrMod.Controls.Add(numericUpDownDuration);
            tabPageAgrMod.Controls.Add(txtbCover);
            tabPageAgrMod.Controls.Add(txtbTitle);
            tabPageAgrMod.Controls.Add(label5);
            tabPageAgrMod.Controls.Add(label4);
            tabPageAgrMod.Controls.Add(label3);
            tabPageAgrMod.Controls.Add(label2);
            tabPageAgrMod.Controls.Add(btnCancelar);
            tabPageAgrMod.Controls.Add(btnGuardar);
            tabPageAgrMod.Location = new Point(4, 24);
            tabPageAgrMod.Name = "tabPageAgrMod";
            tabPageAgrMod.Padding = new Padding(3);
            tabPageAgrMod.Size = new Size(930, 499);
            tabPageAgrMod.TabIndex = 1;
            tabPageAgrMod.Text = "Agregar/Modificar";
            tabPageAgrMod.UseVisualStyleBackColor = true;
            // 
            // numericUpDownQualification
            // 
            numericUpDownQualification.DecimalPlaces = 1;
            numericUpDownQualification.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownQualification.Location = new Point(334, 262);
            numericUpDownQualification.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownQualification.Name = "numericUpDownQualification";
            numericUpDownQualification.Size = new Size(120, 23);
            numericUpDownQualification.TabIndex = 9;
            // 
            // numericUpDownDuration
            // 
            numericUpDownDuration.Location = new Point(334, 191);
            numericUpDownDuration.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numericUpDownDuration.Name = "numericUpDownDuration";
            numericUpDownDuration.Size = new Size(120, 23);
            numericUpDownDuration.TabIndex = 8;
            // 
            // txtbCover
            // 
            txtbCover.Location = new Point(334, 224);
            txtbCover.Name = "txtbCover";
            txtbCover.Size = new Size(307, 23);
            txtbCover.TabIndex = 7;
            // 
            // txtbTitle
            // 
            txtbTitle.Location = new Point(334, 152);
            txtbTitle.Name = "txtbTitle";
            txtbTitle.Size = new Size(307, 23);
            txtbTitle.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(250, 264);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 5;
            label5.Text = "Calificación";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(250, 227);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 4;
            label4.Text = "Portada:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(250, 193);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 3;
            label3.Text = "Duración:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 157);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 2;
            label2.Text = "Título:";
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 22;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(458, 371);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(87, 36);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 22;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(365, 371);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(87, 36);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // timerStatusBar
            // 
            timerStatusBar.Interval = 3000;
            timerStatusBar.Tick += timerStatusBar_Tick;
            // 
            // PeliculasView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 527);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PeliculasView";
            Text = "Peliculas";
            tabControl1.ResumeLayout(false);
            tabPageLista.ResumeLayout(false);
            tabPageLista.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picboxMovie).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMovie).EndInit();
            tabPageAgrMod.ResumeLayout(false);
            tabPageAgrMod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQualification).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDuration).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageLista;
        private PictureBox picboxMovie;
        private FontAwesome.Sharp.IconButton btnSalir;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private DataGridView dgvMovie;
        private TabPage tabPageAgrMod;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox txtbSearch;
        private Label label1;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private TextBox txtbCover;
        private TextBox txtbTitle;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private NumericUpDown numericUpDownQualification;
        private NumericUpDown numericUpDownDuration;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatusMessage;
        private System.Windows.Forms.Timer timerStatusBar;
    }
}