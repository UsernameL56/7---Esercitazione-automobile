using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassiAuto
{
    internal class Class2
    {
    }
    public class AutomobileAutomatica : Automobile
    {
        public AutomobileAutomatica()
        {
            Velocita = 0;
            Marcia = 0;
            Accensione = 0;
        }
        public override int marciaAuto(int val)
        {
            if (_accensione == 1 && _velocita == 0 && _marcia == 0)
                _marcia = 1;
            else if (_velocita == (30 + 20 * (_marcia - 1)) && _velocita < 130 && val == 1)
                _marcia++;
            else if (_velocita == (30 + 20 * Math.Abs(_marcia - 2)) && val == 0)
                _marcia--;
            else if (_marcia == 1 && _velocita == 0)
                _marcia = 0;
            else
            {
                return -1;
            }
            return 0;
        }
    }
}
