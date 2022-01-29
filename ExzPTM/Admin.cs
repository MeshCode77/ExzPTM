using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Сделать авторизацию и добавление пользователей через БД

namespace ExzPTM
{
    public partial class Admin : Form
    {       
        string pass;

        public string Pass { get => pass; set => pass = value; }

        public Admin()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == textBox3.Text)
            {
                Pass = textBox2.Text;
                DataTrans.temp = textBox2.Text;
                label4.Text = "Пароль сохранен";
                return;
            }
            else
            {
                label4.ForeColor = Color.Red;
                label4.Text = "Пароли не совпадают";
                return;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
