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
using _7___Esercitazione_automobile.user;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ClassiAuto;

namespace _7___Esercitazione_automobile
{
    
    public partial class Form1 : Form
    {
        
        public static UserControlManuale manuale;
        public static Panel Panel1;

        public Form1()
        {
            InitializeComponent();
            
            manuale = new UserControlManuale();
            Panel1 = panel1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addUserControl(panel1, manuale);
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
