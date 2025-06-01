using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuentaBancaria
{
    public partial class Form1 : Form
    {
        private CuentaBancaria cuenta;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string titular = textBox1.Text;
            double saldoInicial = double.Parse(textBox2.Text);
            cuenta = new CuentaBancaria(titular, saldoInicial);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cuenta.Depositar(double.Parse(textBox3.Text)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cuenta.MostrarInformacion());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cuenta.Retirar(double.Parse(textBox4.Text)));
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double saldoActual = cuenta.ConsultarSaldo();
            MessageBox.Show($"Saldo final: ${saldoActual}");
        }
    }
}
