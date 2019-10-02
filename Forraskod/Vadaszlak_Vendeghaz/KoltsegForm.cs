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

    public partial class KoltsegForm : Form
    {
        public string[] oszlop = { "Rezsi", "Tisztítószerek", "Üzemanyag", "Felújítás", "Egyéb", "Dátum" };

        MySqlConnection myConn = new MySqlConnection("server=remotemysql.com;user id=yN6LYJnGl2; password=i72zP359qP; database=yN6LYJnGl2; charset=utf8");
        MySqlCommand myComm;
        MySqlDataReader dr;
        int koltsegID;

        public KoltsegForm()
        {
            InitializeComponent();
            //comboBoxKeres.DataSource = Enum.GetValues(typeof(KoltsegTablaNevek));
            ComboKeresFeltolt();
            AdatracsKolt();
        }

        void ComboKeresFeltolt()
        {
            for (int i = 0; i < oszlop.Length; i++)
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
            textRezsi.Text = "Rezsi";
            textTisztitoszer.Text = "Tisztítószerek";
            textUzemanyag.Text = "Üzemanyag";
            textFelujitas.Text = "Felújítás";
            textEgyeb.Text = "Egyéb";
        }

        void AdatracsKolt()
        {
            string keresendo ="";
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
                case "Rezsi":
                    szuresiFeltetel = "rezsi";
                    break;
                case "Tisztítószerek":
                    szuresiFeltetel = "tisztitoszerek";
                    break;
                case "Üzemanyag":
                    szuresiFeltetel = "uzemanyag";
                    break;
                case "Felújítás":
                    szuresiFeltetel = "felujitas";
                    break;
                case "Egyéb":
                    szuresiFeltetel = "egyeb";
                    break;
                case "Dátum":
                    szuresiFeltetel = "koltekezes_datuma";
                    keresendo = KarakterCsere(textKeres.Text);
                    break;
            }

            string q = "select * from koltseg where " + szuresiFeltetel + " like '" + keresendo + "%'";

            try
            {
                Kapcsolodas();
                MySqlDataAdapter dAdapter = new MySqlDataAdapter(q, myConn);
                DataTable dTable = new DataTable();
                dAdapter.Fill(dTable);
                dgvKoltseg.DataSource = dTable;
                //string[] oszlop = { "", "Rezsi", "Tisztítószerek", "Üzemanyag", "Felújítás", "Egyéb", "Dátum" };

                for (int i = 0; i < dgvKoltseg.ColumnCount-1; i++)
                {
                    dgvKoltseg.Columns[i+1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvKoltseg.Columns[i+1].HeaderText = oszlop[i];
                }
                dgvKoltseg.Columns[0].Visible = false;
                dgvKoltseg.Font = new Font("Arial", 10);
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //dgvKoltseg.CurrentCell = dgvKoltseg.CurrentRow.Cells[0];
            //dgvKoltseg.CurrentCell.RowIndex;
        }

        private void textKeres_TextChanged(object sender, EventArgs e)
        {
            AdatracsKolt();
        }

        private void btnFelvesz_Click(object sender, EventArgs e)
        {
            Reset();
            textRezsi.Focus();
            buttonVendegMentes.Text = "Mentés";
        }

        private void btnSzerkeszt_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dgvKoltseg.CurrentRow.Cells[0].Value) == koltsegID)
            {
                string RezsiErt = dgvKoltseg.CurrentRow.Cells[1].Value.ToString();
                string tisztErt = dgvKoltseg.CurrentRow.Cells[2].Value.ToString();
                string uzemErt = dgvKoltseg.CurrentRow.Cells[3].Value.ToString();
                string felujErt = dgvKoltseg.CurrentRow.Cells[4].Value.ToString();
                string egyebErt = dgvKoltseg.CurrentRow.Cells[5].Value.ToString();

                textRezsi.Text = (RezsiErt == "" || RezsiErt == "0") ? "Rezsi" : RezsiErt;
                textTisztitoszer.Text = (tisztErt == "" || tisztErt == "0") ? "Tisztítószerek" : tisztErt;
                textUzemanyag.Text = (uzemErt == "" || uzemErt == "0") ? "Üzemanyag" : uzemErt;
                textFelujitas.Text = (felujErt == "" || felujErt == "0") ? "Felújítás" : felujErt;
                textEgyeb.Text = (egyebErt == "" || egyebErt == "0") ? "Egyéb" : egyebErt;

                koltsegID = int.Parse(dgvKoltseg.CurrentRow.Cells[0].Value.ToString());
                buttonVendegMentes.Text = "Módosít";
            }
        }

        private void buttonVendegMentes_Click(object sender, EventArgs e)
        {
            if ( textRezsi.Text.Trim() !=""  && textTisztitoszer.Text.Trim() !="" && textFelujitas.Text.Trim() !="" && textUzemanyag.Text.Trim() !="" && textEgyeb.Text.Trim() !="")
            {
                if (textRezsi.Text != "Rezsi" || textTisztitoszer.Text != "Tisztítószerek" || textUzemanyag.Text != "Üzemanyag" || textFelujitas.Text != "Felújítás" || textEgyeb.Text != "Egyéb")
                {
                    if (buttonVendegMentes.Text.Equals("Módosít"))
                    {
                        string q = "update koltseg set rezsi='" + textRezsi.Text + "', tisztitoszerek='" + textTisztitoszer.Text + "', uzemanyag='" + textUzemanyag.Text + "', felujitas='" + textFelujitas.Text + "', egyeb='" + textEgyeb.Text + "' where id = " + koltsegID;

                        try
                        {
                            Kapcsolodas();
                            myComm = new MySqlCommand(q, myConn);
                            dr = myComm.ExecuteReader();
                            myConn.Close();
                            buttonVendegMentes.Text = "Mentés";
                            myConn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else if (buttonVendegMentes.Text.Equals("Mentés"))
                    {
                        string q = "insert into koltseg (rezsi, tisztitoszerek, uzemanyag , felujitas, egyeb) values ('" + textRezsi.Text + "', '" + textTisztitoszer.Text + "', '" + textUzemanyag + "', '" + textFelujitas.Text + "', '" + textEgyeb.Text + "')";

                        try
                        {
                            Kapcsolodas();
                            myComm = new MySqlCommand(q, myConn);
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
                    MessageBox.Show("Minden mező nem lehet üres, legalább egyet kikell tölteni!", "Figyelem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("A mező nem lehet üres!", "Figyelem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            AdatracsKolt();
        }

        private void textKeres_Enter(object sender, EventArgs e)
        {
            if (textKeres.Text.Equals("Keresés..."))
                textKeres.Text = "";
        }

        private void textRezsi_Enter(object sender, EventArgs e)
        {
            if (textRezsi.Text.Equals("Rezsi"))
                textRezsi.Text = "";
        }

        private void textTisztitoszer_Enter(object sender, EventArgs e)
        {
            if (textTisztitoszer.Text.Equals("Tisztítószerek"))
                textTisztitoszer.Text = "";
        }

        private void textUzemanyag_Enter(object sender, EventArgs e)
        {
            if (textUzemanyag.Text.Equals("Üzemanyag"))
                textUzemanyag.Text = "";
        }

        private void textFelujitas_Enter(object sender, EventArgs e)
        {
            if (textFelujitas.Text.Equals("Felújítás"))
                textFelujitas.Text = "";
        }

        private void textEgyeb_Enter(object sender, EventArgs e)
        {
            if (textEgyeb.Text.Equals("Egyéb"))
                textEgyeb.Text = "";
        }

        private void textKeres_Leave(object sender, EventArgs e)
        {
            if (textKeres.Text.Equals(""))
                textKeres.Text = "Keresés...";
        }

        private void textRezsi_Leave(object sender, EventArgs e)
        {
            if (textRezsi.Text.Equals(""))
                textRezsi.Text = "Rezsi";
        }

        private void textTisztitoszer_Leave(object sender, EventArgs e)
        {
            if (textTisztitoszer.Text.Equals(""))
                textTisztitoszer.Text = "Tisztítószerek";
        }

        private void textUzemanyag_Leave(object sender, EventArgs e)
        {
            if (textUzemanyag.Text.Equals(""))
                textUzemanyag.Text = "Üzemanyag";
        }

        private void textFelujitas_Leave(object sender, EventArgs e)
        {
            if (textFelujitas.Text.Equals(""))
                textFelujitas.Text = "Felújítás";
        }

        private void textEgyeb_Leave(object sender, EventArgs e)
        {
            if (textEgyeb.Text.Equals(""))
                textEgyeb.Text = "Egyéb";
        }

        private void btnEltavolit_Click(object sender, EventArgs e)
        {
            string q = "delete from koltseg where id = " + koltsegID;

            DialogResult eredmeny = MessageBox.Show("Bitos hogy törölni szeretné?", "Figyelem!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (eredmeny == DialogResult.Yes)
            {
                try
                {
                    Kapcsolodas();
                    myComm = new MySqlCommand(q, myConn);
                    dr = myComm.ExecuteReader();
                    myConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                AdatracsKolt();
            }
        }

        private void dgvKoltseg_Click(object sender, EventArgs e)
        {
            koltsegID = Convert.ToInt32(dgvKoltseg.CurrentRow.Cells[0].Value);
        }

        private void comboBoxKeres_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdatracsKolt();
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
