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
    public partial class Vizualizacao : Form
    {
        public Vizualizacao()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {

            DialogResult resultado =
                folderBrowserDialog1.ShowDialog();

            if (resultado == DialogResult.OK &&
                !string.IsNullOrEmpty(
                    folderBrowserDialog1.SelectedPath))
            {
                txtCaminho.Text =
                    folderBrowserDialog1.SelectedPath;
            }
        }

        bool ValidarDiretorio()
        {

            string diretorio = txtCaminho.Text;
            string nomeArquivo = txtNome.Text;


            if (string.IsNullOrEmpty(diretorio) ||
                string.IsNullOrEmpty(nomeArquivo))
            {
                MessageBox.Show(
                    "Por favor, informe os " +
                    "dados corretamente");


                return false;
            }


            if (!Directory.Exists(diretorio))
            {
                MessageBox.Show("" +
                    "O diretório especificado não existe.");

                return false;
            }
            return true;

        }

        string GetDiretorioCompleto()
        {
            //Direto + nome + extensão
            //C:/
            //Teste
            //.txt
            //c:/Teste.txt
            return
                Path.Combine(txtCaminho.Text,
                txtNome.Text + ".txt");
        }


        private void btnCarregar_Click_1(object sender, EventArgs e)
        {
            if (!ValidarDiretorio())
                return;

            string diretorioCompleto = GetDiretorioCompleto();

            if (!File.Exists(diretorioCompleto))
            {
                MessageBox.Show(
                    "O arquivo não existe.");
            }
            else
            {
                //Iremos carregar o
                //conteudo do arquivo
                //ReadAllText responsavel
                //por ler o arquivo

                txtArquivo.Text =
                    File.ReadAllText(
                        diretorioCompleto);

                MessageBox.Show(
                    "Conteudo carregado com sucesso.");
            }
        }
    }
}