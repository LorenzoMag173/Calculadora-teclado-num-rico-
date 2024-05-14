namespace Calculadora_Númerica
{
    partial class Calculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.numZero = new System.Windows.Forms.Button();
            this.adição = new System.Windows.Forms.Button();
            this.divisão = new System.Windows.Forms.Button();
            this.numTres = new System.Windows.Forms.Button();
            this.numSeis = new System.Windows.Forms.Button();
            this.numNove = new System.Windows.Forms.Button();
            this.numUm = new System.Windows.Forms.Button();
            this.numQuatro = new System.Windows.Forms.Button();
            this.numSete = new System.Windows.Forms.Button();
            this.numOito = new System.Windows.Forms.Button();
            this.numCinco = new System.Windows.Forms.Button();
            this.numDois = new System.Windows.Forms.Button();
            this.subtração = new System.Windows.Forms.Button();
            this.multiplicação = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.resultado = new System.Windows.Forms.TextBox();
            this.apagar = new System.Windows.Forms.Button();
            this.numVirgula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numZero
            // 
            this.numZero.Location = new System.Drawing.Point(63, 254);
            this.numZero.Name = "numZero";
            this.numZero.Size = new System.Drawing.Size(45, 45);
            this.numZero.TabIndex = 0;
            this.numZero.Text = "0";
            this.numZero.UseVisualStyleBackColor = true;
            this.numZero.Click += new System.EventHandler(this.num0_Click);
            // 
            // adição
            // 
            this.adição.Location = new System.Drawing.Point(182, 254);
            this.adição.Name = "adição";
            this.adição.Size = new System.Drawing.Size(45, 45);
            this.adição.TabIndex = 1;
            this.adição.Text = "+";
            this.adição.UseVisualStyleBackColor = true;
            this.adição.Click += new System.EventHandler(this.adição_Click);
            // 
            // divisão
            // 
            this.divisão.Location = new System.Drawing.Point(181, 101);
            this.divisão.Name = "divisão";
            this.divisão.Size = new System.Drawing.Size(45, 45);
            this.divisão.TabIndex = 2;
            this.divisão.Text = " ÷";
            this.divisão.UseVisualStyleBackColor = true;
            this.divisão.Click += new System.EventHandler(this.divisão_Click);
            // 
            // numTres
            // 
            this.numTres.Location = new System.Drawing.Point(114, 203);
            this.numTres.Name = "numTres";
            this.numTres.Size = new System.Drawing.Size(45, 45);
            this.numTres.TabIndex = 3;
            this.numTres.Text = "3";
            this.numTres.UseVisualStyleBackColor = true;
            this.numTres.Click += new System.EventHandler(this.num3_Click);
            // 
            // numSeis
            // 
            this.numSeis.Location = new System.Drawing.Point(114, 152);
            this.numSeis.Name = "numSeis";
            this.numSeis.Size = new System.Drawing.Size(45, 45);
            this.numSeis.TabIndex = 4;
            this.numSeis.Text = "6";
            this.numSeis.UseVisualStyleBackColor = true;
            this.numSeis.Click += new System.EventHandler(this.num6_Click);
            // 
            // numNove
            // 
            this.numNove.Location = new System.Drawing.Point(114, 101);
            this.numNove.Name = "numNove";
            this.numNove.Size = new System.Drawing.Size(45, 45);
            this.numNove.TabIndex = 5;
            this.numNove.Text = "9";
            this.numNove.UseVisualStyleBackColor = true;
            this.numNove.Click += new System.EventHandler(this.num9_Click);
            // 
            // numUm
            // 
            this.numUm.Location = new System.Drawing.Point(12, 203);
            this.numUm.Name = "numUm";
            this.numUm.Size = new System.Drawing.Size(45, 45);
            this.numUm.TabIndex = 6;
            this.numUm.Text = "1";
            this.numUm.UseVisualStyleBackColor = true;
            this.numUm.Click += new System.EventHandler(this.num1_Click);
            // 
            // numQuatro
            // 
            this.numQuatro.Location = new System.Drawing.Point(12, 152);
            this.numQuatro.Name = "numQuatro";
            this.numQuatro.Size = new System.Drawing.Size(45, 45);
            this.numQuatro.TabIndex = 7;
            this.numQuatro.Text = "4";
            this.numQuatro.UseVisualStyleBackColor = true;
            this.numQuatro.Click += new System.EventHandler(this.num4_Click);
            // 
            // numSete
            // 
            this.numSete.Location = new System.Drawing.Point(11, 101);
            this.numSete.Name = "numSete";
            this.numSete.Size = new System.Drawing.Size(45, 45);
            this.numSete.TabIndex = 8;
            this.numSete.Text = "7";
            this.numSete.UseVisualStyleBackColor = true;
            this.numSete.Click += new System.EventHandler(this.num7_Click);
            // 
            // numOito
            // 
            this.numOito.Location = new System.Drawing.Point(63, 101);
            this.numOito.Name = "numOito";
            this.numOito.Size = new System.Drawing.Size(45, 45);
            this.numOito.TabIndex = 9;
            this.numOito.Text = "8";
            this.numOito.UseVisualStyleBackColor = true;
            this.numOito.Click += new System.EventHandler(this.num8_Click);
            // 
            // numCinco
            // 
            this.numCinco.Location = new System.Drawing.Point(63, 152);
            this.numCinco.Name = "numCinco";
            this.numCinco.Size = new System.Drawing.Size(45, 45);
            this.numCinco.TabIndex = 10;
            this.numCinco.Text = "5";
            this.numCinco.UseVisualStyleBackColor = true;
            this.numCinco.Click += new System.EventHandler(this.num5_Click);
            // 
            // numDois
            // 
            this.numDois.Location = new System.Drawing.Point(63, 203);
            this.numDois.Name = "numDois";
            this.numDois.Size = new System.Drawing.Size(45, 45);
            this.numDois.TabIndex = 11;
            this.numDois.Text = "2";
            this.numDois.UseVisualStyleBackColor = true;
            this.numDois.Click += new System.EventHandler(this.num2_Click);
            // 
            // subtração
            // 
            this.subtração.Location = new System.Drawing.Point(182, 203);
            this.subtração.Name = "subtração";
            this.subtração.Size = new System.Drawing.Size(45, 45);
            this.subtração.TabIndex = 12;
            this.subtração.Text = "-";
            this.subtração.UseVisualStyleBackColor = true;
            this.subtração.Click += new System.EventHandler(this.subtração_Click);
            // 
            // multiplicação
            // 
            this.multiplicação.Location = new System.Drawing.Point(182, 152);
            this.multiplicação.Name = "multiplicação";
            this.multiplicação.Size = new System.Drawing.Size(45, 45);
            this.multiplicação.TabIndex = 13;
            this.multiplicação.Text = "x";
            this.multiplicação.UseVisualStyleBackColor = true;
            this.multiplicação.Click += new System.EventHandler(this.multiplicação_Click);
            // 
            // igual
            // 
            this.igual.Location = new System.Drawing.Point(114, 254);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(45, 45);
            this.igual.TabIndex = 14;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.resultado_Click);
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(11, 21);
            this.resultado.Multiline = true;
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(215, 45);
            this.resultado.TabIndex = 15;
            this.resultado.TextChanged += new System.EventHandler(this.resposta_TextChanged);
            // 
            // apagar
            // 
            this.apagar.Location = new System.Drawing.Point(182, 305);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(45, 45);
            this.apagar.TabIndex = 16;
            this.apagar.Text = "apaga";
            this.apagar.UseVisualStyleBackColor = true;
            this.apagar.Click += new System.EventHandler(this.apagar_Click);
            // 
            // numVirgula
            // 
            this.numVirgula.Location = new System.Drawing.Point(12, 254);
            this.numVirgula.Name = "numVirgula";
            this.numVirgula.Size = new System.Drawing.Size(45, 45);
            this.numVirgula.TabIndex = 17;
            this.numVirgula.Text = ",";
            this.numVirgula.UseVisualStyleBackColor = true;
            this.numVirgula.Click += new System.EventHandler(this.button1_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 364);
            this.Controls.Add(this.numVirgula);
            this.Controls.Add(this.apagar);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.multiplicação);
            this.Controls.Add(this.subtração);
            this.Controls.Add(this.numDois);
            this.Controls.Add(this.numCinco);
            this.Controls.Add(this.numOito);
            this.Controls.Add(this.numSete);
            this.Controls.Add(this.numQuatro);
            this.Controls.Add(this.numUm);
            this.Controls.Add(this.numNove);
            this.Controls.Add(this.numSeis);
            this.Controls.Add(this.numTres);
            this.Controls.Add(this.divisão);
            this.Controls.Add(this.adição);
            this.Controls.Add(this.numZero);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculadora";
            this.Text = "Calculadora Lorenzo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button numZero;
        private System.Windows.Forms.Button adição;
        private System.Windows.Forms.Button divisão;
        private System.Windows.Forms.Button numTres;
        private System.Windows.Forms.Button numSeis;
        private System.Windows.Forms.Button numNove;
        private System.Windows.Forms.Button numUm;
        private System.Windows.Forms.Button numQuatro;
        private System.Windows.Forms.Button numSete;
        private System.Windows.Forms.Button numOito;
        private System.Windows.Forms.Button numCinco;
        private System.Windows.Forms.Button numDois;
        private System.Windows.Forms.Button subtração;
        private System.Windows.Forms.Button multiplicação;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Button apagar;
        private System.Windows.Forms.Button numVirgula;
    }
}

