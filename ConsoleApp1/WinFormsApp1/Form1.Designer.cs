namespace WinFormsApp1
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
            btCriarCarro = new Button();
            lblEstado = new Label();
            btnOnOff = new Button();
            groupBoxVelocidade = new GroupBox();
            lblVelocidade = new Label();
            btnAcelera = new Button();
            btnTrava = new Button();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            groupBoxVelocidade.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btCriarCarro
            // 
            btCriarCarro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btCriarCarro.Location = new Point(609, 308);
            btCriarCarro.Name = "btCriarCarro";
            btCriarCarro.Size = new Size(112, 82);
            btCriarCarro.TabIndex = 0;
            btCriarCarro.Text = "Construir carro";
            btCriarCarro.UseVisualStyleBackColor = true;
            btCriarCarro.Click += btCriarCarro_Click;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstado.Location = new Point(61, 342);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(70, 28);
            lblEstado.TabIndex = 1;
            lblEstado.Text = "label1";
            // 
            // btnOnOff
            // 
            btnOnOff.Enabled = false;
            btnOnOff.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOnOff.Location = new Point(609, 201);
            btnOnOff.Name = "btnOnOff";
            btnOnOff.Size = new Size(112, 82);
            btnOnOff.TabIndex = 2;
            btnOnOff.Text = "Ligar";
            btnOnOff.UseVisualStyleBackColor = true;
            btnOnOff.Click += btnOnOff_Click;
            // 
            // groupBoxVelocidade
            // 
            groupBoxVelocidade.Controls.Add(lblVelocidade);
            groupBoxVelocidade.Controls.Add(btnAcelera);
            groupBoxVelocidade.Controls.Add(btnTrava);
            groupBoxVelocidade.Enabled = false;
            groupBoxVelocidade.Location = new Point(341, 39);
            groupBoxVelocidade.Name = "groupBoxVelocidade";
            groupBoxVelocidade.Size = new Size(428, 139);
            groupBoxVelocidade.TabIndex = 3;
            groupBoxVelocidade.TabStop = false;
            groupBoxVelocidade.Text = "Velocidade";
            // 
            // lblVelocidade
            // 
            lblVelocidade.AutoSize = true;
            lblVelocidade.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblVelocidade.Location = new Point(178, 39);
            lblVelocidade.Name = "lblVelocidade";
            lblVelocidade.Size = new Size(24, 28);
            lblVelocidade.TabIndex = 5;
            lblVelocidade.Text = "0";
            // 
            // btnAcelera
            // 
            btnAcelera.Enabled = false;
            btnAcelera.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAcelera.Location = new Point(316, 26);
            btnAcelera.Name = "btnAcelera";
            btnAcelera.Size = new Size(49, 48);
            btnAcelera.TabIndex = 4;
            btnAcelera.Text = "+";
            btnAcelera.UseVisualStyleBackColor = true;
            btnAcelera.Click += btnAcelera_Click;
            // 
            // btnTrava
            // 
            btnTrava.Enabled = false;
            btnTrava.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnTrava.Location = new Point(23, 26);
            btnTrava.Name = "btnTrava";
            btnTrava.Size = new Size(49, 48);
            btnTrava.TabIndex = 3;
            btnTrava.Text = "-";
            btnTrava.UseVisualStyleBackColor = true;
            btnTrava.Click += btnTrava_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 4;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(groupBoxVelocidade);
            Controls.Add(btnOnOff);
            Controls.Add(lblEstado);
            Controls.Add(btCriarCarro);
            Name = "Form1";
            Text = "Form1";
            groupBoxVelocidade.ResumeLayout(false);
            groupBoxVelocidade.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btCriarCarro;
        private Label lblEstado;
        private Button btnOnOff;
        private GroupBox groupBoxVelocidade;
        private Button btnTrava;
        private Button btnAcelera;
        private Label lblVelocidade;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
    }
}
