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

namespace isTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Formlar.FrmDepartmanlar departmanlistesi;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(departmanlistesi==null|| departmanlistesi.IsDisposed) { 
            departmanlistesi = new Formlar.FrmDepartmanlar();
            departmanlistesi.MdiParent = this;
            departmanlistesi.Show();
            }
        }

        private void btnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmPersoneller frm = new Formlar.FrmPersoneller();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmPersonelistatistik frm = new Formlar.frmPersonelistatistik();
            frm.MdiParent = this;
            frm.Show();
        }
        Formlar.FrmGorevListesi gorevlistesi;
        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gorevlistesi == null || gorevlistesi.IsDisposed)
            {
                gorevlistesi = new Formlar.FrmGorevListesi();
                gorevlistesi.MdiParent = this;
                gorevlistesi.Show();
            }
        }

        private void btnGorevTanimla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmGorevTanimla frm = new Formlar.FrmGorevTanimla();
            frm.Show();
        }

        private void btnGorevDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.FrmGorevDetay frm = new Formlar.FrmGorevDetay();
            frm.Show();
        }
        Formlar.FrmAnaForm anaform;
        private void btnAnaForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (anaform == null || anaform.IsDisposed)
            {
                anaform = new Formlar.FrmAnaForm();
                anaform.MdiParent = this;
                anaform.Show();
            }
        }
        Formlar.FrmAktifTalepler aktifTalepler;
        private void btnAktifTalepler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             
            if (aktifTalepler == null || aktifTalepler.IsDisposed)
            {
                aktifTalepler = new Formlar.FrmAktifTalepler();
                aktifTalepler.MdiParent = this;
                aktifTalepler.Show();
            }

        }
    }
}
