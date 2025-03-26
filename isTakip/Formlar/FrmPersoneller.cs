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
using isTakip.Entity;

namespace isTakip.Formlar
{
    public partial class FrmPersoneller : Form
    {
        public FrmPersoneller()
        {
            InitializeComponent();
        }

        İsTakipEntities db = new İsTakipEntities();
        void PersonelListesi()
        {
            var degerler = from x in db.Personel
                           select new
                           {
                               x.ID,
                               x.Ad,
                               x.Soyad,
                               x.Mail,
                               Departman = x.Departmanlar.Ad,
                               x.Durum
                           };
            gridControl1.DataSource = degerler.Where(x => x.Durum == true).ToList();


        }
        private void FrmPersoneller_Load(object sender, EventArgs e)
        {
            PersonelListesi();

            var departmanlar = (from x in db.Departmanlar
                                select new
                                {
                                    x.ID,
                                    x.Ad,

                                }).ToList();
            txtDepartman.Properties.ValueMember = "ID";
            txtDepartman.Properties.DisplayMember = "Ad";
            txtDepartman.Properties.DataSource = departmanlar;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            PersonelListesi();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Personel t = new Personel();
            t.Ad = txtAd.Text;
            t.Soyad = txtSoyad.Text;
            t.Mail = txtMail.Text;
            t.Gorsel = txtGorsel.Text;
            t.Departman = int.Parse(txtDepartman.EditValue.ToString());
            db.Personel.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Yeni personel kaydınız başarılı bir şekilde eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PersonelListesi();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var x = int.Parse(txtId.Text);
            var deger = db.Personel.Find(x);
            deger.Durum = false;
            db.SaveChanges();
            XtraMessageBox.Show("Silme işleminiz başarı ile gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            PersonelListesi();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtAd.Text = gridView1.GetFocusedRowCellValue("Ad").ToString();
            txtSoyad.Text = gridView1.GetFocusedRowCellValue("Soyad").ToString();
            txtMail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
            //txtGorsel.Text = gridView1.GetFocusedRowCellValue("Gorsel").ToString();
            txtDepartman.Text = gridView1.GetFocusedRowCellValue("Departman").ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtId.Text);
            var deger = db.Personel.Find(x);
            deger.Ad = txtAd.Text;
            deger.Soyad = txtSoyad.Text;
            deger.Mail = txtMail.Text;
            deger.Gorsel = txtGorsel.Text;
            deger.Departman = int.Parse(txtDepartman.EditValue.ToString());
            db.SaveChanges();
            XtraMessageBox.Show("Güncelleme işleminiz başarı ile gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PersonelListesi();
        }
    }
}
