namespace Vadaszlak_Vendeghaz
{
    partial class VendegForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelSzuletes = new System.Windows.Forms.Label();
            this.dtpSzulet = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxKeres = new System.Windows.Forms.ComboBox();
            this.labelUrlap = new System.Windows.Forms.Label();
            this.textTelefon = new System.Windows.Forms.TextBox();
            this.textMegye = new System.Windows.Forms.TextBox();
            this.textKereszt = new System.Windows.Forms.TextBox();
            this.textVezetek = new System.Windows.Forms.TextBox();
            this.textLakcim = new System.Windows.Forms.TextBox();
            this.buttonVendegMegse = new System.Windows.Forms.Button();
            this.btnMentMod = new System.Windows.Forms.Button();
            this.textKeres = new System.Windows.Forms.TextBox();
            this.btnEltavolit = new System.Windows.Forms.Button();
            this.btnSzerkeszt = new System.Windows.Forms.Button();
            this.btnUjvendeg = new System.Windows.Forms.Button();
            this.dgvVendeg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendeg)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSzuletes
            // 
            this.labelSzuletes.AutoSize = true;
            this.labelSzuletes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSzuletes.Location = new System.Drawing.Point(811, 493);
            this.labelSzuletes.Name = "labelSzuletes";
            this.labelSzuletes.Size = new System.Drawing.Size(103, 20);
            this.labelSzuletes.TabIndex = 63;
            this.labelSzuletes.Text = "Születési idő:";
            this.labelSzuletes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpSzulet
            // 
            this.dtpSzulet.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpSzulet.CalendarMonthBackground = System.Drawing.Color.PaleGoldenrod;
            this.dtpSzulet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpSzulet.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSzulet.Location = new System.Drawing.Point(816, 516);
            this.dtpSzulet.Name = "dtpSzulet";
            this.dtpSzulet.Size = new System.Drawing.Size(202, 26);
            this.dtpSzulet.TabIndex = 61;
            this.dtpSzulet.Value = new System.DateTime(1969, 3, 23, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(887, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 60;
            this.label3.Text = "Szűrés:";
            // 
            // comboBoxKeres
            // 
            this.comboBoxKeres.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.comboBoxKeres.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxKeres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxKeres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxKeres.FormattingEnabled = true;
            this.comboBoxKeres.Location = new System.Drawing.Point(816, 39);
            this.comboBoxKeres.Name = "comboBoxKeres";
            this.comboBoxKeres.Size = new System.Drawing.Size(202, 24);
            this.comboBoxKeres.TabIndex = 59;
            this.comboBoxKeres.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxKeres_DrawItem);
            // 
            // labelUrlap
            // 
            this.labelUrlap.AutoSize = true;
            this.labelUrlap.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUrlap.Location = new System.Drawing.Point(844, 277);
            this.labelUrlap.Name = "labelUrlap";
            this.labelUrlap.Size = new System.Drawing.Size(147, 33);
            this.labelUrlap.TabIndex = 58;
            this.labelUrlap.Text = "Vendég Űrlap";
            // 
            // textTelefon
            // 
            this.textTelefon.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.textTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textTelefon.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textTelefon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textTelefon.Location = new System.Drawing.Point(816, 390);
            this.textTelefon.Margin = new System.Windows.Forms.Padding(5);
            this.textTelefon.Name = "textTelefon";
            this.textTelefon.Size = new System.Drawing.Size(202, 26);
            this.textTelefon.TabIndex = 57;
            this.textTelefon.Text = "Telefonszám";
            this.textTelefon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textTelefon.Enter += new System.EventHandler(this.textTelefon_Enter);
            this.textTelefon.Leave += new System.EventHandler(this.textTelefon_Leave);
            // 
            // textMegye
            // 
            this.textMegye.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.textMegye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textMegye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textMegye.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textMegye.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textMegye.Location = new System.Drawing.Point(815, 462);
            this.textMegye.Margin = new System.Windows.Forms.Padding(5);
            this.textMegye.Name = "textMegye";
            this.textMegye.Size = new System.Drawing.Size(202, 26);
            this.textMegye.TabIndex = 56;
            this.textMegye.Text = "Megye";
            this.textMegye.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textMegye.Enter += new System.EventHandler(this.textMegye_Enter);
            this.textMegye.Leave += new System.EventHandler(this.textMegye_Leave);
            // 
            // textKereszt
            // 
            this.textKereszt.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.textKereszt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textKereszt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textKereszt.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textKereszt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textKereszt.Location = new System.Drawing.Point(816, 354);
            this.textKereszt.Margin = new System.Windows.Forms.Padding(5);
            this.textKereszt.Name = "textKereszt";
            this.textKereszt.Size = new System.Drawing.Size(202, 26);
            this.textKereszt.TabIndex = 55;
            this.textKereszt.Text = "Keresztnév";
            this.textKereszt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textKereszt.Enter += new System.EventHandler(this.textKereszt_Enter);
            this.textKereszt.Leave += new System.EventHandler(this.textKereszt_Leave);
            // 
            // textVezetek
            // 
            this.textVezetek.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.textVezetek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textVezetek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textVezetek.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textVezetek.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textVezetek.Location = new System.Drawing.Point(816, 318);
            this.textVezetek.Margin = new System.Windows.Forms.Padding(5);
            this.textVezetek.Name = "textVezetek";
            this.textVezetek.Size = new System.Drawing.Size(202, 26);
            this.textVezetek.TabIndex = 54;
            this.textVezetek.Text = "Vezetéknév";
            this.textVezetek.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textVezetek.Enter += new System.EventHandler(this.textVezetek_Enter);
            this.textVezetek.Leave += new System.EventHandler(this.textVezetek_Leave);
            // 
            // textLakcim
            // 
            this.textLakcim.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.textLakcim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textLakcim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textLakcim.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textLakcim.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textLakcim.Location = new System.Drawing.Point(816, 426);
            this.textLakcim.Margin = new System.Windows.Forms.Padding(5);
            this.textLakcim.Name = "textLakcim";
            this.textLakcim.Size = new System.Drawing.Size(202, 26);
            this.textLakcim.TabIndex = 53;
            this.textLakcim.Text = "Lakcím";
            this.textLakcim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textLakcim.Enter += new System.EventHandler(this.textLakcim_Enter);
            this.textLakcim.Leave += new System.EventHandler(this.textLakcim_Leave);
            // 
            // buttonVendegMegse
            // 
            this.buttonVendegMegse.BackColor = System.Drawing.Color.Black;
            this.buttonVendegMegse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonVendegMegse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVendegMegse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVendegMegse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonVendegMegse.Location = new System.Drawing.Point(815, 565);
            this.buttonVendegMegse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 2);
            this.buttonVendegMegse.Name = "buttonVendegMegse";
            this.buttonVendegMegse.Size = new System.Drawing.Size(90, 42);
            this.buttonVendegMegse.TabIndex = 52;
            this.buttonVendegMegse.Text = "Mégse";
            this.buttonVendegMegse.UseVisualStyleBackColor = false;
            this.buttonVendegMegse.Click += new System.EventHandler(this.buttonVendegMegse_Click);
            // 
            // btnMentMod
            // 
            this.btnMentMod.BackColor = System.Drawing.Color.Black;
            this.btnMentMod.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMentMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMentMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMentMod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMentMod.Location = new System.Drawing.Point(927, 564);
            this.btnMentMod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 2);
            this.btnMentMod.Name = "btnMentMod";
            this.btnMentMod.Size = new System.Drawing.Size(90, 42);
            this.btnMentMod.TabIndex = 51;
            this.btnMentMod.Text = "Mentés";
            this.btnMentMod.UseVisualStyleBackColor = false;
            this.btnMentMod.Click += new System.EventHandler(this.buttonVendegMentes_Click);
            // 
            // textKeres
            // 
            this.textKeres.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.textKeres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textKeres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textKeres.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textKeres.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textKeres.Location = new System.Drawing.Point(816, 71);
            this.textKeres.Margin = new System.Windows.Forms.Padding(5);
            this.textKeres.Name = "textKeres";
            this.textKeres.Size = new System.Drawing.Size(202, 26);
            this.textKeres.TabIndex = 50;
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
            this.btnEltavolit.Location = new System.Drawing.Point(817, 233);
            this.btnEltavolit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 2);
            this.btnEltavolit.Name = "btnEltavolit";
            this.btnEltavolit.Size = new System.Drawing.Size(202, 26);
            this.btnEltavolit.TabIndex = 49;
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
            this.btnSzerkeszt.Location = new System.Drawing.Point(817, 201);
            this.btnSzerkeszt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 2);
            this.btnSzerkeszt.Name = "btnSzerkeszt";
            this.btnSzerkeszt.Size = new System.Drawing.Size(202, 26);
            this.btnSzerkeszt.TabIndex = 48;
            this.btnSzerkeszt.Text = "Szerkeszt";
            this.btnSzerkeszt.UseVisualStyleBackColor = false;
            this.btnSzerkeszt.Click += new System.EventHandler(this.btnSzerkeszt_Click);
            // 
            // btnUjvendeg
            // 
            this.btnUjvendeg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUjvendeg.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnUjvendeg.FlatAppearance.BorderSize = 0;
            this.btnUjvendeg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUjvendeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUjvendeg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUjvendeg.Location = new System.Drawing.Point(817, 166);
            this.btnUjvendeg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 2);
            this.btnUjvendeg.Name = "btnUjvendeg";
            this.btnUjvendeg.Size = new System.Drawing.Size(202, 28);
            this.btnUjvendeg.TabIndex = 46;
            this.btnUjvendeg.Text = "Új vendég";
            this.btnUjvendeg.UseVisualStyleBackColor = false;
            this.btnUjvendeg.Click += new System.EventHandler(this.btnFelvesz_Click);
            // 
            // dgvVendeg
            // 
            this.dgvVendeg.AllowUserToAddRows = false;
            this.dgvVendeg.BackgroundColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVendeg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVendeg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVendeg.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVendeg.Location = new System.Drawing.Point(13, 12);
            this.dgvVendeg.Name = "dgvVendeg";
            this.dgvVendeg.ReadOnly = true;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            this.dgvVendeg.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVendeg.Size = new System.Drawing.Size(797, 594);
            this.dgvVendeg.TabIndex = 64;
            this.dgvVendeg.Click += new System.EventHandler(this.DataGVVendeg_Click);
            // 
            // VendegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(1024, 618);
            this.Controls.Add(this.dgvVendeg);
            this.Controls.Add(this.labelSzuletes);
            this.Controls.Add(this.dtpSzulet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxKeres);
            this.Controls.Add(this.labelUrlap);
            this.Controls.Add(this.textTelefon);
            this.Controls.Add(this.textMegye);
            this.Controls.Add(this.textKereszt);
            this.Controls.Add(this.textVezetek);
            this.Controls.Add(this.textLakcim);
            this.Controls.Add(this.buttonVendegMegse);
            this.Controls.Add(this.btnMentMod);
            this.Controls.Add(this.textKeres);
            this.Controls.Add(this.btnEltavolit);
            this.Controls.Add(this.btnSzerkeszt);
            this.Controls.Add(this.btnUjvendeg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VendegForm";
            this.Text = "VendegForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendeg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSzuletes;
        private System.Windows.Forms.DateTimePicker dtpSzulet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxKeres;
        private System.Windows.Forms.Label labelUrlap;
        private System.Windows.Forms.TextBox textTelefon;
        private System.Windows.Forms.TextBox textMegye;
        private System.Windows.Forms.TextBox textKereszt;
        public System.Windows.Forms.TextBox textVezetek;
        private System.Windows.Forms.TextBox textLakcim;
        private System.Windows.Forms.Button buttonVendegMegse;
        private System.Windows.Forms.Button btnMentMod;
        public System.Windows.Forms.TextBox textKeres;
        private System.Windows.Forms.Button btnEltavolit;
        private System.Windows.Forms.Button btnSzerkeszt;
        private System.Windows.Forms.Button btnUjvendeg;
        private System.Windows.Forms.DataGridView dgvVendeg;
    }
}