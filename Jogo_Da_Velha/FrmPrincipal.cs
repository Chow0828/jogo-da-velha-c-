   using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_Da_Velha
{ 
    public partial class FrmPrincipal : Form
    {
       
        int rodadas = 0;

        public void ChecarVencedor()
        {
            if(btn0.Text == "X" && btn1.Text =="X" && btn2.Text == "X" || btn3.Text == "X" && btn4.Text == "X" && btn5.Text == "X" || btn6.Text == "X" && btn7.Text == "X" && btn8.Text == "X" || btn0.Text == "X" && btn4.Text == "X" && btn8.Text == "X" || btn2.Text == "X" && btn4.Text == "X" && btn6.Text == "X" || btn0.Text == "X" && btn3.Text == "X" && btn6.Text == "X" || btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X" || btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
            {
                txtMensagem.Text = "Jogador 1 Venceu!";

                if(txtMensagem.Text == "Jogador 1 Venceu!"  )
                {
                    txtMensagem.BackColor = Color.BlueViolet;
                    txtMensagem.ForeColor = Color.White;

                   //ideia caso fosse fazer o pontos 
                  // int p;
                 //  p =+ 1;
                //   txtPontos.Text = p.ToString();

                }
            }
            else if(btn0.Text == "O" && btn1.Text == "O" && btn2.Text == "O" || btn3.Text == "O" && btn4.Text == "O" && btn5.Text == "O" || btn6.Text == "O" && btn7.Text == "O" && btn8.Text == "O" || btn0.Text == "O" && btn4.Text == "O" && btn8.Text == "O" || btn2.Text == "O" && btn4.Text == "O" && btn6.Text == "O" || btn0.Text == "O" && btn3.Text == "O" && btn6.Text == "O" || btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O" || btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
            {
                txtMensagem.Text = "Jogador 2 Venceu!";

                if (txtMensagem.Text == "Jogador 2 Venceu!")
                {
                    txtMensagem.BackColor = Color.Pink;
                    txtMensagem.ForeColor = Color.Black;
                    
                }

            }
            else if(btn0.Text != "" && btn1.Text != ""&&  btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "")
            {
                txtMensagem.Text = "Deu velha";
            }
           
        }

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            //criei um objeto,assim quando eu clicar em um botão vai ser a partir deste como referência,
            // com isso não precido programar em todos a mesma coisa

            Button btn0 = (Button)sender;

            //ele ja comeca com rodada=0,quando eu clico rodada=1,portanto o jogador 1=par|jogador2=Impar
            if(btn0.Text == "")
            {
            //como rodadas esta iniciado em 0,quando for rodar vai clicar e rodadas será igual a 1,vez do jogador 2;

                if (rodadas % 2 == 0)
                {
                    txtMensagem.Text = "Vez do Jogador 2!";
                    btn0.Text = "X";
                    ChecarVencedor();
                    rodadas++;

                }
                else
                {
                    txtMensagem.Text = "Vez do Jogador 1!";
                    btn0.Text = "O";
                    ChecarVencedor();
                    rodadas++;
                }
                
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
          
                btn0.Text = "";
                btn1.Text = "";
                btn2.Text = "";
                btn3.Text = "";
                btn4.Text = "";
                btn5.Text = "";
                btn6.Text = "";
                btn7.Text = "";
                btn8.Text = "";

            txtMensagem.Text = "";
            txtMensagem.BackColor = Color.WhiteSmoke;


            }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
    }

