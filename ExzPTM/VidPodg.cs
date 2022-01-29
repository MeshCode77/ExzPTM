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
    public partial class VidPodg : Form
    {
        int id; // значение id выбранной строки
        int ind; // значение индекса выбранной строки + 1
        int temp;
        public VidPodg()
        {
            InitializeComponent();

            dgVidPodg.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // выделить всю строку

            dgVidPodg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgVidPodg.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgVidPodg.DefaultCellStyle.SelectionForeColor = Color.Blue;
        }

        private void VidPodg_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pPMDataSet.typepodg". При необходимости она может быть перемещена или удалена.
            this.typepodgTableAdapter.Fill(this.pPMDataSet.typepodg);

            int row = dgVidPodg.Rows.Count;

            //textBox1.Text = row.ToString();

            
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
                    CommandText = "spInsertVidPodg"
                };

                // входные параметры
                //cmd.Parameters.AddWithValue("@idEmpl", DataTrans.lastIDempl);
                cmd.Parameters.AddWithValue("@name", tbVidPodg.Text);
                cmd.Parameters.AddWithValue("@expDate", tbDateExp.Text);
            
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.typepodgTableAdapter.Fill(this.pPMDataSet.typepodg);

            int rowIndex = dgVidPodg.Rows.Count; // узнаем количество строк
            dgVidPodg.CurrentCell = dgVidPodg[0, rowIndex - 1]; // устанавливаем курсор на новую добавленую сроку 
        }

        private void dgVidPodg_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tbVidPodg.Text = dgVidPodg.CurrentRow.Cells["name"].Value.ToString();
            tbDateExp.Text = dgVidPodg.CurrentRow.Cells["expdate"].Value.ToString();

            id = (int)dgVidPodg.CurrentRow.Cells["id1"].Value;

            //textBox2.Text = id.ToString();

            ind = dgVidPodg.CurrentRow.Index;

            //textBox3.Text = ind.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pPMDataSet.Tables["typepodg"].Rows[dgVidPodg.CurrentRow.Index].Delete(); // удаляет строку из таблицы users в DataSet
            typepodgTableAdapter.Update(pPMDataSet.typepodg);
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
                    CommandText = "spUpdateVidPodg"
                };

                // входные параметры
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@vidPodg", tbVidPodg.Text);
                cmd.Parameters.AddWithValue("@dateExp", tbDateExp.Text);               

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                dgVidPodg.CellEnter -= dgVidPodg_CellEnter;

                this.typepodgTableAdapter.Fill(this.pPMDataSet.typepodg); // обновить dataGridView

                dgVidPodg.CellEnter += dgVidPodg_CellEnter;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            dgVidPodg.CurrentCell = dgVidPodg[1, ind];

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(pPMDataSet.Tables["typepodg"]);
            DV.RowFilter = string.Format("name LIKE '%{0}%'", tbSearche.Text.Trim());
            dgVidPodg.DataSource = DV;
        }
    }
}
