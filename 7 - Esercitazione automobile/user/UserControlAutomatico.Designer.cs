namespace _7___Esercitazione_automobile.user
{
    partial class UserControlAutomatico
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
            this.statoAccensione = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Decelerazione = new System.Windows.Forms.Button();
            this.Accelerazione = new System.Windows.Forms.Button();
            this.accensione = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.automatico = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // statoAccensione
            // 
            this.statoAccensione.AutoSize = true;
            this.statoAccensione.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statoAccensione.Location = new System.Drawing.Point(75, 161);
            this.statoAccensione.Name = "statoAccensione";
            this.statoAccensione.Size = new System.Drawing.Size(79, 24);
            this.statoAccensione.TabIndex = 41;
            this.statoAccensione.Text = "STATO";
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(371, 74);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(327, 84);
            this.listView1.TabIndex = 40;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // Decelerazione
            // 
            this.Decelerazione.Location = new System.Drawing.Point(432, 258);
            this.Decelerazione.Name = "Decelerazione";
            this.Decelerazione.Size = new System.Drawing.Size(78, 184);
            this.Decelerazione.TabIndex = 39;
            this.Decelerazione.Text = "Decelerazione";
            this.Decelerazione.UseVisualStyleBackColor = true;
            this.Decelerazione.Click += new System.EventHandler(this.Decelerazione_Click);
            // 
            // Accelerazione
            // 
            this.Accelerazione.Location = new System.Drawing.Point(536, 258);
            this.Accelerazione.Name = "Accelerazione";
            this.Accelerazione.Size = new System.Drawing.Size(78, 184);
            this.Accelerazione.TabIndex = 38;
            this.Accelerazione.Text = "Accelerazione";
            this.Accelerazione.UseVisualStyleBackColor = true;
            this.Accelerazione.Click += new System.EventHandler(this.Accelerazione_Click);
            // 
            // accensione
            // 
            this.accensione.BackColor = System.Drawing.Color.Red;
            this.accensione.Location = new System.Drawing.Point(101, 188);
            this.accensione.Name = "accensione";
            this.accensione.Size = new System.Drawing.Size(90, 89);
            this.accensione.TabIndex = 37;
            this.accensione.Text = "Accensione";
            this.accensione.UseVisualStyleBackColor = false;
            this.accensione.Click += new System.EventHandler(this.accensione_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(714, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "MARCE:";
            // 
            // automatico
            // 
            this.automatico.Location = new System.Drawing.Point(16, 15);
            this.automatico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.automatico.Name = "automatico";
            this.automatico.Size = new System.Drawing.Size(95, 66);
            this.automatico.TabIndex = 43;
            this.automatico.Text = "MANUALE";
            this.automatico.UseVisualStyleBackColor = true;
            this.automatico.Click += new System.EventHandler(this.automatico_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 24);
            this.label2.TabIndex = 44;
            this.label2.Text = "AUTO CAMBIO AUTOMATICO";
            // 
            // UserControlAutomatico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.automatico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statoAccensione);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Decelerazione);
            this.Controls.Add(this.Accelerazione);
            this.Controls.Add(this.accensione);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserControlAutomatico";
            this.Size = new System.Drawing.Size(1078, 490);
            this.Load += new System.EventHandler(this.UserControlAutomatico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statoAccensione;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Decelerazione;
        private System.Windows.Forms.Button Accelerazione;
        private System.Windows.Forms.Button accensione;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button automatico;
        private System.Windows.Forms.Label label2;
    }
}
