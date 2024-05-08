namespace TelevisaoForms
{
    partial class frmPrincipal
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
            btnOnOff = new Button();
            lblInfo = new Label();
            groupBoxCanais = new GroupBox();
            lblCanal = new Label();
            btnAumentaCanal = new Button();
            btnDiminuiCanal = new Button();
            groupBoxVolume = new GroupBox();
            progressBarVolume = new ProgressBar();
            lblVolume = new Label();
            btnAumentaVolume = new Button();
            btnDiminueVolume = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            groupBoxCanais.SuspendLayout();
            groupBoxVolume.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnOnOff
            // 
            btnOnOff.Enabled = false;
            btnOnOff.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnOnOff.Location = new Point(527, 249);
            btnOnOff.Name = "btnOnOff";
            btnOnOff.Size = new Size(121, 73);
            btnOnOff.TabIndex = 0;
            btnOnOff.Text = "Ligar";
            btnOnOff.UseVisualStyleBackColor = true;
            btnOnOff.Click += btnOnOff_Click;
            // 
            // lblInfo
            // 
            lblInfo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblInfo.Location = new Point(47, 274);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(239, 25);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Não existe nenhuma Box criada!";
            // 
            // groupBoxCanais
            // 
            groupBoxCanais.Controls.Add(lblCanal);
            groupBoxCanais.Controls.Add(btnAumentaCanal);
            groupBoxCanais.Controls.Add(btnDiminuiCanal);
            groupBoxCanais.Enabled = false;
            groupBoxCanais.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxCanais.Location = new Point(381, 35);
            groupBoxCanais.Name = "groupBoxCanais";
            groupBoxCanais.Size = new Size(336, 189);
            groupBoxCanais.TabIndex = 2;
            groupBoxCanais.TabStop = false;
            groupBoxCanais.Text = "Canais";
            // 
            // lblCanal
            // 
            lblCanal.AutoSize = true;
            lblCanal.Location = new Point(161, 61);
            lblCanal.Name = "lblCanal";
            lblCanal.Size = new Size(17, 23);
            lblCanal.TabIndex = 2;
            lblCanal.Text = "-";
            // 
            // btnAumentaCanal
            // 
            btnAumentaCanal.Location = new Point(213, 46);
            btnAumentaCanal.Name = "btnAumentaCanal";
            btnAumentaCanal.Size = new Size(94, 52);
            btnAumentaCanal.TabIndex = 1;
            btnAumentaCanal.Text = "+";
            btnAumentaCanal.UseVisualStyleBackColor = true;
            btnAumentaCanal.Click += btnAumentaCanal_Click;
            // 
            // btnDiminuiCanal
            // 
            btnDiminuiCanal.Location = new Point(19, 46);
            btnDiminuiCanal.Name = "btnDiminuiCanal";
            btnDiminuiCanal.Size = new Size(94, 52);
            btnDiminuiCanal.TabIndex = 0;
            btnDiminuiCanal.Text = "-";
            btnDiminuiCanal.UseVisualStyleBackColor = true;
            btnDiminuiCanal.Click += btnDiminuiCanal_Click;
            // 
            // groupBoxVolume
            // 
            groupBoxVolume.Controls.Add(progressBarVolume);
            groupBoxVolume.Controls.Add(lblVolume);
            groupBoxVolume.Controls.Add(btnAumentaVolume);
            groupBoxVolume.Controls.Add(btnDiminueVolume);
            groupBoxVolume.Enabled = false;
            groupBoxVolume.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxVolume.Location = new Point(24, 35);
            groupBoxVolume.Name = "groupBoxVolume";
            groupBoxVolume.Size = new Size(339, 189);
            groupBoxVolume.TabIndex = 3;
            groupBoxVolume.TabStop = false;
            groupBoxVolume.Text = "Volume";
            // 
            // progressBarVolume
            // 
            progressBarVolume.Location = new Point(23, 103);
            progressBarVolume.Name = "progressBarVolume";
            progressBarVolume.Size = new Size(297, 55);
            progressBarVolume.TabIndex = 6;
            // 
            // lblVolume
            // 
            lblVolume.AutoSize = true;
            lblVolume.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblVolume.Location = new Point(160, 121);
            lblVolume.Name = "lblVolume";
            lblVolume.Size = new Size(17, 23);
            lblVolume.TabIndex = 5;
            lblVolume.Text = "-";
            // 
            // btnAumentaVolume
            // 
            btnAumentaVolume.Location = new Point(206, 48);
            btnAumentaVolume.Name = "btnAumentaVolume";
            btnAumentaVolume.Size = new Size(78, 38);
            btnAumentaVolume.TabIndex = 4;
            btnAumentaVolume.Text = "+";
            btnAumentaVolume.UseVisualStyleBackColor = true;
            btnAumentaVolume.Click += btnAumentaVolume_Click;
            // 
            // btnDiminueVolume
            // 
            btnDiminueVolume.Location = new Point(36, 48);
            btnDiminueVolume.Name = "btnDiminueVolume";
            btnDiminueVolume.Size = new Size(74, 38);
            btnDiminueVolume.TabIndex = 3;
            btnDiminueVolume.Text = "-";
            btnDiminueVolume.UseVisualStyleBackColor = true;
            btnDiminueVolume.Click += btnDiminueVolume_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(738, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "&Nova Box";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(87, 24);
            toolStripMenuItem1.Text = "&Nova Box";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 357);
            Controls.Add(groupBoxVolume);
            Controls.Add(groupBoxCanais);
            Controls.Add(lblInfo);
            Controls.Add(btnOnOff);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "POO-Televisão";
            groupBoxCanais.ResumeLayout(false);
            groupBoxCanais.PerformLayout();
            groupBoxVolume.ResumeLayout(false);
            groupBoxVolume.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOnOff;
        private Label lblInfo;
        private GroupBox groupBoxCanais;
        private Button btnDiminuiCanal;
        private Label lblCanal;
        private Button btnAumentaCanal;
        private GroupBox groupBoxVolume;
        private Label lblVolume;
        private Button btnDiminuiVolume;
        private Button btnAumentaVolume;
        private ProgressBar progressBarVolume;
        private Button btnDiminueVolume;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}
