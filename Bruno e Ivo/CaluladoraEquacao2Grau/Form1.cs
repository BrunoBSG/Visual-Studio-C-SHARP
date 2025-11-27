using System.Drawing.Printing;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CaluladoraEquacao2Grau
{
    public partial class Form1 : Form
    {
        TextBox txtseleconado;
        double a, b, c, delta, xI, xII, raiz;
        public Form1()
        {
            InitializeComponent();
        }
        private void DestacarTextBox(TextBox txt)
        {
            //destaca a txt selecionada

            if (txtseleconado != null) { txtseleconado.BackColor = Color.White; }
            if (txt.Text == "A" || txt.Text == "B" || txt.Text == "C")
                txt.Text = "";
            txtseleconado = txt;
            txt.BackColor = Color.Yellow;
        }
        private void MudarCorA(object sender, EventArgs e)
        {
            DestacarTextBox(txtA);
        }

        private void MudarCorB(object sender, EventArgs e)
        {
            DestacarTextBox(txtB);
        }

        private void MudarCorC(object sender, EventArgs e)
        {
            DestacarTextBox(txtC);
        }

        private void BtnEventClick(object sender, EventArgs e)
        {
            if (txtseleconado != null)
            {
                Button botao = (Button)sender;
                txtseleconado.Text += botao.Text;
            }

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //calcula xI XII e delta

            a = double.Parse(txtA.Text);
            b = double.Parse(txtB.Text);
            c = double.Parse(txtC.Text);
            delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                MessageBox.Show("Não existe raiz real (Δ < 0)");
                txtA.Text = "";
                txtB.Text = "";
                txtC.Text = "";
                return;
            }
            else
            {
                raiz = Math.Sqrt(delta);
                xI = (-b + raiz) / (2 * a);
                xII = (-b - raiz) / (2 * a);
            }
            //Mostra os resultados
            txtDelta.Text = delta.ToString("F2");
            txtXI.Text = xI.ToString("F2");
            txtXII.Text = xII.ToString("F2");
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            //Delta
            listBox1.Items.Add("Delta = B² -4 x A x C");
            listBox1.Items.Add($"Delta = ({b})² - 4 x {a} x {c}");
            listBox1.Items.Add($"Delta = {delta}");
            listBox1.Items.Add($"-----------------------------------------------------------");
            //X uma linha
            listBox1.Items.Add($"X = (-B +- Raíz de Delta) /(2 x A)");
            listBox1.Items.Add($"X' = ({b} + {raiz}) / (2 x {a}) ");
            listBox1.Items.Add($"X' = ({b + raiz}) / {2 * a} ");
            listBox1.Items.Add($"X' = {xI}");
            //X duas linhas
            listBox1.Items.Add($"-----------------------------------------------------------");
            listBox1.Items.Add($"x'' = ({b} - {raiz}) / (2 x {a}) ");
            listBox1.Items.Add($"({b - raiz}) / {2 * a}");
            listBox1.Items.Add($"X' = {xII}");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //limpar
            a = 0; b = 0; c = 0;
            delta = 0;
            xI = 0;
            xII = 0;
            raiz = 0;
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            listBox1.Items.Clear();
            txtXI.Text = "";
            txtXII.Text = "";
            txtDelta.Text = "";
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            if (txtseleconado != null)
            {
                txtseleconado.Text = "";
            }
        }

        private void btnTraco_Click(object sender, EventArgs e)
        {
            if (txtseleconado != null)
            {
                if (txtseleconado.Text.Contains("-"))
                {
                    txtseleconado.Text = txtseleconado.Text.Replace("-", "+");
                }
                else
                {
                    txtseleconado.Text = "-" + txtseleconado.Text;
                }
            }
        }

        private void txtXII_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDelta_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtXI_TextChanged(object sender, EventArgs e)
        {
        }

        private void KeyPresstxt(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}