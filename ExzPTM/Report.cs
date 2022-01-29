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
    public partial class Report : Form
    {
        Employees em = new Employees();
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pPMDataSet.employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.pPMDataSet.employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "PPMDataSet.typepodg". При необходимости она может быть перемещена или удалена.
         
            this.reportViewer1.RefreshReport();

            em.day14AndProsrochka();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
