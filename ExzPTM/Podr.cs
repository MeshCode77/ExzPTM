using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExzPTM
{
    public partial class Podr : Form
    {
        int idPodr;
        int ind;
        public Podr()
        {
            InitializeComponent();

            dgPodr.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // выделить всю строку

            dgPodr.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgPodr.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgPodr.DefaultCellStyle.SelectionForeColor = Color.Blue;

        }

        private void Podr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pPMDataSet.podr". При необходимости она может быть перемещена или удалена.
            this.podrTableAdapter.Fill(this.pPMDataSet.podr);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = new SqlConnection(Properties.Settings.Default.PPMConnectionString),
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "spInsertPodr"
                };

                // входные параметры
                //cmd.Parameters.AddWithValue("@idEmpl", DataTrans.lastIDempl);
                cmd.Parameters.AddWithValue("@podr", tbPodr.Text);
                

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.podrTableAdapter.Fill(this.pPMDataSet.podr);

            int rowIndex = dgPodr.Rows.Count; // узнаем количество строк
            dgPodr.CurrentCell = dgPodr[0, rowIndex - 1]; // устанавливаем курсор на новую добавленую сроку 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pPMDataSet.Tables["podr"].Rows[dgPodr.CurrentRow.Index].Delete(); // удаляет строку из таблицы users в DataSet
            podrTableAdapter.Update(pPMDataSet.podr);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = new SqlConnection(Properties.Settings.Default.PPMConnectionString),
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "spUpdatePodr"
                };

                // входные параметры
                cmd.Parameters.AddWithValue("@id", idPodr);
                cmd.Parameters.AddWithValue("@podr", tbPodr.Text);                

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                dgPodr.CellEnter -= dgPodr_CellEnter;

                this.podrTableAdapter.Fill(this.pPMDataSet.podr); // обновить dataGridView

                dgPodr.CellEnter += dgPodr_CellEnter;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dgPodr.CurrentCell = dgPodr[1, ind];
        }

        private void dgPodr_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            idPodr = (int)dgPodr.CurrentRow.Cells["id"].Value;
            ind = dgPodr.CurrentRow.Index;

            tbPodr.Text = dgPodr.CurrentRow.Cells["name"].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(pPMDataSet.Tables["typepodg"]);
            DV.RowFilter = string.Format("name LIKE '%{0}%'", tbSearche.Text.Trim());
            dgPodr.DataSource = DV;

            
        }
    }
}
