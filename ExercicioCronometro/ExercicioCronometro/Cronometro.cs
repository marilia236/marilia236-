namespace ExercicioCronometro
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Cronometro
    {
        #region Atributos

        private DateTime _start;

        private DateTime _stop;

        private bool _isrunning;

        #endregion

        //Método
        public void StartClock()
        {
            if (_isrunning)
                //throw new InvalidOperationException("O cronometro já está ligado");

            _start = DateTime.Now;
            _isrunning = true;
        }

        public void StopClock()
        {
            if (!_isrunning)
                throw new InvalidOperationException("O cronometro já está desligado");

            _stop = DateTime.Now;
            _isrunning = false;
        }

        public TimeSpan GetTimeSpan()
        {
            return _stop - _start;
        }

        public bool ClockState()
        {
            return _isrunning;
        }

        public DateTime StartTime()
        {
            return _start;
        }

    }
}