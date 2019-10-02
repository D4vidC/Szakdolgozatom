namespace Vadaszlak_Vendeghaz
{
    partial class FoglalasForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoglalasForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTavozas = new System.Windows.Forms.Label();
            this.labelSzuletes = new System.Windows.Forms.Label();
            this.dtpTavoz = new System.Windows.Forms.DateTimePicker();
            this.dtpErkez = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxKeres = new System.Windows.Forms.ComboBox();
            this.labelFoglal = new System.Windows.Forms.Label();
            this.textFizetett = new System.Windows.Forms.TextBox();
            this.textGyerek = new System.Windows.Forms.TextBox();
            this.textFelnott = new System.Windows.Forms.TextBox();
            this.textLemondott = new System.Windows.Forms.TextBox();
            this.buttonVendegMegse = new System.Windows.Forms.Button();
            this.buttonMentes = new System.Windows.Forms.Button();
            this.textKeres = new System.Windows.Forms.TextBox();
            this.btnEltavolit = new System.Windows.Forms.Button();
            this.btnSzerkeszt = new System.Windows.Forms.Button();
            this.btnFelvesz = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dgvFoglalas = new System.Windows.Forms.DataGridView();
            this.labelVenAz = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoglalas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTavozas
            // 
            this.labelTavozas.AutoSize = true;
            this.labelTavozas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTavozas.Location = new System.Drawing.Point(807, 519);
            this.labelTavozas.Name = "labelTavozas";
            this.labelTavozas.Size = new System.Drawing.Size(72, 20);
            this.labelTavozas.TabIndex = 83;
            this.labelTavozas.Text = "Távozás:";
            this.labelTavozas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSzuletes
            // 
            this.labelSzuletes.AutoSize = true;
            this.labelSzuletes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSzuletes.Location = new System.Drawing.Point(805, 483);
            this.labelSzuletes.Name = "labelSzuletes";
            this.labelSzuletes.Size = new System.Drawing.Size(71, 20);
            this.labelSzuletes.TabIndex = 82;
            this.labelSzuletes.Text = "Érkezés:";
            this.labelSzuletes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpTavoz
            // 
            this.dtpTavoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpTavoz.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTavoz.Location = new System.Drawing.Point(889, 513);
            this.dtpTavoz.Name = "dtpTavoz";
            this.dtpTavoz.Size = new System.Drawing.Size(122, 26);
            this.dtpTavoz.TabIndex = 81;
            this.dtpTavoz.Value = new System.DateTime(2019, 4, 1, 0, 0, 0, 0);
            // 
            // dtpErkez
            // 
            this.dtpErkez.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpErkez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpErkez.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpErkez.Location = new System.Drawing.Point(889, 477);
            this.dtpErkez.Name = "dtpErkez";
            this.dtpErkez.Size = new System.Drawing.Size(121, 26);
            this.dtpErkez.TabIndex = 80;
            this.dtpErkez.Value = new System.DateTime(2019, 4, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(873, 7);
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
            this.comboBoxKeres.Location = new System.Drawing.Point(810, 30);
            this.comboBoxKeres.Name = "comboBoxKeres";
            this.comboBoxKeres.Size = new System.Drawing.Size(202, 24);
            this.comboBoxKeres.TabIndex = 78;
            this.comboBoxKeres.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxKeres_DrawItem);
            // 
            // labelFoglal
            // 
            this.labelFoglal.AutoSize = true;
            this.labelFoglal.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFoglal.Location = new System.Drawing.Point(835, 248);
            this.labelFoglal.Name = "labelFoglal";
            this.labelFoglal.Size = new System.Drawing.Size(149, 33);
            this.labelFoglal.TabIndex = 77;
            this.labelFoglal.Text = "Foglalás Űrlap";
            // 
            // textFizetett
            // 
            this.textFizetett.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.textFizetett.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textFizetett.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textFizetett.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textFizetett.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textFizetett.Location = new System.Drawing.Point(809, 405);
            this.textFizetett.Margin = new System.Windows.Forms.Padding(5);
            this.textFizetett.Name = "textFizetett";
            this.textFizetett.Size = new System.Drawing.Size(202, 26);
            this.textFizetett.TabIndex = 76;
            this.textFizetett.Text = "Fizetett";
            this.textFizetett.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textFizetett.Enter += new System.EventHandler(this.textFizetett_Enter);
            this.textFizetett.Leave += new System.EventHandler(this.textFizetett_Leave);
            // 
            // textGyerek
            // 
            this.textGyerek.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.textGyerek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textGyerek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textGyerek.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textGyerek.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textGyerek.Location = new System.Drawing.Point(809, 369);
            this.textGyerek.Margin = new System.Windows.Forms.Padding(5);
            this.textGyerek.Name = "textGyerek";
            this.textGyerek.Size = new System.Drawing.Size(202, 26);
            this.textGyerek.TabIndex = 74;
            this.textGyerek.Text = "Gyerekek száma";
            this.textGyerek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textGyerek.Enter += new System.EventHandler(this.textGyerek_Enter);
            this.textGyerek.Leave += new System.EventHandler(this.textGyerek_Leave);
            // 
            // textFelnott
            // 
            this.textFelnott.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.textFelnott.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textFelnott.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textFelnott.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textFelnott.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textFelnott.Location = new System.Drawing.Point(809, 333);
            this.textFelnott.Margin = new System.Windows.Forms.Padding(5);
            this.textFelnott.Name = "textFelnott";
            this.textFelnott.Size = new System.Drawing.Size(202, 26);
            this.textFelnott.TabIndex = 73;
            this.textFelnott.Text = "Felnőttek száma";
            this.textFelnott.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textFelnott.Enter += new System.EventHandler(this.textFelnott_Enter);
            this.textFelnott.Leave += new System.EventHandler(this.textFelnott_Leave);
            // 
            // textLemondott
            // 
            this.textLemondott.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.textLemondott.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textLemondott.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textLemondott.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textLemondott.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textLemondott.Location = new System.Drawing.Point(809, 441);
            this.textLemondott.Margin = new System.Windows.Forms.Padding(5);
            this.textLemondott.Name = "textLemondott";
            this.textLemondott.Size = new System.Drawing.Size(202, 26);
            this.textLemondott.TabIndex = 72;
            this.textLemondott.Text = "Lemondott";
            this.textLemondott.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLemondott.Enter += new System.EventHandler(this.textLemondott_Enter);
            this.textLemondott.Leave += new System.EventHandler(this.textLemondott_Leave);
            // 
            // buttonVendegMegse
            // 
            this.buttonVendegMegse.BackColor = System.Drawing.Color.Black;
            this.buttonVendegMegse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonVendegMegse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVendegMegse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVendegMegse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonVendegMegse.Location = new System.Drawing.Point(808, 564);
            this.buttonVendegMegse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 2);
            this.buttonVendegMegse.Name = "buttonVendegMegse";
            this.buttonVendegMegse.Size = new System.Drawing.Size(90, 42);
            this.buttonVendegMegse.TabIndex = 71;
            this.buttonVendegMegse.Text = "Mégse";
            this.buttonVendegMegse.UseVisualStyleBackColor = false;
            // 
            // buttonMentes
            // 
            this.buttonMentes.BackColor = System.Drawing.Color.Black;
            this.buttonMentes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonMentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonMentes.Location = new System.Drawing.Point(922, 565);
            this.buttonMentes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 2);
            this.buttonMentes.Name = "buttonMentes";
            this.buttonMentes.Size = new System.Drawing.Size(90, 42);
            this.buttonMentes.TabIndex = 70;
            this.buttonMentes.Text = "Mentés";
            this.buttonMentes.UseVisualStyleBackColor = false;
            this.buttonMentes.Click += new System.EventHandler(this.buttonMentes_Click);
            // 
            // textKeres
            // 
            this.textKeres.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.textKeres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textKeres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textKeres.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textKeres.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textKeres.Location = new System.Drawing.Point(810, 62);
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
            this.btnEltavolit.Location = new System.Drawing.Point(809, 197);
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
            this.btnSzerkeszt.Location = new System.Drawing.Point(808, 157);
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
            this.btnFelvesz.Location = new System.Drawing.Point(808, 116);
            this.btnFelvesz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 2);
            this.btnFelvesz.Name = "btnFelvesz";
            this.btnFelvesz.Size = new System.Drawing.Size(202, 28);
            this.btnFelvesz.TabIndex = 65;
            this.btnFelvesz.Text = "Új foglalás";
            this.btnFelvesz.UseVisualStyleBackColor = false;
            this.btnFelvesz.Click += new System.EventHandler(this.btnFelvesz_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "159-1598230_png-file-svg-sniper-target-logo.png");
            this.imageList1.Images.SetKeyName(1, "clipart1598230.png");
            // 
            // dgvFoglalas
            // 
            this.dgvFoglalas.AllowUserToAddRows = false;
            this.dgvFoglalas.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFoglalas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFoglalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFoglalas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFoglalas.Location = new System.Drawing.Point(12, 12);
            this.dgvFoglalas.Name = "dgvFoglalas";
            this.dgvFoglalas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFoglalas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFoglalas.Size = new System.Drawing.Size(787, 594);
            this.dgvFoglalas.TabIndex = 86;
            this.dgvFoglalas.Click += new System.EventHandler(this.dgvFoglalas_Click);
            // 
            // labelVenAz
            // 
            this.labelVenAz.AutoSize = true;
            this.labelVenAz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVenAz.Location = new System.Drawing.Point(804, 302);
            this.labelVenAz.Name = "labelVenAz";
            this.labelVenAz.Size = new System.Drawing.Size(146, 20);
            this.labelVenAz.TabIndex = 87;
            this.labelVenAz.Text = "Vendég azonosító: ";
            this.labelVenAz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FoglalasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(1024, 618);
            this.Controls.Add(this.labelVenAz);
            this.Controls.Add(this.dgvFoglalas);
            this.Controls.Add(this.labelTavozas);
            this.Controls.Add(this.labelSzuletes);
            this.Controls.Add(this.dtpTavoz);
            this.Controls.Add(this.dtpErkez);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxKeres);
            this.Controls.Add(this.labelFoglal);
            this.Controls.Add(this.textFizetett);
            this.Controls.Add(this.textGyerek);
            this.Controls.Add(this.textFelnott);
            this.Controls.Add(this.textLemondott);
            this.Controls.Add(this.buttonVendegMegse);
            this.Controls.Add(this.buttonMentes);
            this.Controls.Add(this.textKeres);
            this.Controls.Add(this.btnEltavolit);
            this.Controls.Add(this.btnSzerkeszt);
            this.Controls.Add(this.btnFelvesz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FoglalasForm";
            this.Text = "FoglalasForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoglalas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTavozas;
        private System.Windows.Forms.Label labelSzuletes;
        private System.Windows.Forms.DateTimePicker dtpTavoz;
        private System.Windows.Forms.DateTimePicker dtpErkez;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxKeres;
        private System.Windows.Forms.Label labelFoglal;
        private System.Windows.Forms.TextBox textFizetett;
        private System.Windows.Forms.TextBox textGyerek;
        public System.Windows.Forms.TextBox textFelnott;
        private System.Windows.Forms.TextBox textLemondott;
        private System.Windows.Forms.Button buttonVendegMegse;
        private System.Windows.Forms.Button buttonMentes;
        public System.Windows.Forms.TextBox textKeres;
        private System.Windows.Forms.Button btnEltavolit;
        private System.Windows.Forms.Button btnSzerkeszt;
        private System.Windows.Forms.Button btnFelvesz;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dgvFoglalas;
        private System.Windows.Forms.Label labelVenAz;
    }
}