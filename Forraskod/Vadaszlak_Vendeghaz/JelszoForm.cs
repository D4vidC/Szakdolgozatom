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
    public partial class JelszoForm : Form
    {
        MySqlConnection myConn = new MySqlConnection("server=remotemysql.com;user id=yN6LYJnGl2; password=i72zP359qP; database=yN6LYJnGl2; charset=utf8");
        MySqlCommand myComm;
        MySqlDataReader dr;

        public JelszoForm()
        {
            InitializeComponent();
        }

        public void Kapcsolodas()
        {
            if (myConn.State == ConnectionState.Closed)
                myConn.Open();
        }

        private void buttonMentes_Click(object sender, EventArgs e)
        {
            int jelszoID = 0;
            string q = "select id from jelszo where jelszo like md5('" + textBoxRegiJ.Text + "')";
            Console.WriteLine(q);

            if (textBoxUjJ.Text.Trim() != "" && textBoxUjJIsm.Text.Trim() != "")  
            {
                if (textBoxUjJ.Text.Length >= 4)
                {


                    if (textBoxUjJ.Text == textBoxUjJIsm.Text)
                    {
                        try
                        {
                            Kapcsolodas();
                            myComm = new MySqlCommand(q, myConn);
                            dr = myComm.ExecuteReader();
                            if (dr.HasRows)
                            {
                                dr.Read();
                                jelszoID = Convert.ToInt32(dr[0]);
                                dr.Close();
                                q = "UPDATE jelszo SET jelszo=md5(" + textBoxUjJ.Text + ") WHERE id=" + jelszoID;

                                myComm = new MySqlCommand(q, myConn);
                                dr = myComm.ExecuteReader();
                                labelsiker.ForeColor = Color.DarkOliveGreen;
                                labelsiker.Text = "A jelszó módosítása sikeres!";
                            }
                            else
                            {
                                MessageBox.Show("Érvénytelen jelenlegi jelszót adott meg!", "Figyelem!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                            myConn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Az 'új jelszó' mező és az 'új jelszó ismét' mező tartalmának meg kell egyeznie!", "Figyelem!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Legalább 4 karakter hosszú jelszót adjon meg!", "Figyelem!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("A mezők tartalma nem lehet üres!", "Figyelem!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void labelsiker_Click(object sender, EventArgs e)
        {
            if (labelsiker.Text.Equals("Sikeres jelszó módosítás!"))
            {
                //vendég ablakra vissza írányít
            }
        }

        private void buttonMegse_Click(object sender, EventArgs e)
        {
            textBoxRegiJ.Text = "";
            textBoxUjJ.Text = "";
            textBoxUjJIsm.Text = "";
        }

        private void JelszoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
