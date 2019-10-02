using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Cursor = System.Windows.Forms.Cursor;

namespace Vadaszlak_Vendeghaz
{
    public partial class Foablak : Form
    {
        public static Cursor CreateCursor(Bitmap bm, Size size)
        {
            bm = new Bitmap(bm, size);
            return new Cursor(bm.GetHicon());
        }

        MySqlConnection myConn = new MySqlConnection("server=remotemysql.com;user id=yN6LYJnGl2; password=i72zP359qP; database=yN6LYJnGl2; charset=utf8");
        MySqlCommand myComm1;
        Point mouseDownPoint = Point.Empty;
        MySqlDataReader dr;
        int rekordID;
        public Point egerHelye;


        public Foablak()
        {
            InitializeComponent();
            MenuSzinez(1);
            VendegForm vendegF = new VendegForm();
            panelFo.Controls.Clear();
            vendegF.TopLevel = false;
            panelFo.Controls.Add(vendegF);
            vendegF.Dock = DockStyle.Fill;
            vendegF.Show();
            this.Cursor = Form1.CreateCursor((Bitmap)imageList2.Images[0], new Size(30, 30));
        }

        void MenuSzinez(int szam)
        {
            btnVendeg.BackColor = Color.DarkKhaki;
            btnFoglalas.BackColor = Color.DarkKhaki;
            btnKoltsegek.BackColor = Color.DarkKhaki;
            btnStat.BackColor = Color.DarkKhaki;
            btnJelszo.BackColor = Color.DarkKhaki;
            btnVendeg.BackColor = Color.DarkKhaki;

            btnVendeg.ForeColor = Color.Black;
            btnFoglalas.ForeColor = Color.Black;
            btnKoltsegek.ForeColor = Color.Black;
            btnStat.ForeColor = Color.Black;
            btnJelszo.ForeColor = Color.Black;
            btnVendeg.ForeColor = Color.Black;

            Color hatterSzin = Color.Black;
            Color szovegSzin = Color.PaleGoldenrod;

            switch (szam)
            {
                case 1:
                    btnVendeg.BackColor = hatterSzin; 
                    btnVendeg.ForeColor = szovegSzin; break;
                case 2:
                    btnFoglalas.BackColor = hatterSzin;
                    btnFoglalas.ForeColor = szovegSzin; break;
                case 3:
                    btnKoltsegek.BackColor = hatterSzin; 
                    btnKoltsegek.ForeColor = szovegSzin; break;
                case 4:
                    btnStat.BackColor = hatterSzin; 
                    btnStat.ForeColor = szovegSzin; break;
                case 5:
                    btnJelszo.BackColor = hatterSzin; 
                    btnJelszo.ForeColor = szovegSzin; break;
                case 6:
                    btnKijelentezes.BackColor = hatterSzin; 
                    btnKijelentezes.ForeColor = szovegSzin; break;
            }
        }

        private void Foablak_MouseDown(object sender, MouseEventArgs e)
        {
            egerHelye = new Point(-e.X, -e.Y);
        }

        private void Foablak_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point egerPoz = Control.MousePosition;
                egerPoz.Offset(egerHelye.X, egerPoz.Y);
                Location = egerPoz;
            }
        }

        public void BtnFoglalas()
        {
            FoglalasForm foglalasF = new FoglalasForm();
            panelFo.Controls.Clear();
            foglalasF.TopLevel = false;
            panelFo.Controls.Add(foglalasF);
            foglalasF.Dock = DockStyle.Fill;
            foglalasF.Show();
            MenuSzinez(2);

        }

        private void btnFoglalas_Click(object sender, EventArgs e)
        {
            BtnFoglalas();
        }

        private void btnVendeg_Click(object sender, EventArgs e)
        {
            VendegForm vendegF = new VendegForm();
            panelFo.Controls.Clear();
            vendegF.TopLevel = false;
            panelFo.Controls.Add(vendegF);
            vendegF.Dock = DockStyle.Fill;
            vendegF.Show();
            MenuSzinez(1);
        }

        private void btnKoltsegek_Click(object sender, EventArgs e)
        {
            KoltsegForm koltsegF = new KoltsegForm();
            panelFo.Controls.Clear();
            koltsegF.TopLevel = false;
            panelFo.Controls.Add(koltsegF);
            koltsegF.Dock = DockStyle.Fill;
            koltsegF.Show();
            MenuSzinez(3);
        }

        private void btnStat_Click(object sender, EventArgs e)
        {
            panelFo.Controls.Clear();
            StatForm statF = new StatForm();
            statF.TopLevel = false;
            panelFo.Controls.Add(statF);
            statF.Dock = DockStyle.Fill;
            statF.Show();
            MenuSzinez(4);
        }

        private void buttonJelszo_Click(object sender, EventArgs e)
        {
            JelszoForm jelszoF = new JelszoForm();
            panelFo.Controls.Clear();
            jelszoF.TopLevel = false;
            panelFo.Controls.Add(jelszoF);
            jelszoF.Dock = DockStyle.Fill;
            jelszoF.Show();
            MenuSzinez(5);
        }

        private void btnKilep_Click(object sender, EventArgs e)
        {
            MenuSzinez(6);
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
