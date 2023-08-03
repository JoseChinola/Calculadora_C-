namespace CalculadoraForms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModulo = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.lblHistorial = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnUno = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.btnModulo);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnPunto);
            this.panel1.Controls.Add(this.btnCero);
            this.panel1.Controls.Add(this.lblHistorial);
            this.panel1.Controls.Add(this.txtResultado);
            this.panel1.Controls.Add(this.btnBorrar);
            this.panel1.Controls.Add(this.btnResultado);
            this.panel1.Controls.Add(this.btnDividir);
            this.panel1.Controls.Add(this.btnSumar);
            this.panel1.Controls.Add(this.btnRestar);
            this.panel1.Controls.Add(this.btnMultiplicar);
            this.panel1.Controls.Add(this.btnNueve);
            this.panel1.Controls.Add(this.btnOcho);
            this.panel1.Controls.Add(this.btnSiete);
            this.panel1.Controls.Add(this.btnSeis);
            this.panel1.Controls.Add(this.btnCinco);
            this.panel1.Controls.Add(this.btnCuatro);
            this.panel1.Controls.Add(this.btnTres);
            this.panel1.Controls.Add(this.btnDos);
            this.panel1.Controls.Add(this.btnUno);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 677);
            this.panel1.TabIndex = 0;
            // 
            // btnModulo
            // 
            this.btnModulo.Image = ((System.Drawing.Image)(resources.GetObject("btnModulo.Image")));
            this.btnModulo.Location = new System.Drawing.Point(189, 185);
            this.btnModulo.Name = "btnModulo";
            this.btnModulo.Size = new System.Drawing.Size(135, 83);
            this.btnModulo.TabIndex = 21;
            this.btnModulo.UseVisualStyleBackColor = true;
            this.btnModulo.Click += new System.EventHandler(this.btnModulo_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(43, 185);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(135, 83);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Image = ((System.Drawing.Image)(resources.GetObject("btnPunto.Image")));
            this.btnPunto.Location = new System.Drawing.Point(40, 568);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(135, 83);
            this.btnPunto.TabIndex = 19;
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnCero
            // 
            this.btnCero.Image = ((System.Drawing.Image)(resources.GetObject("btnCero.Image")));
            this.btnCero.Location = new System.Drawing.Point(186, 568);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(281, 83);
            this.btnCero.TabIndex = 18;
            this.btnCero.UseVisualStyleBackColor = true;
            this.btnCero.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblHistorial
            // 
            this.lblHistorial.AutoSize = true;
            this.lblHistorial.Location = new System.Drawing.Point(38, 41);
            this.lblHistorial.Name = "lblHistorial";
            this.lblHistorial.Size = new System.Drawing.Size(0, 15);
            this.lblHistorial.TabIndex = 17;
            this.lblHistorial.Click += new System.EventHandler(this.lblHistorial_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.Color.Red;
            this.txtResultado.Location = new System.Drawing.Point(43, 59);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(575, 98);
            this.txtResultado.TabIndex = 16;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.Location = new System.Drawing.Point(334, 185);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(135, 83);
            this.btnBorrar.TabIndex = 14;
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.BackColor = System.Drawing.Color.Red;
            this.btnResultado.Image = ((System.Drawing.Image)(resources.GetObject("btnResultado.Image")));
            this.btnResultado.Location = new System.Drawing.Point(482, 565);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(136, 84);
            this.btnResultado.TabIndex = 13;
            this.btnResultado.UseVisualStyleBackColor = false;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.Color.Red;
            this.btnDividir.Image = ((System.Drawing.Image)(resources.GetObject("btnDividir.Image")));
            this.btnDividir.Location = new System.Drawing.Point(482, 188);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(135, 81);
            this.btnDividir.TabIndex = 12;
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnSumar
            // 
            this.btnSumar.BackColor = System.Drawing.Color.Red;
            this.btnSumar.Image = ((System.Drawing.Image)(resources.GetObject("btnSumar.Image")));
            this.btnSumar.Location = new System.Drawing.Point(482, 379);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSumar.Size = new System.Drawing.Size(135, 82);
            this.btnSumar.TabIndex = 11;
            this.btnSumar.UseVisualStyleBackColor = false;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // btnRestar
            // 
            this.btnRestar.BackColor = System.Drawing.Color.Red;
            this.btnRestar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestar.Image")));
            this.btnRestar.Location = new System.Drawing.Point(483, 287);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(135, 82);
            this.btnRestar.TabIndex = 10;
            this.btnRestar.UseVisualStyleBackColor = false;
            this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.Color.Red;
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.ForeColor = System.Drawing.Color.White;
            this.btnMultiplicar.Image = ((System.Drawing.Image)(resources.GetObject("btnMultiplicar.Image")));
            this.btnMultiplicar.Location = new System.Drawing.Point(483, 473);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(135, 82);
            this.btnMultiplicar.TabIndex = 9;
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnNueve
            // 
            this.btnNueve.Image = ((System.Drawing.Image)(resources.GetObject("btnNueve.Image")));
            this.btnNueve.Location = new System.Drawing.Point(333, 287);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(135, 82);
            this.btnNueve.TabIndex = 8;
            this.btnNueve.UseVisualStyleBackColor = true;
            this.btnNueve.Click += new System.EventHandler(this.btnNueve_Click);
            // 
            // btnOcho
            // 
            this.btnOcho.Image = ((System.Drawing.Image)(resources.GetObject("btnOcho.Image")));
            this.btnOcho.Location = new System.Drawing.Point(189, 286);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(135, 83);
            this.btnOcho.TabIndex = 7;
            this.btnOcho.UseVisualStyleBackColor = true;
            this.btnOcho.Click += new System.EventHandler(this.btnOcho_Click);
            // 
            // btnSiete
            // 
            this.btnSiete.Image = ((System.Drawing.Image)(resources.GetObject("btnSiete.Image")));
            this.btnSiete.Location = new System.Drawing.Point(43, 285);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(135, 83);
            this.btnSiete.TabIndex = 6;
            this.btnSiete.UseVisualStyleBackColor = true;
            this.btnSiete.Click += new System.EventHandler(this.btnSiete_Click);
            // 
            // btnSeis
            // 
            this.btnSeis.Image = ((System.Drawing.Image)(resources.GetObject("btnSeis.Image")));
            this.btnSeis.Location = new System.Drawing.Point(333, 380);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(136, 82);
            this.btnSeis.TabIndex = 5;
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.btnSeis_Click);
            // 
            // btnCinco
            // 
            this.btnCinco.Image = ((System.Drawing.Image)(resources.GetObject("btnCinco.Image")));
            this.btnCinco.Location = new System.Drawing.Point(189, 380);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(135, 82);
            this.btnCinco.TabIndex = 4;
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.btnCinco_Click);
            // 
            // btnCuatro
            // 
            this.btnCuatro.Image = ((System.Drawing.Image)(resources.GetObject("btnCuatro.Image")));
            this.btnCuatro.Location = new System.Drawing.Point(43, 380);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(135, 82);
            this.btnCuatro.TabIndex = 3;
            this.btnCuatro.UseVisualStyleBackColor = true;
            this.btnCuatro.Click += new System.EventHandler(this.btnCuatro_Click);
            // 
            // btnTres
            // 
            this.btnTres.Image = ((System.Drawing.Image)(resources.GetObject("btnTres.Image")));
            this.btnTres.Location = new System.Drawing.Point(333, 474);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(135, 83);
            this.btnTres.TabIndex = 2;
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.btnTres_Click);
            // 
            // btnDos
            // 
            this.btnDos.Image = ((System.Drawing.Image)(resources.GetObject("btnDos.Image")));
            this.btnDos.Location = new System.Drawing.Point(189, 474);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(135, 82);
            this.btnDos.TabIndex = 1;
            this.btnDos.UseVisualStyleBackColor = true;
            this.btnDos.Click += new System.EventHandler(this.btnDos_Click);
            // 
            // btnUno
            // 
            this.btnUno.Image = ((System.Drawing.Image)(resources.GetObject("btnUno.Image")));
            this.btnUno.Location = new System.Drawing.Point(43, 474);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(135, 82);
            this.btnUno.TabIndex = 0;
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.btnUno_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(668, 677);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblHistorial;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnModulo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnPunto;
    }
}

