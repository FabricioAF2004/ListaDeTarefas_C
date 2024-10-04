namespace ListaDeTarefas
{
    partial class ListaDeTarefas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxTarefas = new ListBox();
            label1 = new Label();
            txtTarefa = new TextBox();
            txtDescricao = new TextBox();
            label2 = new Label();
            btnAdicionar = new Button();
            btnRemover = new Button();
            btnEditar = new Button();
            btnLimpar = new Button();
            btnConcluir = new Button();
            listBoxDescricao = new ListBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // listBoxTarefas
            // 
            listBoxTarefas.FormattingEnabled = true;
            listBoxTarefas.ItemHeight = 25;
            listBoxTarefas.Location = new Point(12, 16);
            listBoxTarefas.Name = "listBoxTarefas";
            listBoxTarefas.Size = new Size(405, 654);
            listBoxTarefas.TabIndex = 0;
            listBoxTarefas.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(423, 16);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 1;
            label1.Text = "Listar Tarefa";
            // 
            // txtTarefa
            // 
            txtTarefa.Location = new Point(423, 44);
            txtTarefa.Name = "txtTarefa";
            txtTarefa.Size = new Size(365, 31);
            txtTarefa.TabIndex = 2;
            txtTarefa.TextChanged += txtLstTarefa_TextChanged;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(423, 106);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(365, 31);
            txtDescricao.TabIndex = 4;
            txtDescricao.TextChanged += txtLst_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(423, 78);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 3;
            label2.Text = "Listar Descrição";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(423, 143);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(112, 34);
            btnAdicionar.TabIndex = 5;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(676, 143);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(112, 34);
            btnRemover.TabIndex = 6;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(423, 183);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(112, 34);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(676, 183);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(112, 34);
            btnLimpar.TabIndex = 8;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnConcluir
            // 
            btnConcluir.Location = new Point(423, 223);
            btnConcluir.Name = "btnConcluir";
            btnConcluir.Size = new Size(365, 34);
            btnConcluir.TabIndex = 9;
            btnConcluir.Text = "Concluir";
            btnConcluir.UseVisualStyleBackColor = true;
            btnConcluir.Click += btnConcluir_Click;
            // 
            // listBoxDescricao
            // 
            listBoxDescricao.FormattingEnabled = true;
            listBoxDescricao.ItemHeight = 25;
            listBoxDescricao.Location = new Point(423, 291);
            listBoxDescricao.Name = "listBoxDescricao";
            listBoxDescricao.Size = new Size(365, 379);
            listBoxDescricao.TabIndex = 10;
            listBoxDescricao.SelectedIndexChanged += LstDescricao_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(563, 260);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 11;
            label3.Text = "Descrição";
            // 
            // ListaDeTarefas
            // 
            AcceptButton = btnAdicionar;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 698);
            Controls.Add(label3);
            Controls.Add(listBoxDescricao);
            Controls.Add(btnConcluir);
            Controls.Add(btnLimpar);
            Controls.Add(btnEditar);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(txtDescricao);
            Controls.Add(label2);
            Controls.Add(txtTarefa);
            Controls.Add(label1);
            Controls.Add(listBoxTarefas);
            Name = "ListaDeTarefas";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxTarefas;
        private Label label1;
        private TextBox txtTarefa;
        private TextBox txtDescricao;
        private Label label2;
        private Button btnAdicionar;
        private Button btnRemover;
        private Button btnEditar;
        private Button btnLimpar;
        private Button btnConcluir;
        private ListBox listBoxDescricao;
        private Label label3;
    }
}
