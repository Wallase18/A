namespace Cliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.textEndereçoIp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPorta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textArquivo = new System.Windows.Forms.TextBox();
            this.btnEnvia = new System.Windows.Forms.Button();
            this.btnProcura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Endereço IP :";
            // 
            // textEndereçoIp
            // 
            this.textEndereçoIp.Location = new System.Drawing.Point(25, 56);
            this.textEndereçoIp.Name = "textEndereçoIp";
            this.textEndereçoIp.Size = new System.Drawing.Size(145, 27);
            this.textEndereçoIp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Porta :";
            // 
            // textPorta
            // 
            this.textPorta.Location = new System.Drawing.Point(25, 125);
            this.textPorta.Name = "textPorta";
            this.textPorta.Size = new System.Drawing.Size(145, 27);
            this.textPorta.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Selecione o arquivo :";
            // 
            // textArquivo
            // 
            this.textArquivo.Location = new System.Drawing.Point(25, 191);
            this.textArquivo.Name = "textArquivo";
            this.textArquivo.Size = new System.Drawing.Size(238, 27);
            this.textArquivo.TabIndex = 5;
            // 
            // btnEnvia
            // 
            this.btnEnvia.Location = new System.Drawing.Point(25, 321);
            this.btnEnvia.Name = "btnEnvia";
            this.btnEnvia.Size = new System.Drawing.Size(147, 36);
            this.btnEnvia.TabIndex = 6;
            this.btnEnvia.Text = "Envia Arquivo";
            this.btnEnvia.UseVisualStyleBackColor = true;
            this.btnEnvia.Click += new System.EventHandler(this.btnEnvia_Click);
            // 
            // btnProcura
            // 
            this.btnProcura.Location = new System.Drawing.Point(25, 235);
            this.btnProcura.Name = "btnProcura";
            this.btnProcura.Size = new System.Drawing.Size(144, 29);
            this.btnProcura.TabIndex = 7;
            this.btnProcura.Text = "Procura";
            this.btnProcura.UseVisualStyleBackColor = true;
            this.btnProcura.Click += new System.EventHandler(this.btnProcura_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 383);
            this.Controls.Add(this.btnProcura);
            this.Controls.Add(this.btnEnvia);
            this.Controls.Add(this.textArquivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPorta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textEndereçoIp);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "TCP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textEndereçoIp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPorta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textArquivo;
        private System.Windows.Forms.Button btnEnvia;
        private System.Windows.Forms.Button btnProcura;
    }
}

