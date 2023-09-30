using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3(string Login, string Password)
        {
            InitializeComponent();
            label1.Text = Login;
            label2.Text = Password;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
