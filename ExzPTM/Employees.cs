using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExzPTM
{
    public partial class Employees : Form
    {
        int idEmpl; // индекс строки выбранного сотрудника
        int ind;

        public int IdEmpl { get => idEmpl; set => idEmpl = value; }

        public Employees()
        {
            InitializeComponent();

            dgEmpl.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // выделить всю строку

            dgEmpl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            dgEmpl.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgEmpl.DefaultCellStyle.SelectionForeColor = Color.Blue;

            this.FormBorderStyle = FormBorderStyle.FixedDialog; // запрет изменения размера формы
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pPMDataSet.typepodg". При необходимости она может быть перемещена или удалена.
            this.typepodgTableAdapter.Fill(this.pPMDataSet.typepodg);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pPMDataSet.podr". При необходимости она может быть перемещена или удалена.
            this.podrTableAdapter.Fill(this.pPMDataSet.podr);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pPMDataSet.employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.pPMDataSet.employees);

            //label7.Visible = false;
            //comboBox1.Visible = false;

            EditDateOff();

            //textBox2.Text = DateTime.Now.AddDays(14).ToShortDateString().ToString();

            day14AndProsrochka();

        }

        public void day14AndProsrochka()
        {
            List<string> list = new List<string>();
            
            int col = dgEmpl.Rows.Count - 1;

            DateTime tek14 = DateTime.Today.AddDays(14);
                      
            for (int i = 0; i <= col; i++)
            {
                // 14 дней до окончания срока подготовки
                if(tek14 >= (DateTime)dgEmpl.Rows[i].Cells["dateExpired"].Value) 
                        dgEmpl.Rows[i].DefaultCellStyle.BackColor = Color.Yellow; 
                // срок подготовки просрочен
                if ((DateTime)dgEmpl.Rows[i].Cells["dateExpired"].Value <= DateTime.Now)
                        dgEmpl.Rows[i].DefaultCellStyle.BackColor = Color.LightCoral;

            }
        }


        // Добавить сотрудника
        private void button2_Click(object sender, EventArgs e)
        {
            //AddEmplcs addEmplcs = new AddEmplcs();            
            //addEmplcs.Show();

            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = new SqlConnection(Properties.Settings.Default.PPMConnectionString),
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "spInsertEmployees"
                };

                // входные параметры
                cmd.Parameters.AddWithValue("@idpodr", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@lastName", tbLastName.Text);
                cmd.Parameters.AddWithValue("@firstName", tbFirstName.Text);
                cmd.Parameters.AddWithValue("@parentName", tbParentName.Text);
                cmd.Parameters.AddWithValue("@position", tbPosition.Text);
                cmd.Parameters.AddWithValue("@talon", tbTalon.Text);
                cmd.Parameters.AddWithValue("@vidPodg", cbVidPodg.Text);
                cmd.Parameters.AddWithValue("@date_pass", dtpDatePass.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@dateExp", dtpExpDate.Value); // Дата окончания

                

                //// определяем первый выходной параметр
                SqlParameter LastId = new SqlParameter
                {
                    ParameterName = "@lastID",
                    SqlDbType = SqlDbType.Int
                };
                // указываем, что параметр будет выходным для связи с таблицей formullar
                LastId.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(LastId);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
               
                DataTrans.lastIDempl = LastId.Value.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.employeesTableAdapter.Fill(this.pPMDataSet.employees);

            day14AndProsrochka();

            int rowIndex = dgEmpl.Rows.Count; // узнаем количество строк
            dgEmpl.CurrentCell = dgEmpl[0, rowIndex - 1]; // устанавливаем курсор на новую добавленую сроку 
        }

        private void dgEmpl_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            idEmpl = (int)dgEmpl.CurrentRow.Cells[0].Value;

            ind = dgEmpl.CurrentRow.Index;

            tbLastName.Text = dgEmpl.CurrentRow.Cells[1].Value.ToString();
            tbFirstName.Text = dgEmpl.CurrentRow.Cells[2].Value.ToString();
            tbParentName.Text = dgEmpl.CurrentRow.Cells[3].Value.ToString();
            tbPosition.Text = dgEmpl.CurrentRow.Cells[4].Value.ToString();
            tbTalon.Text = dgEmpl.CurrentRow.Cells[5].Value.ToString();
            //tbDate.Text = dgEmpl.CurrentRow.Cells[6].Value.ToString();
            //dateTimePicker1.Value = (DateTime)dgEmpl.CurrentRow.Cells[6].Value.ToString();
        }

        // Удалить сотрудника
        private void button3_Click(object sender, EventArgs e)
        {
            pPMDataSet.Tables["employees"].Rows[dgEmpl.CurrentRow.Index].Delete(); // удаляет строку из таблицы users в DataSet
            employeesTableAdapter.Update(pPMDataSet.employees);

            int rowIndex = dgEmpl.Rows.Count; // узнаем количество строк
            dgEmpl.CurrentCell = dgEmpl[0, rowIndex - 1]; // устанавливаем курсор на новую добавленую сроку 
        }

        // Редактировать данные сотрудника
        private void button4_Click(object sender, EventArgs e)
        {
                      
        }

        private void EditDateOn()
        {
            tbLastName.ReadOnly = false;
            tbFirstName.ReadOnly = false;
            tbParentName.ReadOnly = false;
            tbPosition.ReadOnly = false;
            tbTalon.ReadOnly = false;
            //tbDate.ReadOnly = false;
            label7.Visible = true;
            comboBox1.Visible = true;
            dtpDatePass.Enabled = true;

            comboBox1.Enabled = true;
            dtpExpDate.Enabled = true;
            cbVidPodg.Enabled = true;
            cbDateExp.Enabled = true;

            button2.Enabled = true;
            button3.Enabled = true;          
            button5.Enabled = true;
            button6.Enabled = true;
        }

        private void EditDateOff()
        {
            tbLastName.ReadOnly = true;
            tbFirstName.ReadOnly = true; ;
            tbParentName.ReadOnly = true; ;
            tbPosition.ReadOnly = true; ;
            tbTalon.ReadOnly = true; ;
            //tbDate.ReadOnly = true; ;
            label7.Visible = false; ;
            //comboBox1.Visible = false;
            dtpDatePass.Enabled = false;

            comboBox1.Enabled = false;
            dtpExpDate.Enabled = false;
            cbVidPodg.Enabled = false;
            cbDateExp.Enabled = false;

            button2.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }

        // Обновить данные сотрудника
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                

                SqlCommand cmd = new SqlCommand
                {
                    Connection = new SqlConnection(Properties.Settings.Default.PPMConnectionString),
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "spUpdateEmployees"
                };

                // входные параметры
                cmd.Parameters.AddWithValue("@idEmpl", idEmpl);
                cmd.Parameters.AddWithValue("@lastName", tbLastName.Text);
                cmd.Parameters.AddWithValue("@firstName", tbFirstName.Text);
                cmd.Parameters.AddWithValue("@parentName", tbParentName.Text);
                cmd.Parameters.AddWithValue("@position", tbPosition.Text);
                cmd.Parameters.AddWithValue("@talon", tbTalon.Text);
                cmd.Parameters.AddWithValue("@vidPodg", cbVidPodg.Text);
                cmd.Parameters.AddWithValue("@date_pass", dtpDatePass.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@dateExp", dtpExpDate.Value); // Дата окончания


                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                dgEmpl.CellEnter -= dgEmpl_CellEnter;

                this.employeesTableAdapter.Fill(this.pPMDataSet.employees);

                day14AndProsrochka();

                dgEmpl.CellEnter += dgEmpl_CellEnter;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dgEmpl.CurrentCell = dgEmpl[1, ind];

        }

        private void button6_Click(object sender, EventArgs e)
        {
            tbLastName.Text = "";
            tbFirstName.Text = "";
            tbParentName.Text = "";
            tbPosition.Text = "";
            tbTalon.Text = "";
                    
        }

        

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            EditAdmin ea = new EditAdmin();

            if (ea.ShowDialog() == DialogResult.OK)
            {                
                EditDateOn();               
            }
            else
            {
                
                EditDateOff();
                checkBox1.Checked = false;
                return;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDateExp.SelectedIndex = cbVidPodg.SelectedIndex;

            // можно и switch case
            if (cbDateExp.Text == "12")
                dtpExpDate.Value =  DateTime.Now.AddYears(1);
            if (cbDateExp.Text == "24")
                dtpExpDate.Value = DateTime.Now.AddYears(2);
            if (cbDateExp.Text == "36")
                dtpExpDate.Value = DateTime.Now.AddYears(3);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(pPMDataSet.Tables["Employees"]);
            DV.RowFilter = string.Format("lastname LIKE '%{0}%'", tbSearche.Text.Trim());
            dgEmpl.DataSource = DV;

            day14AndProsrochka();
        }
    }
}
