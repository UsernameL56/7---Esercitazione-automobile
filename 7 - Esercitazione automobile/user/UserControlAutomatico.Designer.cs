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
            this.SuspendLayout();
            // 
            // statoAccensione
            // 
            this.statoAccensione.AutoSize = true;
            this.statoAccensione.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statoAccensione.Location = new System.Drawing.Point(100, 198);
            this.statoAccensione.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statoAccensione.Name = "statoAccensione";
            this.statoAccensione.Size = new System.Drawing.Size(100, 29);
            this.statoAccensione.TabIndex = 41;
            this.statoAccensione.Text = "STATO";
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(510, 33);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(435, 103);
            this.listView1.TabIndex = 40;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // Decelerazione
            // 
            this.Decelerazione.Location = new System.Drawing.Point(576, 317);
            this.Decelerazione.Margin = new System.Windows.Forms.Padding(4);
            this.Decelerazione.Name = "Decelerazione";
            this.Decelerazione.Size = new System.Drawing.Size(104, 226);
            this.Decelerazione.TabIndex = 39;
            this.Decelerazione.Text = "Decelerazione";
            this.Decelerazione.UseVisualStyleBackColor = true;
            this.Decelerazione.Click += new System.EventHandler(this.Decelerazione_Click);
            // 
            // Accelerazione
            // 
            this.Accelerazione.Location = new System.Drawing.Point(714, 317);
            this.Accelerazione.Margin = new System.Windows.Forms.Padding(4);
            this.Accelerazione.Name = "Accelerazione";
            this.Accelerazione.Size = new System.Drawing.Size(104, 226);
            this.Accelerazione.TabIndex = 38;
            this.Accelerazione.Text = "Accelerazione";
            this.Accelerazione.UseVisualStyleBackColor = true;
            this.Accelerazione.Click += new System.EventHandler(this.Accelerazione_Click);
            // 
            // accensione
            // 
            this.accensione.BackColor = System.Drawing.Color.Red;
            this.accensione.Location = new System.Drawing.Point(135, 231);
            this.accensione.Margin = new System.Windows.Forms.Padding(4);
            this.accensione.Name = "accensione";
            this.accensione.Size = new System.Drawing.Size(120, 109);
            this.accensione.TabIndex = 37;
            this.accensione.Text = "Accensione";
            this.accensione.UseVisualStyleBackColor = false;
            this.accensione.Click += new System.EventHandler(this.accensione_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(963, 412);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 42;
            this.label1.Text = "MARCIA";
            // 
            // automatico
            // 
            this.automatico.Location = new System.Drawing.Point(21, 19);
            this.automatico.Name = "automatico";
            this.automatico.Size = new System.Drawing.Size(127, 81);
            this.automatico.TabIndex = 43;
            this.automatico.Text = "AUTOMATICO";
            this.automatico.UseVisualStyleBackColor = true;
            this.automatico.Click += new System.EventHandler(this.automatico_Click);
            // 
            // UserControlAutomatico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.automatico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statoAccensione);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Decelerazione);
            this.Controls.Add(this.Accelerazione);
            this.Controls.Add(this.accensione);
            this.Name = "UserControlAutomatico";
            this.Size = new System.Drawing.Size(1437, 603);
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
    }
}
