using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab345
{
    public partial class FormAddress : Form
    {
        FormReturnString Saddress;

        public FormAddress(FormReturnString Saddress)
        {
            this.Saddress = Saddress;
            Address address = new Address(Saddress.Text);

            InitializeComponent();
            textBox1.Text = address.Country;
            textBox2.Text = address.Area;
            textBox3.Text = address.Region;
            textBox4.Text = address.City;
            textBox5.Text = address.Street;
            textBox6.Text = address.House;
            textBox7.Text = address.Apartment;
            textBox8.Text = address.Mail;
        }

        private void buttonClose_Click(object sender, EventArgs e) => Close();

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Address address = new Address();
            address.Country = textBox1.Text;
            address.Area = textBox2.Text;
            address.Region = textBox3.Text;
            address.City = textBox4.Text;
            address.Street = textBox5.Text;
            address.House = textBox6.Text;
            address.Apartment = textBox7.Text;
            address.Mail = textBox8.Text;
            Saddress.Text = address.ToString();
            Close();
        }
    }
}
