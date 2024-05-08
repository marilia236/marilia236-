
namespace WindowsFormsAlunos
{
    partial class Form1
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
            this.lblIdAluno = new System.Windows.Forms.Label();
            this.txtIdAluno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.AlunoslistBox = new System.Windows.Forms.ListBox();
            this.btnApagarAluno = new System.Windows.Forms.Button();
            this.btnEditarAluno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdAluno
            // 
            this.lblIdAluno.AutoSize = true;
            this.lblIdAluno.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdAluno.Location = new System.Drawing.Point(43, 44);
            this.lblIdAluno.Name = "lblIdAluno";
            this.lblIdAluno.Size = new System.Drawing.Size(113, 25);
            this.lblIdAluno.TabIndex = 0;
            this.lblIdAluno.Text = "Id de aluno:";
            // 
            // txtIdAluno
            // 
            this.txtIdAluno.Enabled = false;
            this.txtIdAluno.Location = new System.Drawing.Point(224, 44);
            this.txtIdAluno.Name = "txtIdAluno";
            this.txtIdAluno.Size = new System.Drawing.Size(196, 22);
            this.txtIdAluno.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do aluno: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apelido do Aluno:";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(221, 132);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(285, 22);
            this.txtNomeAluno.TabIndex = 4;
            // 
            // txtApelido
            // 
            this.txtApelido.Location = new System.Drawing.Point(224, 220);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(282, 22);
            this.txtApelido.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(395, 284);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 43);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(278, 284);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(111, 43);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // AlunoslistBox
            // 
            this.AlunoslistBox.FormattingEnabled = true;
            this.AlunoslistBox.ItemHeight = 16;
            this.AlunoslistBox.Location = new System.Drawing.Point(48, 377);
            this.AlunoslistBox.Name = "AlunoslistBox";
            this.AlunoslistBox.Size = new System.Drawing.Size(667, 164);
            this.AlunoslistBox.TabIndex = 8;
            // 
            // btnApagarAluno
            // 
            this.btnApagarAluno.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarAluno.Location = new System.Drawing.Point(736, 377);
            this.btnApagarAluno.Name = "btnApagarAluno";
            this.btnApagarAluno.Size = new System.Drawing.Size(159, 76);
            this.btnApagarAluno.TabIndex = 9;
            this.btnApagarAluno.Text = "Apagar aluno selecionado";
            this.btnApagarAluno.UseVisualStyleBackColor = true;
            // 
            // btnEditarAluno
            // 
            this.btnEditarAluno.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAluno.Location = new System.Drawing.Point(736, 466);
            this.btnEditarAluno.Name = "btnEditarAluno";
            this.btnEditarAluno.Size = new System.Drawing.Size(159, 75);
            this.btnEditarAluno.TabIndex = 10;
            this.btnEditarAluno.Text = "Editar aluno selecionado";
            this.btnEditarAluno.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 574);
            this.Controls.Add(this.btnEditarAluno);
            this.Controls.Add(this.btnApagarAluno);
            this.Controls.Add(this.AlunoslistBox);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdAluno);
            this.Controls.Add(this.lblIdAluno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdAluno;
        private System.Windows.Forms.TextBox txtIdAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ListBox AlunoslistBox;
        private System.Windows.Forms.Button btnApagarAluno;
        private System.Windows.Forms.Button btnEditarAluno;
    }
}

