using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Array_Associado_Imagens
{
    public partial class Form1 : Form
    {
        string texto; //Guardar o texto escrito.
        int tamanho, posicao; //Guardar o tamanho do texto e a posição da letra no texto.
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            texto = "";//Iniciando a variável string.

        }
        private void btnTraduzir_Click(object sender, EventArgs e)
        {
            texto = txtFrase.Text;//Atribuir o que foi inserido a variavel Texto.
            if (texto.Length > 0)//Verificar se existe ja uma frase escrita.
            {
                tamanho = texto.Length - 1;//Retirar um valor do tamanho da frase pq o vetor começa em 0.
                Relogio.Enabled = true;//Ativar o relogio para contar os minutos.
                posicao = 0;//Definir a posição inicial.
            }
        }

        private void Relogio_Tick(object sender, EventArgs e)
        {
            if(posicao < tamanho)
            {
                int letra = (int)System.Convert.ToChar(texto[posicao]);//Obter o código ASCII das letras inseridas. 
                
                if (letra >= 65 && letra <= 90)//Caracteres sem acentos.
                {                   
                    letra -= 65;//Aqui vamos pegar as 65 posições para corresponder  as posições do ImageList.
                    picImagem.Image = ImageList.Images[letra];//Apresentar as imagens.
                }
                else 
                {
                    //Agora para os caracteres especiais.
                    if (letra >= 192 && letra <= 197) picImagem.Image = ImageList.Images[0];//Letra A com acentos.
                    else if (letra == 199) picImagem.Image = ImageList.Images[2];//Letra Ç.
                    else if (letra >= 200 && letra <= 203) picImagem.Image = ImageList.Images[4];//Letra E com acentos.
                    else if (letra >= 204 && letra <= 207) picImagem.Image = ImageList.Images[8];// Letra I com acentos.
                    else if (letra >= 210 && letra <= 214) picImagem.Image = ImageList.Images[14];// Letra O com acentos.
                    else if (letra >= 217 && letra <= 220) picImagem.Image = ImageList.Images[20];// Letra U com acentos.
                    else picImagem.Image = null; //Aqui para limpar a imagen.
                }
                posicao++;//Passar para o proximo caracter.
            }
            else
            {
                Relogio.Enabled = false;//Parar o relogio quando terminar a frase.
                picImagem.Image = null;//Limpar a imagem.
            }
        }

        private void nudDuracao_ValueChanged(object sender, EventArgs e)
        {
            Relogio.Interval = ((int)nudDuracao.Value) * 1000;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Aqui é repor as definições.
            txtFrase.ResetText();
            picImagem.Image = null;
            Relogio.Enabled = false;
            posicao = 0;
            nudDuracao.Value = 1;
            txtFrase.Focus();
        }
    }
}
