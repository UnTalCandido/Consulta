namespace Consulta
{
    partial class FrmMain
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
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.TxtComando = new System.Windows.Forms.TextBox();
            this.LblLineas = new System.Windows.Forms.Label();
            this.LblContador = new System.Windows.Forms.Label();
            this.DgDatos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(672, 298);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(158, 58);
            this.BtnAceptar.TabIndex = 0;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // TxtComando
            // 
            this.TxtComando.Location = new System.Drawing.Point(12, 298);
            this.TxtComando.Multiline = true;
            this.TxtComando.Name = "TxtComando";
            this.TxtComando.Size = new System.Drawing.Size(636, 137);
            this.TxtComando.TabIndex = 1;
            this.TxtComando.TextChanged += new System.EventHandler(this.TxtComando_TextChanged);
            // 
            // LblLineas
            // 
            this.LblLineas.AutoSize = true;
            this.LblLineas.Location = new System.Drawing.Point(669, 397);
            this.LblLineas.Name = "LblLineas";
            this.LblLineas.Size = new System.Drawing.Size(35, 13);
            this.LblLineas.TabIndex = 2;
            this.LblLineas.Text = "label1";
            // 
            // LblContador
            // 
            this.LblContador.AutoSize = true;
            this.LblContador.Location = new System.Drawing.Point(756, 397);
            this.LblContador.Name = "LblContador";
            this.LblContador.Size = new System.Drawing.Size(35, 13);
            this.LblContador.TabIndex = 3;
            this.LblContador.Text = "label2";
            // 
            // DgDatos
            // 
            this.DgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgDatos.Location = new System.Drawing.Point(12, 12);
            this.DgDatos.Name = "DgDatos";
            this.DgDatos.Size = new System.Drawing.Size(818, 265);
            this.DgDatos.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 447);
            this.Controls.Add(this.DgDatos);
            this.Controls.Add(this.LblContador);
            this.Controls.Add(this.LblLineas);
            this.Controls.Add(this.TxtComando);
            this.Controls.Add(this.BtnAceptar);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.TextBox TxtComando;
        private System.Windows.Forms.Label LblLineas;
        private System.Windows.Forms.Label LblContador;
        private System.Windows.Forms.DataGridView DgDatos;
    }
}

