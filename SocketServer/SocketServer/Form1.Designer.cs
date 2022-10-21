namespace SocketServer
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
            this.button_connetti = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_connessione = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_invio = new System.Windows.Forms.Label();
            this.label_ric = new System.Windows.Forms.Label();
            this.label_num = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_connetti
            // 
            this.button_connetti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_connetti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_connetti.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_connetti.Location = new System.Drawing.Point(292, 47);
            this.button_connetti.Name = "button_connetti";
            this.button_connetti.Size = new System.Drawing.Size(190, 53);
            this.button_connetti.TabIndex = 0;
            this.button_connetti.Text = "Avvia Connessione Server";
            this.button_connetti.UseVisualStyleBackColor = false;
            this.button_connetti.Click += new System.EventHandler(this.button_connetti_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stato connessione:";
            // 
            // label_connessione
            // 
            this.label_connessione.AutoSize = true;
            this.label_connessione.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_connessione.ForeColor = System.Drawing.Color.Red;
            this.label_connessione.Location = new System.Drawing.Point(313, 145);
            this.label_connessione.Name = "label_connessione";
            this.label_connessione.Size = new System.Drawing.Size(95, 16);
            this.label_connessione.TabIndex = 2;
            this.label_connessione.Text = "Non connesso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Richiesta ricevuta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero generato:";
            // 
            // label_invio
            // 
            this.label_invio.AutoSize = true;
            this.label_invio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_invio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_invio.Location = new System.Drawing.Point(291, 311);
            this.label_invio.Name = "label_invio";
            this.label_invio.Size = new System.Drawing.Size(0, 18);
            this.label_invio.TabIndex = 5;
            // 
            // label_ric
            // 
            this.label_ric.AutoSize = true;
            this.label_ric.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ric.Location = new System.Drawing.Point(313, 189);
            this.label_ric.Name = "label_ric";
            this.label_ric.Size = new System.Drawing.Size(0, 16);
            this.label_ric.TabIndex = 6;
            // 
            // label_num
            // 
            this.label_num.AutoSize = true;
            this.label_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_num.Location = new System.Drawing.Point(313, 235);
            this.label_num.Name = "label_num";
            this.label_num.Size = new System.Drawing.Size(0, 16);
            this.label_num.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 394);
            this.Controls.Add(this.label_num);
            this.Controls.Add(this.label_ric);
            this.Controls.Add(this.label_invio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_connessione);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_connetti);
            this.Name = "Form1";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_connetti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_connessione;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_invio;
        private System.Windows.Forms.Label label_ric;
        private System.Windows.Forms.Label label_num;
    }
}

