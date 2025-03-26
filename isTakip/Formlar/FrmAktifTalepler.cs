using isTakip.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace isTakip.Formlar
{
    public partial class FrmAktifTalepler : Form
    {
        public FrmAktifTalepler()
        {
            InitializeComponent();
        }

        private void FrmAktifTalepler_Load(object sender, EventArgs e)
        {
            İsTakipEntities db = new İsTakipEntities();
            var degerler = (from x in db.Cagrilar
                            select new
                            {
                                x.ID,
                                x.Firmalar.Ad,
                                x.Firmalar.Telefon,
                                x.Konu,
                                x.Aciklama,
                                x.Durum
                            }).Where(y=>y.Durum==true).ToList();
            gridControl1.DataSource = degerler;
        }
    }
}
