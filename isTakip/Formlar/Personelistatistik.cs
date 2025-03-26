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
    public partial class frmPersonelistatistik : Form
    {
        public frmPersonelistatistik()
        {
            InitializeComponent();
        }
        İsTakipEntities db = new İsTakipEntities();
        private void frmPersonelistatistik_Load(object sender, EventArgs e)
        {
            lblToplamDepartman.Text = db.Departmanlar.Count().ToString();
            lblToplamPersonel.Text = db.Personel.Count().ToString();
            lblFirmaSayisi.Text = db.Firmalar.Count().ToString();
            lblAktifIs.Text = db.Gorevler.Count(x => x.Durum == true).ToString();
            lblPasifIs.Text = db.Gorevler.Count(x => x.Durum == false).ToString();
            lblSonGorev.Text = db.Gorevler.OrderByDescending(x => x.ID).Select(x => x.Aciklama).FirstOrDefault();
            lblSonGorevTarihi.Text = db.Gorevler.OrderByDescending(x=>x.ID).Select(x=>x.Tarih).FirstOrDefault().ToString();
            lblIsYapilanSehir.Text = db.Firmalar.Select(x => x.İl).Distinct().Count().ToString();
            lblSektorSayisi.Text = db.Firmalar.Select(x => x.Sektor).Distinct().Count().ToString();
            DateTime bugun = DateTime.Today;
            lblBugunAcilanGorevler.Text = db.Gorevler.Count(x => x.Tarih == bugun).ToString();
            var d1 = db.Gorevler.GroupBy(x=> x.GorevAlan).OrderByDescending(z=>z.Count()).Select(y=>y.Key).FirstOrDefault();
            lblAyinPersoneli.Text = db.Personel.Where(x=>x.ID == d1).Select(y=>y.Ad+""+y.Soyad).FirstOrDefault().ToString();
            lblAyinDepartmani.Text = db.Departmanlar.Where(x=>x.ID == db.Personel.Where(t=>t.ID==d1).Select(z=>z.Departman).FirstOrDefault()).Select(y=>y.Ad).FirstOrDefault().ToString();
        }
    }
}
