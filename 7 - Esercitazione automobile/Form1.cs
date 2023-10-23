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
        int marcia, stato;
        public Form1()
        {
            InitializeComponent();
            auto = new Automobile();
            listView1.Items.Add(Convert.ToString(auto.Velocita));
            marcia = 0;
            stato = 0;
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
        private void Decelerazione_Click(object sender, EventArgs e)
        {
            auto.Decelerazione();
            listView1.Clear();
            listView1.Items.Add(Convert.ToString(auto.Velocita));
        }



        private void accensione_Click(object sender, EventArgs e)
        {
            stato = auto.accensioneAuto();
            if (stato == 1)
            {
                statoAccensione.Text = "STATO: Acceso";
                accensione.BackColor = Color.Green;
            }
            else if (stato == 0)
            {
                statoAccensione.Text = "STATO: Spento";
                accensione.BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Per poter spegnere l'auto la velocita' dev'essere pari a 0, e la marcia in folle");
            }
                
        }

        private void folle_Click(object sender, EventArgs e)
        {
            
                marcia = auto.marciaAuto(0);
                if (marcia == 0)
                {
                    prima.BackColor = Color.White;
                    folle.BackColor = Color.Green;
                    seconda.BackColor = Color.White;
                    terza.BackColor = Color.White;
                    quarta.BackColor = Color.White;
                    quinta.BackColor = Color.White;
                    sesta.BackColor = Color.White;
                }
           
           
        }
        private void prima_Click(object sender, EventArgs e)
        {
            if (stato == 1)
            {
                marcia = auto.marciaAuto(1);
                if (marcia == 0)
                {
                    prima.BackColor = Color.Green;
                    folle.BackColor = Color.White;
                    seconda.BackColor = Color.White;
                    terza.BackColor = Color.White;
                    quarta.BackColor = Color.White;
                    quinta.BackColor = Color.White;
                    sesta.BackColor = Color.White;
                }
            }
            else
                MessageBox.Show("L'auto è spenta.", "Informazione");
        }
        private void seconda_Click(object sender, EventArgs e)
        {
            marcia = auto.marciaAuto(2);
            if (marcia == 0)
            {
                prima.BackColor = Color.White;
                folle.BackColor = Color.White;
                seconda.BackColor = Color.Green;
                terza.BackColor = Color.White;
                quarta.BackColor = Color.White;
                quinta.BackColor = Color.White;
                sesta.BackColor = Color.White;
            }
        }
        private void terza_Click(object sender, EventArgs e)
        {
            marcia = auto.marciaAuto(3);
            if (marcia == 0)
            {
                prima.BackColor = Color.White;
                folle.BackColor = Color.White;
                seconda.BackColor = Color.White;
                terza.BackColor = Color.Green;
                quarta.BackColor = Color.White;
                quinta.BackColor = Color.White;
                sesta.BackColor = Color.White;
            }
        }
        private void quarta_Click(object sender, EventArgs e)
        {
            marcia = auto.marciaAuto(4);
            if (marcia == 0)
            {
                prima.BackColor = Color.White;
                folle.BackColor = Color.White;
                seconda.BackColor = Color.White;
                terza.BackColor = Color.White;
                quarta.BackColor = Color.Green;
                quinta.BackColor = Color.White;
                sesta.BackColor = Color.White;
            }
        }
        private void quinta_Click(object sender, EventArgs e)
        {
            marcia = auto.marciaAuto(5);
            if (marcia == 0)
            {
                prima.BackColor = Color.White;
                folle.BackColor = Color.White;
                seconda.BackColor = Color.White;
                terza.BackColor = Color.White;
                quarta.BackColor = Color.White;
                quinta.BackColor = Color.Green;
                sesta.BackColor = Color.White;
            }
        }

        private void sesta_Click(object sender, EventArgs e)
        {
            marcia = auto.marciaAuto(6);
            if (marcia == 0)
            {
                prima.BackColor = Color.White;
                folle.BackColor = Color.White;
                seconda.BackColor = Color.White;
                terza.BackColor = Color.White;
                quarta.BackColor = Color.White;
                quinta.BackColor = Color.White;
                sesta.BackColor = Color.Green;
            }
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
            set { if(value >=0 && value<=6)
                    _marcia = value; }
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
            else if(_velocita == 0  && _marcia == 0)
            {
                return _accensione = 0;
            }else
                return -1;
        }

        public int marciaAuto(int cambio)
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
                _marcia = _marcia;
                return -1;
            }
            return 0;
        }
        public void Accelerazione()
        {
            if(_accensione == 1)
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
