namespace WinForms.Views
{
    partial class FavGamesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavGamesView));
            tabControlFavGames = new TabControl();
            Lista = new TabPage();
            dgvGames = new DataGridView();
            btnRemove = new FontAwesome.Sharp.IconButton();
            btnSearch = new FontAwesome.Sharp.IconButton();
            textBox6 = new TextBox();
            btnExit = new FontAwesome.Sharp.IconButton();
            btnEdit = new FontAwesome.Sharp.IconButton();
            btnAdd = new FontAwesome.Sharp.IconButton();
            pictureBoxList = new PictureBox();
            AgregarEditar = new TabPage();
            nUDReleaseYear = new NumericUpDown();
            btnCancel = new FontAwesome.Sharp.IconButton();
            btnSave = new FontAwesome.Sharp.IconButton();
            txtImageUrl = new TextBox();
            pictureBoxAddEdit = new PictureBox();
            label5 = new Label();
            txtGenre = new TextBox();
            txtPlatform = new TextBox();
            txtTitle = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabControlFavGames.SuspendLayout();
            Lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGames).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxList).BeginInit();
            AgregarEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUDReleaseYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAddEdit).BeginInit();
            SuspendLayout();
            // 
            // tabControlFavGames
            // 
            tabControlFavGames.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlFavGames.Appearance = TabAppearance.FlatButtons;
            tabControlFavGames.Controls.Add(Lista);
            tabControlFavGames.Controls.Add(AgregarEditar);
            tabControlFavGames.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControlFavGames.Location = new Point(12, 12);
            tabControlFavGames.Name = "tabControlFavGames";
            tabControlFavGames.SelectedIndex = 0;
            tabControlFavGames.Size = new Size(831, 432);
            tabControlFavGames.TabIndex = 0;
            // 
            // Lista
            // 
            Lista.BackgroundImage = Properties.Resources.BackGroundGames;
            Lista.Controls.Add(dgvGames);
            Lista.Controls.Add(btnRemove);
            Lista.Controls.Add(btnSearch);
            Lista.Controls.Add(textBox6);
            Lista.Controls.Add(btnExit);
            Lista.Controls.Add(btnEdit);
            Lista.Controls.Add(btnAdd);
            Lista.Controls.Add(pictureBoxList);
            Lista.Location = new Point(4, 28);
            Lista.Name = "Lista";
            Lista.Padding = new Padding(3);
            Lista.Size = new Size(823, 400);
            Lista.TabIndex = 0;
            Lista.Text = "Lista";
            Lista.UseVisualStyleBackColor = true;
            // 
            // dgvGames
            // 
            dgvGames.AllowUserToAddRows = false;
            dgvGames.AllowUserToDeleteRows = false;
            dgvGames.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvGames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGames.Cursor = Cursors.Hand;
            dgvGames.Location = new Point(6, 49);
            dgvGames.MultiSelect = false;
            dgvGames.Name = "dgvGames";
            dgvGames.ReadOnly = true;
            dgvGames.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGames.Size = new Size(512, 348);
            dgvGames.TabIndex = 27;
            dgvGames.SelectionChanged += dgvGames_SelectionChanged;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRemove.Cursor = Cursors.Hand;
            btnRemove.FlatStyle = FlatStyle.Popup;
            btnRemove.IconChar = FontAwesome.Sharp.IconChar.None;
            btnRemove.IconColor = Color.Black;
            btnRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRemove.Location = new Point(715, 230);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 26;
            btnRemove.Text = "Eliminar";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSearch.IconColor = Color.Black;
            btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearch.Location = new Point(440, 19);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(78, 23);
            btnSearch.TabIndex = 25;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.Control;
            textBox6.Location = new Point(6, 19);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(428, 24);
            textBox6.TabIndex = 24;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.None;
            btnExit.IconColor = Color.Black;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.Location = new Point(742, 371);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 22;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEdit.IconColor = Color.Black;
            btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEdit.Location = new Point(634, 230);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 21;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAdd.IconColor = Color.Black;
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.Location = new Point(553, 230);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 20;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // pictureBoxList
            // 
            pictureBoxList.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxList.BackColor = Color.Transparent;
            pictureBoxList.Location = new Point(561, 19);
            pictureBoxList.Name = "pictureBoxList";
            pictureBoxList.Size = new Size(219, 189);
            pictureBoxList.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxList.TabIndex = 19;
            pictureBoxList.TabStop = false;
            // 
            // AgregarEditar
            // 
            AgregarEditar.BackColor = SystemColors.Control;
            AgregarEditar.BackgroundImage = Properties.Resources.BackGroundGames;
            AgregarEditar.Controls.Add(nUDReleaseYear);
            AgregarEditar.Controls.Add(btnCancel);
            AgregarEditar.Controls.Add(btnSave);
            AgregarEditar.Controls.Add(txtImageUrl);
            AgregarEditar.Controls.Add(pictureBoxAddEdit);
            AgregarEditar.Controls.Add(label5);
            AgregarEditar.Controls.Add(txtGenre);
            AgregarEditar.Controls.Add(txtPlatform);
            AgregarEditar.Controls.Add(txtTitle);
            AgregarEditar.Controls.Add(label4);
            AgregarEditar.Controls.Add(label3);
            AgregarEditar.Controls.Add(label2);
            AgregarEditar.Controls.Add(label1);
            AgregarEditar.Location = new Point(4, 28);
            AgregarEditar.Name = "AgregarEditar";
            AgregarEditar.Padding = new Padding(3);
            AgregarEditar.Size = new Size(823, 400);
            AgregarEditar.TabIndex = 1;
            AgregarEditar.Text = "Agregar/Editar";
            // 
            // nUDReleaseYear
            // 
            nUDReleaseYear.Location = new Point(171, 173);
            nUDReleaseYear.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nUDReleaseYear.Name = "nUDReleaseYear";
            nUDReleaseYear.Size = new Size(269, 24);
            nUDReleaseYear.TabIndex = 22;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancel.BackColor = Color.LightCoral;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold);
            btnCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            btnCancel.IconColor = Color.Black;
            btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancel.Location = new Point(365, 291);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.BackColor = Color.LightGreen;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold);
            btnSave.IconChar = FontAwesome.Sharp.IconChar.None;
            btnSave.IconColor = Color.Black;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.Location = new Point(171, 291);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 20;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtImageUrl
            // 
            txtImageUrl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtImageUrl.BackColor = SystemColors.Control;
            txtImageUrl.Location = new Point(561, 223);
            txtImageUrl.Name = "txtImageUrl";
            txtImageUrl.Size = new Size(219, 24);
            txtImageUrl.TabIndex = 19;
            txtImageUrl.TextChanged += txtImageUrl_TextChanged;
            // 
            // pictureBoxAddEdit
            // 
            pictureBoxAddEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxAddEdit.BackColor = Color.Transparent;
            pictureBoxAddEdit.Location = new Point(561, 19);
            pictureBoxAddEdit.Name = "pictureBoxAddEdit";
            pictureBoxAddEdit.Size = new Size(219, 189);
            pictureBoxAddEdit.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxAddEdit.TabIndex = 18;
            pictureBoxAddEdit.TabStop = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold);
            label5.Location = new Point(472, 228);
            label5.Name = "label5";
            label5.Size = new Size(83, 19);
            label5.TabIndex = 17;
            label5.Text = "Url imagen:";
            // 
            // txtGenre
            // 
            txtGenre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtGenre.BackColor = SystemColors.Control;
            txtGenre.Location = new Point(171, 131);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(269, 24);
            txtGenre.TabIndex = 15;
            // 
            // txtPlatform
            // 
            txtPlatform.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtPlatform.BackColor = SystemColors.Control;
            txtPlatform.Location = new Point(171, 92);
            txtPlatform.Name = "txtPlatform";
            txtPlatform.Size = new Size(269, 24);
            txtPlatform.TabIndex = 14;
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtTitle.BackColor = SystemColors.Control;
            txtTitle.Location = new Point(171, 54);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(269, 24);
            txtTitle.TabIndex = 13;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold);
            label4.Location = new Point(24, 178);
            label4.Name = "label4";
            label4.Size = new Size(139, 19);
            label4.TabIndex = 12;
            label4.Text = "Año de lanzamiento:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold);
            label3.Location = new Point(24, 136);
            label3.Name = "label3";
            label3.Size = new Size(58, 19);
            label3.TabIndex = 11;
            label3.Text = "Género:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold);
            label2.Location = new Point(24, 97);
            label2.Name = "label2";
            label2.Size = new Size(83, 19);
            label2.TabIndex = 10;
            label2.Text = "Plataforma:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold);
            label1.Location = new Point(24, 59);
            label1.Name = "label1";
            label1.Size = new Size(52, 19);
            label1.TabIndex = 9;
            label1.Text = "Título:";
            // 
            // FavGamesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(855, 456);
            Controls.Add(tabControlFavGames);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(871, 495);
            Name = "FavGamesView";
            Text = "Fav Games";
            tabControlFavGames.ResumeLayout(false);
            Lista.ResumeLayout(false);
            Lista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGames).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxList).EndInit();
            AgregarEditar.ResumeLayout(false);
            AgregarEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUDReleaseYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAddEdit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlFavGames;
        private TabPage Lista;
        private TabPage AgregarEditar;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnSave;
        private TextBox txtImageUrl;
        private PictureBox pictureBoxAddEdit;
        private Label label5;
        private TextBox txtGenre;
        private TextBox txtPlatform;
        private TextBox txtTitle;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox6;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnAdd;
        private PictureBox pictureBoxList;
        private FontAwesome.Sharp.IconButton btnSearch;
        private FontAwesome.Sharp.IconButton btnRemove;
        private NumericUpDown nUDReleaseYear;
        private DataGridView dgvGames;
    }
}