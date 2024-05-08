using ConsoleApp1;

namespace WinFormsApp1;

public partial class Form1 : Form
{
    Carro _boguinhas;

    public Form1()
    {
        InitializeComponent();
    }

    private void btCriarCarro_Click(object sender, EventArgs e)
    {
        _boguinhas = new Carro();

        lblEstado.Text = _boguinhas.Estado;

        btnOnOff.Enabled = true;
    }

    private void btnOnOff_Click(object sender, EventArgs e)
    {
        if (_boguinhas.Ligado)
        {
            _boguinhas.Desligar();
            btnOnOff.Text = "Ligar";
            groupBoxVelocidade.Enabled = false;
            btnAcelera.Enabled = false;
            btnTrava.Enabled = false;
            lblVelocidade.Enabled = false;
            _boguinhas.Velocidade = 0;
        }
        else
        {
            _boguinhas.Ligar();
            btnOnOff.Text = "Desligar";
            groupBoxVelocidade.Enabled = true;
            btnAcelera.Enabled = true;
            btnTrava.Enabled = true;
            lblVelocidade.Enabled = true;
        }
        lblVelocidade.Text = _boguinhas.Velocidade.ToString();
        lblEstado.Text = _boguinhas.Estado;
    }

    private void btnTrava_Click(object sender, EventArgs e)
    {
        _boguinhas.Velocidade--;
        lblVelocidade.Text = _boguinhas.Velocidade.ToString();
    }

    private void btnAcelera_Click(object sender, EventArgs e)
    {
        _boguinhas.Velocidade++;
        lblVelocidade.Text = _boguinhas.Velocidade.ToString();
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
        if (_boguinhas != null)
        {
            FrmConfig frmConfig = new FrmConfig(_boguinhas);
            frmConfig.Show();
        }
    }
}

