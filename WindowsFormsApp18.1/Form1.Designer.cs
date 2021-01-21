
namespace WindowsFormsApp18._1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelRekeningnaam = new System.Windows.Forms.Label();
            this.txtRek = new System.Windows.Forms.TextBox();
            this.btnRekPlus = new System.Windows.Forms.Button();
            this.btnRekMin = new System.Windows.Forms.Button();
            this.btnSRekMin = new System.Windows.Forms.Button();
            this.btnSRekPlus = new System.Windows.Forms.Button();
            this.txtSpaarRek = new System.Windows.Forms.TextBox();
            this.labelSpaarrekeningnaam = new System.Windows.Forms.Label();
            this.btnZichtRekMin = new System.Windows.Forms.Button();
            this.btnZichtRekPlus = new System.Windows.Forms.Button();
            this.txtZichtRek = new System.Windows.Forms.TextBox();
            this.labelZichtrekeningnaam = new System.Windows.Forms.Label();
            this.btnRente = new System.Windows.Forms.Button();
            this.labelRekeningSaldo = new System.Windows.Forms.Label();
            this.labelSpaarRekeningSaldoRente = new System.Windows.Forms.Label();
            this.labelZichtRekeningSaldo = new System.Windows.Forms.Label();
            this.btnEquals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRekeningnaam
            // 
            this.labelRekeningnaam.AutoSize = true;
            this.labelRekeningnaam.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRekeningnaam.Location = new System.Drawing.Point(13, 13);
            this.labelRekeningnaam.Name = "labelRekeningnaam";
            this.labelRekeningnaam.Size = new System.Drawing.Size(89, 20);
            this.labelRekeningnaam.TabIndex = 0;
            this.labelRekeningnaam.Text = "Rekening";
            // 
            // txtRek
            // 
            this.txtRek.Location = new System.Drawing.Point(16, 34);
            this.txtRek.Name = "txtRek";
            this.txtRek.Size = new System.Drawing.Size(269, 22);
            this.txtRek.TabIndex = 1;
            // 
            // btnRekPlus
            // 
            this.btnRekPlus.Location = new System.Drawing.Point(291, 23);
            this.btnRekPlus.Name = "btnRekPlus";
            this.btnRekPlus.Size = new System.Drawing.Size(75, 44);
            this.btnRekPlus.TabIndex = 2;
            this.btnRekPlus.Text = "+";
            this.btnRekPlus.UseVisualStyleBackColor = true;
            this.btnRekPlus.Click += new System.EventHandler(this.btnRekPlus_Click);
            // 
            // btnRekMin
            // 
            this.btnRekMin.Location = new System.Drawing.Point(372, 23);
            this.btnRekMin.Name = "btnRekMin";
            this.btnRekMin.Size = new System.Drawing.Size(75, 44);
            this.btnRekMin.TabIndex = 3;
            this.btnRekMin.Text = "-";
            this.btnRekMin.UseVisualStyleBackColor = true;
            this.btnRekMin.Click += new System.EventHandler(this.btnRekMin_Click);
            // 
            // btnSRekMin
            // 
            this.btnSRekMin.Location = new System.Drawing.Point(372, 125);
            this.btnSRekMin.Name = "btnSRekMin";
            this.btnSRekMin.Size = new System.Drawing.Size(75, 44);
            this.btnSRekMin.TabIndex = 7;
            this.btnSRekMin.Text = "-";
            this.btnSRekMin.UseVisualStyleBackColor = true;
            this.btnSRekMin.Click += new System.EventHandler(this.btnSRekMin_Click);
            // 
            // btnSRekPlus
            // 
            this.btnSRekPlus.Location = new System.Drawing.Point(291, 125);
            this.btnSRekPlus.Name = "btnSRekPlus";
            this.btnSRekPlus.Size = new System.Drawing.Size(75, 44);
            this.btnSRekPlus.TabIndex = 6;
            this.btnSRekPlus.Text = "+";
            this.btnSRekPlus.UseVisualStyleBackColor = true;
            this.btnSRekPlus.Click += new System.EventHandler(this.btnSRekPlus_Click);
            // 
            // txtSpaarRek
            // 
            this.txtSpaarRek.Location = new System.Drawing.Point(16, 136);
            this.txtSpaarRek.Name = "txtSpaarRek";
            this.txtSpaarRek.Size = new System.Drawing.Size(269, 22);
            this.txtSpaarRek.TabIndex = 5;
            // 
            // labelSpaarrekeningnaam
            // 
            this.labelSpaarrekeningnaam.AutoSize = true;
            this.labelSpaarrekeningnaam.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpaarrekeningnaam.Location = new System.Drawing.Point(13, 115);
            this.labelSpaarrekeningnaam.Name = "labelSpaarrekeningnaam";
            this.labelSpaarrekeningnaam.Size = new System.Drawing.Size(139, 20);
            this.labelSpaarrekeningnaam.TabIndex = 4;
            this.labelSpaarrekeningnaam.Text = "Spaarrekening";
            // 
            // btnZichtRekMin
            // 
            this.btnZichtRekMin.Location = new System.Drawing.Point(372, 225);
            this.btnZichtRekMin.Name = "btnZichtRekMin";
            this.btnZichtRekMin.Size = new System.Drawing.Size(75, 44);
            this.btnZichtRekMin.TabIndex = 11;
            this.btnZichtRekMin.Text = "-";
            this.btnZichtRekMin.UseVisualStyleBackColor = true;
            this.btnZichtRekMin.Click += new System.EventHandler(this.btnZichtRekMin_Click);
            // 
            // btnZichtRekPlus
            // 
            this.btnZichtRekPlus.Location = new System.Drawing.Point(291, 225);
            this.btnZichtRekPlus.Name = "btnZichtRekPlus";
            this.btnZichtRekPlus.Size = new System.Drawing.Size(75, 44);
            this.btnZichtRekPlus.TabIndex = 10;
            this.btnZichtRekPlus.Text = "+";
            this.btnZichtRekPlus.UseVisualStyleBackColor = true;
            this.btnZichtRekPlus.Click += new System.EventHandler(this.btnZichtRekPlus_Click);
            // 
            // txtZichtRek
            // 
            this.txtZichtRek.Location = new System.Drawing.Point(16, 236);
            this.txtZichtRek.Name = "txtZichtRek";
            this.txtZichtRek.Size = new System.Drawing.Size(269, 22);
            this.txtZichtRek.TabIndex = 9;
            // 
            // labelZichtrekeningnaam
            // 
            this.labelZichtrekeningnaam.AutoSize = true;
            this.labelZichtrekeningnaam.Font = new System.Drawing.Font("Courier New", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZichtrekeningnaam.Location = new System.Drawing.Point(13, 215);
            this.labelZichtrekeningnaam.Name = "labelZichtrekeningnaam";
            this.labelZichtrekeningnaam.Size = new System.Drawing.Size(139, 20);
            this.labelZichtrekeningnaam.TabIndex = 8;
            this.labelZichtrekeningnaam.Text = "Zichtrekening";
            // 
            // btnRente
            // 
            this.btnRente.Location = new System.Drawing.Point(486, 125);
            this.btnRente.Name = "btnRente";
            this.btnRente.Size = new System.Drawing.Size(120, 44);
            this.btnRente.TabIndex = 12;
            this.btnRente.Text = "Rente";
            this.btnRente.UseVisualStyleBackColor = true;
            this.btnRente.Click += new System.EventHandler(this.btnRente_Click);
            // 
            // labelRekeningSaldo
            // 
            this.labelRekeningSaldo.AutoSize = true;
            this.labelRekeningSaldo.Location = new System.Drawing.Point(17, 74);
            this.labelRekeningSaldo.Name = "labelRekeningSaldo";
            this.labelRekeningSaldo.Size = new System.Drawing.Size(0, 17);
            this.labelRekeningSaldo.TabIndex = 13;
            // 
            // labelSpaarRekeningSaldoRente
            // 
            this.labelSpaarRekeningSaldoRente.AutoSize = true;
            this.labelSpaarRekeningSaldoRente.Location = new System.Drawing.Point(17, 179);
            this.labelSpaarRekeningSaldoRente.Name = "labelSpaarRekeningSaldoRente";
            this.labelSpaarRekeningSaldoRente.Size = new System.Drawing.Size(0, 17);
            this.labelSpaarRekeningSaldoRente.TabIndex = 14;
            // 
            // labelZichtRekeningSaldo
            // 
            this.labelZichtRekeningSaldo.AutoSize = true;
            this.labelZichtRekeningSaldo.Location = new System.Drawing.Point(17, 279);
            this.labelZichtRekeningSaldo.Name = "labelZichtRekeningSaldo";
            this.labelZichtRekeningSaldo.Size = new System.Drawing.Size(0, 17);
            this.labelZichtRekeningSaldo.TabIndex = 15;
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(539, 301);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(187, 100);
            this.btnEquals.TabIndex = 16;
            this.btnEquals.Text = "Equals";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.labelZichtRekeningSaldo);
            this.Controls.Add(this.labelSpaarRekeningSaldoRente);
            this.Controls.Add(this.labelRekeningSaldo);
            this.Controls.Add(this.btnRente);
            this.Controls.Add(this.btnZichtRekMin);
            this.Controls.Add(this.btnZichtRekPlus);
            this.Controls.Add(this.txtZichtRek);
            this.Controls.Add(this.labelZichtrekeningnaam);
            this.Controls.Add(this.btnSRekMin);
            this.Controls.Add(this.btnSRekPlus);
            this.Controls.Add(this.txtSpaarRek);
            this.Controls.Add(this.labelSpaarrekeningnaam);
            this.Controls.Add(this.btnRekMin);
            this.Controls.Add(this.btnRekPlus);
            this.Controls.Add(this.txtRek);
            this.Controls.Add(this.labelRekeningnaam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRekeningnaam;
        private System.Windows.Forms.TextBox txtRek;
        private System.Windows.Forms.Button btnRekPlus;
        private System.Windows.Forms.Button btnRekMin;
        private System.Windows.Forms.Button btnSRekMin;
        private System.Windows.Forms.Button btnSRekPlus;
        private System.Windows.Forms.TextBox txtSpaarRek;
        private System.Windows.Forms.Label labelSpaarrekeningnaam;
        private System.Windows.Forms.Button btnZichtRekMin;
        private System.Windows.Forms.Button btnZichtRekPlus;
        private System.Windows.Forms.TextBox txtZichtRek;
        private System.Windows.Forms.Label labelZichtrekeningnaam;
        private System.Windows.Forms.Button btnRente;
        private System.Windows.Forms.Label labelRekeningSaldo;
        private System.Windows.Forms.Label labelSpaarRekeningSaldoRente;
        private System.Windows.Forms.Label labelZichtRekeningSaldo;
        private System.Windows.Forms.Button btnEquals;
    }
}

