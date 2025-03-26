using DevExpress.XtraGrid;
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

namespace isTakip.Personel
{
    public partial class FrmTamamlananGörevler : Form
    {
        public FrmTamamlananGörevler()
        {
            InitializeComponent();
        }
        İsTakipEntities db = new İsTakipEntities();
        private void FrmTamamlananGörevler_Load(object sender, EventArgs e)
        {
            var degerler = (from x in db.Gorevler
                            select new
                            {
                                x.ID,
                                x.Aciklama,
                                x.Tarih,
                                x.GorevAlan,
                                x.Durum
                            }).Where(y => y.GorevAlan == 1 && y.Durum == false).ToList();

            gridControl1.DataSource = degerler;
            gridView1.Columns["GorevAlan"].Visible = false;
            gridView1.Columns["Durum"].Visible = false;
        }
    }
}
