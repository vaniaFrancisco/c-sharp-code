
namespace Ex.dados_alunos
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_1 = new System.Windows.Forms.Label();
            this.botao_inserir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_nomeAluno = new System.Windows.Forms.TextBox();
            this.textBox_numeroAluno = new System.Windows.Forms.TextBox();
            this.textBox_notaAluno = new System.Windows.Forms.TextBox();
            this.button_Remover = new System.Windows.Forms.Button();
            this.button_pesquisar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_pesquisa = new System.Windows.Forms.TextBox();
            this.button_sair = new System.Windows.Forms.Button();
            this.label_media_nota = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_listar = new System.Windows.Forms.Button();
            this.info = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_maior_nota = new System.Windows.Forms.Label();
            this.label_menor_nota = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Font = new System.Drawing.Font("Arial Black", 12.25F, System.Drawing.FontStyle.Bold);
            this.label_1.Location = new System.Drawing.Point(22, 25);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(147, 24);
            this.label_1.TabIndex = 0;
            this.label_1.Text = "Nome do aluno";
            // 
            // botao_inserir
            // 
            this.botao_inserir.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_inserir.Location = new System.Drawing.Point(226, 137);
            this.botao_inserir.Name = "botao_inserir";
            this.botao_inserir.Size = new System.Drawing.Size(88, 34);
            this.botao_inserir.TabIndex = 1;
            this.botao_inserir.Text = "Inserir/Alterar";
            this.botao_inserir.UseVisualStyleBackColor = true;
            this.botao_inserir.Click += new System.EventHandler(this.botao_inserir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero do aluno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nota do aluno";
            // 
            // textBox_nomeAluno
            // 
            this.textBox_nomeAluno.Location = new System.Drawing.Point(175, 29);
            this.textBox_nomeAluno.Name = "textBox_nomeAluno";
            this.textBox_nomeAluno.Size = new System.Drawing.Size(313, 20);
            this.textBox_nomeAluno.TabIndex = 4;
            this.textBox_nomeAluno.TextChanged += new System.EventHandler(this.textBox_nomeAluno_TextChanged);
            this.textBox_nomeAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_nomeAluno_KeyPress);
            // 
            // textBox_numeroAluno
            // 
            this.textBox_numeroAluno.Location = new System.Drawing.Point(188, 68);
            this.textBox_numeroAluno.Name = "textBox_numeroAluno";
            this.textBox_numeroAluno.Size = new System.Drawing.Size(300, 20);
            this.textBox_numeroAluno.TabIndex = 5;
            this.textBox_numeroAluno.TextChanged += new System.EventHandler(this.textBox_numeroAluno_TextChanged);
            this.textBox_numeroAluno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_numeroAluno_KeyPress);
            // 
            // textBox_notaAluno
            // 
            this.textBox_notaAluno.Location = new System.Drawing.Point(161, 110);
            this.textBox_notaAluno.Name = "textBox_notaAluno";
            this.textBox_notaAluno.Size = new System.Drawing.Size(327, 20);
            this.textBox_notaAluno.TabIndex = 6;
            this.textBox_notaAluno.TextChanged += new System.EventHandler(this.textBox_notaAluno_TextChanged);
            // 
            // button_Remover
            // 
            this.button_Remover.Location = new System.Drawing.Point(320, 136);
            this.button_Remover.Name = "button_Remover";
            this.button_Remover.Size = new System.Drawing.Size(88, 35);
            this.button_Remover.TabIndex = 7;
            this.button_Remover.Text = "Remover";
            this.button_Remover.UseVisualStyleBackColor = true;
            // 
            // button_pesquisar
            // 
            this.button_pesquisar.Location = new System.Drawing.Point(301, 236);
            this.button_pesquisar.Name = "button_pesquisar";
            this.button_pesquisar.Size = new System.Drawing.Size(88, 31);
            this.button_pesquisar.TabIndex = 9;
            this.button_pesquisar.Text = "PESQUISAR";
            this.button_pesquisar.UseVisualStyleBackColor = true;
            this.button_pesquisar.Click += new System.EventHandler(this.button_pesquisar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Pesquisar aluno";
            // 
            // textBox_pesquisa
            // 
            this.textBox_pesquisa.Location = new System.Drawing.Point(188, 210);
            this.textBox_pesquisa.Name = "textBox_pesquisa";
            this.textBox_pesquisa.Size = new System.Drawing.Size(327, 20);
            this.textBox_pesquisa.TabIndex = 12;
            // 
            // button_sair
            // 
            this.button_sair.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sair.Location = new System.Drawing.Point(20, 392);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(75, 36);
            this.button_sair.TabIndex = 13;
            this.button_sair.Text = "SAIR";
            this.button_sair.UseVisualStyleBackColor = true;
            this.button_sair.Click += new System.EventHandler(this.button_sair_Click);
            // 
            // label_media_nota
            // 
            this.label_media_nota.AutoSize = true;
            this.label_media_nota.Location = new System.Drawing.Point(143, 300);
            this.label_media_nota.Name = "label_media_nota";
            this.label_media_nota.Size = new System.Drawing.Size(90, 13);
            this.label_media_nota.TabIndex = 14;
            this.label_media_nota.Text = "label_media_nota";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(537, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(384, 279);
            this.dataGridView1.TabIndex = 17;
            // 
            // button_listar
            // 
            this.button_listar.Location = new System.Drawing.Point(704, 326);
            this.button_listar.Name = "button_listar";
            this.button_listar.Size = new System.Drawing.Size(88, 40);
            this.button_listar.TabIndex = 18;
            this.button_listar.Text = "Listar";
            this.button_listar.UseVisualStyleBackColor = true;
            this.button_listar.Click += new System.EventHandler(this.button1_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(298, 183);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(35, 13);
            this.info.TabIndex = 19;
            this.info.Text = "label6";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Média Turma";
            // 
            // label_maior_nota
            // 
            this.label_maior_nota.AutoSize = true;
            this.label_maior_nota.Location = new System.Drawing.Point(146, 272);
            this.label_maior_nota.Name = "label_maior_nota";
            this.label_maior_nota.Size = new System.Drawing.Size(87, 13);
            this.label_maior_nota.TabIndex = 21;
            this.label_maior_nota.Text = "label_maior_nota";
            // 
            // label_menor_nota
            // 
            this.label_menor_nota.AutoSize = true;
            this.label_menor_nota.Location = new System.Drawing.Point(142, 326);
            this.label_menor_nota.Name = "label_menor_nota";
            this.label_menor_nota.Size = new System.Drawing.Size(91, 13);
            this.label_menor_nota.TabIndex = 23;
            this.label_menor_nota.Text = "label_menor_nota";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 23);
            this.label9.TabIndex = 25;
            this.label9.Text = "Melhor Aluno";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 26;
            this.label10.Text = "Pior Aluno";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_menor_nota);
            this.Controls.Add(this.label_maior_nota);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.info);
            this.Controls.Add(this.button_listar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_media_nota);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.textBox_pesquisa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_pesquisar);
            this.Controls.Add(this.button_Remover);
            this.Controls.Add(this.textBox_notaAluno);
            this.Controls.Add(this.textBox_numeroAluno);
            this.Controls.Add(this.textBox_nomeAluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botao_inserir);
            this.Controls.Add(this.label_1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Button botao_inserir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_nomeAluno;
        private System.Windows.Forms.TextBox textBox_numeroAluno;
        private System.Windows.Forms.TextBox textBox_notaAluno;
        private System.Windows.Forms.Button button_Remover;
        private System.Windows.Forms.Button button_pesquisar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_pesquisa;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.Label label_media_nota;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_listar;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_maior_nota;
        private System.Windows.Forms.Label label_menor_nota;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

