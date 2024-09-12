namespace Conversor_de_Modas
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
            groupBox1 = new GroupBox();
            ent_dolar = new RadioButton();
            ent_euro = new RadioButton();
            ent_real = new RadioButton();
            groupBox2 = new GroupBox();
            sai_dolar = new RadioButton();
            sai_euro = new RadioButton();
            sai_real = new RadioButton();
            label1 = new Label();
            entrada = new TextBox();
            label2 = new Label();
            saida = new TextBox();
            calcular = new Button();
            limpar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ent_dolar);
            groupBox1.Controls.Add(ent_euro);
            groupBox1.Controls.Add(ent_real);
            groupBox1.Location = new Point(16, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(162, 124);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Entrada";
            // 
            // ent_dolar
            // 
            ent_dolar.AutoSize = true;
            ent_dolar.Font = new Font("Segoe UI", 12F);
            ent_dolar.Location = new Point(19, 82);
            ent_dolar.Name = "ent_dolar";
            ent_dolar.Size = new Size(66, 25);
            ent_dolar.TabIndex = 2;
            ent_dolar.TabStop = true;
            ent_dolar.Text = "Dolar";
            ent_dolar.UseVisualStyleBackColor = true;
            // 
            // ent_euro
            // 
            ent_euro.AutoSize = true;
            ent_euro.Font = new Font("Segoe UI", 12F);
            ent_euro.Location = new Point(19, 57);
            ent_euro.Name = "ent_euro";
            ent_euro.Size = new Size(60, 25);
            ent_euro.TabIndex = 1;
            ent_euro.TabStop = true;
            ent_euro.Text = "Euro";
            ent_euro.UseVisualStyleBackColor = true;
            // 
            // ent_real
            // 
            ent_real.AutoSize = true;
            ent_real.Font = new Font("Segoe UI", 12F);
            ent_real.Location = new Point(19, 32);
            ent_real.Name = "ent_real";
            ent_real.Size = new Size(58, 25);
            ent_real.TabIndex = 0;
            ent_real.TabStop = true;
            ent_real.Text = "Real";
            ent_real.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(sai_dolar);
            groupBox2.Controls.Add(sai_euro);
            groupBox2.Controls.Add(sai_real);
            groupBox2.Location = new Point(191, 70);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(162, 124);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Saida";
            // 
            // sai_dolar
            // 
            sai_dolar.AutoSize = true;
            sai_dolar.Font = new Font("Segoe UI", 12F);
            sai_dolar.Location = new Point(17, 82);
            sai_dolar.Name = "sai_dolar";
            sai_dolar.Size = new Size(66, 25);
            sai_dolar.TabIndex = 5;
            sai_dolar.TabStop = true;
            sai_dolar.Text = "Dolar";
            sai_dolar.UseVisualStyleBackColor = true;
            // 
            // sai_euro
            // 
            sai_euro.AutoSize = true;
            sai_euro.Font = new Font("Segoe UI", 12F);
            sai_euro.Location = new Point(17, 57);
            sai_euro.Name = "sai_euro";
            sai_euro.Size = new Size(60, 25);
            sai_euro.TabIndex = 4;
            sai_euro.TabStop = true;
            sai_euro.Text = "Euro";
            sai_euro.UseVisualStyleBackColor = true;
            // 
            // sai_real
            // 
            sai_real.AutoSize = true;
            sai_real.Font = new Font("Segoe UI", 12F);
            sai_real.Location = new Point(17, 32);
            sai_real.Name = "sai_real";
            sai_real.Size = new Size(58, 25);
            sai_real.TabIndex = 3;
            sai_real.TabStop = true;
            sai_real.Text = "Real";
            sai_real.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 9);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 2;
            label1.Text = "Entre com os Valores: ";
            // 
            // entrada
            // 
            entrada.Location = new Point(12, 27);
            entrada.Name = "entrada";
            entrada.Size = new Size(341, 23);
            entrada.TabIndex = 3;
            entrada.TextChanged += entrada_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 252);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 4;
            label2.Text = "Valores Convertido: ";
            label2.Click += label2_Click;
            // 
            // saida
            // 
            saida.Enabled = false;
            saida.Location = new Point(12, 270);
            saida.Name = "saida";
            saida.Size = new Size(341, 23);
            saida.TabIndex = 5;
            saida.TextChanged += textBox1_TextChanged;
            // 
            // calcular
            // 
            calcular.Location = new Point(54, 215);
            calcular.Name = "calcular";
            calcular.Size = new Size(114, 23);
            calcular.TabIndex = 6;
            calcular.Text = "Cacular";
            calcular.UseVisualStyleBackColor = true;
            calcular.Click += button1_Click;
            // 
            // limpar
            // 
            limpar.Location = new Point(174, 215);
            limpar.Name = "limpar";
            limpar.Size = new Size(114, 23);
            limpar.TabIndex = 7;
            limpar.Text = "Limpar";
            limpar.UseVisualStyleBackColor = true;
            limpar.Click += limpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 316);
            Controls.Add(limpar);
            Controls.Add(calcular);
            Controls.Add(saida);
            Controls.Add(label2);
            Controls.Add(entrada);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox entrada;
        private Label label2;
        private TextBox saida;
        private Button calcular;
        private Button limpar;
        private RadioButton ent_dolar;
        private RadioButton ent_euro;
        private RadioButton ent_real;
        private RadioButton sai_dolar;
        private RadioButton sai_euro;
        private RadioButton sai_real;
    }
}
