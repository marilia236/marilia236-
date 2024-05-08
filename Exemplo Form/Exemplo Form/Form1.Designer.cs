namespace Exemplo_Form
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
            btn_Saudar = new Button();
            btn_Despedir = new Button();
            btn_Terminar = new Button();
            txt_Mensagem = new TextBox();
            lbl_Mensagem = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Gainsboro;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(28, 21);
            label1.Name = "label1";
            label1.Size = new Size(748, 53);
            label1.TabIndex = 0;
            label1.Text = "Prima um Botão para Selecionar uma Mensagem";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Saudar
            // 
            btn_Saudar.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Saudar.Location = new Point(28, 103);
            btn_Saudar.Name = "btn_Saudar";
            btn_Saudar.Size = new Size(160, 48);
            btn_Saudar.TabIndex = 1;
            btn_Saudar.Text = "Saudar";
            btn_Saudar.UseVisualStyleBackColor = true;
            btn_Saudar.Click += btn_Saudar_Click;
            // 
            // btn_Despedir
            // 
            btn_Despedir.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Despedir.Location = new Point(28, 154);
            btn_Despedir.Name = "btn_Despedir";
            btn_Despedir.Size = new Size(160, 48);
            btn_Despedir.TabIndex = 2;
            btn_Despedir.Text = "Despedir";
            btn_Despedir.UseVisualStyleBackColor = true;
            btn_Despedir.Click += btn_Despedir_Click;
            // 
            // btn_Terminar
            // 
            btn_Terminar.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Terminar.Location = new Point(28, 205);
            btn_Terminar.Name = "btn_Terminar";
            btn_Terminar.Size = new Size(160, 48);
            btn_Terminar.TabIndex = 3;
            btn_Terminar.Text = "Terminar";
            btn_Terminar.UseVisualStyleBackColor = true;
            btn_Terminar.Click += btn_Terminar_Click;
            // 
            // txt_Mensagem
            // 
            txt_Mensagem.Location = new Point(221, 106);
            txt_Mensagem.Multiline = true;
            txt_Mensagem.Name = "txt_Mensagem";
            txt_Mensagem.Size = new Size(567, 94);
            txt_Mensagem.TabIndex = 4;
            txt_Mensagem.TextChanged += txt_Mensagem_TextChanged;
            // 
            // lbl_Mensagem
            // 
            lbl_Mensagem.AutoSize = true;
            lbl_Mensagem.Location = new Point(222, 214);
            lbl_Mensagem.Name = "lbl_Mensagem";
            lbl_Mensagem.Size = new Size(0, 20);
            lbl_Mensagem.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_Mensagem);
            Controls.Add(txt_Mensagem);
            Controls.Add(btn_Terminar);
            Controls.Add(btn_Despedir);
            Controls.Add(btn_Saudar);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Botões e Caixas  de Texto e Labels";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Saudar;
        private Button btn_Despedir;
        private Button btn_Terminar;
        private TextBox txt_Mensagem;
        private Label lbl_Mensagem;
    }
}
