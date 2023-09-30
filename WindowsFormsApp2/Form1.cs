using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        XmlDocument xDoc = new XmlDocument();
        XmlElement xRoot;       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                xDoc.Load("gg.xml");
                xRoot = xDoc.DocumentElement;
            }
            string enteredUsername = textBox1.Text;
            string enteredPassword = textBox2.Text;

            XmlNodeList users = xDoc.SelectNodes("/Users/User");

            foreach (XmlNode user in users)
            {
                string username = user.SelectSingleNode("Username").InnerText;
                string password = user.SelectSingleNode("Password").InnerText;

                if (enteredUsername == username && enteredPassword == password)
                {
                    Form3 tmp = new Form3(username, password);
                    tmp.Show();
                    return;
                }
            }

            MessageBox.Show("Неверное имя пользователя или пароль.");

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 tmp = new Form2();
            tmp.Show();
        }
    }
}
