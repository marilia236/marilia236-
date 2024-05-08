namespace Cronometro
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
            label1 = new Label();
            lblInicio = new Label();
            lblDuracao = new Label();
            label3 = new Label();
            lblDuracaoSeg = new Label();
            label5 = new Label();
            btnIniciar = new Button();
            btnParar = new Button();
            btnLimpar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 22);
            label1.Name = "label1";
            label1.Size = new Size(254, 46);
            label1.TabIndex = 0;
            label1.Text = "Início da contagem:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblInicio
            // 
            lblInicio.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblInicio.Location = new Point(327, 22);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(137, 46);
            lblInicio.TabIndex = 1;
            lblInicio.Text = "00:00:00";
            lblInicio.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDuracao
            // 
            lblDuracao.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblDuracao.Location = new Point(327, 86);
            lblDuracao.Name = "lblDuracao";
            lblDuracao.Size = new Size(137, 46);
            lblDuracao.TabIndex = 3;
            lblDuracao.Text = "00:00:00";
            lblDuracao.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(29, 86);
            label3.Name = "label3";
            label3.Size = new Size(254, 46);
            label3.TabIndex = 2;
            label3.Text = "Duração:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            label3.Click += label3_Click;
            // 
            // lblDuracaoSeg
            // 
            lblDuracaoSeg.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblDuracaoSeg.Location = new Point(327, 153);
            lblDuracaoSeg.Name = "lblDuracaoSeg";
            lblDuracaoSeg.Size = new Size(137, 46);
            lblDuracaoSeg.TabIndex = 5;
            lblDuracaoSeg.Text = "00:00:00";
            lblDuracaoSeg.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(29, 153);
            label5.Name = "label5";
            label5.Size = new Size(254, 46);
            label5.TabIndex = 4;
            label5.Text = "Duração em segundos:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnIniciar
            // 
            btnIniciar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciar.Location = new Point(127, 248);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(99, 46);
            btnIniciar.TabIndex = 6;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            // 
            // btnParar
            // 
            btnParar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnParar.Location = new Point(244, 248);
            btnParar.Name = "btnParar";
            btnParar.Size = new Size(99, 46);
            btnParar.TabIndex = 7;
            btnParar.Text = "Parar";
            btnParar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpar.Location = new Point(365, 248);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(99, 46);
            btnLimpar.TabIndex = 8;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 332);
            Controls.Add(btnLimpar);
            Controls.Add(btnParar);
            Controls.Add(btnIniciar);
            Controls.Add(lblDuracaoSeg);
            Controls.Add(label5);
            Controls.Add(lblDuracao);
            Controls.Add(label3);
            Controls.Add(lblInicio);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lblInicio;
        private Label lblDuracao;
        private Label label3;
        private Label lblDuracaoSeg;
        private Label label5;
        private Button btnIniciar;
        private Button btnParar;
        private Button btnLimpar;
    }
}
