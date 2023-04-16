using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaCalcGrafica
{
    public partial class FrmCalc : Form
    {
        public FrmCalc()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblOper_Click(object sender, EventArgs e)
        {

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCalc_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja mesmo sair?","Atenção",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;

            }
        }

        private void RdbSomar_CheckedChanged(object sender, EventArgs e)
        {
            lblOper.Text = "+";

        }

        private void RdbSubtrair_CheckedChanged(object sender, EventArgs e)
        {
            lblOper.Text = "-";
        }

        private void RdbMulti_CheckedChanged(object sender, EventArgs e)
        {
            lblOper.Text = "×";
        }

        private void RdbDividir_CheckedChanged(object sender, EventArgs e)
        {
            lblOper.Text = "/";
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Clear();
            rdbSomar.Checked = true;
            txtNum1.Focus();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            Contas contas = new Contas();
            string resposta = "";
            try
            {
                contas.Num1 = Convert.ToDouble(txtNum1.Text);
                contas.Num2 = Double.Parse(txtNum2.Text);
                if (rdbSomar.Checked)
                {
                    resposta = contas.Somar();
                }
                else if (rdbSubtrair.Checked)
                {
                    resposta = contas.Subtrair();
                }
                else if (rdbMulti.Checked)
                {
                    resposta = contas.Multiplicacao();
                }
                else
                {
                    resposta = contas.Divisao();
                }

                MessageBox.Show(resposta, "Resultado:", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Atenção", MessageBoxButtons.OK,  MessageBoxIcon.Error);
              
            }
          
        }
    }
}
