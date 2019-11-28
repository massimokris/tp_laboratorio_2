using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbOperador.SelectedIndex = 0;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtNumero1.Text) || String.IsNullOrEmpty(txtNumero2.Text))
            {
                labelResultado.Text = "Ingrese valores";
            } else
            {
                labelResultado.Text = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text).ToString();
            }
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConvertirABinario_Click(object sender, EventArgs e)
        {
            labelResultado.Text = Numero.DecimalBinario(labelResultado.Text);
            btnConvertirADecimal.Enabled = true;
            btnConvertirABinario.Enabled = false;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {

            Limpiar();
        }

        /// <summary>
        /// Limpiar los textBox y el label del resultado
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            labelResultado.Text = "";
        }

        /// <summary>
        /// invocar al metodo Operar de la clase Calculadora
        /// </summary>
        /// <param name="num1">primer operando</param>
        /// <param name="num2">segundo operando</param>
        /// <param name="operador">operador aritmetico</param>
        /// <returns>resultado de la operación</returns>
        private double Operar(string num1, string num2, string operador)
        {
            return Calculadora.Operar(new Numero(num1), new Numero(num2), operador);
        }

        private void BtnConvertirADecimal_Click(object sender, EventArgs e)
        {
            labelResultado.Text = Numero.BinarioDecimal(labelResultado.Text);

            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = false;
        }
    }
}
