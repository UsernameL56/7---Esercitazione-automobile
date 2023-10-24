namespace _7___Esercitazione_automobile.user
{
    partial class UserControlManuale
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

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.folle = new System.Windows.Forms.Button();
            this.statoAccensione = new System.Windows.Forms.Label();
            this.sesta = new System.Windows.Forms.Button();
            this.quinta = new System.Windows.Forms.Button();
            this.quarta = new System.Windows.Forms.Button();
            this.terza = new System.Windows.Forms.Button();
            this.seconda = new System.Windows.Forms.Button();
            this.prima = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Decelerazione = new System.Windows.Forms.Button();
            this.Accelerazione = new System.Windows.Forms.Button();
            this.accensione = new System.Windows.Forms.Button();
            this.manuale = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(830, 228);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 38;
            this.label1.Text = "MARCE";
            // 
            // folle
            // 
            this.folle.BackColor = System.Drawing.Color.Green;
            this.folle.Location = new System.Drawing.Point(799, 269);
            this.folle.Name = "folle";
            this.folle.Size = new System.Drawing.Size(51, 54);
            this.folle.TabIndex = 37;
            this.folle.Text = "N";
            this.folle.UseVisualStyleBackColor = false;
            this.folle.Click += new System.EventHandler(this.folle_Click);
            // 
            // statoAccensione
            // 
            this.statoAccensione.AutoSize = true;
            this.statoAccensione.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statoAccensione.Location = new System.Drawing.Point(91, 172);
            this.statoAccensione.Name = "statoAccensione";
            this.statoAccensione.Size = new System.Drawing.Size(79, 24);
            this.statoAccensione.TabIndex = 36;
            this.statoAccensione.Text = "STATO";
            // 
            // sesta
            // 
            this.sesta.BackColor = System.Drawing.Color.White;
            this.sesta.Location = new System.Drawing.Point(902, 345);
            this.sesta.Name = "sesta";
            this.sesta.Size = new System.Drawing.Size(51, 54);
            this.sesta.TabIndex = 35;
            this.sesta.Text = "6";
            this.sesta.UseVisualStyleBackColor = false;
            this.sesta.Click += new System.EventHandler(this.sesta_Click);
            // 
            // quinta
            // 
            this.quinta.BackColor = System.Drawing.Color.White;
            this.quinta.Location = new System.Drawing.Point(834, 345);
            this.quinta.Name = "quinta";
            this.quinta.Size = new System.Drawing.Size(51, 54);
            this.quinta.TabIndex = 34;
            this.quinta.Text = "5";
            this.quinta.UseVisualStyleBackColor = false;
            this.quinta.Click += new System.EventHandler(this.quinta_Click);
            // 
            // quarta
            // 
            this.quarta.BackColor = System.Drawing.Color.White;
            this.quarta.Location = new System.Drawing.Point(766, 345);
            this.quarta.Name = "quarta";
            this.quarta.Size = new System.Drawing.Size(51, 54);
            this.quarta.TabIndex = 33;
            this.quarta.Text = "4";
            this.quarta.UseVisualStyleBackColor = false;
            this.quarta.Click += new System.EventHandler(this.quarta_Click);
            // 
            // terza
            // 
            this.terza.BackColor = System.Drawing.Color.White;
            this.terza.Location = new System.Drawing.Point(935, 269);
            this.terza.Name = "terza";
            this.terza.Size = new System.Drawing.Size(51, 54);
            this.terza.TabIndex = 32;
            this.terza.Text = "3";
            this.terza.UseVisualStyleBackColor = false;
            this.terza.Click += new System.EventHandler(this.terza_Click);
            // 
            // seconda
            // 
            this.seconda.BackColor = System.Drawing.Color.White;
            this.seconda.Location = new System.Drawing.Point(867, 269);
            this.seconda.Name = "seconda";
            this.seconda.Size = new System.Drawing.Size(51, 54);
            this.seconda.TabIndex = 31;
            this.seconda.Text = "2";
            this.seconda.UseVisualStyleBackColor = false;
            this.seconda.Click += new System.EventHandler(this.seconda_Click);
            // 
            // prima
            // 
            this.prima.BackColor = System.Drawing.Color.White;
            this.prima.Location = new System.Drawing.Point(731, 269);
            this.prima.Name = "prima";
            this.prima.Size = new System.Drawing.Size(51, 54);
            this.prima.TabIndex = 30;
            this.prima.Text = "1";
            this.prima.UseVisualStyleBackColor = false;
            this.prima.Click += new System.EventHandler(this.prima_Click);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(383, 74);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(327, 84);
            this.listView1.TabIndex = 29;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // Decelerazione
            // 
            this.Decelerazione.Location = new System.Drawing.Point(448, 269);
            this.Decelerazione.Name = "Decelerazione";
            this.Decelerazione.Size = new System.Drawing.Size(78, 184);
            this.Decelerazione.TabIndex = 28;
            this.Decelerazione.Text = "Decelerazione";
            this.Decelerazione.UseVisualStyleBackColor = true;
            this.Decelerazione.Click += new System.EventHandler(this.Decelerazione_Click_1);
            // 
            // Accelerazione
            // 
            this.Accelerazione.Location = new System.Drawing.Point(551, 269);
            this.Accelerazione.Name = "Accelerazione";
            this.Accelerazione.Size = new System.Drawing.Size(78, 184);
            this.Accelerazione.TabIndex = 27;
            this.Accelerazione.Text = "Accelerazione";
            this.Accelerazione.UseVisualStyleBackColor = true;
            this.Accelerazione.Click += new System.EventHandler(this.Accelerazione_Click_1);
            // 
            // accensione
            // 
            this.accensione.BackColor = System.Drawing.Color.Red;
            this.accensione.Location = new System.Drawing.Point(117, 199);
            this.accensione.Name = "accensione";
            this.accensione.Size = new System.Drawing.Size(90, 89);
            this.accensione.TabIndex = 26;
            this.accensione.Text = "Accensione";
            this.accensione.UseVisualStyleBackColor = false;
            this.accensione.Click += new System.EventHandler(this.accensione_Click_1);
            // 
            // manuale
            // 
            this.manuale.Location = new System.Drawing.Point(16, 14);
            this.manuale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.manuale.Name = "manuale";
            this.manuale.Size = new System.Drawing.Size(95, 66);
            this.manuale.TabIndex = 39;
            this.manuale.Text = "AUTOMATICO";
            this.manuale.UseVisualStyleBackColor = true;
            this.manuale.Click += new System.EventHandler(this.manuale_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(379, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 24);
            this.label2.TabIndex = 45;
            this.label2.Text = "AUTO CAMBIO MANUALE";
            // 
            // UserControlManuale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.manuale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.folle);
            this.Controls.Add(this.statoAccensione);
            this.Controls.Add(this.sesta);
            this.Controls.Add(this.quinta);
            this.Controls.Add(this.quarta);
            this.Controls.Add(this.terza);
            this.Controls.Add(this.seconda);
            this.Controls.Add(this.prima);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Decelerazione);
            this.Controls.Add(this.Accelerazione);
            this.Controls.Add(this.accensione);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControlManuale";
            this.Size = new System.Drawing.Size(1078, 490);
            this.Load += new System.EventHandler(this.UserControlManuale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button folle;
        private System.Windows.Forms.Label statoAccensione;
        private System.Windows.Forms.Button sesta;
        private System.Windows.Forms.Button quinta;
        private System.Windows.Forms.Button quarta;
        private System.Windows.Forms.Button terza;
        private System.Windows.Forms.Button seconda;
        private System.Windows.Forms.Button prima;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Decelerazione;
        private System.Windows.Forms.Button Accelerazione;
        private System.Windows.Forms.Button accensione;
        private System.Windows.Forms.Button manuale;
        private System.Windows.Forms.Label label2;
    }
}
