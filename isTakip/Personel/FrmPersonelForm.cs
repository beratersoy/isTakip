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
    public partial class FrmPersonelForm : Form
    {
        public FrmPersonelForm()
        {
            InitializeComponent();
        }

        private void btnAktifGorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Personel.FrmAktifGorevler frm = new Personel.FrmAktifGorevler();   
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnTamamlananGorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Personel.FrmTamamlananGörevler frm = new Personel.FrmTamamlananGörevler();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
