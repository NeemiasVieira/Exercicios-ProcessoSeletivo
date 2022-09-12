namespace Exercício1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btn_ajuda = new System.Windows.Forms.Button();
            this.Btn_limpar = new System.Windows.Forms.Button();
            this.Btn_fechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_valorkg = new System.Windows.Forms.TextBox();
            this.Txt_tara = new System.Windows.Forms.TextBox();
            this.Txt_peso = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Txt_resultado = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Btn_calcular = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_ajuda
            // 
            this.Btn_ajuda.AccessibleDescription = "Da informações sobre o programa";
            this.Btn_ajuda.AccessibleName = "Ajuda";
            this.Btn_ajuda.BackgroundImage = global::Exercício1.Properties.Resources.Help;
            this.Btn_ajuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_ajuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ajuda.Location = new System.Drawing.Point(6, 20);
            this.Btn_ajuda.Name = "Btn_ajuda";
            this.Btn_ajuda.Size = new System.Drawing.Size(102, 76);
            this.Btn_ajuda.TabIndex = 35;
            this.Btn_ajuda.UseVisualStyleBackColor = true;
            this.Btn_ajuda.Click += new System.EventHandler(this.Btn_ajuda_Click);
            // 
            // Btn_limpar
            // 
            this.Btn_limpar.AccessibleDescription = "Limpa os dados.";
            this.Btn_limpar.AccessibleName = "Limpar";
            this.Btn_limpar.BackgroundImage = global::Exercício1.Properties.Resources.Clean;
            this.Btn_limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_limpar.Location = new System.Drawing.Point(114, 20);
            this.Btn_limpar.Name = "Btn_limpar";
            this.Btn_limpar.Size = new System.Drawing.Size(102, 76);
            this.Btn_limpar.TabIndex = 36;
            this.Btn_limpar.UseVisualStyleBackColor = true;
            this.Btn_limpar.Click += new System.EventHandler(this.Btn_limpar_Click);
            // 
            // Btn_fechar
            // 
            this.Btn_fechar.AccessibleDescription = "Fecha o programa.";
            this.Btn_fechar.AccessibleName = "Fechar";
            this.Btn_fechar.BackgroundImage = global::Exercício1.Properties.Resources.close1;
            this.Btn_fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_fechar.Location = new System.Drawing.Point(222, 20);
            this.Btn_fechar.Name = "Btn_fechar";
            this.Btn_fechar.Size = new System.Drawing.Size(102, 76);
            this.Btn_fechar.TabIndex = 37;
            this.Btn_fechar.UseVisualStyleBackColor = true;
            this.Btn_fechar.Click += new System.EventHandler(this.Btn_fechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "Valor do quilo (R$):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 42;
            this.label2.Text = "Tara do prato (g) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 43;
            this.label3.Text = "Peso do prato (g) :";
            // 
            // Txt_valorkg
            // 
            this.Txt_valorkg.AccessibleDescription = "Valor a ser pago por kg em reais.";
            this.Txt_valorkg.AccessibleName = "Valor/Preço do Kg";
            this.Txt_valorkg.Location = new System.Drawing.Point(110, 33);
            this.Txt_valorkg.Name = "Txt_valorkg";
            this.Txt_valorkg.Size = new System.Drawing.Size(100, 23);
            this.Txt_valorkg.TabIndex = 30;
            this.Txt_valorkg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_valorkg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_valorkg_KeyPress);
            // 
            // Txt_tara
            // 
            this.Txt_tara.AccessibleDescription = "Valor em reais da tara do prato.";
            this.Txt_tara.AccessibleName = "Tara";
            this.Txt_tara.Location = new System.Drawing.Point(110, 62);
            this.Txt_tara.Name = "Txt_tara";
            this.Txt_tara.Size = new System.Drawing.Size(100, 23);
            this.Txt_tara.TabIndex = 31;
            this.Txt_tara.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_tara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_tara_KeyPress);
            // 
            // Txt_peso
            // 
            this.Txt_peso.AccessibleDescription = "Peso do prato em gramas";
            this.Txt_peso.AccessibleName = "Total pesado";
            this.Txt_peso.Location = new System.Drawing.Point(110, 94);
            this.Txt_peso.Name = "Txt_peso";
            this.Txt_peso.Size = new System.Drawing.Size(100, 23);
            this.Txt_peso.TabIndex = 32;
            this.Txt_peso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_peso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_peso_KeyDown);
            this.Txt_peso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_peso_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox1.Controls.Add(this.Btn_ajuda);
            this.groupBox1.Controls.Add(this.Btn_limpar);
            this.groupBox1.Controls.Add(this.Btn_fechar);
            this.groupBox1.Location = new System.Drawing.Point(326, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 109);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ações";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txt_resultado);
            this.groupBox2.Location = new System.Drawing.Point(12, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 109);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // Txt_resultado
            // 
            this.Txt_resultado.AccessibleDescription = "Exibe as gramas consumidas e o valor a ser pago pelo cliente.";
            this.Txt_resultado.AccessibleName = "Resultado";
            this.Txt_resultado.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Txt_resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_resultado.Enabled = false;
            this.Txt_resultado.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Txt_resultado.Location = new System.Drawing.Point(6, 48);
            this.Txt_resultado.Name = "Txt_resultado";
            this.Txt_resultado.ReadOnly = true;
            this.Txt_resultado.Size = new System.Drawing.Size(296, 27);
            this.Txt_resultado.TabIndex = 34;
            this.Txt_resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox3.BackgroundImage = global::Exercício1.Properties.Resources.ModalGR22;
            this.groupBox3.Location = new System.Drawing.Point(243, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(413, 209);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Btn_calcular);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.Txt_valorkg);
            this.groupBox4.Controls.Add(this.Txt_peso);
            this.groupBox4.Controls.Add(this.Txt_tara);
            this.groupBox4.Location = new System.Drawing.Point(7, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(225, 165);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informações do Prato";
            // 
            // Btn_calcular
            // 
            this.Btn_calcular.AccessibleDescription = "Calcula o valor do prato";
            this.Btn_calcular.AccessibleName = "Calcular";
            this.Btn_calcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_calcular.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_calcular.Location = new System.Drawing.Point(20, 129);
            this.Btn_calcular.Name = "Btn_calcular";
            this.Btn_calcular.Size = new System.Drawing.Size(184, 23);
            this.Btn_calcular.TabIndex = 33;
            this.Btn_calcular.Text = "Calcular";
            this.Btn_calcular.UseVisualStyleBackColor = true;
            this.Btn_calcular.Click += new System.EventHandler(this.Btn_calcular_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackgroundImage = global::Exercício1.Properties.Resources.Prato;
            this.groupBox5.Location = new System.Drawing.Point(56, 176);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(132, 80);
            this.groupBox5.TabIndex = 44;
            this.groupBox5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(672, 373);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(692, 416);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(692, 416);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício 1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Btn_ajuda;
        private Button Btn_limpar;
        private Button Btn_fechar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Txt_valorkg;
        private TextBox Txt_tara;
        private TextBox Txt_peso;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private TextBox Txt_resultado;
        private Button Btn_calcular;
        private GroupBox groupBox5;
    }
}