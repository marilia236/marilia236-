namespace Exemplo_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Saudar_Click(object sender, EventArgs e)
        {
            txt_Mensagem.Visible = true;
            btn_Despedir.Enabled = true;
            txt_Mensagem.Text = "Olá Benvindos aos Windows Forms em c#...\r\n0s botões são os maiores";
            txt_Mensagem.Font = new Font("Bookman old Style", 12, FontStyle.Bold);
            txt_Mensagem.BackColor = Color.LightGray;
            txt_Mensagem.ForeColor = Color.DarkBlue;
        }

        private void txt_Mensagem_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_Mensagem.Visible = false; //Esconde a caixa de texto
            btn_Despedir.Enabled = false; //Inibe os boões
            btn_Terminar.Enabled = false;
        }

        private void btn_Despedir_Click(object sender, EventArgs e)
        {
            lbl_Mensagem.Text = "As labels também são as maiores...";
            txt_Mensagem.Text = "Adeus até à próxima...";
            lbl_Mensagem.BackColor = Color.FromArgb(50, 100, 20);
            btn_Terminar.Enabled = true;
            ;
        }

        private void btn_Terminar_Click(object sender, EventArgs e)
        {
            //Close(); //Fecha o form
            Application.Exit(); // Fecha todas as janelas
        }
    }
}
