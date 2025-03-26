using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using isTakip.Entity;

namespace isTakip.Formlar
{
    public partial class FrmGorevTanimla : Form
    {
        public FrmGorevTanimla()
        {
            InitializeComponent();
        }
        İsTakipEntities db = new İsTakipEntities();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Gorevler g = new Gorevler();
            g.Aciklama = txtAciklama.Text;
            g.Durum = true;
            g.GorevAlan = int.Parse(lookUpEdit1.EditValue.ToString());
            g.GorevVeren = int.Parse(txtGorevVeren.Text);
            g.Tarih = DateTime.Parse(txtTarih.Text);
            db.Gorevler.Add(g);
            db.SaveChanges();
            XtraMessageBox.Show("Görev Başarılı Bir Şekilde Tanımlandı.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void FrmGorevTanimla_Load(object sender, EventArgs e)
        {
            var degerler = (from x in db.Personel
                                select new
                                {
                                    x.ID,
                                   AdSoyad = x.Ad +" "+ x.Soyad

                                }).ToList();
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AdSoyad";
            lookUpEdit1.Properties.DataSource = degerler;
        }
    }
}
