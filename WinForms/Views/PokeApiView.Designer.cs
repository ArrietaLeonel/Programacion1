namespace WinForms.Views
{
    partial class PokeApiView
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            cbxPokemons = new ComboBox();
            lblAbility1 = new Label();
            lblAbility2 = new Label();
            lblAbility3 = new Label();
            lblAbility4 = new Label();
            lblStat = new Label();
            lblStat1 = new Label();
            lblStat1b = new Label();
            lblStat3b = new Label();
            lblStat3 = new Label();
            lblStat2b = new Label();
            lblStat2 = new Label();
            lblStat4b = new Label();
            lblStat4 = new Label();
            lblStat5b = new Label();
            lblStat5 = new Label();
            lblStat6b = new Label();
            lblStat6 = new Label();
            btnRandom = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(67, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(577, 82);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 3;
            label1.Text = "Habilidades";
            // 
            // cbxPokemons
            // 
            cbxPokemons.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxPokemons.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbxPokemons.FormattingEnabled = true;
            cbxPokemons.Location = new Point(127, 82);
            cbxPokemons.Name = "cbxPokemons";
            cbxPokemons.Size = new Size(121, 23);
            cbxPokemons.TabIndex = 4;
            cbxPokemons.SelectedIndexChanged += cbxPokemons_SelectedIndexChanged;
            // 
            // lblAbility1
            // 
            lblAbility1.AutoSize = true;
            lblAbility1.Location = new Point(496, 107);
            lblAbility1.Name = "lblAbility1";
            lblAbility1.Size = new Size(0, 15);
            lblAbility1.TabIndex = 5;
            // 
            // lblAbility2
            // 
            lblAbility2.AutoSize = true;
            lblAbility2.Location = new Point(660, 107);
            lblAbility2.Name = "lblAbility2";
            lblAbility2.Size = new Size(0, 15);
            lblAbility2.TabIndex = 6;
            // 
            // lblAbility3
            // 
            lblAbility3.AutoSize = true;
            lblAbility3.Location = new Point(496, 141);
            lblAbility3.Name = "lblAbility3";
            lblAbility3.Size = new Size(0, 15);
            lblAbility3.TabIndex = 7;
            // 
            // lblAbility4
            // 
            lblAbility4.AutoSize = true;
            lblAbility4.Location = new Point(660, 141);
            lblAbility4.Name = "lblAbility4";
            lblAbility4.Size = new Size(0, 15);
            lblAbility4.TabIndex = 8;
            // 
            // lblStat
            // 
            lblStat.AutoSize = true;
            lblStat.Location = new Point(577, 207);
            lblStat.Name = "lblStat";
            lblStat.Size = new Size(67, 15);
            lblStat.TabIndex = 9;
            lblStat.Text = "Estadísticas";
            // 
            // lblStat1
            // 
            lblStat1.AutoSize = true;
            lblStat1.Location = new Point(496, 228);
            lblStat1.Name = "lblStat1";
            lblStat1.Size = new Size(38, 15);
            lblStat1.TabIndex = 10;
            lblStat1.Text = "label2";
            // 
            // lblStat1b
            // 
            lblStat1b.AutoSize = true;
            lblStat1b.Location = new Point(496, 243);
            lblStat1b.Name = "lblStat1b";
            lblStat1b.Size = new Size(38, 15);
            lblStat1b.TabIndex = 11;
            lblStat1b.Text = "label2";
            // 
            // lblStat3b
            // 
            lblStat3b.AutoSize = true;
            lblStat3b.Location = new Point(496, 304);
            lblStat3b.Name = "lblStat3b";
            lblStat3b.Size = new Size(38, 15);
            lblStat3b.TabIndex = 13;
            lblStat3b.Text = "label3";
            // 
            // lblStat3
            // 
            lblStat3.AutoSize = true;
            lblStat3.Location = new Point(496, 289);
            lblStat3.Name = "lblStat3";
            lblStat3.Size = new Size(38, 15);
            lblStat3.TabIndex = 12;
            lblStat3.Text = "label2";
            // 
            // lblStat2b
            // 
            lblStat2b.AutoSize = true;
            lblStat2b.Location = new Point(660, 243);
            lblStat2b.Name = "lblStat2b";
            lblStat2b.Size = new Size(38, 15);
            lblStat2b.TabIndex = 15;
            lblStat2b.Text = "label5";
            // 
            // lblStat2
            // 
            lblStat2.AutoSize = true;
            lblStat2.Location = new Point(660, 228);
            lblStat2.Name = "lblStat2";
            lblStat2.Size = new Size(38, 15);
            lblStat2.TabIndex = 14;
            lblStat2.Text = "label2";
            // 
            // lblStat4b
            // 
            lblStat4b.AutoSize = true;
            lblStat4b.Location = new Point(660, 304);
            lblStat4b.Name = "lblStat4b";
            lblStat4b.Size = new Size(38, 15);
            lblStat4b.TabIndex = 17;
            lblStat4b.Text = "label7";
            // 
            // lblStat4
            // 
            lblStat4.AutoSize = true;
            lblStat4.Location = new Point(660, 289);
            lblStat4.Name = "lblStat4";
            lblStat4.Size = new Size(38, 15);
            lblStat4.TabIndex = 16;
            lblStat4.Text = "label2";
            // 
            // lblStat5b
            // 
            lblStat5b.AutoSize = true;
            lblStat5b.Location = new Point(496, 358);
            lblStat5b.Name = "lblStat5b";
            lblStat5b.Size = new Size(38, 15);
            lblStat5b.TabIndex = 19;
            lblStat5b.Text = "label9";
            // 
            // lblStat5
            // 
            lblStat5.AutoSize = true;
            lblStat5.Location = new Point(496, 343);
            lblStat5.Name = "lblStat5";
            lblStat5.Size = new Size(38, 15);
            lblStat5.TabIndex = 18;
            lblStat5.Text = "label2";
            // 
            // lblStat6b
            // 
            lblStat6b.AutoSize = true;
            lblStat6b.Location = new Point(660, 358);
            lblStat6b.Name = "lblStat6b";
            lblStat6b.Size = new Size(44, 15);
            lblStat6b.TabIndex = 21;
            lblStat6b.Text = "label11";
            // 
            // lblStat6
            // 
            lblStat6.AutoSize = true;
            lblStat6.Location = new Point(660, 343);
            lblStat6.Name = "lblStat6";
            lblStat6.Size = new Size(38, 15);
            lblStat6.TabIndex = 20;
            lblStat6.Text = "label2";
            // 
            // btnRandom
            // 
            btnRandom.Location = new Point(150, 358);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(75, 23);
            btnRandom.TabIndex = 22;
            btnRandom.Text = "Aleatorio";
            btnRandom.UseVisualStyleBackColor = true;
            btnRandom.Click += btnRandom_Click;
            // 
            // PokeApiView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRandom);
            Controls.Add(lblStat6b);
            Controls.Add(lblStat6);
            Controls.Add(lblStat5b);
            Controls.Add(lblStat5);
            Controls.Add(lblStat4b);
            Controls.Add(lblStat4);
            Controls.Add(lblStat2b);
            Controls.Add(lblStat2);
            Controls.Add(lblStat3b);
            Controls.Add(lblStat3);
            Controls.Add(lblStat1b);
            Controls.Add(lblStat1);
            Controls.Add(lblStat);
            Controls.Add(lblAbility4);
            Controls.Add(lblAbility3);
            Controls.Add(lblAbility2);
            Controls.Add(lblAbility1);
            Controls.Add(cbxPokemons);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "PokeApiView";
            Text = "PokeApi";
            Load += PokeApiView_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox cbxPokemons;
        private Label lblAbility1;
        private Label lblAbility2;
        private Label lblAbility3;
        private Label lblAbility4;
        private Label lblStat;
        private Label lblStat1;
        private Label lblStat1b;
        private Label lblStat3b;
        private Label lblStat3;
        private Label lblStat2b;
        private Label lblStat2;
        private Label lblStat4b;
        private Label lblStat4;
        private Label lblStat5b;
        private Label lblStat5;
        private Label lblStat6b;
        private Label lblStat6;
        private Button btnRandom;
    }
}