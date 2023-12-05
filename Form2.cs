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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.MidnightBlue;
            panel2.BackColor = Color.MidnightBlue;
            string st;
            DateTime ddn = DateTime.Now;
            string CrLf = "\r\n";
            st = ddn.ToString();
            textBox3.Text = st.Substring(0, 10) + CrLf + st.Substring(11);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
        }
    }
}
