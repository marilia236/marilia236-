namespace WinFormsApp1
{
    partial class FrmConfig
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
            numericUpDownVelocidade = new NumericUpDown();
            label1 = new Label();
            btnOK = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownVelocidade).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownVelocidade
            // 
            numericUpDownVelocidade.Location = new Point(219, 23);
            numericUpDownVelocidade.Name = "numericUpDownVelocidade";
            numericUpDownVelocidade.Size = new Size(150, 27);
            numericUpDownVelocidade.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 23);
            label1.Name = "label1";
            label1.Size = new Size(196, 28);
            label1.TabIndex = 1;
            label1.Text = "Velocidade máxima";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(400, 23);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(127, 29);
            btnOK.TabIndex = 2;
            btnOK.Text = "Ok";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // FrmConfig
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 128);
            Controls.Add(btnOK);
            Controls.Add(label1);
            Controls.Add(numericUpDownVelocidade);
            Name = "FrmConfig";
            Text = "Configurações do carro";
            ((System.ComponentModel.ISupportInitialize)numericUpDownVelocidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownVelocidade;
        private Label label1;
        private Button btnOK;
    }
}