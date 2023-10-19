using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _7___Esercitazione_automobile
{
    
    public partial class Form1 : Form
    {
        Automobile auto;
        public Form1()
        {
            InitializeComponent();
            auto = new Automobile();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            statoAccensione.Text = "STATO: Spento";
        }

        private void Accelerazione_Click(object sender, EventArgs e)
        {
            auto.Accelerazione();
            listView1.Clear();
            listView1.Items.Add(Convert.ToString(auto.Velocita));
        }

        private void prima_Click(object sender, EventArgs e)
        {
            auto.marciaAuto(1);
        }
        private void seconda_Click(object sender, EventArgs e)
        {
            auto.marciaAuto(2);
        }

        private void accensione_Click(object sender, EventArgs e)
        {
            int stato = auto.accensioneAuto();
            if (stato == 1)
                statoAccensione.Text = "STATO: Acceso";
            else
            {
                statoAccensione.Text = "STATO: Spento";

                while (auto.Velocita != 0)
                {
                    auto.Velocita -= 5;
                    Thread.Sleep(500);
                    listView1.Clear();
                    listView1.Items.Add(Convert.ToString(auto.Velocita));
                }
               
            }
                


        }

        private void prima_MouseClick(object sender, MouseEventArgs e)
        {
            prima.BackColor = Color.Green;
            seconda.BackColor = Color.White;
        }

        private void seconda_MouseClick(object sender, MouseEventArgs e)
        {
            prima.BackColor = Color.White;
            seconda.BackColor = Color.Green;
        }
    }

    public class Automobile
    {
        // attributi
        private int _velocita;
        private int _marcia;
        private int _accensione;

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
            set { _velocita = value; }
        }
        public int Marcia
        {
            get { return _marcia; }
            set { _marcia = value; }
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
            else
            {
                return _accensione = 0;
            }
        }

        public void marciaAuto(int cambio)
        {
            if (_marcia + 1 == cambio)
                _marcia = cambio;
            else if (_marcia - 1 == cambio)
                _marcia = cambio;
            else
                _marcia = _marcia;
        }
        public void Accelerazione()
        {
            if(_accensione == 1)
            {
                if (_marcia == 1 && _velocita < 30)
                    _velocita += 5;
                else if (_marcia == 2 &&  _velocita>=30 && _velocita < 60)
                    _velocita += 5;
                else if (_marcia == 3 && _velocita < 70)
                    _velocita += 5;
                else if (_marcia == 4 && _velocita < 90)
                    _velocita += 5;
                else if (_marcia == 5 && _velocita < 110)
                    _velocita += 5;
                else if(_marcia == 6 && _velocita < 130)
                    _velocita += 5;
            }
        }
        public void Decelerazione()
        {
            if (_accensione == 1)
            {
                if (_marcia == 1 && _velocita > 0)
                    _velocita -= 5;
                else if (_marcia == 2 && _velocita > 30)
                    _velocita -= 5;
                else if (_marcia == 3 && _velocita > 60)
                    _velocita -= 5;
                else if (_marcia == 4 && _velocita > 70)
                    _velocita -= 5;
                else if (_marcia == 5 && _velocita > 90)
                    _velocita -= 5;
                else if (_marcia == 6 && _velocita > 110)
                    _velocita -= 5;
            }
        }
    }
}
