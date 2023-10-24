using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassiAuto
{
    public static class Class1
    {
    }

    public class Automobile
    {
        // attributi
        protected int _velocita;
        protected int _marcia;
        protected int _accensione;

        // costruttore
        public Automobile()
        {
            Velocita = 0;
            Marcia = 0;
            Accensione = 0;
        }

        // metodi accessor
        public int Velocita
        {
            get { return _velocita; }
            set 
            {
                if(value >= 0)
                    _velocita = value; 
            }
        }
        public int Marcia
        {
            get { return _marcia; }
            set
            {
                if (value >= 0 && value <= 6)
                    _marcia = value;
            }
        }
        public int Accensione
        {
            get { return _accensione; }
            set { _accensione = value; }
        }

        // metodi

        public int accensioneAuto()
        {
            if (_accensione == 0 && _velocita == 0)
                return _accensione = 1;
            else if (_velocita == 0 && _marcia == 0)
            {
                return _accensione = 0;
            }
            else
                return -1;
        }

        public virtual int marciaAuto(int cambio)
        {
            if (_marcia == 0 && cambio == 1)
                _marcia = cambio;
            else if (_velocita >= (30 + 20 * (_marcia - 1)) && _marcia + 1 == cambio)
                _marcia = cambio;
            else if (_velocita <= (30 + 20 * (_marcia - 2)) && _marcia - 1 == cambio && cambio != 0)
                _marcia = cambio;
            else if (_marcia == 1 && cambio == 0 && _velocita == 0)
                _marcia = cambio;
            else
            {
                return -1;
            }
            return 0;
        }
        public void Accelerazione()
        {
            if (_accensione == 1)
            {
                if (_marcia == 1 && _velocita < 30)
                    _velocita += 5;
                else if (_marcia == 2 && _velocita >= 30 && _velocita < 50)
                    _velocita += 5;
                else if (_marcia == 3 && _velocita >= 50 && _velocita < 70)
                    _velocita += 5;
                else if (_marcia == 4 && _velocita >= 70 && _velocita < 90)
                    _velocita += 5;
                else if (_marcia == 5 && _velocita >= 90 && _velocita < 110)
                    _velocita += 5;
                else if (_marcia == 6 && _velocita >= 110 && _velocita < 130)
                    _velocita += 5;
            }
        }
        public void Decelerazione()
        {
            if (_accensione == 1)
            {
                if (_marcia == 1 && _velocita > 0 && _velocita <= 30)
                    _velocita -= 5;
                else if (_marcia == 2 && _velocita > 30 && _velocita <= 50)
                    _velocita -= 5;
                else if (_marcia == 3 && _velocita > 50 && _velocita <= 70)
                    _velocita -= 5;
                else if (_marcia == 4 && _velocita > 70 && _velocita <= 90)
                    _velocita -= 5;
                else if (_marcia == 5 && _velocita > 90 && _velocita <= 110)
                    _velocita -= 5;
                else if (_marcia == 6 && _velocita > 110)
                    _velocita -= 5;
            }
        }
    }
}
