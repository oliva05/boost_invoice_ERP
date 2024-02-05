using ACS.Classes;
using JAGUAR_APP.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAGUAR_APP
{
    public partial class MDIParentFormLOSA : Form
    {
        //private int childFormNumber = 0;
        frmMain frm;
        public MDIParentFormLOSA()
        {
            InitializeComponent();
            lblServerName.Text = "Server Name: " + Globals.JAGUAR_ServerName + "  DB: " + Globals.JAGUAR_ActiveDB;
            frm = new frmMain();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) 
        {
            //frm = new frmMain();
            //frm.MdiParent = this;
            //frm.WindowState = FormWindowState.Normal;
            //frm.Show();
        }
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frm = new frmMain();
            //frm.MdiParent = this;
            //frm.WindowState = FormWindowState.Normal;
            //frm.Show();
        }

        private void MDIParentFormLOSA_Click(object sender, EventArgs e)  
        {
            //Form frmx = (Form)sender;
            //if (frmx.Name == "Gat")
            //{
            //    frm = new frmMain();
            //    frm.MdiParent = this;
            //    frm.WindowState = FormWindowState.Normal;

            //    frm.Show();
            //}
        }

        private void MDIParentFormLOSA_MouseClick(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //{
            //    frm = new frmMain();
            //    frm.MdiParent = this;
            //    frm.WindowState = FormWindowState.Normal;

            //    frm.Show();
            //}
        }

        private void panelControl1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void contextMenuStrip1_MouseClick(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //{
            //    frm = new frmMain();
            //    frm.MdiParent = this;
            //    frm.WindowState = FormWindowState.Normal;

            //    frm.Show();
            //}
        }

        private void MDIParentFormLOSA_MouseClick_1(object sender, MouseEventArgs e)
        {
            //if (e.Button == System.Windows.Forms.MouseButtons.Right)
            //{
            //    popupMenu1.ShowPopup(Cursor.Position);
            //}
        }

        private void MDIParentFormLOSA_Click_1(object sender, EventArgs e)
        {
            //if (e.Button == System.Windows.Forms.MouseButtons.Right)
            //{
            //    popupMenu1.ShowPopup(Cursor.Position);
            //}
        }

        private void abrirLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm1 in this.MdiChildren)
            {
                //if (frm.Name == "frmMain")
                //{
                //    frm.Dispose();
                //    return;
                //}
                frm1.Dispose();
            }
            frm = new frmMain();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
        }

        private void notificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //xfrmPopup frm = new xfrmPopup();
            //frm.ShowDialog();
        }
    }
}
