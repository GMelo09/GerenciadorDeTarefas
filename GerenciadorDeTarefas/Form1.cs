using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeTarefas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Adicionar as colunas ao dataGridView
            dgvTarefas.Columns.Add("colTarefa", "Tarefa");
            dgvTarefas.Columns.Add("colResponsavel", "Responsavel");
            dgvTarefas.Columns.Add("colSetor", "Setor");
            dgvTarefas.Columns.Add("colData", "Data Limite");
            //Popular o Combobox:
            string[] setores = { "Administrativo", "Financeiro", "Suporte", "Atendimeto", "Desenvolvimeto" };
            //adicionar os setores ao cmb
            cmbSetor.Items.AddRange(setores);
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //Verificar se os campos estão vazios
            if (string.IsNullOrEmpty(txbNomeTarefa.Text) && txbNomeTarefa.Text.Length < 3)
            {
                MessageBox.Show("O nome da tarefa não pode ficar em branco", "ERRO", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txbResponsavel.Text) && txbResponsavel.Text.Length < 3)
            {
                MessageBox.Show("O nome do Responsavel não pode ficar em branco", "ERRO", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (cmbSetor.SelectedIndex == -1)
            {
                MessageBox.Show("O Setor não pode ficar em branco", "ERRO", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);

            }
            else if (dtpDataLmt.Value < DateTime.Today)
            {
                MessageBox.Show("Não e possivel adiconar taferas em datas passadas", "ERRO", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
            else
            {
                string tarefa = txbNomeTarefa.Text;
                string resp = txbResponsavel.Text;
                string setor = cmbSetor.Text;
                DateTime limite = dtpDataLmt.Value;

                //adicionar a linha:
                dgvTarefas.Rows.Add(tarefa, resp, setor, limite);

                //Limpar os Campos:
                txbNomeTarefa.Clear();
                txbResponsavel.Clear();
                cmbSetor.SelectedIndex = -1;
                dtpDataLmt.Value = DateTime.Today; // Retornar a data limite para hoje

            }

        }

        private void pibApagar_Click(object sender, EventArgs e)
        {
            //Verificar se existe alguma célula selecionada:
            if (dgvTarefas.SelectedCells.Count > 0)
            {



                //Obter a linha selecionada:
                int linhasSelecionada = dgvTarefas.SelectedCells[0].RowIndex;

                //Perguntar se o usuario realmente quer remover:
                DialogResult resultado = MessageBox.Show("Tem certeza que Realmente deseja remover? ", "Atenção",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    //Apagar:
                    dgvTarefas.Rows.RemoveAt(linhasSelecionada);
                }



            }
            else
            {
                MessageBox.Show("Selecione Uma linha para remover!!",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvTarefas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pibApagar_Click(pibApagar, EventArgs.Empty);
        }
    }
}
