using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeOVNI
{
    public partial class Gerenciador : Form
    {
        // objetos globais:
        BibliotecaOVNI.OVNI ovni;


        public Gerenciador(BibliotecaOVNI.OVNI ovni) // obrigatoriamente deve-se iniciar
        {
            InitializeComponent();
            // copiando o ovni vindo da outra janela para projeto global:
            this.ovni = ovni;

            // atualizar as informações:
            AtualizarInformacoes();
            cmbPlanetas.Items.AddRange(BibliotecaOVNI.OVNI.PlanetasValidos);    
        }

        public void AtualizarInformacoes()
        {
            lbltripulantes.Text = $"Tripulantes: {ovni.QtdTripulantes}";
            lblabduzidos.Text = $"Abduzidos: {ovni.QtdAbduzidos}";
            lblsituacao.Text = $"Situação: {(ovni.Situacao ? "Ligado" : "Desligado")}";
            lblPlaneta.Text = $"Planeta Atual: {ovni.PlanetaAtual}";
            cmbPlanetas.Text = ovni.PlanetaAtual;

            // atualizar os botões ligar e desligar:
            btndesligar.Enabled = ovni.Situacao;
            btnligar.Enabled = !ovni.Situacao;

            //ativar ou desativar os groupbox de acordo com o atatus da nave:
            grbAbduzidos.Enabled = ovni.Situacao;
            grbPlaneta.Enabled = ovni.Situacao;
            grbTripulantes.Enabled = ovni.Situacao;

            // verificar se está na terra
            if(ovni.PlanetaAtual == "Terra")
            {
                pibTerra.Image = Properties.Resources.terra;
            }
            else
            {
                pibTerra.Image = null;
            }



        }

        private void btnligar_Click(object sender, EventArgs e)
        {
            if (ovni.Ligar())
            {
                MessageBox.Show("O OVNI foi Ligado!",
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O OVNI já está ligado!",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // atualizar ás informações:
            AtualizarInformacoes();

        }

        private void btndesligar_Click(object sender, EventArgs e)
        {
            if (ovni.Desligar())
            {
                MessageBox.Show("O OVNI foi desligado!",
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O OVNI já está ligado!",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // atualizar ás informações:
            AtualizarInformacoes();

            // popular o combobox com os planetas válidos:
            //cmbPlanetas.Items.AddRange(BibliotecaOVNI.OVNI.PlanetasValidos);

        }

        private void btnAdicionarTripulantes_Click(object sender, EventArgs e)
        {
            if (ovni.AdicionarTripulante())
            {
                MessageBox.Show("Tripulante Adicionado!",
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("A nave já está lotada de tripulantes!",
                  "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarInformacoes();
        }
         
        private void btnRemoverTripulantes_Click(object sender, EventArgs e)
        {
            if (ovni.RemoverTripulante())
            {
                MessageBox.Show("Tripulante Removido!",
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Não é possível mais remover tripulantes!",
                  "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarInformacoes();
        }

        private void btnAdicionarAbduzidos_Click(object sender, EventArgs e)
        {
            if (ovni.Abduzir())
            {
                MessageBox.Show("Tripulante Abduzido!",
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("A nave já está lotada de tripulantes. Não é possivel Abduzir mais!",
                  "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarInformacoes();
        }

        private void btnRemoverAbduzidos_Click(object sender, EventArgs e)
        {
            if (ovni.Desabduzir())
            {
                MessageBox.Show("Tripulante Desabduzido!",
                    "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Não é possível mais Desabduzir tripulantes!",
                  "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarInformacoes();
        }

        private void btnMudarPlaneta_Click(object sender, EventArgs e)
        {
           if (ovni.MudarPlaneta(cmbPlanetas.Text))
            {
                MessageBox.Show("voce mudou de Planeta!",
                                   "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);  
            }
            else
            {
                MessageBox.Show("Não foi possivel mudar de Planeta!",
                  "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarInformacoes();
        }

        private void btnRetornarDePlaneta_Click(object sender, EventArgs e)
        {
            if (ovni.RetornarAoPlanetaDeOrigem())
             
            {
                MessageBox.Show("voce retornou ao Planeta de origem!",
                               "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Não é possivel retornar. Voce já esta no Planeta de origem!",
                "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            AtualizarInformacoes();

        }
    }
}
