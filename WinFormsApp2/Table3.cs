using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Table3 : Form
    {
        public Table3()
        {
            InitializeComponent();
        }

        SqlConnection con = new(@"Data Source=d2iwg;Initial Catalog=BRUH;Integrated Security=True");
        public int ID;
        private void Table3_Load(object sender, EventArgs e)
        {
            GetBruhRecord();
        }

        private void GetBruhRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from BRUH_TB2", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            recordDataGridView.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO BRUH_TB2 (q,w,e,r,t,y) VALUES (@q,@w,@e,@r,@t,@y)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@q", txtNameP.Text);
            cmd.Parameters.AddWithValue("@w", txtConData.Text);
            cmd.Parameters.AddWithValue("@e", txtDateAnt.Text);
            cmd.Parameters.AddWithValue("@r", txtNameTake.Text);
            cmd.Parameters.AddWithValue("@t", txtGiveit.Text);
            cmd.Parameters.AddWithValue("@y", txtGiveRec.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            GetBruhRecord();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void ResetControls()
        {
            txtNameP.Clear();
            txtConData.Clear();
            txtDateAnt.Clear();
            txtNameTake.Clear();
            txtGiveit.Clear();
            txtGiveRec.Clear();

            txtNameP.Focus();
        }

        private void recordDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(recordDataGridView.SelectedRows[0].Cells[0].Value);
            txtNameP.Text = recordDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtConData.Text = recordDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtDateAnt.Text = recordDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            txtNameTake.Text = recordDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            txtGiveit.Text = recordDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            txtGiveRec.Text = recordDataGridView.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE BRUH_TB2 SET q= @q, w= @w, e= @e, r= @r, t= @t, y= @y WHERE ID= @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.ID);
                cmd.Parameters.AddWithValue("@q", txtNameP.Text);
                cmd.Parameters.AddWithValue("@w", txtConData.Text);
                cmd.Parameters.AddWithValue("@e", txtDateAnt.Text);
                cmd.Parameters.AddWithValue("@r", txtNameTake.Text);
                cmd.Parameters.AddWithValue("@t", txtGiveit.Text);
                cmd.Parameters.AddWithValue("@y", txtGiveRec.Text);

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
                SqlCommand cmd = new SqlCommand("DELETE FROM BRUH_TB2 WHERE ID= @ID", con);
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

        private void button5_Click(object sender, EventArgs e)
        {
            mainMenu to = new();
            to.Show();
            this.Hide();
        }
    }
}
