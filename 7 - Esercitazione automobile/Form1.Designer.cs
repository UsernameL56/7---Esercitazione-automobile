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
            this.terza = new System.Windows.Forms.Button();
            this.quarta = new System.Windows.Forms.Button();
            this.quinta = new System.Windows.Forms.Button();
            this.sesta = new System.Windows.Forms.Button();
            this.statoAccensione = new System.Windows.Forms.Label();
            this.folle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // accensione
            // 
            this.accensione.BackColor = System.Drawing.Color.Red;
            this.accensione.Location = new System.Drawing.Point(83, 228);
            this.accensione.Margin = new System.Windows.Forms.Padding(4);
            this.accensione.Name = "accensione";
            this.accensione.Size = new System.Drawing.Size(120, 109);
            this.accensione.TabIndex = 0;
            this.accensione.Text = "Accensione";
            this.accensione.UseVisualStyleBackColor = false;
            this.accensione.Click += new System.EventHandler(this.accensione_Click);
            // 
            // Accelerazione
            // 
            this.Accelerazione.Location = new System.Drawing.Point(662, 314);
            this.Accelerazione.Margin = new System.Windows.Forms.Padding(4);
            this.Accelerazione.Name = "Accelerazione";
            this.Accelerazione.Size = new System.Drawing.Size(104, 226);
            this.Accelerazione.TabIndex = 1;
            this.Accelerazione.Text = "Accelerazione";
            this.Accelerazione.UseVisualStyleBackColor = true;
            this.Accelerazione.Click += new System.EventHandler(this.Accelerazione_Click);
            // 
            // Decelerazione
            // 
            this.Decelerazione.Location = new System.Drawing.Point(524, 314);
            this.Decelerazione.Margin = new System.Windows.Forms.Padding(4);
            this.Decelerazione.Name = "Decelerazione";
            this.Decelerazione.Size = new System.Drawing.Size(104, 226);
            this.Decelerazione.TabIndex = 2;
            this.Decelerazione.Text = "Decelerazione";
            this.Decelerazione.UseVisualStyleBackColor = true;
            this.Decelerazione.Click += new System.EventHandler(this.Decelerazione_Click);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(500, 29);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(281, 103);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // prima
            // 
            this.prima.BackColor = System.Drawing.Color.White;
            this.prima.Location = new System.Drawing.Point(902, 314);
            this.prima.Margin = new System.Windows.Forms.Padding(4);
            this.prima.Name = "prima";
            this.prima.Size = new System.Drawing.Size(68, 66);
            this.prima.TabIndex = 4;
            this.prima.Text = "1";
            this.prima.UseVisualStyleBackColor = false;
            this.prima.Click += new System.EventHandler(this.prima_Click);
            // 
            // seconda
            // 
            this.seconda.BackColor = System.Drawing.Color.White;
            this.seconda.Location = new System.Drawing.Point(1083, 314);
            this.seconda.Margin = new System.Windows.Forms.Padding(4);
            this.seconda.Name = "seconda";
            this.seconda.Size = new System.Drawing.Size(68, 66);
            this.seconda.TabIndex = 5;
            this.seconda.Text = "2";
            this.seconda.UseVisualStyleBackColor = false;
            this.seconda.Click += new System.EventHandler(this.seconda_Click);
            // 
            // terza
            // 
            this.terza.BackColor = System.Drawing.Color.White;
            this.terza.Location = new System.Drawing.Point(1174, 314);
            this.terza.Margin = new System.Windows.Forms.Padding(4);
            this.terza.Name = "terza";
            this.terza.Size = new System.Drawing.Size(68, 66);
            this.terza.TabIndex = 6;
            this.terza.Text = "3";
            this.terza.UseVisualStyleBackColor = false;
            this.terza.Click += new System.EventHandler(this.terza_Click);
            // 
            // quarta
            // 
            this.quarta.BackColor = System.Drawing.Color.White;
            this.quarta.Location = new System.Drawing.Point(948, 408);
            this.quarta.Margin = new System.Windows.Forms.Padding(4);
            this.quarta.Name = "quarta";
            this.quarta.Size = new System.Drawing.Size(68, 66);
            this.quarta.TabIndex = 7;
            this.quarta.Text = "4";
            this.quarta.UseVisualStyleBackColor = false;
            this.quarta.Click += new System.EventHandler(this.quarta_Click);
            // 
            // quinta
            // 
            this.quinta.BackColor = System.Drawing.Color.White;
            this.quinta.Location = new System.Drawing.Point(1039, 408);
            this.quinta.Margin = new System.Windows.Forms.Padding(4);
            this.quinta.Name = "quinta";
            this.quinta.Size = new System.Drawing.Size(68, 66);
            this.quinta.TabIndex = 8;
            this.quinta.Text = "5";
            this.quinta.UseVisualStyleBackColor = false;
            this.quinta.Click += new System.EventHandler(this.quinta_Click);
            // 
            // sesta
            // 
            this.sesta.BackColor = System.Drawing.Color.White;
            this.sesta.Location = new System.Drawing.Point(1130, 408);
            this.sesta.Margin = new System.Windows.Forms.Padding(4);
            this.sesta.Name = "sesta";
            this.sesta.Size = new System.Drawing.Size(68, 66);
            this.sesta.TabIndex = 9;
            this.sesta.Text = "6";
            this.sesta.UseVisualStyleBackColor = false;
            this.sesta.Click += new System.EventHandler(this.sesta_Click);
            // 
            // statoAccensione
            // 
            this.statoAccensione.AutoSize = true;
            this.statoAccensione.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statoAccensione.Location = new System.Drawing.Point(48, 195);
            this.statoAccensione.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statoAccensione.Name = "statoAccensione";
            this.statoAccensione.Size = new System.Drawing.Size(100, 29);
            this.statoAccensione.TabIndex = 10;
            this.statoAccensione.Text = "STATO";
            // 
            // folle
            // 
            this.folle.BackColor = System.Drawing.Color.Green;
            this.folle.Location = new System.Drawing.Point(992, 314);
            this.folle.Margin = new System.Windows.Forms.Padding(4);
            this.folle.Name = "folle";
            this.folle.Size = new System.Drawing.Size(68, 66);
            this.folle.TabIndex = 11;
            this.folle.Text = "N";
            this.folle.UseVisualStyleBackColor = false;
            this.folle.Click += new System.EventHandler(this.folle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1034, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "MARCE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 607);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button terza;
        private System.Windows.Forms.Button quarta;
        private System.Windows.Forms.Button quinta;
        private System.Windows.Forms.Button sesta;
        private System.Windows.Forms.Label statoAccensione;
        private System.Windows.Forms.Button folle;
        private System.Windows.Forms.Label label1;
    }
}

