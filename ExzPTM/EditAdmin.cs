using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ExzPTM
{
    public partial class EditAdmin : Form
    {
       
        public EditAdmin()
        {
            InitializeComponent();

            timer1.Enabled = true;
            timer1.Interval = 3000;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {           

            Admin admin = new Admin();
                             
            if(textBox1.Text != DataTrans.temp)
            {
                label1.ForeColor = Color.Red;             
                label1.Text = "Пароль не верен!!!";

                timer1.Tick += timer1_Tick;
                timer1.Start();
            }
            else
            {
                DialogResult = DialogResult.OK;
            }           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {           
            label1.Text = null;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
