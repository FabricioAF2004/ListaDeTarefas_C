namespace ListaDeTarefas
{
    public partial class ListaDeTarefas : Form
    {
        public ListaDeTarefas()
        {
            InitializeComponent();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtLstTarefa_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLst_TextChanged(object sender, EventArgs e)
        {

        }

        private void LstDescricao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTarefa.Text) && !string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                string tarefa = txtTarefa.Text;
                string descricao = txtDescricao.Text;

                listBoxTarefas.Items.Add(tarefa);
                listBoxDescricao.Items.Add(descricao);

                txtTarefa.Clear();
                txtDescricao.Clear();
            }
            else
            {
                MessageBox.Show("Digite uma tarefa e uma descrição para adicionar.");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listBoxTarefas.SelectedIndex != -1)
            {
                int index = listBoxTarefas.SelectedIndex;
                listBoxTarefas.Items.RemoveAt(index);
                listBoxDescricao.Items.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Selecione uma tarefa para remover.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (listBoxTarefas.SelectedIndex != -1)
            {
                int index = listBoxTarefas.SelectedIndex;
                txtTarefa.Text = listBoxTarefas.SelectedItem.ToString();
                txtDescricao.Text = listBoxDescricao.Items[index].ToString();

                listBoxTarefas.Items.RemoveAt(index);
                listBoxDescricao.Items.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Selecione uma tarefa para editar.");
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTarefa.Clear();
            txtDescricao.Clear();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            if (listBoxTarefas.SelectedIndex != -1)
            {
                int index = listBoxTarefas.SelectedIndex;
                string tarefaConcluida = listBoxTarefas.SelectedItem.ToString() + " (Concluída)";
                listBoxTarefas.Items[index] = tarefaConcluida;
            }
            else
            {
                MessageBox.Show("Selecione uma tarefa para marcar como concluída.");
            }
        }
    }
}
