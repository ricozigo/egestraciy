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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получаем введенные значения из текстовых полей
            string login = textBox1.Text;
            string password1 = textBox2.Text;
            string password2 = textBox3.Text;

            // Проверяем, что пароли совпадают
            if (password1 != password2)
            {
                MessageBox.Show("Пароли не совпадают. Пожалуйста, повторите ввод пароля.");
                return;
            }

            // Создаем XML-документ и добавляем в него информацию
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("gg.xml"); // Загружаем существующий XML-файл или создаем новый

            // Создаем элементы XML для логина и пароля
            XmlElement userElement = xmlDoc.CreateElement("User");
            XmlElement loginElement = xmlDoc.CreateElement("Username");
            loginElement.InnerText = login;
            XmlElement passwordElement = xmlDoc.CreateElement("Password");
            passwordElement.InnerText = password1;

            // Добавляем элементы в XML-документ
            userElement.AppendChild(loginElement);
            userElement.AppendChild(passwordElement);
            xmlDoc.DocumentElement.AppendChild(userElement);

            // Сохраняем XML-документ
            xmlDoc.Save("gg.xml");

            // Очищаем текстовые поля
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            MessageBox.Show("Регистрация завершена успешно.");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
