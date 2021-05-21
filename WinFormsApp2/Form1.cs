using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        SqlConnection con = new(@"Data Source=d2iwg;Initial Catalog=BRUH;Integrated Security=True");
        public int ID;

        private void Form1_Load(object sender, EventArgs e)
        {
            GetBruhRecord();
        }

        private void GetBruhRecord()
        {
            SqlCommand cmd = new("Select  * from BRUH_TB", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            bruhRecordDataGridView.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IfValid())
            {
                SqlCommand cmd = new("INSERT INTO BRUH_TB VALUES (@Имя, @Фамилия, @Отчество, @Должность)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Имя", txtName.Text);
                cmd.Parameters.AddWithValue("@Фамилия", txtLastName.Text);
                cmd.Parameters.AddWithValue("@Отчество", txtSecondName.Text);
                cmd.Parameters.AddWithValue("@Должность", comboBox2.SelectedItem);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                //MessageBox.Show("Данные занесены в базу", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

                GetBruhRecord();
                ResetControls();
            }
        }

        private bool IfValid()
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Введите имя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void ResetControls()
        {
            txtName.Clear();
            txtLastName.Clear();
            txtSecondName.Clear();
            
            txtName.Focus();
        }

        private void bruhRecordDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(bruhRecordDataGridView.SelectedRows[0].Cells[0].Value);
            txtName.Text = bruhRecordDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txtLastName.Text = bruhRecordDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txtSecondName.Text = bruhRecordDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            comboBox2.Text = bruhRecordDataGridView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ID > 0 )
            {
                SqlCommand cmd = new("UPDATE BRUH_TB SET Имя= @Имя, Фамилия= @Фамилия, Отчество= @Отчество, Должность= @Должность WHERE ID= @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.ID);
                cmd.Parameters.AddWithValue("@Имя", txtName.Text);
                cmd.Parameters.AddWithValue("@Фамилия", txtLastName.Text);
                cmd.Parameters.AddWithValue("@Отчество", txtSecondName.Text);
                cmd.Parameters.AddWithValue("@Должность", comboBox2.Text);

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

        private void button3_Click(object sender, EventArgs e)
        {
            if(ID > 0)
            {
                SqlCommand cmd = new("DELETE FROM BRUH_TB WHERE ID= @ID", con);
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
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            mainMenu to = new();
            to.Show();
            this.Hide();
        }
    }
}
