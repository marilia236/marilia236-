namespace TelevisaoForms
{
    partial class frmNovaBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOk = new Button();
            label1 = new Label();
            numericUpDownCanais = new NumericUpDown();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCanais).BeginInit();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnOk.Location = new Point(570, 189);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(117, 84);
            btnOk.TabIndex = 0;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 115);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 1;
            label1.Text = "Número de canais";
            // 
            // numericUpDownCanais
            // 
            numericUpDownCanais.Location = new Point(159, 115);
            numericUpDownCanais.Name = "numericUpDownCanais";
            numericUpDownCanais.Size = new Size(248, 27);
            numericUpDownCanais.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(417, 190);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(117, 84);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmNovaBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(722, 300);
            Controls.Add(btnCancelar);
            Controls.Add(numericUpDownCanais);
            Controls.Add(label1);
            Controls.Add(btnOk);
            Name = "frmNovaBox";
            Text = "Nova Box";
            Load += frmNovaBox_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownCanais).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private Label label1;
        private NumericUpDown numericUpDownCanais;
        private Button btnCancelar;
    }
}