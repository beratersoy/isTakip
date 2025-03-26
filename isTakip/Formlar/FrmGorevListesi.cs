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
    public partial class FrmGorevListesi : Form
    {
        public FrmGorevListesi()
        {
            InitializeComponent();
        }
        İsTakipEntities db = new İsTakipEntities();
        void GorevListele()
        {
            gridControl1.DataSource = (from x in db.Gorevler select new { x.Aciklama }).ToList();
        }
        private void FrmGorevListesi_Load(object sender, EventArgs e)
        {
          GorevListele();
            lblAktifGorev.Text = db.Gorevler.Where(x => x.Durum == true).Count().ToString();
            lblPasifGorev.Text = db.Gorevler.Where(x => x.Durum == false).Count().ToString();
            lblToplamDepartman.Text= db.Departmanlar.Count().ToString();

            chartControl1.Series["Durum"].Points.AddPoint("Aktif Görevler", int.Parse(lblAktifGorev.Text));
            chartControl1.Series["Durum"].Points.AddPoint("Pasif Görevler", int.Parse(lblPasifGorev.Text));


        }

        
    }
}
