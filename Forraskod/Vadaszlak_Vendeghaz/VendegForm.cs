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

namespace Vadaszlak_Vendeghaz
{
    public partial class VendegForm : Form
    {
        MySqlConnection myConn = new MySqlConnection("server=remotemysql.com;user id=yN6LYJnGl2; password=i72zP359qP; database=yN6LYJnGl2; charset=utf8");
        MySqlCommand myComm1;
        MySqlDataReader dr;

        public static int vendegID;
        public string[] oszlop = { "Id", "Vezetéknév", "Keresztnév", "Telefonszám", "Lakcím", "Megye", "Születési dátum" };

        public VendegForm()
        {
            InitializeComponent();
            dtpSzulet.Value = DateTime.Today;
            ComboKeresFeltolt();
            AdatracsVen();
            vendegID = Convert.ToInt32(dgvVendeg.Rows[0].Cells[0].Value);
        }
        void ComboKeresFeltolt()
        {
            for (int i = 1; i < oszlop.Length; i++)
            {
                comboBoxKeres.Items.Add(oszlop[i]);
            }
            comboBoxKeres.SelectedIndex = 0;
        }

        string KarakterCsere(string s)
        {
            string szoveg = s.Replace('.', '-');
            return szoveg;
        }

        public void Kapcsolodas()
        {
            if (myConn.State == ConnectionState.Closed)
                myConn.Open();
        }

        void Reset()
        {
            textVezetek.Text = "Vezetéknév";
            textKereszt.Text = "Keresztnév";
            textTelefon.Text = "Telefonszám";
            textLakcim.Text = "Lakcím";
            textMegye.Text = "Megye";
            dtpSzulet.Value = DateTime.Now;
        }

        string DatumKotojellel(string s)
        {
            DateTime szuldatum = Convert.ToDateTime(s);
            string szulText = szuldatum.Year + "-" + szuldatum.Month + "-" + szuldatum.Day;

            return szulText;
        }

        void AdatracsVen()
        {
            string szuresiFeltetel = "";
            string keresendo = "";

            if (textKeres.Text.Equals("Keresés..."))
            {
                keresendo = "";
            }
            else if(comboBoxKeres.SelectedItem.ToString().Equals("szuletesi_datum"))
            {
                keresendo = KarakterCsere(textKeres.Text);
            }
            else
            {
                keresendo = textKeres.Text;
            }
            switch (comboBoxKeres.SelectedItem)
            {
                case "Vezetéknév":
                    szuresiFeltetel = "vezeteknev";
                    break;
                case "Keresztnév":
                    szuresiFeltetel = "keresztnev";
                    break;
                case "Telefonszám":
                    szuresiFeltetel = "telefonszam";
                    break;
                case "Lakcím":
                    szuresiFeltetel = "lakcim";
                    break;
                case "Megye":
                    szuresiFeltetel = "megye";
                    break;
                case "Születési dátum":
                    szuresiFeltetel = "szuletesi_datum";
                    break;
            }
            string q = "select * from vendeg where " + szuresiFeltetel + " like '" + keresendo + "%'";

            try
            {
                Kapcsolodas();
                MySqlDataAdapter dAdapter = new MySqlDataAdapter(q, myConn);
                DataTable dTable = new DataTable();
                dAdapter.Fill(dTable);
                dgvVendeg.DataSource = dTable;

                for (int i = 0; i < dgvVendeg.ColumnCount; i++)
                {
                    dgvVendeg.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvVendeg.Columns[i].HeaderText = oszlop[i];
                }
                dgvVendeg.Font = new Font("Arial", 10);
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba az adatbázishoz való kapcsolódás során!\n\n" + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnFelvesz_Click(object sender, EventArgs e)
        {
            Reset();
            textVezetek.Focus();
            btnMentMod.Text = "Mentés";
        }

        private void btnSzerkeszt_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dgvVendeg.CurrentRow.Cells[0].Value) == vendegID)
            {
                textVezetek.Text = dgvVendeg.CurrentRow.Cells[1].Value.ToString();
                textKereszt.Text = dgvVendeg.CurrentRow.Cells[2].Value.ToString();
                textTelefon.Text = dgvVendeg.CurrentRow.Cells[3].Value.ToString();
                textLakcim.Text = dgvVendeg.CurrentRow.Cells[4].Value.ToString();
                textMegye.Text = dgvVendeg.CurrentRow.Cells[5].Value.ToString();
                dtpSzulet.Value = (dgvVendeg.CurrentRow.Cells[6].Value.ToString() != "") ? Convert.ToDateTime(dgvVendeg.CurrentRow.Cells[6].Value.ToString()) : DateTime.Today;
                vendegID = int.Parse(dgvVendeg.CurrentRow.Cells[0].Value.ToString());
                btnMentMod.Text = "Módosít";                
            }
        }

        private void btnEltavolit_Click(object sender, EventArgs e)
        {
            string q1 = "delete from szallas where v_id = " + vendegID;
            string q2 = "delete from vendeg where id = " + vendegID;

            DialogResult eredmeny = MessageBox.Show("Bitos hogy törölni szeretné?", "Figyelem!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (eredmeny == DialogResult.Yes)
            {
                try
                {
                    Kapcsolodas();
                    myComm1 = new MySqlCommand(q1, myConn);
                    dr = myComm1.ExecuteReader();
                    dr.Close();
                    myComm1 = new MySqlCommand(q2, myConn);
                    dr = myComm1.ExecuteReader();
                    myConn.Close();
                    AdatracsVen();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonVendegMentes_Click(object sender, EventArgs e)
        {
            textTelefon.Text = textTelefon.Text.Equals("Telefonszám") ? "" : textTelefon.Text;
            if (textVezetek.Text.Trim() != "Vezetéknév" && textKereszt.Text.Trim() != "keresztnév")
            {
                if (dtpSzulet.Value < DateTime.Today)
                {
                    if (btnMentMod.Text.Equals("Módosít"))
                    {
                        string q = "update vendeg set vezeteknev='" + textVezetek.Text + "', keresztnev='" + textKereszt.Text + "', szuletesi_datum='" + DatumKotojellel(dtpSzulet.Value.ToString()) + "', telefonszam='" + textTelefon.Text + "', lakcim='" + textLakcim.Text + "', megye='" + textMegye.Text + "' where id = " + vendegID;

                        try
                        {
                            Kapcsolodas();
                            myComm1 = new MySqlCommand(q, myConn);
                            dr = myComm1.ExecuteReader();
                            myConn.Close();
                            btnMentMod.Text = "Mentés";
                            myConn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else if (btnMentMod.Text.Equals("Mentés"))
                    {
                        string q = "insert into vendeg (vezeteknev, keresztnev, szuletesi_datum, telefonszam, lakcim, megye) values ('" + textVezetek.Text + "', '" + textKereszt.Text + "', '" + DatumKotojellel(dtpSzulet.Value.ToString()) + "', '" + textTelefon.Text + "', '" + textLakcim.Text + "', '" + textMegye.Text + "')";

                        try
                        {
                            Kapcsolodas();
                            myComm1 = new MySqlCommand(q, myConn);
                            dr = myComm1.ExecuteReader();
                            myConn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Kérem adja meg a születési dátumot!", "Figyelem!", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("A 'Vezetéknév' és 'Keresztnév' megadása kötelező!","Figyelem!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            AdatracsVen();
        }

        private void textKeres_TextChanged(object sender, EventArgs e)
        {
            AdatracsVen();
        }

        private void textVezetek_Enter(object sender, EventArgs e)
        {
            if (textVezetek.Text.Equals("Vezetéknév"))
            {
                textVezetek.Text = "";
            }
        }

        private void textKereszt_Enter(object sender, EventArgs e)
        {
            if (textKereszt.Text.Equals("Keresztnév"))
            {
                textKereszt.Text = "";
            }
        }

        private void textTelefon_Enter(object sender, EventArgs e)
        {
            if (textTelefon.Text.Equals("Telefonszám"))
            {
                textTelefon.Text = "";
            }
        }

        private void textLakcim_Enter(object sender, EventArgs e)
        {
            if (textLakcim.Text.Equals("Lakcím"))
            {
                textLakcim.Text = "";
            }
        }

        private void textMegye_Enter(object sender, EventArgs e)
        {
            if (textMegye.Text.Equals("Megye"))
            {
                textMegye.Text = "";
            }
        }

        private void textVezetek_Leave(object sender, EventArgs e)
        {
            if (textVezetek.Text.Equals(""))
                textVezetek.Text = "Vezetéknév";
        }

        private void textKereszt_Leave(object sender, EventArgs e)
        {
            if (textKereszt.Text.Equals(""))
                textKereszt.Text = "Keresztnév";
        }

        private void textTelefon_Leave(object sender, EventArgs e)
        {
            if (textTelefon.Text.Equals(""))
                textTelefon.Text = "Telefonszám";
        }

        private void textLakcim_Leave(object sender, EventArgs e)
        {
            if (textLakcim.Text.Equals(""))
                textLakcim.Text = "Lakcím";
        }

        private void textMegye_Leave(object sender, EventArgs e)
        {
            if (textMegye.Text.Equals(""))
                textMegye.Text = "Megye";
        }

        private void textKeres_Enter(object sender, EventArgs e)
        {
            if (textKeres.Text.Equals("Keresés...")) textKeres.Text = "";
        }

        private void textKeres_Leave(object sender, EventArgs e)
        {
            if (textKeres.Text.Equals("")) textKeres.Text = "Keresés...";
        }

        private void buttonVendegMegse_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void DataGVVendeg_Click(object sender, EventArgs e)
        {
            vendegID = Convert.ToInt32(dgvVendeg.CurrentRow.Cells[0].Value);
        }

        private void btnUjFoglalas_Click(object sender, EventArgs e)
        {

            //FoglalasForm foglalasF = new FoglalasForm();
            //panelFo.Controls.Clear();
            //foglalasF.TopLevel = false;
            //panelFo.Controls.Add(foglalasF);
            //foglalasF.Dock = DockStyle.Fill;
            //foglalasF.Show();
            //Foablak.
        }

        private void comboBoxKeres_DrawItem(object sender, DrawItemEventArgs e)
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