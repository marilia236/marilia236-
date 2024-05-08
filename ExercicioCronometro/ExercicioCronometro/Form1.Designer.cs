namespace ExercicioCronometro
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
            components = new System.ComponentModel.Container();
            ButtonOnOff = new Button();
            LabelContador = new Label();
            TimerRelogio = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // ButtonOnOff
            // 
            ButtonOnOff.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonOnOff.Location = new Point(435, 200);
            ButtonOnOff.Name = "ButtonOnOff";
            ButtonOnOff.Size = new Size(94, 91);
            ButtonOnOff.TabIndex = 0;
            ButtonOnOff.Text = "Ligar";
            ButtonOnOff.UseVisualStyleBackColor = true;
            ButtonOnOff.Click += ButtonOnOff_Click;
            // 
            // LabelContador
            // 
            LabelContador.AutoSize = true;
            LabelContador.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            LabelContador.Location = new Point(208, 113);
            LabelContador.Name = "LabelContador";
            LabelContador.Size = new Size(117, 20);
            LabelContador.TabIndex = 1;
            LabelContador.Text = "00:00:00:000";
            // 
            // TimerRelogio
            // 
            TimerRelogio.Interval = 30;
            TimerRelogio.Tick += TimerRelogio_Tick;
            // 
            // Form1
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(565, 326);
            Controls.Add(LabelContador);
            Controls.Add(ButtonOnOff);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.Manual;
            Text = "Form1";
            TransparencyKey = Color.White;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonOnOff;
        private Label LabelContador;
        private System.Windows.Forms.Timer TimerRelogio;
    }
}
