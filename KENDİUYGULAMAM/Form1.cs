using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KENDİUYGULAMAM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string tcno, adSoyad, cinsiyet="", mezuniyet="", diller="", uzmanlik="";
            tcno = txtTc.Text;
            adSoyad = txtAdSoyad.Text;

            //cinsiyet kısmı
            if (rdbBay.Checked == true)
            {
                cinsiyet = rdbBay.Text;

            }
            else if (rdbBayan.Checked == true)
            {
                cinsiyet = rdbBayan.Text;
            }

            //mezuniyet
            if (rdbIlkokul.Checked == true)
            {
                mezuniyet = rdbIlkokul.Text;
            }
            else if (rdbOrtaOgretim.Checked == true)
            {
                mezuniyet = rdbOrtaOgretim.Text;
            }
            else if (rdbLisans.Checked == true)
            {
                mezuniyet = rdbLisans.Text;
            }
            else if (rdbYuksekLisans.Checked == true)
            {
                mezuniyet = rdbYuksekLisans.Text;
            }

            //bildigi diller kısmı
            if (checkBox1.Checked==true)
            {
                diller = diller + " , " + checkBox1.Text;
            }
            if (checkBox2.Checked == true)
            {
                diller = diller + " , " + checkBox1.Text;
            }
            if (checkBox3.Checked == true)
            {
                diller = diller + " , " + checkBox1.Text;
            }
            if (checkBox4.Checked == true)
            {
                diller = diller + " , " + checkBox1.Text;
            }
            if (checkBox5.Checked == true)
            {
                diller = diller + " , " + checkBox1.Text;
            }
            if (checkBox6.Checked == true)
            {
                diller = diller + " , " + checkBox1.Text;
            }
            diller = diller.Substring(1);//string 1. den itibaren başlasın 0. yı sil yani ilk virgülü sil

            //uzmanlık alanları
            if (checkBox7.Checked==true)
            {
                uzmanlik = uzmanlik + " , " + checkBox7.Text;
            }
            if (checkBox8.Checked == true)
            {
                uzmanlik = uzmanlik + " , " + checkBox7.Text;
            }
            if (checkBox9.Checked == true)
            {
                uzmanlik = uzmanlik + " , " + checkBox7.Text;
            }
            if (checkBox10.Checked == true)
            {
                uzmanlik = uzmanlik + " , " + checkBox7.Text;
            }
            if (checkBox11.Checked == true)
            {
                uzmanlik = uzmanlik + " , " + checkBox7.Text;
            }
            if (checkBox12.Checked == true)
            {
                uzmanlik = uzmanlik + " , " + checkBox7.Text;
            }
            uzmanlik = uzmanlik.Substring(1);

            //listboxa ekleme

            listBox1.Items.Add("TC NO : " + tcno + " İSİM SOYİSİM " + adSoyad + " CİNSİYET : " + cinsiyet + " MEZUNİYET :" + mezuniyet
                + " DİLLER : " + diller + " UZMANLİK :" + uzmanlik);

        }
        //listboxta secili olanı silme
        private void btnSil_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);


        }

        private void tbnTumSil_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();


        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            txtAdSoyad.Clear();
            txtTc.Clear();

        }
    }
}
