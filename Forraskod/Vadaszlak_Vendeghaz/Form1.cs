using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Vadaszlak_Vendeghaz
{
    public partial class Form1 : Form
    {
        public Point egerHelye;
        MySqlConnection myConn = new MySqlConnection("server=remotemysql.com;user id=yN6LYJnGl2; password=i72zP359qP; database=yN6LYJnGl2; charset=utf8");
        public MySqlCommand myComm;
        public MySqlDataReader dr;
        public MD5 hash = MD5.Create();

        public static Cursor CreateCursor(Bitmap bm, Size size)
        {
            bm = new Bitmap(bm, size);
            return new Cursor(bm.GetHicon());
        }

        string cons = "server=localhost;user id=root;database=vendeghaz";
        public Form1()
        {
            InitializeComponent();
            this.Cursor = CreateCursor((Bitmap)imageList1.Images[0], new Size(30, 30));
            //Foablak fablak = new Foablak();
            //fablak.Show();
        }

        public void Kapcsolodas()
        {
            if (myConn.State == ConnectionState.Closed)
                 myConn.Open();
        }

        void Belepes()
        {
            string q = "select * from jelszo where jelszo like md5('" +
            txtPassword.Text + "')";

            try
            {
                Kapcsolodas();
                myComm = new MySqlCommand(q, myConn);
                dr = myComm.ExecuteReader();

                if (dr.HasRows)
                {
                    Foablak fablak = new Foablak();
                    fablak.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Érvénytelen jelszó!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.PasswordChar = char.Parse("\0");
                    txtPassword.Text = "jelszó";
                    this.ActiveControl = null;
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Belepes();
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.PasswordChar = char.Parse("\0");
                txtPassword.Text = "jelszó";
                this.ActiveControl = null;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("jelszó"))
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '*';
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            egerHelye = new Point(-e.X, -e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point egerPoz = Control.MousePosition;
                egerPoz.Offset(egerHelye.X, egerPoz.Y);
                Location = egerPoz;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Belepes();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
