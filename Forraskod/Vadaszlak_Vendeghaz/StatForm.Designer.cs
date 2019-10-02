namespace Vadaszlak_Vendeghaz
{
    partial class StatForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelLemondEredm = new System.Windows.Forms.Label();
            this.comboBoxGraf = new System.Windows.Forms.ComboBox();
            this.labelOsszVenEr = new System.Windows.Forms.Label();
            this.labelOsszBev = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxEvek = new System.Windows.Forms.ComboBox();
            this.dtpMettol = new System.Windows.Forms.DateTimePicker();
            this.dtpMeddig = new System.Windows.Forms.DateTimePicker();
            this.labelEgyfo = new System.Windows.Forms.Label();
            this.labelIdoszak = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelEgyfoSzaz = new System.Windows.Forms.Label();
            this.labelEgyforeOsszeg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.PaleGoldenrod;
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.OliveDrab};
            series4.ChartArea = "ChartArea1";
            series4.IsValueShownAsLabel = true;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series";
            series4.YValuesPerPoint = 6;
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(734, 594);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            title4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            title4.Name = "Title1";
            this.chart1.Titles.Add(title4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(770, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Teljes bevétel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(770, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Teljes vendégszám:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(770, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lemondott foglalások:";
            // 
            // labelLemondEredm
            // 
            this.labelLemondEredm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLemondEredm.Location = new System.Drawing.Point(942, 214);
            this.labelLemondEredm.Name = "labelLemondEredm";
            this.labelLemondEredm.Size = new System.Drawing.Size(62, 20);
            this.labelLemondEredm.TabIndex = 9;
            this.labelLemondEredm.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBoxGraf
            // 
            this.comboBoxGraf.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.comboBoxGraf.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxGraf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxGraf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxGraf.FormattingEnabled = true;
            this.comboBoxGraf.Location = new System.Drawing.Point(774, 50);
            this.comboBoxGraf.Name = "comboBoxGraf";
            this.comboBoxGraf.Size = new System.Drawing.Size(230, 25);
            this.comboBoxGraf.TabIndex = 11;
            this.comboBoxGraf.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBoxGraf_DrawItem);
            this.comboBoxGraf.SelectedIndexChanged += new System.EventHandler(this.comboBoxGraf_SelectedIndexChanged);
            // 
            // labelOsszVenEr
            // 
            this.labelOsszVenEr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOsszVenEr.Location = new System.Drawing.Point(924, 168);
            this.labelOsszVenEr.Name = "labelOsszVenEr";
            this.labelOsszVenEr.Size = new System.Drawing.Size(80, 20);
            this.labelOsszVenEr.TabIndex = 12;
            this.labelOsszVenEr.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelOsszBev
            // 
            this.labelOsszBev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOsszBev.Location = new System.Drawing.Point(885, 127);
            this.labelOsszBev.Name = "labelOsszBev";
            this.labelOsszBev.Size = new System.Drawing.Size(119, 20);
            this.labelOsszBev.TabIndex = 13;
            this.labelOsszBev.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(818, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 43);
            this.label8.TabIndex = 14;
            this.label8.Text = "Grafikonok ";
            // 
            // comboBoxEvek
            // 
            this.comboBoxEvek.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.comboBoxEvek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEvek.FormattingEnabled = true;
            this.comboBoxEvek.Location = new System.Drawing.Point(891, 83);
            this.comboBoxEvek.Name = "comboBoxEvek";
            this.comboBoxEvek.Size = new System.Drawing.Size(113, 21);
            this.comboBoxEvek.TabIndex = 15;
            this.comboBoxEvek.SelectedIndexChanged += new System.EventHandler(this.comboBoxEvek_SelectedIndexChanged);
            // 
            // dtpMettol
            // 
            this.dtpMettol.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpMettol.CalendarMonthBackground = System.Drawing.Color.PaleGoldenrod;
            this.dtpMettol.CustomFormat = "yyyy-MM-dd";
            this.dtpMettol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpMettol.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMettol.Location = new System.Drawing.Point(891, 431);
            this.dtpMettol.Name = "dtpMettol";
            this.dtpMettol.Size = new System.Drawing.Size(113, 24);
            this.dtpMettol.TabIndex = 16;
            this.dtpMettol.Value = new System.DateTime(2019, 3, 11, 0, 0, 0, 0);
            this.dtpMettol.ValueChanged += new System.EventHandler(this.dtpMettol_ValueChanged);
            // 
            // dtpMeddig
            // 
            this.dtpMeddig.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpMeddig.CustomFormat = "yyyy-MM-dd";
            this.dtpMeddig.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpMeddig.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMeddig.Location = new System.Drawing.Point(891, 461);
            this.dtpMeddig.Name = "dtpMeddig";
            this.dtpMeddig.Size = new System.Drawing.Size(113, 24);
            this.dtpMeddig.TabIndex = 18;
            this.dtpMeddig.Value = new System.DateTime(2019, 3, 11, 0, 0, 0, 0);
            this.dtpMeddig.ValueChanged += new System.EventHandler(this.dtpMeddig_ValueChanged);
            // 
            // labelEgyfo
            // 
            this.labelEgyfo.AutoSize = true;
            this.labelEgyfo.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEgyfo.Location = new System.Drawing.Point(781, 379);
            this.labelEgyfo.Name = "labelEgyfo";
            this.labelEgyfo.Size = new System.Drawing.Size(231, 33);
            this.labelEgyfo.TabIndex = 19;
            this.labelEgyfo.Text = "Egy főre jutó kiadások";
            // 
            // labelIdoszak
            // 
            this.labelIdoszak.AutoSize = true;
            this.labelIdoszak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIdoszak.Location = new System.Drawing.Point(770, 84);
            this.labelIdoszak.Name = "labelIdoszak";
            this.labelIdoszak.Size = new System.Drawing.Size(48, 20);
            this.labelIdoszak.TabIndex = 20;
            this.labelIdoszak.Text = "Évek:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(770, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mettől:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(770, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Meddig:";
            // 
            // labelEgyfoSzaz
            // 
            this.labelEgyfoSzaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEgyfoSzaz.Location = new System.Drawing.Point(770, 500);
            this.labelEgyfoSzaz.Name = "labelEgyfoSzaz";
            this.labelEgyfoSzaz.Size = new System.Drawing.Size(209, 29);
            this.labelEgyfoSzaz.TabIndex = 23;
            // 
            // labelEgyforeOsszeg
            // 
            this.labelEgyforeOsszeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEgyforeOsszeg.Location = new System.Drawing.Point(770, 529);
            this.labelEgyforeOsszeg.Name = "labelEgyforeOsszeg";
            this.labelEgyforeOsszeg.Size = new System.Drawing.Size(230, 36);
            this.labelEgyforeOsszeg.TabIndex = 24;
            // 
            // StatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(1024, 618);
            this.Controls.Add(this.labelEgyforeOsszeg);
            this.Controls.Add(this.labelEgyfoSzaz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelIdoszak);
            this.Controls.Add(this.labelEgyfo);
            this.Controls.Add(this.dtpMeddig);
            this.Controls.Add(this.dtpMettol);
            this.Controls.Add(this.comboBoxEvek);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelOsszBev);
            this.Controls.Add(this.labelOsszVenEr);
            this.Controls.Add(this.comboBoxGraf);
            this.Controls.Add(this.labelLemondEredm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatForm";
            this.Text = "StatForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelLemondEredm;
        private System.Windows.Forms.ComboBox comboBoxGraf;
        private System.Windows.Forms.Label labelOsszVenEr;
        private System.Windows.Forms.Label labelOsszBev;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpMettol;
        private System.Windows.Forms.DateTimePicker dtpMeddig;
        private System.Windows.Forms.Label labelEgyfo;
        private System.Windows.Forms.Label labelIdoszak;
        public System.Windows.Forms.ComboBox comboBoxEvek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelEgyfoSzaz;
        private System.Windows.Forms.Label labelEgyforeOsszeg;
    }
}