using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuoiKi
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmChonMaTran chonMaTran = new frmChonMaTran();
            chonMaTran.ShowDialog();
        }

        private void btnNhapMaTran_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNhapMaTran nhapMaTran = new frmNhapMaTran();
            nhapMaTran.ShowDialog();
        }

        private void Menu1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnVeDoThi_Click(object sender, EventArgs e)
        {
        }

        private void lblAboutUs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAboutUs frmAboutUs = new frmAboutUs();
            frmAboutUs.Show();
        }
    }
}
