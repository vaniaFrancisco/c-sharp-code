using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_maquina.vendas
{
    public partial class Form1 : Form
    {

        bool emProcesso = false; // 1.Controlar o botão "processar pedido", para que ele não processe mais de uma vez por transição
        public Form1() // 
        {
            // 2. Inicia o componente
            InitializeComponent();

            // 3. colocar as labels com valores iniciais
            this.label_pagar.Text = "0";
            this.label_troco.Text = "0";

            this.label_dev_cinco.Text = "0";
            this.label_dev_dez.Text = "0";
            this.label_dev_vinte.Text = "0";
            this.label_dev_cinquenta.Text = "0";
            this.label_dev_um.Text = "0";
            this.label_dev_dois.Text = "0";
            this.emProcesso = false;
            this.label_response.Text = "Faça seu pedido!";
        }       

        private void botao_processar_Click(object sender, EventArgs e) // 4. Método que é chamado ao clicar no botão: Processar Pedido
        {
            if (this.emProcesso == false) // 5. Verifica o valor da variável emProcesso
            {
                this.emProcesso = true;
                double total = Double.Parse(this.label_pagar.Text); // 6. pega o valor que está na label pagar

                double cincoCentimos = decimal.ToDouble(this.numericUpDown1.Value);// 7. pega o valor decimal e converte para double
                double dezCentimos = decimal.ToDouble(this.numericUpDown2.Value);
                double vinteCentimos = decimal.ToDouble(this.numericUpDown3.Value);
                double ciquentaCentimos = decimal.ToDouble(this.numericUpDown4.Value);
                double umEuro = decimal.ToDouble(this.numericUpDown5.Value);
                double doisEuros = decimal.ToDouble(this.numericUpDown6.Value);

                double valorMoedas = (cincoCentimos * 0.05 + dezCentimos * 0.1 + vinteCentimos * 0.2 + ciquentaCentimos * 0.5 + umEuro * 1 + doisEuros * 2);
                // 8. Multiplica cada quantidade pelo valor(peso) e depois soma-os

                if (valorMoedas > total) // 9. Verifico se o valor das moedas é suficiente para processar o pedido
                {
                    // 10 .Mostra uma mensagem para o ultilizador
                    this.label_response.Text = "Apanhe o troco!";
                    // 11. Mostra o valor de troco
                    this.label_troco.Text = (valorMoedas - total).ToString();
                    // 12. Chama o método para calcular as moedas devolvidas
                    this.calcularMoedas();
                }
                else // 13. Caso contrário mostra-se uma mesagem ao ultilizador e coloca o processo em false
                {
                    this.label_response.Text = "Insira mais moedas!";
                    this.emProcesso = false;
                }
            }            
           
        }

        private void calcularMoedas()
        {
            // 14. obtem o valor que está na label troco, converte para double e coloca na variável troco
            double troco = double.Parse(this.label_troco.Text);

            // 15. faz a divisão, obtem o valor da divisão e o resto da divisão
            double divisao = troco / 2;            
            double resto = troco % 2;
            if (divisao > 0 ) // 16. Se a o valor da divisão for maior que zero quer dizer que aquela moeda específica pode ser devolvida
            {
                // 17. Exemplo:Se o valor do troco for 5, devolvemos 2 moedas de 2 euros
                // 18. Pega o valor da divisão e incrementa na label dev.dois referente a moedas devolvidas ( 2 euros)
                this.label_dev_dois.Text = (int.Parse(this.label_dev_dois.Text) + (int)divisao).ToString();
            }
            double trocoAux = resto;
            divisao = trocoAux / 1;
            resto = trocoAux % 1;
            if (divisao > 0)
            {
                this.label_dev_um.Text = (int.Parse(this.label_dev_um.Text) + (int)divisao).ToString();
            }
            trocoAux = resto;
            divisao = trocoAux / 0.5;
            resto = trocoAux % 0.5;
            if (divisao > 0)
            {
                this.label_dev_cinquenta.Text = (int.Parse(this.label_dev_cinquenta.Text) + (int)divisao).ToString();
            }
            trocoAux = resto;
            divisao = trocoAux / 0.2;
            resto = trocoAux % 0.2;
            if (divisao > 0)
            {
                this.label_dev_vinte.Text = (int.Parse(this.label_dev_vinte.Text) + (int)divisao).ToString();
            }
            trocoAux = resto;
            divisao = trocoAux / 0.1;
            resto = trocoAux % 0.1;
            if (divisao > 0)
            {
                this.label_dev_dez.Text = (int.Parse(this.label_dev_dez.Text) + (int)divisao).ToString();
            }
            trocoAux = resto;
            divisao = Math.Round((trocoAux / 0.05), 2);
            resto = Math.Round((trocoAux % 0.05), 2);
            if (divisao > 0)
            {
                this.label_dev_cinco.Text = (int.Parse(this.label_dev_cinco.Text) + (int)divisao).ToString();
            }
            trocoAux = resto;
        }

        // 19. Serve para adicionar quando for checked ou retirar quando for unchecked
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.changeLabelTotalPay(0.2, checkBox_cha.Checked);
        }

        private void checkBox_cafe_CheckedChanged(object sender, EventArgs e)
        {
            this.changeLabelTotalPay(0.25, checkBox_cafe.Checked);
        }       

        private void checkBox_cappu_CheckedChanged(object sender, EventArgs e)
        {
            this.changeLabelTotalPay(0.3, checkBox_cappu.Checked);

        }

        private void checkBox_chocolate_CheckedChanged(object sender, EventArgs e)
        {
            this.changeLabelTotalPay(0.35, checkBox_chocolate.Checked);
        }

        // 19. Serve para adicionar quando for checked ou retirar quando for unchecked
        // 20. Função generica
        private void changeLabelTotalPay(double charValue, bool sum)
        {
            // 21. Pega o texto que está na label_pagar, converte para double e ponhe na variéval totalPagar
            double totalPagar = Double.Parse(this.label_pagar.Text);

           
            if (sum == true) // 22. Verifica se sum é true ou false
            {
                this.label_pagar.Text = (totalPagar + charValue).ToString();
            }
            else   // 23. se for true, adiciona, caso contrário remove
            {
                this.label_pagar.Text = (totalPagar - charValue).ToString();
            }

        }

        // 24. o botão "Novo pedido" quando é clicado chama este método, e inicializa todos as labels
        private void botao_sair_Click(object sender, EventArgs e)
        {            

            this.label_dev_cinco.Text = "0";
            this.label_dev_dez.Text = "0";
            this.label_dev_vinte.Text = "0";
            this.label_dev_cinquenta.Text = "0";
            this.label_dev_um.Text = "0";
            this.label_dev_dois.Text = "0";

            this.numericUpDown1.Value = 0;
            this.numericUpDown2.Value = 0;
            this.numericUpDown3.Value = 0;
            this.numericUpDown4.Value = 0;
            this.numericUpDown5.Value = 0;
            this.numericUpDown6.Value = 0;

            this.checkBox_cha.Checked = false;
            this.checkBox_cafe.Checked = false;
            this.checkBox_cappu.Checked = false;
            this.checkBox_chocolate.Checked = false;

            this.label_pagar.Text = "0";
            this.label_troco.Text = "0";

            this.emProcesso = false;

            this.label_response.Text = "Faça seu pedido!";           
        }

    }
}
