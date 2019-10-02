namespace Vadaszlak_Vendeghaz
{
    partial class KoltsegForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxKeres = new System.Windows.Forms.ComboBox();
            this.labelUrlap = new System.Windows.Forms.Label();
            this.textUzemanyag = new System.Windows.Forms.TextBox();
            this.textEgyeb = new System.Windows.Forms.TextBox();
            this.textTisztitoszer = new System.Windows.Forms.TextBox();
            this.textRezsi = new System.Windows.Forms.TextBox();
            this.textFelujitas = new System.Windows.Forms.TextBox();
            this.buttonVendegMegse = new System.Windows.Forms.Button();
            this.buttonVendegMentes = new System.Windows.Forms.Button();
            this.textKeres = new System.Windows.Forms.TextBox();
            this.btnEltavolit = new System.Windows.Forms.Button();
            this.btnSzerkeszt = new System.Windows.Forms.Button();
            this.btnFelvesz = new System.Windows.Forms.Button();
            this.dgvKoltseg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKoltseg)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(879, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 79;
            this.label3.Text = "Szűrés:";
            // 
            // comboBoxKeres
            // 
            this.comboBoxKeres.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.comboBoxKeres.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxKeres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxKeres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxKeres.FormattingEnabled = true;
            this.comboBoxKeres.Location = new System.Drawing.Point(810, 36);
            this.comboBoxKeres.Name = "comboBoxKeres";
            this.comboBoxKeres.Size = new System.Drawing.Size(202, 24);
            this.comboBoxKeres.TabIndex = 78;
            this.comboBoxKeres.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxKeres_DrawItem);
            this.comboBoxKeres.SelectedIndexChanged += new System.EventHandler(this.comboBoxKeres_SelectedIndexChanged);
            // 
            // labelUrlap
            // 
            this.labelUrlap.AutoSize = true;
            this.labelUrlap.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUrlap.Location = new System.Drawing.Point(838, 135);
            this.labelUrlap.Name = "labelUrlap";
            this.labelUrlap.Size = new System.Drawing.Size(144, 33);
            this.labelUrlap.TabIndex = 77;
            this.labelUrlap.Text = "Költség Űrlap";
            // 
            // textUzemanyag
            // 
            this.textUzemanyag.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.textUzemanyag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textUzemanyag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textUzemanyag.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textUzemanyag.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textUzemanyag.Location = new System.Drawing.Point(810, 434);
            this.textUzemanyag.Margin = new System.Windows.Forms.Padding(5);
            this.textUzemanyag.Name = "textUzemanyag";
            this.textUzemanyag.Size = new System.Drawing.Size(202, 26);
            this.textUzemanyag.TabIndex = 76;
            this.textUzemanyag.Text = "Üzemanyag";
            this.textUzemanyag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textUzemanyag.Enter += new System.EventHandler(this.textUzemanyag_Enter);
            this.textUzemanyag.Leave += new System.EventHandler(this.textUzemanyag_Leave);
            // 
            // textEgyeb
            // 
            this.textEgyeb.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.textEgyeb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEgyeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textEgyeb.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textEgyeb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textEgyeb.Location = new System.Drawing.Point(809, 506);
            this.textEgyeb.Margin = new System.Windows.Forms.Padding(5);
            this.textEgyeb.Name = "textEgyeb";
            this.textEgyeb.Size = new System.Drawing.Size(202, 26);
            this.textEgyeb.TabIndex = 75;
            this.textEgyeb.Text = "Egyéb";
            this.textEgyeb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textEgyeb.Enter += new System.EventHandler(this.textEgyeb_Enter);
            this.textEgyeb.Leave += new System.EventHandler(this.textEgyeb_Leave);
            // 
            // textTisztitoszer
            // 
            this.textTisztitoszer.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.textTisztitoszer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTisztitoszer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textTisztitoszer.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textTisztitoszer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textTisztitoszer.Location = new System.Drawing.Point(810, 398);
            this.textTisztitoszer.Margin = new System.Windows.Forms.Padding(5);
            this.textTisztitoszer.Name = "textTisztitoszer";
            this.textTisztitoszer.Size = new System.Drawing.Size(202, 26);
            this.textTisztitoszer.TabIndex = 74;
            this.textTisztitoszer.Text = "Tisztítószerek";
            this.textTisztitoszer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textTisztitoszer.Enter += new System.EventHandler(this.textTisztitoszer_Enter);
            this.textTisztitoszer.Leave += new System.EventHandler(this.textTisztitoszer_Leave);
            // 
            // textRezsi
            // 
            this.textRezsi.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.textRezsi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textRezsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textRezsi.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textRezsi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textRezsi.Location = new System.Drawing.Point(810, 362);
            this.textRezsi.Margin = new System.Windows.Forms.Padding(5);
            this.textRezsi.Name = "textRezsi";
            this.textRezsi.Size = new System.Drawing.Size(202, 26);
            this.textRezsi.TabIndex = 73;
            this.textRezsi.Text = "Rezsi";
            this.textRezsi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textRezsi.Enter += new System.EventHandler(this.textRezsi_Enter);
            this.textRezsi.Leave += new System.EventHandler(this.textRezsi_Leave);
            // 
            // textFelujitas
            // 
            this.textFelujitas.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.textFelujitas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textFelujitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textFelujitas.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textFelujitas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textFelujitas.Location = new System.Drawing.Point(810, 470);
            this.textFelujitas.Margin = new System.Windows.Forms.Padding(5);
            this.textFelujitas.Name = "textFelujitas";
            this.textFelujitas.Size = new System.Drawing.Size(202, 26);
            this.textFelujitas.TabIndex = 72;
            this.textFelujitas.Text = "Felújítás";
            this.textFelujitas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textFelujitas.Enter += new System.EventHandler(this.textFelujitas_Enter);
            this.textFelujitas.Leave += new System.EventHandler(this.textFelujitas_Leave);
            // 
            // buttonVendegMegse
            // 
            this.buttonVendegMegse.BackColor = System.Drawing.Color.Black;
            this.buttonVendegMegse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonVendegMegse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVendegMegse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVendegMegse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonVendegMegse.Location = new System.Drawing.Point(809, 565);
            this.buttonVendegMegse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 2);
            this.buttonVendegMegse.Name = "buttonVendegMegse";
            this.buttonVendegMegse.Size = new System.Drawing.Size(90, 42);
            this.buttonVendegMegse.TabIndex = 71;
            this.buttonVendegMegse.Text = "Mégse";
            this.buttonVendegMegse.UseVisualStyleBackColor = false;
            // 
            // buttonVendegMentes
            // 
            this.buttonVendegMentes.BackColor = System.Drawing.Color.Black;
            this.buttonVendegMentes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonVendegMentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVendegMentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVendegMentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonVendegMentes.Location = new System.Drawing.Point(921, 565);
            this.buttonVendegMentes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 2);
            this.buttonVendegMentes.Name = "buttonVendegMentes";
            this.buttonVendegMentes.Size = new System.Drawing.Size(90, 42);
            this.buttonVendegMentes.TabIndex = 70;
            this.buttonVendegMentes.Text = "Mentés";
            this.buttonVendegMentes.UseVisualStyleBackColor = false;
            this.buttonVendegMentes.Click += new System.EventHandler(this.buttonVendegMentes_Click);
            // 
            // textKeres
            // 
            this.textKeres.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.textKeres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textKeres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textKeres.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textKeres.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textKeres.Location = new System.Drawing.Point(810, 68);
            this.textKeres.Margin = new System.Windows.Forms.Padding(5);
            this.textKeres.Name = "textKeres";
            this.textKeres.Size = new System.Drawing.Size(202, 26);
            this.textKeres.TabIndex = 69;
            this.textKeres.Text = "Keresés...";
            this.textKeres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textKeres.TextChanged += new System.EventHandler(this.textKeres_TextChanged);
            this.textKeres.Enter += new System.EventHandler(this.textKeres_Enter);
            this.textKeres.Leave += new System.EventHandler(this.textKeres_Leave);
            // 
            // btnEltavolit
            // 
            this.btnEltavolit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEltavolit.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnEltavolit.FlatAppearance.BorderSize = 0;
            this.btnEltavolit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEltavolit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEltavolit.Location = new System.Drawing.Point(810, 286);
            this.btnEltavolit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 2);
            this.btnEltavolit.Name = "btnEltavolit";
            this.btnEltavolit.Size = new System.Drawing.Size(202, 26);
            this.btnEltavolit.TabIndex = 68;
            this.btnEltavolit.Text = "Eltávolít";
            this.btnEltavolit.UseVisualStyleBackColor = false;
            this.btnEltavolit.Click += new System.EventHandler(this.btnEltavolit_Click);
            // 
            // btnSzerkeszt
            // 
            this.btnSzerkeszt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSzerkeszt.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnSzerkeszt.FlatAppearance.BorderSize = 0;
            this.btnSzerkeszt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSzerkeszt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzerkeszt.Location = new System.Drawing.Point(810, 245);
            this.btnSzerkeszt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 2);
            this.btnSzerkeszt.Name = "btnSzerkeszt";
            this.btnSzerkeszt.Size = new System.Drawing.Size(202, 26);
            this.btnSzerkeszt.TabIndex = 67;
            this.btnSzerkeszt.Text = "Szerkeszt";
            this.btnSzerkeszt.UseVisualStyleBackColor = false;
            this.btnSzerkeszt.Click += new System.EventHandler(this.btnSzerkeszt_Click);
            // 
            // btnFelvesz
            // 
            this.btnFelvesz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFelvesz.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnFelvesz.FlatAppearance.BorderSize = 0;
            this.btnFelvesz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFelvesz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFelvesz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFelvesz.Location = new System.Drawing.Point(810, 202);
            this.btnFelvesz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 2);
            this.btnFelvesz.Name = "btnFelvesz";
            this.btnFelvesz.Size = new System.Drawing.Size(202, 28);
            this.btnFelvesz.TabIndex = 65;
            this.btnFelvesz.Text = "Új költség";
            this.btnFelvesz.UseVisualStyleBackColor = false;
            this.btnFelvesz.Click += new System.EventHandler(this.btnFelvesz_Click);
            // 
            // dgvKoltseg
            // 
            this.dgvKoltseg.AllowUserToAddRows = false;
            this.dgvKoltseg.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            this.dgvKoltseg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKoltseg.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKoltseg.Location = new System.Drawing.Point(10, 12);
            this.dgvKoltseg.Name = "dgvKoltseg";
            this.dgvKoltseg.ReadOnly = true;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            this.dgvKoltseg.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKoltseg.Size = new System.Drawing.Size(788, 595);
            this.dgvKoltseg.TabIndex = 80;
            this.dgvKoltseg.Click += new System.EventHandler(this.dgvKoltseg_Click);
            // 
            // KoltsegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(1024, 618);
            this.Controls.Add(this.dgvKoltseg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxKeres);
            this.Controls.Add(this.labelUrlap);
            this.Controls.Add(this.textUzemanyag);
            this.Controls.Add(this.textEgyeb);
            this.Controls.Add(this.textTisztitoszer);
            this.Controls.Add(this.textRezsi);
            this.Controls.Add(this.textFelujitas);
            this.Controls.Add(this.buttonVendegMegse);
            this.Controls.Add(this.buttonVendegMentes);
            this.Controls.Add(this.textKeres);
            this.Controls.Add(this.btnEltavolit);
            this.Controls.Add(this.btnSzerkeszt);
            this.Controls.Add(this.btnFelvesz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KoltsegForm";
            this.Text = "KoltsegForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKoltseg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxKeres;
        private System.Windows.Forms.Label labelUrlap;
        private System.Windows.Forms.TextBox textUzemanyag;
        private System.Windows.Forms.TextBox textEgyeb;
        private System.Windows.Forms.TextBox textTisztitoszer;
        public System.Windows.Forms.TextBox textRezsi;
        private System.Windows.Forms.TextBox textFelujitas;
        private System.Windows.Forms.Button buttonVendegMegse;
        private System.Windows.Forms.Button buttonVendegMentes;
        public System.Windows.Forms.TextBox textKeres;
        private System.Windows.Forms.Button btnEltavolit;
        private System.Windows.Forms.Button btnSzerkeszt;
        private System.Windows.Forms.Button btnFelvesz;
        private System.Windows.Forms.DataGridView dgvKoltseg;
    }
}