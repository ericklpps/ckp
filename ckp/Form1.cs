namespace ckp
{
    public partial class Form1 : Form
    {
        public decimal Resultado { get; set; }

        public decimal Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }
        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtExibir.Text += "0";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtExibir.Text += "9";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtExibir.Text += "8";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtExibir.Text += "7";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtExibir.Text += "6";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtExibir.Text += "5";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtExibir.Text += "4";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtExibir.Text += "3";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtExibir.Text += "2";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtExibir.Text += "1";
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(txtExibir.Text);
            txtExibir.Text = "";
            lbExibir.Text = "+";
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(txtExibir.Text);
            txtExibir.Text = "";
            lbExibir.Text = "-";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(txtExibir.Text);
            txtExibir.Text = "";
            lbExibir.Text = "/";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txtExibir.Text);
            txtExibir.Text = "";
            lbExibir.Text = "*";
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {

                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(txtExibir.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(txtExibir.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txtExibir.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(txtExibir.Text);
                    break;
            }
            txtExibir.Text = Convert.ToString(Resultado);
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtExibir.Text.Contains(","))
                txtExibir.Text += ",";
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtExibir.Text = "";
            lbExibir.Text = "";
        }
    }
}
