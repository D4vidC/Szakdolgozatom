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
    public partial class FoglalasForm : Form
    {
        public string[] oszlop = { "Id", "Felnőttek száma", "Gyerekek száma", "Fizetett", "Lemondott", "Érkezett", "Távozott" };
        MySqlConnection myConn = new MySqlConnection("server=remotemysql.com;user id=yN6LYJnGl2; password=i72zP359qP; database=yN6LYJnGl2; charset=utf8");
        MySqlCommand myComm;
        MySqlDataReader dr;
        int foglalasID;

        public FoglalasForm()
        {
            InitializeComponent();
            ComboKeresFeltolt();
            AdatracsFog();
            labelVenAz.Text += VendegForm.vendegID;
            dtpErkez.Value = DateTime.Today.AddDays(-1);
            dtpTavoz.Value = DateTime.Today;
            //VendegForm.vendegID
        }

        void ComboKeresFeltolt()
        {
            for (int i = 1; i < oszlop.Length; i++)
            {
                comboBoxKeres.Items.Add(oszlop[i]);
            }
            comboBoxKeres.SelectedIndex = 0;
        }

        public static Cursor CreateCursor(Bitmap bm, Size size)
        {
            bm = new Bitmap(bm, size);
            return new Cursor(bm.GetHicon());
        }

        public void Kapcsolodas()
        {
            if (myConn.State == ConnectionState.Closed)
                myConn.Open();
        }

        string DatumConvertToHeidi(string s)
        {
            DateTime szuldatum = Convert.ToDateTime(s);
            string szulText = szuldatum.Year + "-" + szuldatum.Month + "-" + szuldatum.Day;

            return szulText;
        }

        void Reset()
        {
            textFelnott.Text = "Felnőttek száma";
            textGyerek.Text = "Gyerekek száma";
            textFizetett.Text = "Fizetett";
            textLemondott.Text = "Lemondott";
            //dtpErkez.Value = DateTimePicker.MinimumDateTime;
            //dtpTavoz.Value = DateTimePicker.MinimumDateTime;
            //dtpErkez.Value = DateTime.Now.Year +"-"+ DateTime.Now.Month +"-"+ DateTime.Now.Day;
        }

        void AdatracsFog()
        {
            string keresendo = "";
            string szuresiFeltetel = "";

            if (textKeres.Text.Equals("Keresés..."))
            {
                keresendo = "";
            }
            else
            {
                keresendo = textKeres.Text;
            }

            switch (comboBoxKeres.SelectedItem)
            {
                case "Felnőttek száma":
                    szuresiFeltetel = "felnottek_szama";
                    break;
                case "Gyerekek száma":
                    szuresiFeltetel = "gyerekek_szama";
                    break;
                case "Fizetett":
                    szuresiFeltetel = "fizetett";
                    break;
                case "Lemondott":
                    szuresiFeltetel = "lemondott";
                    break;
                case "Érkezett":
                    szuresiFeltetel = "erkezes_ido";
                    break;
                case "Távozott":
                    szuresiFeltetel = "tavozas_ido";
                    break;
            }

            string q = "select * from foglalas where " + szuresiFeltetel + " like '" + keresendo + "%'";

            try
            {
                if (myConn.State == ConnectionState.Closed)
                {
                    myConn.Open();
                }
                MySqlDataAdapter dAdapter = new MySqlDataAdapter(q, myConn);
                DataTable dTable = new DataTable();
                dAdapter.Fill(dTable);
                dgvFoglalas.DataSource = dTable;
                //string[] oszlop = { "Id", "Felnőttek száma", "Gyerekek száma", "Fizetett", "Lemondott", "Érkezett", "Távozott" };

                for (int i = 0; i < dgvFoglalas.ColumnCount; i++)
                {
                    dgvFoglalas.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvFoglalas.Columns[i].HeaderText = oszlop[i];
                }

                dgvFoglalas.Font = new Font("Arial", 10);
                //foglalasID = Convert.ToInt32(dgvFoglalas.Rows[0].Cells[0].Value);
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textKeres_TextChanged(object sender, EventArgs e)
        {
            AdatracsFog();
        }

        private void btnFelvesz_Click(object sender, EventArgs e)
        {
            Reset();
            textFelnott.Focus();
            buttonMentes.Text = "Mentés";
        }

        private void btnSzerkeszt_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dgvFoglalas.CurrentRow.Cells[0].Value) == foglalasID)
            {
                textFelnott.Text = dgvFoglalas.CurrentRow.Cells[1].Value.ToString();
                textGyerek.Text = dgvFoglalas.CurrentRow.Cells[2].Value.ToString() =="" ? "Gyerekek száma" : dgvFoglalas.CurrentRow.Cells[2].Value.ToString();
                textFizetett.Text = dgvFoglalas.CurrentRow.Cells[3].Value.ToString();
                textLemondott.Text = dgvFoglalas.CurrentRow.Cells[4].Value.ToString() == "" ? "Lemondott" : dgvFoglalas.CurrentRow.Cells[4].Value.ToString();
                dtpErkez.Value = Convert.ToDateTime(dgvFoglalas.CurrentRow.Cells[5].Value.ToString());
                dtpTavoz.Value = Convert.ToDateTime(dgvFoglalas.CurrentRow.Cells[6].Value.ToString());
                foglalasID = int.Parse(dgvFoglalas.CurrentRow.Cells[0].Value.ToString());
                buttonMentes.Text = "Módosít";
            }
        }

        private void btnEltavolit_Click(object sender, EventArgs e)
        {
            string q1 = "delete from szallas where f_id = " + foglalasID;////befejezni
            string q2 = "delete from foglalas where id = " + foglalasID;

            DialogResult eredmeny = MessageBox.Show("Bitos hogy törölni szeretné?", "Figyelem!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (eredmeny == DialogResult.Yes)
            {
                try
                {
                    Kapcsolodas();
                    myComm = new MySqlCommand(q1, myConn);
                    dr = myComm.ExecuteReader();
                    dr.Close();
                    myComm = new MySqlCommand(q2, myConn);
                    dr = myComm.ExecuteReader();
                    myConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                AdatracsFog();
            }
        }

        private void buttonMentes_Click(object sender, EventArgs e)
        {
            if (textFelnott.Text != "Felnőttek száma"  && textFizetett.Text != "Fizetett")
            {
                if (dtpErkez.Value < dtpTavoz.Value)
                {
                    if (textLemondott.Text.Equals("Lemondott") && textGyerek.Text.Equals("Gyerekek száma"))
                    {
                        textLemondott.Text = "";
                        textGyerek.Text = "";
                    }

                    if (buttonMentes.Text.Equals("Módosít"))
                    {
                        string q = "update foglalas set felnottek_szama='" + textFelnott.Text + "', gyerekek_szama='" + textGyerek.Text + "', fizetett='" + textFizetett.Text + "', lemondott='" + textLemondott.Text + "', erkezes_ido='" + DatumConvertToHeidi(dtpErkez.Value.ToString()) + "', tavozas_ido='" + DatumConvertToHeidi(dtpTavoz.Value.ToString()) + "' where id = " + foglalasID;

                        try
                        {
                            if (myConn.State == ConnectionState.Closed)
                            {
                                myConn.Open();
                            }
                            myComm = new MySqlCommand(q, myConn);
                            dr = myComm.ExecuteReader();
                            myConn.Close();
                            buttonMentes.Text = "Mentés";
                            myConn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else if (buttonMentes.Text.Equals("Mentés"))
                    {
                        string q1 = "insert into foglalas (felnottek_szama, gyerekek_szama, fizetett, lemondott, erkezes_ido, tavozas_ido) values ('" + textFelnott.Text + "', '" + textGyerek.Text + "', '" + textFizetett.Text + "', '" + textLemondott.Text + "', '" + DatumConvertToHeidi(dtpErkez.Value.ToString()) + "', '" + DatumConvertToHeidi(dtpTavoz.Value.ToString()) + "')";

                        try
                        {
                            Kapcsolodas();
                            myComm = new MySqlCommand(q1, myConn);
                            dr = myComm.ExecuteReader();
                            foglalasID = Int32.Parse(myComm.LastInsertedId.ToString());
                            dr.Close();
                            string q2 = "insert into szallas (v_id, f_id) values ('" + VendegForm.vendegID + "', '" + foglalasID + "')";
                            myComm = new MySqlCommand(q2, myConn);
                            dr = myComm.ExecuteReader();
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
                    MessageBox.Show("Az érkezés dátumának kisebbnek kell lennie a távozás dátumánál", "Figyelem!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("A 'Felnőttek száma' mező, és a 'Fizetett' mező kitöltése kötelező!", "Figyelem!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            AdatracsFog();
        }

        private void textFelnott_Enter(object sender, EventArgs e)
        {
            if (textFelnott.Text.Equals("Felnőttek száma"))
                textFelnott.Text = "";
        }

        private void textGyerek_Enter(object sender, EventArgs e)
        {
            if (textGyerek.Text.Equals("Gyerekek száma"))
                textGyerek.Text = "";
        }

        private void textFizetett_Enter(object sender, EventArgs e)
        {
            if (textFizetett.Text.Equals("Fizetett"))
                textFizetett.Text = "";
        }

        private void textLemondott_Enter(object sender, EventArgs e)
        {
            if (textLemondott.Text.Equals("Lemondott"))
                textLemondott.Text = "";
        }

        private void textKeres_Enter(object sender, EventArgs e)
        {
            if (textKeres.Text.Equals("Keresés..."))
                textKeres.Text = "";
        }

        private void textKeres_Leave(object sender, EventArgs e)
        {
            if (textKeres.Text.Equals(""))
                textKeres.Text = "Keresés...";
        }

        private void textFelnott_Leave(object sender, EventArgs e)
        {
            if (textFelnott.Text.Equals(""))
                textFelnott.Text = "Felnőttek száma";
        }

        private void textGyerek_Leave(object sender, EventArgs e)
        {
            if (textGyerek.Text.Equals(""))
                textGyerek.Text = "Gyerekek száma";
        }

        private void textFizetett_Leave(object sender, EventArgs e)
        {
            if (textFizetett.Text.Equals(""))
                textFizetett.Text = "Fizetett";
        }

        private void textLemondott_Leave(object sender, EventArgs e)
        {
            if (textLemondott.Text.Equals(""))
                textLemondott.Text = "Lemondott";
        }

        private void buttonVendegHozzaAd_Click(object sender, EventArgs e)
        {
            Foablak fablak = new Foablak();
            VendegForm vendegF = new VendegForm();
            fablak.panelFo.Controls.Clear();
            vendegF.TopLevel = false;
            fablak.panelFo.Controls.Add(vendegF);
            vendegF.Dock = DockStyle.Fill;
            vendegF.Show();
        }

        private void dgvFoglalas_Click(object sender, EventArgs e)
        {
            foglalasID = Convert.ToInt32(dgvFoglalas.CurrentRow.Cells[0].Value);
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