using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassiAuto;

namespace _7___Esercitazione_automobile.user
{
    public partial class UserControlManuale : UserControl
    {
        Automobile auto;
        int marcia, stato;
        public UserControlManuale()
        {
            InitializeComponent();
            auto = new Automobile();
            listView1.Items.Add(Convert.ToString(auto.Velocita));
            marcia = 0;
            stato = 0;
        }

        private void UserControlManuale_Load(object sender, EventArgs e)
        {
            statoAccensione.Text = "STATO: Spento";
        }


        private void accensione_Click_1(object sender, EventArgs e)
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
        private void Decelerazione_Click_1(object sender, EventArgs e)
        {
            auto.Decelerazione();
            listView1.Clear();
            listView1.Items.Add(Convert.ToString(auto.Velocita));
        }

        private void Accelerazione_Click_1(object sender, EventArgs e)
        {
            auto.Accelerazione();
            listView1.Clear();
            listView1.Items.Add(Convert.ToString(auto.Velocita));
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
       
        private void manuale_Click(object sender, EventArgs e)
        {
            addUserControl(Form1.Panel1, Form1.automatico);
        }
        public static void addUserControl(Panel panel1, UserControl userControl)
        {
            //impostazione del UserControl al centro e con riempimento di tutto il panel
            userControl.Dock = DockStyle.Fill;
            //rimozione dell'UserControl attuale dal panel
            panel1.Controls.Clear();
            //aggiunta del nuovo UserControl al panel
            panel1.Controls.Add(userControl);
            //imposta l'UserControl al primo piano
            userControl.BringToFront();
        }
    }
}
