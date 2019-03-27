namespace MessengerClient
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SingIn = new System.Windows.Forms.Button();
            this.SingUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(41, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Witaj";
            // 
            // SingIn
            // 
            this.SingIn.Location = new System.Drawing.Point(48, 118);
            this.SingIn.Name = "SingIn";
            this.SingIn.Size = new System.Drawing.Size(75, 23);
            this.SingIn.TabIndex = 1;
            this.SingIn.Text = "Sing In";
            this.SingIn.UseVisualStyleBackColor = true;
            this.SingIn.Click += new System.EventHandler(this.SingIn_Click);
            // 
            // SingUp
            // 
            this.SingUp.Location = new System.Drawing.Point(48, 162);
            this.SingUp.Name = "SingUp";
            this.SingUp.Size = new System.Drawing.Size(75, 23);
            this.SingUp.TabIndex = 2;
            this.SingUp.Text = "Sing Up";
            this.SingUp.UseVisualStyleBackColor = true;
            this.SingUp.Click += new System.EventHandler(this.SingUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 217);
            this.Controls.Add(this.SingUp);
            this.Controls.Add(this.SingIn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SingIn;
        private System.Windows.Forms.Button SingUp;
    }
}

