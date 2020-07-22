using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double valor1, valor2, result;

        public void Captura()
        {
            valor1 = double.Parse(TBValor1.Text);
            valor2 = double.Parse(TBValor2.Text);
            
         }

        
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMultiplicar_Click(object sender, EventArgs e)
        {
            Captura();
            result = valor1 * valor2;
            TBResult.Text = result.ToString();
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            Captura();
            result = valor1 / valor2;
            TBResult.Text = result.ToString();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btnrestar_Click(object sender, EventArgs e)
        {
            Captura();
            result = valor1 - valor2;
            TBResult.Text = result.ToString();
        }

        

        private void BtnSumar_Click(object sender, EventArgs e)
        {
            Captura();
            result = valor1 + valor2;
            TBResult.Text = result.ToString();
        }
    }
}
