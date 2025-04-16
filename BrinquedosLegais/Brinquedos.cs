using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrinquedosLegais
{
    public partial class Brinquedos : Form
    {
        public Brinquedos()
        {
            InitializeComponent();
        }

        private void btnCpnjValidating(object sender, CancelEventArgs e)
        {
            string numero = "";
            //validacao se foi preenchido
            if (string.IsNullOrEmpty(mtxtCnpj.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(mtxtCnpj, "Preencha o CNPJ!");
            }
            //validacao 14 digitos
            else if (numero.Length != 14)
            {
                e.Cancel = false;
                errorProvider1.SetError(mtxtCnpj, "O CNPJ deve conter 14 números!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(mtxtCnpj, "");
            }
        }

        private void btnNomeValidating(object sender, CancelEventArgs e)
        {
            //validacao se foi preenchido
            if (string.IsNullOrEmpty(mtxtNome.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(mtxtNome, "Preencha o Nome!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(mtxtNome, "");
            }
        }

        private void btnIdadeMinimaValidating(object sender, CancelEventArgs e)
        {
            //validacao se foi preenchido
            if (string.IsNullOrEmpty(mtxtIdadeMinima.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(mtxtIdadeMinima, "Preencha a Idade Mínima!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(mtxtIdadeMinima, "");
            }
        }

        private void btnCategoriaValidating(object sender, CancelEventArgs e)
        {
            //validacao se foi preenchido
            if (string.IsNullOrEmpty(mtxtCategoria.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(mtxtCategoria, "Preencha a Categoria!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(mtxtCategoria, "");
            }
        }

        private void btnDescricaovalidating(object sender, CancelEventArgs e)
        {
            //validacao se foi preenchido
            if (string.IsNullOrEmpty(mtxtDescricao.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(mtxtDescricao, "Preencha a Descrição!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(mtxtDescricao, "");
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show("Dados Salvos.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("É necessário o preenchimento de " + "todos os campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //validar
            if (!ValidarLocal())
                return;

            //Pegar o diretorio
            string localCompleto = GetDiretorioCompleto();

            //validar se o arquivo existe se nao ele cria
            if (File.Exists(localCompleto))
            {
                if (MessageBox.Show("O Arquivo já existe. Deseja substituir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    File.WriteAllText(localCompleto, "CNPJ: " + mtxtCnpj.Text + Environment.NewLine);
                    File.WriteAllText(localCompleto, "Nome: " + mtxtNome.Text + Environment.NewLine);
                    File.WriteAllText(localCompleto, "Categoria: " + mtxtCategoria.Text + Environment.NewLine);
                    File.WriteAllText(localCompleto, "Idade Mínima: " + mtxtIdadeMinima.Text + Environment.NewLine);
                    File.WriteAllText(localCompleto, "Código de Barras: " + mtxtCodBarra.Text + Environment.NewLine);
                    File.WriteAllText(localCompleto, "Preço: " + mtxtPreco.Text + Environment.NewLine);
                    File.WriteAllText(localCompleto, "Descrição: " + mtxtDescricao.Text + Environment.NewLine);
                }
            }
            else
            {
                File.WriteAllText(localCompleto, "");
                MessageBox.Show("Arquivo criado!");
            }

            //definir oq vai escrever no arquivo
            File.AppendAllText(localCompleto, "CNPJ: " + mtxtCnpj.Text + Environment.NewLine);
            File.AppendAllText(localCompleto, "Nome: " + mtxtNome.Text + Environment.NewLine);
            File.AppendAllText(localCompleto, "Categoria: " + mtxtCategoria.Text + Environment.NewLine);
            File.AppendAllText(localCompleto, "Idade Mínima: " + mtxtIdadeMinima.Text + Environment.NewLine);
            File.AppendAllText(localCompleto, "Código de Barras: " + mtxtCodBarra.Text + Environment.NewLine);
            File.AppendAllText(localCompleto, "Preço: " + mtxtPreco.Text + Environment.NewLine);
            File.AppendAllText(localCompleto, "Descrição: " + mtxtDescricao.Text + Environment.NewLine);
        }

       
        private void mtxtCodBarraValidating(object sender, CancelEventArgs e)
        {
            string Cod = "";
            foreach (char i in mtxtCodBarra.Text)
            {
                if (char.IsNumber(i))
                    Cod += i;
            }
            if (string.IsNullOrEmpty(Cod))
            {
                e.Cancel = true;
                errorProvider1.SetError(mtxtCodBarra, "Insira um valor!");
            }
            else if (Cod.Length != 13)
            {
                e.Cancel = true;
                errorProvider1.SetError(mtxtCodBarra, "Deve-se conter 13 caracteres no código de barra!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(mtxtCodBarra, "");
            }
        }

        private void mtxtPreco_Validating(object sender, CancelEventArgs e)
        {
            string valor = "";
            foreach (char i in mtxtPreco.Text)
            {
                if (char.IsNumber(i))
                    valor += i;
            }
            if (string.IsNullOrEmpty(valor))
            {
                e.Cancel = true;
                errorProvider1.SetError(mtxtPreco, "Insira um valor!");
            }
            else if (int.Parse(valor) <= 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(mtxtPreco, "Insira um valor maior que zero!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(mtxtPreco, "");
            }

        }

        private void mtxtNome_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = folderBrowserDialog1.ShowDialog();
            if(resultado == DialogResult.OK && !string.IsNullOrEmpty(folderBrowserDialog1.SelectedPath))
            {
                txtCaminho.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        bool ValidarLocal()
        {
            string local = txtCaminho.Text;
            string nomeArquivo = mtxtCodBarra.Text;

            //Validar preenchimento
            if (string.IsNullOrEmpty(local) || string.IsNullOrEmpty(nomeArquivo))
            {
                MessageBox.Show("Por favor, informe os " + "dados corretamente");
                return false;
            }

            //Validar se existe
            if (!Directory.Exists(local))
            {
                MessageBox.Show("" + "O diretório especificado não existe.");
                return false;
            }
            return true;
        }

        string GetDiretorioCompleto()
        {
            return Path.Combine(txtCaminho.Text, mtxtCodBarra.Text + ".txt");
        }

        private void btnSubstituir_Click(object sender, EventArgs e)
        {
          
        }
    }
}
