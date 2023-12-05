using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace РКИС_прототип
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label5.Text = comboBox1.Text;
            label5.Text = "Enter your login";
            Show();
            label5.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label6.Text = comboBox1.Text;
            label6.Text = "Enter your password";
            Show();
            label6.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Админ" && textBox2.Text == "12345")
            {
                Админ_ok Админ_ok = new Админ_ok();
                Админ_ok.Show();
                MessageBox.Show("Вы вошли на Админ");
            }
            else if (comboBox1.Text == "Админ" && textBox2.Text == "1235")
                MessageBox.Show("неправильный пароль");
            else if (comboBox1.Text == "Бегун" && textBox2.Text == "123456")
            {
                Form2 user = new Form2();
                user.Show();
                MessageBox.Show("Вы вошли на бегун");

            }
            else if (comboBox1.Text == "Бегун" && textBox2.Text == "128")
                MessageBox.Show("неправильный пароль");
            else if (comboBox1.Text == "Координатор" && textBox2.Text == "123456789")
            {
                Form3 user = new Form3();
                user.Show();
                MessageBox.Show("Вы вошли на координатор");

            }
            else if (comboBox1.Text == "Координатор" && textBox2.Text == "12345")
                MessageBox.Show("неправильный пароль");


        }

        private void login_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.MidnightBlue;
            panel2.BackColor = Color.MidnightBlue;
            string st;
            DateTime ddn = DateTime.Now;
            string CrLf = "\r\n";
            st = ddn.ToString();
            textBox3.Text = st.Substring(0, 10) + CrLf + st.Substring(11);
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible=false;
        }
    }
}
