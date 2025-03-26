using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using isTakip.Entity;

namespace isTakip.Formlar
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        İsTakipEntities db = new İsTakipEntities();
        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.Gorevler
                                       select new
                                       {
                                           x.Aciklama,
                                           Personel = x.Personel.Ad + " " + x.Personel.Soyad,
                                           x.Durum
                                       }).Where(y => y.Durum == true).ToList();

            gridView1.Columns["Durum"].Visible = false;

            //Bugün yapılan görevler
            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            gridControl2.DataSource = (from x in db.GorevDetaylar
                                       select new
                                       {
                                           gorevaciklama = x.Gorevler.Aciklama,
                                           x.Aciklama,
                                           x.Tarih
                                       }).Where(x => x.Tarih == bugun).ToList();

            //Aktif Çağrılar
            gridControl3.DataSource = (from x in db.Cagrilar
                                       select new
                                       {
                                           x.Firmalar.Ad,
                                           x.Konu,
                                           x.Tarih,
                                           x.Durum

                                       }).Where(x => x.Durum == true).ToList();
            gridView3.Columns["Durum"].Visible = false;

            //Firma Listesi
            gridControl4.DataSource = (from x in db.Firmalar
                                       select new
                                       {
                                           x.Ad,
                                           x.Telefon,
                                           x.Mail
                                       }).ToList();

            //Sipariş Listesi

        }
    }
}
