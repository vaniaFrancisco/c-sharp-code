using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Ex.dados_alunos
{
    public partial class Form1 : Form
    {
        public List<Aluno> Alunos { get; set; }
        private readonly string caminhoFicheiro = $"c:\\Users\\Vania\\Desktop\\Algoritmos\\Alunos.json";

        public Form1()
        {
            this.Alunos = this.GetAlunos();

            InitializeComponent();

            CalcularMedia();
            CalcularAlunoMenorNota();
            CalcularAlunoMaiorNota();
        }

        private void CalcularMedia()
        {
            double sumMedia = 0;
            double media = 0;
            for (int i = 0; i < this.Alunos.Count; i++)
            {
                sumMedia = sumMedia + this.Alunos[i].notaFinal;
            }

            media = Math.Round(sumMedia / this.Alunos.Count, 2);
            this.label_media_nota.Text = media.ToString();

        }

        private void CalcularAlunoMaiorNota()
        {

            double maiorNota = 0;
            int numeroAluno = 0;
            for (int i = 0; i < this.Alunos.Count; i++)
            {
                if (this.Alunos[i].notaFinal > maiorNota)
                {
                    maiorNota = this.Alunos[i].notaFinal;
                    numeroAluno = this.Alunos[i].numero;
                }
            }

            var alunoEncontrado = this.Alunos.Find(aluno => aluno.numero == numeroAluno);


            this.label_maior_nota.Text = alunoEncontrado.notaFinal.ToString();

        }

        private void CalcularAlunoMenorNota()
        {
            double menorNota = 0;
            int numeroAluno = 0;
            for (int i = 0; i < this.Alunos.Count; i++)
            {
                if (i == 0)
                {
                    menorNota = this.Alunos[i].notaFinal;
                    numeroAluno = this.Alunos[i].numero;
                }
                else if (this.Alunos[i].notaFinal < menorNota)
                {
                    menorNota = this.Alunos[i].notaFinal;
                    numeroAluno = this.Alunos[i].numero;
                }
            }

            var alunoEncontrado = this.Alunos.Find(aluno => aluno.numero == numeroAluno);


            this.label_maior_nota.Text = alunoEncontrado.notaFinal.ToString();
        }

        private List<Aluno> GetAlunos()
        {
            // Colocar o ficheiro em C:\Users\Vania\Desktop\Algoritmos\Ex.dados_alunos\Ex.dados_alunos\bin\Debug
            using (StreamReader r = new StreamReader("Alunos.json"))
            {
                string json = r.ReadToEnd();
                List<Aluno> alunos = JsonConvert.DeserializeObject<List<Aluno>>(json);
                this.Alunos = alunos;
            }

            var list = new List<Aluno>();
            for (int i = 0; i < this.Alunos.Count; i++)
            {
                list.Add(new Aluno()
                {
                    numero = this.Alunos[i].numero,
                    nome = this.Alunos[i].nome,
                    notaFinal = this.Alunos[i].notaFinal
                });
            }

            return list;
        }

        //VAI VALIDAR A ENTRADA DE TEXTO NO CAMPO NOME DO ALUNO
        private void textBox_nomeAluno_TextChanged(object sender, EventArgs e)
        {
            foreach (char nome in textBox_nomeAluno.Text)
            {
                if (char.IsLetter(nome) == false && nome != ' ')
                {
                    //VAI APRESENTAR UMA MENSAGEM DE ERRO CASO SE INSIRA UM NUMERO
                    MessageBox.Show("Insira apenas letras e espaços.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_nomeAluno.Text = textBox_nomeAluno.Text.Remove(textBox_nomeAluno.Text.Length - 1, 1);
                    textBox_nomeAluno.SelectionStart = textBox_nomeAluno.TextLength;
                    break;
                }
            }
        }

        private void textBox_numeroAluno_TextChanged(object sender, EventArgs e)
        {
            foreach (char nome in textBox_numeroAluno.Text)
            {
                if (char.IsDigit(nome) == false && nome != ' ')
                {
                    //VAI APRESENTAR UMA MENSAGEM DE ERRO CASO SE INSIRA UMA LETRA NO CAMPO NUMERO DE ALUNO
                    MessageBox.Show("Insira apenas numeros.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_numeroAluno.ResetText(); //APAGA O TEXTO NO CAMPO NUMERO DE ALUNO
                    break;

                }
            }
        }

        private void textBox_notaAluno_TextChanged(object sender, EventArgs e)
        {
            foreach (char nota in textBox_notaAluno.Text)
            {
                if (char.IsNumber(nota) == false && nota != ' ')
                {
                    //VAI APRESENTAR UMA MENSAGEM DE ERRO CASO SE INSIRA LETRAS NO CAMPO NOTA DO ALUNO
                    MessageBox.Show("Insira apenas numeros.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_notaAluno.ResetText(); //APAGA O TEXTO NO CAMPO NUMERO DE ALUNO
                    break;

                }
            }
        }

        private void botao_inserir_Click(object sender, EventArgs e)
        {
            if (
                !String.IsNullOrEmpty(this.textBox_nomeAluno.Text)
                && !String.IsNullOrEmpty(this.textBox_numeroAluno.Text)
                && !String.IsNullOrEmpty(this.textBox_notaAluno.Text)
                )
            {
                this.info.Text = "";

                this.Alunos.Add(new Aluno()
                {
                    numero = int.Parse(this.textBox_numeroAluno.Text),
                    nome = this.textBox_nomeAluno.Text,
                    notaFinal = double.Parse(this.textBox_notaAluno.Text)
                });

                var jsonToWrite = JsonConvert.SerializeObject(this.Alunos, Formatting.Indented);
                using (var writer = new StreamWriter("Alunos.json"))
                {
                    writer.Write(jsonToWrite);
                }

                this.textBox_nomeAluno.Text = "";
                this.textBox_numeroAluno.Text = "";
                this.textBox_notaAluno.Text = "";

            } else
            {
                this.info.Text = "É necessário preencher todos os campos.";
            }
        }

        private void button_pesquisar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.textBox_pesquisa.Text))
            {
                this.info.Text = "É necessário preencher o campo de pesquisa.";
            } else
            {

                var nome = this.textBox_pesquisa.Text;
                var alunoEncontrado = this.Alunos.Find(aluno => aluno.nome == nome);

                if (!(alunoEncontrado is null))
                {
                    this.textBox_numeroAluno.Text = alunoEncontrado.numero.ToString();
                    this.textBox_nomeAluno.Text = alunoEncontrado.nome;
                    this.textBox_notaAluno.Text = alunoEncontrado.notaFinal.ToString();
                }

                this.info.Text = "";
            }

        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox_nomeAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //VERIFICA SE O CAMPO ESTA VAZIO 
                if (textBox_nomeAluno.Text.Length == 0)
                {
                    //CASO ESTEJA VAZIO APRESENTARA A MENSAGEM DE AVISO
                    MessageBox.Show("Preencha o campo por favor. ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    textBox_nomeAluno.Focus();//COLOCARA O CURSOR NO CAMPO NºALUNO AO DARMOS ENTER
                }
                e.Handled = true; //RETIRA O SOM DE ERRO
            }
        }

        private void textBox_numeroAluno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //VERIFICA SE O CAMPO ESTA VAZIO 
                if (textBox_nomeAluno.Text.Length == 0)
                {
                    //CASO ESTEJA VAZIO APRESENTARA A MENSAGEM DE AVISO
                    MessageBox.Show("Preencha o campo por favor. ", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    textBox_numeroAluno.Focus();//COLOCARA O CURSOR NO CAMPO NºALUNO AO DARMOS ENTER
                }
                e.Handled = true; //RETIRA O SOM DE ERRO

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Alunos = GetAlunos();
            var alunos = this.Alunos;

            CalcularMedia();
            CalcularAlunoMenorNota();
            CalcularAlunoMaiorNota();

            dataGridView1.DataSource = alunos;
        }

        

        public class Aluno
        {
            public int numero { get; set; }
            public string nome { get; set; }
            public double notaFinal { get; set; }
        }

    } 
}
