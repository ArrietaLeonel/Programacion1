namespace WinForms.VIews
{
    partial class EditorTextoView
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
            rtxtbxText = new RichTextBox();
            txtbxText = new TextBox();
            lblTexto = new Label();
            btnAlignCenter = new FontAwesome.Sharp.IconButton();
            btnAlignRight = new FontAwesome.Sharp.IconButton();
            btnAlignLeft = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            cbxSize = new ComboBox();
            cbxFontFamily = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            ibtbBold = new FontAwesome.Sharp.IconButton();
            ibtbItalic = new FontAwesome.Sharp.IconButton();
            ibtbunderlined = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // rtxtbxText
            // 
            rtxtbxText.Location = new Point(12, 208);
            rtxtbxText.Name = "rtxtbxText";
            rtxtbxText.ReadOnly = true;
            rtxtbxText.Size = new Size(776, 230);
            rtxtbxText.TabIndex = 0;
            rtxtbxText.Text = "";
            // 
            // txtbxText
            // 
            txtbxText.Location = new Point(54, 42);
            txtbxText.Name = "txtbxText";
            txtbxText.PlaceholderText = "Escribe algo...";
            txtbxText.Size = new Size(236, 23);
            txtbxText.TabIndex = 1;
            txtbxText.TextChanged += txtbxText_TextChanged;
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Location = new Point(10, 45);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(38, 15);
            lblTexto.TabIndex = 2;
            lblTexto.Text = "Texto:";
            // 
            // btnAlignCenter
            // 
            btnAlignCenter.FlatAppearance.BorderSize = 2;
            btnAlignCenter.IconChar = FontAwesome.Sharp.IconChar.AlignCenter;
            btnAlignCenter.IconColor = Color.Black;
            btnAlignCenter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAlignCenter.IconSize = 28;
            btnAlignCenter.Location = new Point(704, 178);
            btnAlignCenter.Name = "btnAlignCenter";
            btnAlignCenter.Size = new Size(38, 24);
            btnAlignCenter.TabIndex = 4;
            btnAlignCenter.UseVisualStyleBackColor = true;
            btnAlignCenter.Click += btnAlignCenter_Click;
            // 
            // btnAlignRight
            // 
            btnAlignRight.FlatAppearance.BorderSize = 2;
            btnAlignRight.IconChar = FontAwesome.Sharp.IconChar.AlignRight;
            btnAlignRight.IconColor = Color.Black;
            btnAlignRight.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAlignRight.IconSize = 28;
            btnAlignRight.ImageAlign = ContentAlignment.MiddleRight;
            btnAlignRight.Location = new Point(748, 178);
            btnAlignRight.Name = "btnAlignRight";
            btnAlignRight.Size = new Size(38, 24);
            btnAlignRight.TabIndex = 5;
            btnAlignRight.UseVisualStyleBackColor = true;
            btnAlignRight.Click += btnAlignRight_Click;
            // 
            // btnAlignLeft
            // 
            btnAlignLeft.FlatAppearance.BorderSize = 2;
            btnAlignLeft.IconChar = FontAwesome.Sharp.IconChar.AlignLeft;
            btnAlignLeft.IconColor = Color.Black;
            btnAlignLeft.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAlignLeft.IconSize = 28;
            btnAlignLeft.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlignLeft.Location = new Point(660, 178);
            btnAlignLeft.Name = "btnAlignLeft";
            btnAlignLeft.Size = new Size(38, 24);
            btnAlignLeft.TabIndex = 6;
            btnAlignLeft.TextAlign = ContentAlignment.MiddleLeft;
            btnAlignLeft.UseVisualStyleBackColor = true;
            btnAlignLeft.Click += btnAlignLeft_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(686, 160);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 7;
            label1.Text = "Alinear texto";
            // 
            // cbxSize
            // 
            cbxSize.FormattingEnabled = true;
            cbxSize.Items.AddRange(new object[] { "12", "14", "16", "18", "20", "24", "30", "36", "48", "60", "72" });
            cbxSize.Location = new Point(66, 179);
            cbxSize.Name = "cbxSize";
            cbxSize.Size = new Size(45, 23);
            cbxSize.TabIndex = 9;
            cbxSize.Text = "12";
            cbxSize.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cbxFontFamily
            // 
            cbxFontFamily.FormattingEnabled = true;
            cbxFontFamily.Location = new Point(166, 180);
            cbxFontFamily.Name = "cbxFontFamily";
            cbxFontFamily.Size = new Size(121, 23);
            cbxFontFamily.TabIndex = 10;
            cbxFontFamily.Text = "Arial";
            cbxFontFamily.SelectedIndexChanged += cbxFontFamily_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 182);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 8;
            label2.Text = "Fuente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 182);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 11;
            label3.Text = "Tamaño";
            // 
            // ibtbBold
            // 
            ibtbBold.IconChar = FontAwesome.Sharp.IconChar.Bold;
            ibtbBold.IconColor = Color.Black;
            ibtbBold.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtbBold.IconSize = 16;
            ibtbBold.Location = new Point(388, 182);
            ibtbBold.Name = "ibtbBold";
            ibtbBold.Size = new Size(38, 23);
            ibtbBold.TabIndex = 12;
            ibtbBold.UseVisualStyleBackColor = true;
            ibtbBold.Click += ibtbBold_Click;
            // 
            // ibtbItalic
            // 
            ibtbItalic.IconChar = FontAwesome.Sharp.IconChar.Underline;
            ibtbItalic.IconColor = Color.Black;
            ibtbItalic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtbItalic.IconSize = 16;
            ibtbItalic.Location = new Point(476, 182);
            ibtbItalic.Name = "ibtbItalic";
            ibtbItalic.Size = new Size(38, 23);
            ibtbItalic.TabIndex = 13;
            ibtbItalic.UseVisualStyleBackColor = true;
            ibtbItalic.Click += ibtbunderlined_Click;
            // 
            // ibtbunderlined
            // 
            ibtbunderlined.IconChar = FontAwesome.Sharp.IconChar.Italic;
            ibtbunderlined.IconColor = Color.Black;
            ibtbunderlined.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ibtbunderlined.IconSize = 16;
            ibtbunderlined.Location = new Point(432, 182);
            ibtbunderlined.Name = "ibtbunderlined";
            ibtbunderlined.Size = new Size(38, 23);
            ibtbunderlined.TabIndex = 14;
            ibtbunderlined.UseVisualStyleBackColor = true;
            ibtbunderlined.Click += ibtbItalic_Click;
            // 
            // EditorTextoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ibtbunderlined);
            Controls.Add(ibtbItalic);
            Controls.Add(ibtbBold);
            Controls.Add(label3);
            Controls.Add(cbxFontFamily);
            Controls.Add(cbxSize);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAlignLeft);
            Controls.Add(btnAlignRight);
            Controls.Add(btnAlignCenter);
            Controls.Add(lblTexto);
            Controls.Add(txtbxText);
            Controls.Add(rtxtbxText);
            Name = "EditorTextoView";
            Text = "EditorTexto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtxtbxText;
        private TextBox txtbxText;
        private Label lblTexto;
        private FontAwesome.Sharp.IconButton btnAlignCenter;
        private FontAwesome.Sharp.IconButton btnAlignRight;
        private FontAwesome.Sharp.IconButton btnAlignLeft;
        private Label label1;
        private ComboBox cbxSize;
        private ComboBox cbxFontFamily;
        private Label label2;
        private Label label3;
        private FontAwesome.Sharp.IconButton ibtbBold;
        private FontAwesome.Sharp.IconButton ibtbItalic;
        private FontAwesome.Sharp.IconButton ibtbunderlined;
    }
}