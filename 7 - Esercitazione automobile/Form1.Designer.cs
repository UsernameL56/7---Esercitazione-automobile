namespace _7___Esercitazione_automobile
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.accensione = new System.Windows.Forms.Button();
            this.Accelerazione = new System.Windows.Forms.Button();
            this.Decelerazione = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.prima = new System.Windows.Forms.Button();
            this.seconda = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.statoAccensione = new System.Windows.Forms.Label();
            this.folle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accensione
            // 
            this.accensione.Location = new System.Drawing.Point(180, 213);
            this.accensione.Name = "accensione";
            this.accensione.Size = new System.Drawing.Size(109, 97);
            this.accensione.TabIndex = 0;
            this.accensione.Text = "Accensione";
            this.accensione.UseVisualStyleBackColor = true;
            this.accensione.Click += new System.EventHandler(this.accensione_Click);
            // 
            // Accelerazione
            // 
            this.Accelerazione.Location = new System.Drawing.Point(661, 354);
            this.Accelerazione.Name = "Accelerazione";
            this.Accelerazione.Size = new System.Drawing.Size(89, 190);
            this.Accelerazione.TabIndex = 1;
            this.Accelerazione.Text = "Accelerazione";
            this.Accelerazione.UseVisualStyleBackColor = true;
            this.Accelerazione.Click += new System.EventHandler(this.Accelerazione_Click);
            // 
            // Decelerazione
            // 
            this.Decelerazione.Location = new System.Drawing.Point(557, 354);
            this.Decelerazione.Name = "Decelerazione";
            this.Decelerazione.Size = new System.Drawing.Size(89, 190);
            this.Decelerazione.TabIndex = 2;
            this.Decelerazione.Text = "Decelerazione";
            this.Decelerazione.UseVisualStyleBackColor = true;
            this.Decelerazione.Click += new System.EventHandler(this.Decelerazione_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(346, 52);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(613, 91);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // prima
            // 
            this.prima.BackColor = System.Drawing.Color.White;
            this.prima.Location = new System.Drawing.Point(809, 384);
            this.prima.Name = "prima";
            this.prima.Size = new System.Drawing.Size(62, 60);
            this.prima.TabIndex = 4;
            this.prima.Text = "1";
            this.prima.UseVisualStyleBackColor = false;
            this.prima.Click += new System.EventHandler(this.prima_Click);
            this.prima.MouseClick += new System.Windows.Forms.MouseEventHandler(this.prima_MouseClick);
            // 
            // seconda
            // 
            this.seconda.BackColor = System.Drawing.Color.White;
            this.seconda.Location = new System.Drawing.Point(945, 384);
            this.seconda.Name = "seconda";
            this.seconda.Size = new System.Drawing.Size(62, 60);
            this.seconda.TabIndex = 5;
            this.seconda.Text = "2";
            this.seconda.UseVisualStyleBackColor = false;
            this.seconda.Click += new System.EventHandler(this.seconda_Click);
            this.seconda.MouseClick += new System.Windows.Forms.MouseEventHandler(this.seconda_MouseClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(1013, 384);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 60);
            this.button5.TabIndex = 6;
            this.button5.Text = "3";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(1081, 384);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(62, 60);
            this.button6.TabIndex = 7;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(1149, 384);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(62, 60);
            this.button7.TabIndex = 8;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(1217, 384);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(62, 60);
            this.button8.TabIndex = 9;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // statoAccensione
            // 
            this.statoAccensione.AutoSize = true;
            this.statoAccensione.Location = new System.Drawing.Point(320, 250);
            this.statoAccensione.Name = "statoAccensione";
            this.statoAccensione.Size = new System.Drawing.Size(0, 13);
            this.statoAccensione.TabIndex = 10;
            // 
            // folle
            // 
            this.folle.BackColor = System.Drawing.Color.White;
            this.folle.Location = new System.Drawing.Point(877, 384);
            this.folle.Name = "folle";
            this.folle.Size = new System.Drawing.Size(62, 60);
            this.folle.TabIndex = 11;
            this.folle.Text = "N";
            this.folle.UseVisualStyleBackColor = false;
            this.folle.Click += new System.EventHandler(this.folle_Click);
            this.folle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.folle_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 678);
            this.Controls.Add(this.folle);
            this.Controls.Add(this.statoAccensione);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.seconda);
            this.Controls.Add(this.prima);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Decelerazione);
            this.Controls.Add(this.Accelerazione);
            this.Controls.Add(this.accensione);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button accensione;
        private System.Windows.Forms.Button Accelerazione;
        private System.Windows.Forms.Button Decelerazione;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button prima;
        private System.Windows.Forms.Button seconda;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label statoAccensione;
        private System.Windows.Forms.Button folle;
    }
}

