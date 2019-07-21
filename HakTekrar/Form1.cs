using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HakTekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hak = 5;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lblRandomSayi.Text = rnd.Next(10000000, 100000000).ToString();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {            
            try
            {
                int randomGiris = int.Parse(txtGiris.Text);
                int randomsayi = int.Parse(lblRandomSayi.Text);
                if (randomGiris == randomsayi)
                {
                    txtGiris.Enabled = false;
                    btnGiris.Enabled = false;
                    MessageBox.Show("Giriş Başarılı !!");
                }
                else
                {
                    hak--;
                    lblKalanHak.Text = hak.ToString();
                    MessageBox.Show("Yanlış Giriş yaptınız Hak Sayınız :"+hak);
                    if (hak == 0)
                    {
                        btnGiris.Enabled = false;
                        txtGiris.Enabled = false;
                        lblRandomSayi.Text = "********";
                        MessageBox.Show("Giriş Hakkınız kalmadı giriş yapamazsınız !");
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
               
            }
        }
    }
}
