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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PokeApiView));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            cbxPokemons = new ComboBox();
            lblAbility1 = new Label();
            lblAbility2 = new Label();
            lblAbility3 = new Label();
            lblAbility4 = new Label();
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
            lblStat = new Label();
            panel1 = new Panel();
            iconPictureBoxCircleQuestion = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBoxCircleQuestion).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(77, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(212, 205);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(536, 71);
            label1.Name = "label1";
            label1.Size = new Size(136, 30);
            label1.TabIndex = 3;
            label1.Text = "Habilidades";
            // 
            // cbxPokemons
            // 
            cbxPokemons.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxPokemons.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cbxPokemons.FormattingEnabled = true;
            cbxPokemons.Location = new Point(122, 78);
            cbxPokemons.Name = "cbxPokemons";
            cbxPokemons.Size = new Size(121, 23);
            cbxPokemons.TabIndex = 4;
            cbxPokemons.SelectedIndexChanged += cbxPokemons_SelectedIndexChanged;
            // 
            // lblAbility1
            // 
            lblAbility1.AutoSize = true;
            lblAbility1.Cursor = Cursors.Help;
            lblAbility1.Location = new Point(511, 116);
            lblAbility1.Name = "lblAbility1";
            lblAbility1.Size = new Size(0, 15);
            lblAbility1.TabIndex = 5;
            lblAbility1.MouseHover += lblAbility1_MouseHover;
            // 
            // lblAbility2
            // 
            lblAbility2.AutoSize = true;
            lblAbility2.Cursor = Cursors.Help;
            lblAbility2.Location = new Point(675, 116);
            lblAbility2.Name = "lblAbility2";
            lblAbility2.Size = new Size(0, 15);
            lblAbility2.TabIndex = 6;
            lblAbility2.MouseHover += lblAbility2_MouseHover;
            // 
            // lblAbility3
            // 
            lblAbility3.AutoSize = true;
            lblAbility3.Cursor = Cursors.Help;
            lblAbility3.Location = new Point(511, 150);
            lblAbility3.Name = "lblAbility3";
            lblAbility3.Size = new Size(0, 15);
            lblAbility3.TabIndex = 7;
            lblAbility3.MouseHover += lblAbility3_MouseHover;
            // 
            // lblAbility4
            // 
            lblAbility4.AutoSize = true;
            lblAbility4.Cursor = Cursors.Help;
            lblAbility4.Location = new Point(675, 150);
            lblAbility4.Name = "lblAbility4";
            lblAbility4.Size = new Size(0, 15);
            lblAbility4.TabIndex = 8;
            lblAbility4.MouseHover += lblAbility4_MouseHover;
            // 
            // lblStat1
            // 
            lblStat1.AutoSize = true;
            lblStat1.Location = new Point(499, 262);
            lblStat1.Name = "lblStat1";
            lblStat1.Size = new Size(38, 15);
            lblStat1.TabIndex = 10;
            lblStat1.Text = "label2";
            // 
            // lblStat1b
            // 
            lblStat1b.AutoSize = true;
            lblStat1b.Location = new Point(499, 277);
            lblStat1b.Name = "lblStat1b";
            lblStat1b.Size = new Size(38, 15);
            lblStat1b.TabIndex = 11;
            lblStat1b.Text = "label2";
            // 
            // lblStat3b
            // 
            lblStat3b.AutoSize = true;
            lblStat3b.Location = new Point(499, 338);
            lblStat3b.Name = "lblStat3b";
            lblStat3b.Size = new Size(38, 15);
            lblStat3b.TabIndex = 13;
            lblStat3b.Text = "label3";
            // 
            // lblStat3
            // 
            lblStat3.AutoSize = true;
            lblStat3.Location = new Point(499, 323);
            lblStat3.Name = "lblStat3";
            lblStat3.Size = new Size(38, 15);
            lblStat3.TabIndex = 12;
            lblStat3.Text = "label2";
            // 
            // lblStat2b
            // 
            lblStat2b.AutoSize = true;
            lblStat2b.Location = new Point(675, 277);
            lblStat2b.Name = "lblStat2b";
            lblStat2b.Size = new Size(38, 15);
            lblStat2b.TabIndex = 15;
            lblStat2b.Text = "label5";
            // 
            // lblStat2
            // 
            lblStat2.AutoSize = true;
            lblStat2.Location = new Point(675, 262);
            lblStat2.Name = "lblStat2";
            lblStat2.Size = new Size(38, 15);
            lblStat2.TabIndex = 14;
            lblStat2.Text = "label2";
            // 
            // lblStat4b
            // 
            lblStat4b.AutoSize = true;
            lblStat4b.Location = new Point(675, 338);
            lblStat4b.Name = "lblStat4b";
            lblStat4b.Size = new Size(38, 15);
            lblStat4b.TabIndex = 17;
            lblStat4b.Text = "label7";
            // 
            // lblStat4
            // 
            lblStat4.AutoSize = true;
            lblStat4.Location = new Point(675, 323);
            lblStat4.Name = "lblStat4";
            lblStat4.Size = new Size(38, 15);
            lblStat4.TabIndex = 16;
            lblStat4.Text = "label2";
            // 
            // lblStat5b
            // 
            lblStat5b.AutoSize = true;
            lblStat5b.Location = new Point(499, 392);
            lblStat5b.Name = "lblStat5b";
            lblStat5b.Size = new Size(38, 15);
            lblStat5b.TabIndex = 19;
            lblStat5b.Text = "label9";
            // 
            // lblStat5
            // 
            lblStat5.AutoSize = true;
            lblStat5.Location = new Point(499, 377);
            lblStat5.Name = "lblStat5";
            lblStat5.Size = new Size(38, 15);
            lblStat5.TabIndex = 18;
            lblStat5.Text = "label2";
            // 
            // lblStat6b
            // 
            lblStat6b.AutoSize = true;
            lblStat6b.Location = new Point(675, 392);
            lblStat6b.Name = "lblStat6b";
            lblStat6b.Size = new Size(44, 15);
            lblStat6b.TabIndex = 21;
            lblStat6b.Text = "label11";
            // 
            // lblStat6
            // 
            lblStat6.AutoSize = true;
            lblStat6.Location = new Point(675, 377);
            lblStat6.Name = "lblStat6";
            lblStat6.Size = new Size(38, 15);
            lblStat6.TabIndex = 20;
            lblStat6.Text = "label2";
            // 
            // btnRandom
            // 
            btnRandom.Location = new Point(144, 318);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(75, 23);
            btnRandom.TabIndex = 22;
            btnRandom.Text = "Aleatorio";
            btnRandom.UseVisualStyleBackColor = true;
            btnRandom.Click += btnRandom_Click;
            // 
            // lblStat
            // 
            lblStat.AutoSize = true;
            lblStat.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblStat.Location = new Point(536, 221);
            lblStat.Name = "lblStat";
            lblStat.Size = new Size(134, 30);
            lblStat.TabIndex = 23;
            lblStat.Text = "Estadísticas";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(405, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(2, 427);
            panel1.TabIndex = 24;
            // 
            // iconPictureBoxCircleQuestion
            // 
            iconPictureBoxCircleQuestion.BackColor = SystemColors.Control;
            iconPictureBoxCircleQuestion.ForeColor = SystemColors.ControlText;
            iconPictureBoxCircleQuestion.IconChar = FontAwesome.Sharp.IconChar.CircleQuestion;
            iconPictureBoxCircleQuestion.IconColor = SystemColors.ControlText;
            iconPictureBoxCircleQuestion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBoxCircleQuestion.IconSize = 26;
            iconPictureBoxCircleQuestion.Location = new Point(670, 78);
            iconPictureBoxCircleQuestion.Name = "iconPictureBoxCircleQuestion";
            iconPictureBoxCircleQuestion.Size = new Size(27, 26);
            iconPictureBoxCircleQuestion.TabIndex = 25;
            iconPictureBoxCircleQuestion.TabStop = false;
            iconPictureBoxCircleQuestion.MouseHover += iconPictureBoxCircleQuestion_MouseHover;
            // 
            // PokeApiView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(iconPictureBoxCircleQuestion);
            Controls.Add(panel1);
            Controls.Add(lblStat);
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
            Controls.Add(lblAbility4);
            Controls.Add(lblAbility3);
            Controls.Add(lblAbility2);
            Controls.Add(lblAbility1);
            Controls.Add(cbxPokemons);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PokeApiView";
            Text = "PokeApi";
            Load += PokeApiView_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBoxCircleQuestion).EndInit();
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
        private Label lblStat;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxCircleQuestion;
    }
}