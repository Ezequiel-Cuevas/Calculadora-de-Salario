namespace CalculadoraSalarioApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalarioPorHora = new System.Windows.Forms.TextBox();
            this.txtHorasTrabajadas = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa tu salario por hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa la cantidad de horas trabajadas en la semana";
            // 
            // txtSalarioPorHora
            // 
            this.txtSalarioPorHora.Location = new System.Drawing.Point(37, 55);
            this.txtSalarioPorHora.Name = "txtSalarioPorHora";
            this.txtSalarioPorHora.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioPorHora.TabIndex = 2;
            // 
            // txtHorasTrabajadas
            // 
            this.txtHorasTrabajadas.Location = new System.Drawing.Point(229, 55);
            this.txtHorasTrabajadas.Name = "txtHorasTrabajadas";
            this.txtHorasTrabajadas.Size = new System.Drawing.Size(100, 20);
            this.txtHorasTrabajadas.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(141, 105);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(102, 180);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(146, 95);
            this.lstResultados.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtHorasTrabajadas);
            this.Controls.Add(this.txtSalarioPorHora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalarioPorHora;
        private System.Windows.Forms.TextBox txtHorasTrabajadas;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ListBox lstResultados;
    }
}

