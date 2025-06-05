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
            lblAbility5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(139, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 205);
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
            cbxPokemons.Location = new Point(12, 82);
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
            lblAbility1.Size = new Size(69, 15);
            lblAbility1.TabIndex = 5;
            lblAbility1.Text = "Habilidades";
            // 
            // lblAbility2
            // 
            lblAbility2.AutoSize = true;
            lblAbility2.Location = new Point(660, 107);
            lblAbility2.Name = "lblAbility2";
            lblAbility2.Size = new Size(69, 15);
            lblAbility2.TabIndex = 6;
            lblAbility2.Text = "Habilidades";
            // 
            // lblAbility3
            // 
            lblAbility3.AutoSize = true;
            lblAbility3.Location = new Point(496, 141);
            lblAbility3.Name = "lblAbility3";
            lblAbility3.Size = new Size(69, 15);
            lblAbility3.TabIndex = 7;
            lblAbility3.Text = "Habilidades";
            // 
            // lblAbility4
            // 
            lblAbility4.AutoSize = true;
            lblAbility4.Location = new Point(660, 141);
            lblAbility4.Name = "lblAbility4";
            lblAbility4.Size = new Size(69, 15);
            lblAbility4.TabIndex = 8;
            lblAbility4.Text = "Habilidades";
            // 
            // lblAbility5
            // 
            lblAbility5.AutoSize = true;
            lblAbility5.Location = new Point(577, 178);
            lblAbility5.Name = "lblAbility5";
            lblAbility5.Size = new Size(69, 15);
            lblAbility5.TabIndex = 9;
            lblAbility5.Text = "Habilidades";
            // 
            // PokeApiView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAbility5);
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
        private Label lblAbility5;
    }
}