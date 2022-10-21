namespace SocketClient
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
            this.label_inviata = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_connessa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_num = new System.Windows.Forms.Label();
            this.label_ric = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_connetti
            // 
            this.button_connetti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_connetti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_connetti.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_connetti.Location = new System.Drawing.Point(303, 36);
            this.button_connetti.Name = "button_connetti";
            this.button_connetti.Size = new System.Drawing.Size(183, 62);
            this.button_connetti.TabIndex = 0;
            this.button_connetti.Text = "Avvia Connessione Client";
            this.button_connetti.UseVisualStyleBackColor = false;
            this.button_connetti.Click += new System.EventHandler(this.button_connetti_Click);
            // 
            // label_inviata
            // 
            this.label_inviata.AutoSize = true;
            this.label_inviata.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_inviata.Location = new System.Drawing.Point(322, 194);
            this.label_inviata.Name = "label_inviata";
            this.label_inviata.Size = new System.Drawing.Size(136, 18);
            this.label_inviata.TabIndex = 5;
            this.label_inviata.Text = "Richiesta Inviata.";
            this.label_inviata.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Socket connessa a:";
            // 
            // label_connessa
            // 
            this.label_connessa.AutoSize = true;
            this.label_connessa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_connessa.Location = new System.Drawing.Point(322, 140);
            this.label_connessa.Name = "label_connessa";
            this.label_connessa.Size = new System.Drawing.Size(0, 16);
            this.label_connessa.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Numero generato dal server:";
            // 
            // label_num
            // 
            this.label_num.AutoSize = true;
            this.label_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_num.Location = new System.Drawing.Point(328, 251);
            this.label_num.Name = "label_num";
            this.label_num.Size = new System.Drawing.Size(0, 16);
            this.label_num.TabIndex = 8;
            // 
            // label_ric
            // 
            this.label_ric.AutoSize = true;
            this.label_ric.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ric.Location = new System.Drawing.Point(277, 329);
            this.label_ric.Name = "label_ric";
            this.label_ric.Size = new System.Drawing.Size(222, 18);
            this.label_ric.TabIndex = 9;
            this.label_ric.Text = "Numero ricevuto dal  server.";
            this.label_ric.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 386);
            this.Controls.Add(this.label_ric);
            this.Controls.Add(this.label_num);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_connessa);
            this.Controls.Add(this.label_inviata);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_connetti);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_connetti;
        private System.Windows.Forms.Label label_inviata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_connessa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_num;
        private System.Windows.Forms.Label label_ric;
    }
}

