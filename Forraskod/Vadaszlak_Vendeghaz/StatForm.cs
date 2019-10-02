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

namespace Vadaszlak_Vendeghaz
{
    public partial class StatForm : Form
    {
        MySqlConnection myConn = new MySqlConnection("server=remotemysql.com;user id=yN6LYJnGl2; password=i72zP359qP; database=yN6LYJnGl2; charset=utf8");
        MySqlCommand myComm1;
        MySqlDataReader dr;
        MySqlDataAdapter adapter;
        DataTable dTable;
        public string mettol;
        public string meddig;

        string[] comboGrafNev = { "Vendégek száma éves", "Vendégek száma havi", "Bevétel éves", "Bevétel havi", "Profit éves", "Profit havi", "Foglalások éves", "Foglalások havi", "Lemondott foglalások", "Megyék szerint"};

        List<string> koltsegL = new List<string>();
        List<string> bevetelL = new List<string>();

        public StatForm()
        {
            InitializeComponent();
            FoglalasEvei();
            comboBoxEvek.SelectedIndex = comboBoxEvek.Items.Count - 1;
            ComboKeresFeltolt(comboGrafNev);
            mettol = DateTime.Now.Year + "-01-01";
            meddig = DateTime.Now.ToString("yyyy-MM-dd");
            dtpMeddig.Value = Convert.ToDateTime(DateTime.Today.ToString("yyyy-MM-dd"));
            dtpMettol.Value = Convert.ToDateTime(DateTime.Today.Year + "-01-01");
            LemondottFoglalasok();
            OsszVendeg();
            OsszBevetel();
            VendegEvesChart();
            EgyForeSzazalek();
            EgyforeOsszeg();
        }

        void ComboKeresFeltolt(string[] nevek)
        {
            for (int i = 0; i < nevek.Length; i++)
            {
                comboBoxGraf.Items.Add(nevek[i]);
            }
            comboBoxGraf.SelectedIndex = 0;
        }

        //string DatumKotojellel(string s)
        //{
        //    DateTime szuldatum = Convert.ToDateTime(s);
        //    string szulText = szuldatum.Year + "-" + szuldatum.Month + "-" + szuldatum.Day;
        //    return szulText;
        //}

        double szazalek(int sz1, int sz2)
        {
            return sz1 * 1.0 / sz2 * 100;
        }

        void Kapcsolodas()
        {
            if (myConn.State == ConnectionState.Closed)
                myConn.Open();
        }

        void LemondottF()
        {
            string q = "SELECT YEAR(erkezes_ido) as evek, count(Lemondott) AS db FROM foglalas WHERE Lemondott = 1 GROUP BY YEAR(erkezes_ido)";

            try
            {
                Kapcsolodas();
                adapter = new MySqlDataAdapter(q, myConn);
                dTable = new DataTable();
                adapter.Fill(dTable);

                chart1.Series["Series"].XValueMember = "evek";
                chart1.Series["Series"].YValueMembers = "db";
                chart1.DataSource = dTable;
                chart1.DataBind();
                myConn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        void Profit()
        {
            string q1 = "SELECT year(tavozas_ido) as evek, sum(fizetett) as osszeg FROM foglalas group by year(tavozas_ido)";

            string q2 = "SELECT year(koltekezes_datuma) as evek, SUM(rezsi) + SUM(tisztitoszerek) +SUM(uzemanyag) + SUM(felujitas) + SUM(egyeb) as osszeg FROM koltseg group by year(koltekezes_datuma)";

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            try
            {
                Kapcsolodas();
                myComm1 = new MySqlCommand(q1, myConn);
                dr = myComm1.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dictionary.Add(dr["evek"].ToString(), Convert.ToInt32(dr["osszeg"]));
                    }
                }

                dr.Close();

                myComm1 = new MySqlCommand(q2, myConn);
                dr = myComm1.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (dictionary.ContainsKey(dr["evek"].ToString()))
                        {
                            int ertek = dictionary[dr["evek"].ToString()] - Convert.ToInt32(dr["osszeg"].ToString());
                            dictionary[dr["evek"].ToString()] = ertek;
                        }
                        else
                        {
                            dictionary[dr["evek"].ToString()] = Convert.ToInt32(dr["evek"].ToString());
                        }
                    }
                }
                dr.Close();
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            List<int> profitT = new List<int>();
            List<string> evekT = new List<string>();

            foreach (var item in dictionary)
            {
                evekT.Add(item.Key);
                profitT.Add(item.Value);
            }

            chart1.Series["Series"].Points.DataBindXY(evekT, profitT);
        }

        void ProfitHavi()
        {
            string q1 = "SELECT month(tavozas_ido) as honap, sum(fizetett) as osszeg FROM foglalas where year(tavozas_ido) like '" + comboBoxEvek.SelectedItem+ "' group by month(tavozas_ido)";

            string q2 = "SELECT month(koltekezes_datuma) as honap, SUM(rezsi) + SUM(tisztitoszerek) + SUM(uzemanyag) + SUM(felujitas) + SUM(egyeb) as osszeg FROM koltseg where year(koltekezes_datuma) like '"+comboBoxEvek.SelectedItem+"' group by year(koltekezes_datuma), month(koltekezes_datuma)";

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            try
            {
                Kapcsolodas();
                myComm1 = new MySqlCommand(q1, myConn);
                dr = myComm1.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dictionary.Add(dr["honap"].ToString(), Convert.ToInt32(dr["osszeg"]));
                    }
                }

                dr.Close();

                myComm1 = new MySqlCommand(q2, myConn);
                dr = myComm1.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (dictionary.ContainsKey(dr["honap"].ToString()))
                        {
                            int ertek = dictionary[dr["honap"].ToString()] - Convert.ToInt32(dr["osszeg"].ToString());
                            dictionary[dr["honap"].ToString()] = ertek;
                        }
                        else
                        {
                            dictionary[dr["honap"].ToString()] = Convert.ToInt32(dr["honap"].ToString());
                        }
                    }
                }
                dr.Close();
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            List<int> profitT = new List<int>();
            List<string> evekT = new List<string>();

            foreach (var item in dictionary)
            {
                evekT.Add(item.Key);
                profitT.Add(item.Value);
            }

            chart1.Series["Series"].Points.DataBindXY(evekT, profitT);
        }

        void EgyforeOsszeg()
        {
            int szam1 = 0;
            int szam2 = 0;

            string q1 = "SELECT SUM(rezsi) + SUM(tisztitoszerek) +SUM(uzemanyag) + SUM(felujitas) + SUM(egyeb) FROM koltseg WHERE koltekezes_datuma >= '" + mettol + "' AND koltekezes_datuma <= '" + meddig + "'";

            string q2 = "SELECT count(id) from foglalas WHERE erkezes_ido >= '" + mettol + "' AND erkezes_ido <= '" + meddig + "'";

            try
            {
                Kapcsolodas();
                myComm1 = new MySqlCommand(q1, myConn);
                dr = myComm1.ExecuteReader();
                dr.Read();
                bool szamE = Int32.TryParse(dr[0].ToString(), out szam1);
                dr.Close();

                myComm1 = new MySqlCommand(q2, myConn);
                dr = myComm1.ExecuteReader();
                dr.Read();
                szamE = Int32.TryParse(dr[0].ToString(), out szam2); 
                dr.Close();
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (szam1==0)
            {
                labelEgyforeOsszeg.Text = "";
            }
            else if (szam2==0)
            {
                labelEgyforeOsszeg.Text = "";
            }
            else
            {
                labelEgyforeOsszeg.Text = (szam1 / szam2) + " Ft/Fő";
            }
        }

        void EgyForeSzazalek()
        {
            int szam1, szam2;

            string q1 = "SELECT SUM(rezsi) + SUM(tisztitoszerek) +SUM(uzemanyag) + SUM(felujitas) + SUM(egyeb) FROM koltseg WHERE koltekezes_datuma >= '" + mettol + "' AND koltekezes_datuma <= '" + meddig + "'";
            string q2 = "SELECT sum(fizetett) FROM foglalas WHERE erkezes_ido >= '" + mettol + "' AND erkezes_ido <= '" + meddig + "'";
            try
            {
                Kapcsolodas();
                myComm1 = new MySqlCommand(q1, myConn);
                dr = myComm1.ExecuteReader();
                dr.Read();
                bool szamE = Int32.TryParse(dr[0].ToString(), out szam1);
                dr.Close();

                myComm1 = new MySqlCommand(q2, myConn);
                dr = myComm1.ExecuteReader();
                dr.Read();
                szamE = Int32.TryParse(dr[0].ToString(), out szam2);
                if (szam1==0)
                {
                    labelEgyfoSzaz.Text = "Nem volt kiadás\na megadott időszakban";
                }
                else if (szam2==0)
                {
                    labelEgyfoSzaz.Text = "Nem volt vendég a megadott időszakban";
                }
                else
                {
                    labelEgyfoSzaz.Text = String.Format("A bevétel {0:0.00} %-a", (float)szazalek(szam1, szam2));
                }
                dr.Close();
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FoglalasEvei()
        {
            string q = "SELECT year(erkezes_ido) AS 'evek' FROM vendeg v join szallas sz ON v.id = sz.v_id join foglalas f ON f.id = sz.f_id GROUP BY year(f.erkezes_ido)";
            try
            {
                Kapcsolodas();
                myComm1 = new MySqlCommand(q, myConn);
                dr = myComm1.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        comboBoxEvek.Items.Add(dr[0]);
                    }
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void VenSzamHoChart()
        {
            string q = "SELECT month(erkezes_ido) AS 'honap', COUNT(v.id) AS 'vendeg' FROM vendeg v join szallas sz ON v.id = sz.v_id join foglalas f ON f.id = sz.f_id WHERE YEAR(erkezes_ido) LIKE '" + comboBoxEvek.SelectedItem + "' GROUP BY month(f.erkezes_ido)";

            try
            {
                Kapcsolodas();
                adapter = new MySqlDataAdapter(q, myConn);
                dTable = new DataTable();
                adapter.Fill(dTable);

                chart1.Series["Series"].XValueMember = "honap";
                chart1.Series["Series"].YValueMembers = "vendeg";
                chart1.DataSource = dTable;
                chart1.DataBind();
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void MegyekSzerintChart()
        {
            string q = "SELECT megye, COUNT(megye) as szam FROM vendeg WHERE megye NOT LIKE '' GROUP BY megye ORDER BY szam";

            try
            {
                Kapcsolodas();
                adapter = new MySqlDataAdapter(q, myConn);
                dTable = new DataTable();
                adapter.Fill(dTable);

                chart1.Series["Series"].XValueMember = "megye";
                chart1.Series["Series"].YValueMembers = "szam";
                chart1.DataSource = dTable;
                chart1.DataBind();
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void VendegEvesChart()
        {
            string q = "SELECT YEAR(erkezes_ido) AS 'ev', COUNT(v.id) AS 'vendeg' FROM vendeg v JOIN szallas sz ON v.id = sz.v_id join foglalas f ON f.id = sz.f_id GROUP BY YEAR(f.erkezes_ido)";

            try
            {
                Kapcsolodas();
                adapter = new MySqlDataAdapter(q, myConn);
                dTable = new DataTable();

                adapter.Fill(dTable);

                chart1.Series["Series"].XValueMember = "ev";
                chart1.Series["Series"].YValueMembers = "vendeg";
                chart1.DataSource = dTable;
                chart1.DataBind();
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void BevetelEvesChart()
        {
            string q = "SELECT YEAR(erkezes_ido) AS 'ev', sum(fizetett) AS 'osszeg' FROM foglalas GROUP BY YEAR(erkezes_ido)";

            try
            {
                Kapcsolodas();
                adapter = new MySqlDataAdapter(q, myConn);
                dTable = new DataTable();
                adapter.Fill(dTable);
                chart1.Series["Series"].XValueMember = "ev";
                chart1.Series["Series"].YValueMembers = "osszeg";
                chart1.DataSource = dTable;
                chart1.DataBind();
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void BevetelHavi()
        {
            string q = "SELECT month(erkezes_ido) as honapok, SUM(fizetett) as bevetel FROM foglalas WHERE YEAR(erkezes_ido) LIKE '"+comboBoxEvek.SelectedItem+"' GROUP BY MONTH(erkezes_ido)";
            try
            {
                Kapcsolodas();
                adapter = new MySqlDataAdapter(q, myConn);
                dTable = new DataTable();
                adapter.Fill(dTable);
                chart1.Series["Series"].XValueMember = "honapok";
                chart1.Series["Series"].YValueMembers = "bevetel";
                chart1.DataSource = dTable;
                chart1.DataBind();
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void OsszBevetel()
        {
            string q = "select sum(fizetett) as 'Teljes Bevétel éves' from foglalas";

            try
            {
                Kapcsolodas();
                myComm1 = new MySqlCommand(q, myConn);
                dr = myComm1.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        labelOsszBev.Text = String.Format("{0:000 000} Ft", dr[0]); 
                    }
                }

                dr.Close();
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void OsszVendeg()
        {
            string q = "select count(id) as osszVen from vendeg";

            try
            {
                Kapcsolodas();
                myComm1 = new MySqlCommand(q, myConn);
                dr = myComm1.ExecuteReader();

                while (dr.Read())
                {
                    if (dr.HasRows)
                        labelOsszVenEr.Text = dr[0] + " Fő";
                }

                dr.Close();
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FoglalasokEves()
        {
            string q = "select  year(erkezes_ido) as ev, count(id) as db from foglalas group by year(erkezes_ido)";

            try
            {
                Kapcsolodas();
                adapter = new MySqlDataAdapter(q, myConn);
                dTable = new DataTable();
                adapter.Fill(dTable);
                chart1.Series["Series"].XValueMember = "ev";
                chart1.Series["Series"].YValueMembers = "db";
                chart1.DataSource = dTable;
                chart1.DataBind();
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void FoglalasokHavi()
        {
            string q = "select month(erkezes_ido) as honapok, count(id) as db from foglalas where year(erkezes_ido) like '" + comboBoxEvek.SelectedItem + "' group by month(erkezes_ido)";

            try
            {
                Kapcsolodas();
                adapter = new MySqlDataAdapter(q, myConn);
                dTable = new DataTable();
                adapter.Fill(dTable);

                //var chartArea = new ChartArea("MyChart");
                //Title title = chart1.Titles.Add("Test");
                chart1.Series["Series"].XValueMember = "honapok";
                //chart1.ChartAreas["Series"].AxisX.Title = "fsdf";
                //chart1.Series["Series"].AxisLabel = "honapok";
                chart1.Series["Series"].YValueMembers = "db";

                //chartArea.AxisX.Title = "xxx";
                //chartArea.AxisY.Title = "yyy";

                chart1.DataSource = dTable;
                chart1.DataBind();
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void LemondottFoglalasok()
        {
            string q = "select count(Lemondott) as osszLem from foglalas where Lemondott = 1";
            string q1 = "select count(id) as osszLem from foglalas";
            int szam1 = 0;
            int szam2 = 0;

            try
            {
                Kapcsolodas();
                myComm1 = new MySqlCommand(q, myConn);
                dr = myComm1.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows)
                    {
                        szam1 = Convert.ToInt32(dr[0].ToString());
                    }
                }
                dr.Close();
                myConn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba a adatbázis kapcsolodás során", "Hoppá1", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            try
            {
                Kapcsolodas();
                myComm1 = new MySqlCommand(q1, myConn);
                dr = myComm1.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows)
                    {
                        szam2 = Convert.ToInt32(dr[0].ToString());
                    }
                }

                dr.Close();
                myConn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hiba a adatbázis kapcsolodás során", "Hoppá2", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            labelLemondEredm.Text = Math.Floor(szazalek(szam1, szam2)) + " %";
        }

        private void comboBoxGraf_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxGraf.SelectedItem.ToString())
            {
                case "Vendégek száma éves":

                    VendegEvesChart();
                    //dtpMettol.Visible = false;
                    //dtpMeddig.Visible = false;
                    comboBoxEvek.Visible = false;
                    labelIdoszak.Visible = false;
                    break;
                case "Bevétel éves":
                    BevetelEvesChart();
                    //dtpMettol.Visible = false;
                    //dtpMeddig.Visible = false;
                    comboBoxEvek.Visible = false;
                    labelIdoszak.Visible = false;
                    break;
                //string[] comboGrafNev = { "Vendégek száma éves", "Vendégek száma havi", "Bevétel éves", "Települések szerint", "Egy főre jutú költség" };

                case "Vendégek száma havi":
                    VenSzamHoChart();
                    //dtpMettol.Visible = false;
                    //dtpMeddig.Visible = false;
                    comboBoxEvek.Visible = true;
                    labelIdoszak.Visible = true;
                    break;
                case "Megyék szerint":
                    MegyekSzerintChart();
                    //dtpMettol.Visible = false;
                    //dtpMeddig.Visible = false;
                    comboBoxEvek.Visible = false;
                    labelIdoszak.Visible = false;
                    break;
                //case "Egy főre jutó költség":
                //    comboBoxEvek.Visible = false;
                //    labelIdoszak.Visible = false;
                //dtpMettol.Visible = true;
                //dtpMeddig.Visible = true;
                //dtpMeddig.Value = Convert.ToDateTime(DateTime.Today.ToString("yyyy-MM-dd"));
                //dtpMettol.Value = Convert.ToDateTime(DateTime.Today.Year + "-01-01");
                //EgyForeSzazalek();
                //break;
                case "Profit éves":
                    Profit();
                    //dtpMettol.Visible = false;
                    //dtpMeddig.Visible = false;
                    comboBoxEvek.Visible = false;
                    labelIdoszak.Visible = false;
                    break;
                case "Profit havi":
                    ProfitHavi();
                    //dtpMettol.Visible = false;
                    //dtpMeddig.Visible = false;
                    comboBoxEvek.Visible = true;
                    labelIdoszak.Visible = true;
                    break;
                case "Lemondott foglalások":
                    LemondottF();
                    //dtpMettol.Visible = false;
                    //dtpMeddig.Visible = false;
                    comboBoxEvek.Visible = false;
                    labelIdoszak.Visible = false;
                    break;
                case "Bevétel havi":
                    BevetelHavi();
                    //dtpMettol.Visible = false;
                    //dtpMeddig.Visible = false;
                    labelIdoszak.Visible = true;
                    comboBoxEvek.Visible = true;
                    break;
                case "Foglalások éves":
                    FoglalasokEves();
                    //dtpMettol.Visible = false;
                    //dtpMeddig.Visible = false;
                    labelIdoszak.Visible = false;
                    comboBoxEvek.Visible = false;
                    break;
                case "Foglalások havi":
                    FoglalasokHavi();
                    //dtpMettol.Visible = false;
                    //dtpMeddig.Visible = false;
                    labelIdoszak.Visible = true;
                    comboBoxEvek.Visible = true;
                    break;
            }
        }

        private void comboBoxEvek_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxGraf.SelectedItem)// miért returnd null?
            {
                case "Vendégek száma havi":
                    VenSzamHoChart();
                    break;
                case "Bevétel havi":
                    BevetelHavi();
                    break;
                case "Profit havi":
                    ProfitHavi();
                    break;
                case "Foglalások havi":
                    FoglalasokHavi();
                    break;
            }

        }

        private void dtpMettol_ValueChanged(object sender, EventArgs e)
        {
            mettol = dtpMettol.Value.ToString("yyy-MM-dd");//pont miatt kell
            EgyForeSzazalek();
            EgyforeOsszeg();
        }

        private void dtpMeddig_ValueChanged(object sender, EventArgs e)
        {
            meddig = dtpMeddig.Value.ToString("yyy-MM-dd");
            EgyForeSzazalek();
            EgyforeOsszeg();
        }

        private void comboBoxGraf_DrawItem(object sender, DrawItemEventArgs e)
        {
            // By using Sender, one method could handle multiple ComboBoxes
            ComboBox cbx = sender as ComboBox;
            if (cbx != null)
            {
                // Always draw the background
                e.DrawBackground();

                // Drawing one of the items?
                if (e.Index >= 0)
                {
                    // Set the string alignment.  Choices are Center, Near and Far
                    StringFormat sf = new StringFormat();
                    sf.LineAlignment = StringAlignment.Center;
                    sf.Alignment = StringAlignment.Center;
                    //e.Graphics.FillRectangle(Brushes.Red, e.Bounds);

                    // Set the Brush to ComboBox ForeColor to maintain any ComboBox color settings
                    // Assumes Brush is solid
                    Brush brush = new SolidBrush(cbx.ForeColor);

                    // If drawing highlighted selection, change brush
                    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                        brush = SystemBrushes.HighlightText;

                    // Draw the string
                    e.Graphics.DrawString(cbx.Items[e.Index].ToString(), cbx.Font, brush, e.Bounds, sf);


                }
            }
        }
    }
}
