using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Table2 : Form
    {
        public Table2()
        {
            InitializeComponent();
        }

        SqlConnection con = new(@"Data Source=d2iwg;Initial Catalog=BRUH;Integrated Security=True");
        public int ID;

        private void button1_Click(object sender, EventArgs e)
        {
            mainMenu to = new mainMenu();
            to.Show();
            this.Hide();
        }

        private void Table2_Load(object sender, EventArgs e)
        {
            GetBruhRecord();
        }

        private void GetBruhRecord()
        {
            
            SqlCommand cmd = new SqlCommand("Select * from BRUH_TB1", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            recordDataGridView.DataSource = dt;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(IfValid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO BRUH_TB1 (q,w,e,r,t,y) VALUES (@q,@w,@e,@r,@t,@y)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@q", comboWorkItem.SelectedItem);
                cmd.Parameters.AddWithValue("@w", txtWorkItem.Text);
                cmd.Parameters.AddWithValue("@e", comboCompStat.SelectedItem);
                cmd.Parameters.AddWithValue("@r", comboSystemStat.SelectedItem);
                cmd.Parameters.AddWithValue("@t", txtSystemBlock.Text);
                cmd.Parameters.AddWithValue("@y", txtSystemMono.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                GetBruhRecord();
            }
        }

        private bool IfValid()
        {
            if (txtSystemBlock.Text == string.Empty || txtSystemMono.Text == string.Empty || txtSystemBlock.Text == string.Empty)
            {
                MessageBox.Show("Введите дату и оборудование", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void ResetControls()
        {
            txtWorkItem.Clear();
            txtSystemMono.Clear();
            txtSystemBlock.Clear();

            txtWorkItem.Focus();
        }

        private void RecordDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(recordDataGridView.SelectedRows[0].Cells[0].Value);
            comboWorkItem.Text = recordDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtWorkItem.Text = recordDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            comboCompStat.Text = recordDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            comboSystemStat.Text = recordDataGridView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE BRUH_TB1 SET q= @q, w= @w, e= @e, r= @r, t= @t, y= @y WHERE ID= @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.ID);
                cmd.Parameters.AddWithValue("@q", txtWorkItem.Text);
                cmd.Parameters.AddWithValue("@w", txtSystemBlock.Text);
                cmd.Parameters.AddWithValue("@e", txtSystemMono.Text);
                cmd.Parameters.AddWithValue("@r", comboWorkItem.Text);
                cmd.Parameters.AddWithValue("@t", comboSystemStat.Text);
                cmd.Parameters.AddWithValue("@y", comboCompStat.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Данные обновлены", "Обновленно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetBruhRecord();
                ResetControls();
            }
            else
            {
                MessageBox.Show("Выбурете данные для обновления", "Выбрать?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM BRUH_TB1 WHERE ID= @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.ID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Данные удалены", "Удалено", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetBruhRecord();
                ResetControls();
            }
            else
            {
                MessageBox.Show("Выбурете данные для удаления", "Выбрать?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
