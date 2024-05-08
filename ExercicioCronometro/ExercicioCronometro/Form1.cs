namespace ExercicioCronometro
{
    public partial class Form1 : Form
    {
        //Obejto, Composição
        private readonly Cronometro _cronometro;

        public Form1()
        {
            InitializeComponent();
            _cronometro = new Cronometro();
        }

        private void ButtonOnOff_Click(object sender, EventArgs e)
        {
            if (_cronometro.ClockState())
            {
                _cronometro.StopClock();
                ButtonOnOff.Text = "Liga";
                TimerRelogio.Enabled = false;
                //LabelContador.Text = _cronometro.GetTimeSpan().ToString();
            }
            else
            {
                _cronometro.startClock();
                ButtonOnOff.Text = "Desliga";
                TimerRelogio.Enabled = true;
            }
        }

        private void UpdateLabel()
        {
            var tempo = DateTime.Now - _cronometro.StartTime();

            LabelContador.Text = String.Format("{0:D2}:{1:D2}:{2:D2}:{3}", tempo.Hours, tempo.Minutes, tempo.Seconds, tempo.Milliseconds);
        }

        private void TimerRelogio_Tick(object sender, EventArgs e)
        {
            UpdateLabel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
