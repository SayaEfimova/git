using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace РКИС_прототип
{
    public partial class Админ_ok : Form
    {
        public Админ_ok()
        {
            InitializeComponent();
        }

        private void Админ_ok_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.MidnightBlue;
            panel2.BackColor = Color.MidnightBlue;
            string st;
            DateTime ddn = DateTime.Now;
            string CrLf = "\r\n";
            st = ddn.ToString();
            textBox3.Text = st.Substring(0, 10) + CrLf + st.Substring(11);
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
