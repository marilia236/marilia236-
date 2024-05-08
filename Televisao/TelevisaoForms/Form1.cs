using Televisao.Console;

namespace TelevisaoForms
{
    public partial class frmPrincipal : Form
    {
        public Box Meo {get; set;}

        // Uma Propriedade desta propria form classe e um atributo
        //public Box _meo;

        /*
        // deixa de ser propriedade passa a tributo
        Box _meo;

        //propriedade por defeito
        public Box Meo
        {
             get
             {
                 return _meo;
             }
             set
             {
                 _meo = value;
             }
        }
        */

        //Construtor onde vou poder criar a Box, televisão
        public frmPrincipal()
        {
            InitializeComponent();
            //Na prática estou instanciar o objeto 
            Meo = new Box();

            if (Meo != null)
            {
                btnOnOff.Enabled = true;
                lblInfo.Text = Meo.Mensagem;
            }
        }

        //É um Método que vai ligar e desligar
        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if (Meo.Estado)
            {
                Meo.Desligar();
                lblInfo.Text = Meo.Mensagem;
                btnOnOff.Text = "Ligar";

                //Canais
                groupBoxCanais.Enabled = false;
                lblCanal.Text = "-";

                //Volume
                groupBoxVolume.Enabled = false;
                progressBarVolume.Value = 0;
            }
            else
            {
                Meo.Ligar();
                lblInfo.Text = Meo.Mensagem;
                btnOnOff.Text = "Desligar";

                //Canais
                groupBoxCanais.Enabled = true;
                lblCanal.Text = Meo.Canal.ToString();

                //Volume
                groupBoxVolume.Enabled = true;
                progressBarVolume.Value = Meo.Volume;
            }
        }

        private void btnAumentaCanal_Click(object sender, EventArgs e)
        {
            Meo.Canal++;
            lblCanal.Text = Meo.Canal.ToString();
        }

        private void btnDiminuiCanal_Click(object sender, EventArgs e)
        {
            Meo.Canal--;
            lblCanal.Text = Meo.Canal.ToString();
        }

        private void btnDiminueVolume_Click(object sender, EventArgs e)
        {
            Meo.Volume--;
            progressBarVolume.Value = Meo.Volume;
        }

        private void btnAumentaVolume_Click(object sender, EventArgs e)
        {
           Meo.Volume++;
            progressBarVolume.Value = Meo.Volume;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            frmNovaBox frmNova = new frmNovaBox(this);
            frmNova.Show();
        }
    }
}
