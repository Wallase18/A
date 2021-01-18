using System;
using System.IO;
using System.Net.Sockets;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Form1 : Form
    {
        private static string nomeAbreviadoArquivo = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcura_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Emvio de arquivo - Cliente";
            dlg.ShowDialog();
            textArquivo.Text = dlg.FileName;
            nomeAbreviadoArquivo = dlg.SafeFileName;
        }

        private void btnEnvia_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textEndereçoIp.Text)&&
                string.IsNullOrEmpty(textPorta.Text)&&
                string.IsNullOrEmpty(textArquivo.Text))
            {
                MessageBox.Show("Dados Invalidos...");
                return;
            }

            string enderecoIP = textEndereçoIp.Text;
            int porta = int.Parse(textPorta.Text);
            string nomeArquivo = textArquivo.Text;

            try
            {
                Task.Factory.StartNew(() => EnviarArquivo(enderecoIP, porta, nomeArquivo, nomeAbreviadoArquivo));
                MessageBox.Show("Arquivo Enviado com sucesso");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }
        public void EnviarArquivo(String IPHostRemoto, int PortaHostRemoto, string nomeCaminhoArquivo, string nomeAbreviadoArquivo)
        {
            try
            {
                if (!string.IsNullOrEmpty(IPHostRemoto))
                {
                    byte[] fileNameByte = Encoding.ASCII.GetBytes(nomeAbreviadoArquivo);
                    byte[] fileData = File.ReadAllBytes(nomeCaminhoArquivo);
                    byte[] clientData = new byte[4 + fileNameByte.Length + fileData.Length];
                    byte[] fileNameLen = BitConverter.GetBytes(fileNameByte.Length);

                    fileNameLen.CopyTo(clientData, 0);
                    fileNameByte.CopyTo(clientData, 4);
                    fileData.CopyTo(clientData, 4 + fileNameByte.Length);

                    TcpClient clientSocket = new TcpClient(IPHostRemoto, PortaHostRemoto);
                    NetworkStream networkStream = clientSocket.GetStream();

                    networkStream.Write(clientData, 0, clientData.GetLength(0));
                    networkStream.Close();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
