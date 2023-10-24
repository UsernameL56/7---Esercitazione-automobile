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
    public partial class UserControlAutomatico : UserControl
    {
        AutomobileAutomatica autoAuto;
        int stato;
        public UserControlAutomatico()
        {
            InitializeComponent();
            autoAuto = new AutomobileAutomatica();
            stato = 0;
        }

        private void UserControlAutomatico_Load(object sender, EventArgs e)
        {

        }

        private void Accelerazione_Click(object sender, EventArgs e)
        {
            autoAuto.marciaAuto(1);
            autoAuto.Accelerazione();
            listView1.Clear();
            listView1.Items.Add(Convert.ToString(autoAuto.Velocita));
            label1.Text = "MARCIA: " + Convert.ToString(autoAuto.Marcia);
        }

        private void Decelerazione_Click(object sender, EventArgs e)
        {
            autoAuto.marciaAuto(0);
            autoAuto.Decelerazione();
            listView1.Clear();
            listView1.Items.Add(Convert.ToString(autoAuto.Velocita));
            label1.Text = "MARCIA: " + Convert.ToString(autoAuto.Marcia);
        }

        private void accensione_Click(object sender, EventArgs e)
        {
            stato = autoAuto.accensioneAuto();
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

        private void automatico_Click(object sender, EventArgs e)
        {
            addUserControl(Form1.Panel1, Form1.manuale);
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
