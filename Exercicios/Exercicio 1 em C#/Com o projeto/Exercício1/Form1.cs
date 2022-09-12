using System.Reflection.Metadata.Ecma335;
//Autor: Neemias Vieira Fernandes, https://github.com/NeemiasVieira


        #region Inicialização e variáveis globais
        namespace Exercício1
                {
                    public partial class Form1 : Form
                    {
                        float precokg = 0;
                        float tara = 0;
                        float peso = 0;
                        float pesofinal = 0;
                        float valordoprato = 0;
        



                        public Form1()
                        {
                            InitializeComponent();                           
                        }
                        #endregion
        #region Botão Calcular
        private void Btn_calcular_Click(object sender, EventArgs e)
        {
           
                try
                {
                if (Txt_peso.Text == "" || Txt_tara.Text == "" || Txt_valorkg.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos primeiro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Txt_valorkg.Focus();
                }
                else
                {
                    precokg = float.Parse(Txt_valorkg.Text);
                    tara = float.Parse(Txt_tara.Text);
                    peso = float.Parse(Txt_peso.Text);
                    pesofinal = peso - tara;
                    valordoprato = (pesofinal / 1000) * precokg;
                    if (valordoprato > 0)
                    {
                        Txt_resultado.Text = "O prato de " + pesofinal + " gramas custa: R$ " + (valordoprato.ToString("F"));
                    }
                    else
                    {
                        MessageBox.Show("O valor do prato é igual ou menor que zero, confira os dados e tente novamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


                }
                catch
                {
                    MessageBox.Show("Algo deu errado, confirme se as informações estão corretas!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
           
        }

        #endregion
        //Calcula o valor a ser pago e exibe a quantidade de gramas pega pelo cliente e quanto ele deverá pagar em reais.
        #region Botão Limpar
        private void Btn_limpar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja limpar os dados?", "Limpando...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Txt_peso.Text = "";
                Txt_resultado.Text = "";
                Txt_tara.Text = "";
                Txt_valorkg.Text = "";
                Txt_valorkg.Focus();
            }

        }
        #endregion
        //Apaga o valor de todos os campos e altera o foco pro início.
        #region Botão fechar
        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o programa?", "Encerrando", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
            
        }
        #endregion
        //Fecha o programa.
        #region Botão ajuda
        private void Btn_ajuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No primeiro campo coloque o valor do quilo, no segundo o peso do prato vazio e no terceiro o peso do prato com a comida, e em seguida clique em calcular, o resultado aparecerá abaixo", "Ajuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
        //Exibe uma mensagem com orientações para usar o programa.
        #region Calcular (ao cliclar enter)
        private void Txt_peso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (Txt_peso.Text == "" || Txt_tara.Text == "" || Txt_valorkg.Text == "")
                    {
                        MessageBox.Show("Preencha todos os campos primeiro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Txt_valorkg.Focus();
                    }
                    else
                    {
                        precokg = float.Parse(Txt_valorkg.Text);
                        tara = float.Parse(Txt_tara.Text);
                        peso = float.Parse(Txt_peso.Text);
                        pesofinal = peso - tara;
                        valordoprato = (pesofinal / 1000) * precokg;
                        if (valordoprato > 0)
                        {
                            Txt_resultado.Text = "O prato de " + pesofinal + " gramas custa: R$ " + (valordoprato.ToString("F"));
                        }
                        else
                        {
                            MessageBox.Show("O valor do prato é igual ou menor que zero, confira os dados e tente novamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }


                }
                catch
                {
                    MessageBox.Show("Algo deu errado, confirme se as informações estão corretas!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        #endregion
        //Calcula quando o foco está no terceiro campo e o usuário pressiona a tecla Enter.
        #region Consistencia númerica
        private void Txt_valorkg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 46 && (e.KeyChar > 47 && e.KeyChar < 58) || e.KeyChar == 8 || e.KeyChar == 44) 
            {
                e.KeyChar = e.KeyChar;
            }
            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }

        private void Txt_tara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 46 && (e.KeyChar > 47 && e.KeyChar < 58) || e.KeyChar == 8 || e.KeyChar == 44)
            {
                e.KeyChar = e.KeyChar;
            }
            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }

        private void Txt_peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 46 && (e.KeyChar > 47 && e.KeyChar < 58) || e.KeyChar == 8 || e.KeyChar == 44)
            {
                e.KeyChar = e.KeyChar;
            }
            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
            #endregion 
        //Só permite números e "," e não permite "."
        }
    }

}