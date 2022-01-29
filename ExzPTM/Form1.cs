using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExzPTM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void видыToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            VidPodg vp = new VidPodg();
            vp.MdiParent = this;
            vp.Show();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees emp = new Employees();
            emp.MdiParent = this;
            emp.Show();
        }

        private void подразделенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Podr podr = new Podr();
            podr.MdiParent = this;
            podr.Show();
        }

        private void отчетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report rep = new Report();
            rep.MdiParent = this;
            rep.Show();
        }

        private void парольАдминистратораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
