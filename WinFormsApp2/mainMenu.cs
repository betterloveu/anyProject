using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 to = new();
            to.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Table2 to = new();
            to.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Table3 to = new();
            to.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void mainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        
    }
}
