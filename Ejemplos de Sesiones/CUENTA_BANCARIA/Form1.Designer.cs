
namespace CUENTA_BANCARIA
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComposicionBox = new System.Windows.Forms.ComboBox();
            this.CuotaTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SaldoFinal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.IncialTxt = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ForTxt = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.PeriodoBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PeriodoBox);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.ComposicionBox);
            this.groupBox1.Controls.Add(this.CuotaTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CUENTA DE AHORRO";
            // 
            // ComposicionBox
            // 
            this.ComposicionBox.FormattingEnabled = true;
            this.ComposicionBox.Items.AddRange(new object[] {
            "MENSUAL",
            "MENSUAL",
            "ANUAL"});
            this.ComposicionBox.Location = new System.Drawing.Point(160, 118);
            this.ComposicionBox.Name = "ComposicionBox";
            this.ComposicionBox.Size = new System.Drawing.Size(94, 21);
            this.ComposicionBox.TabIndex = 8;
            // 
            // CuotaTxt
            // 
            this.CuotaTxt.Location = new System.Drawing.Point(177, 65);
            this.CuotaTxt.Name = "CuotaTxt";
            this.CuotaTxt.Size = new System.Drawing.Size(77, 20);
            this.CuotaTxt.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "COMPOSICION APLICA A: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CUOTA DE DEPOSITO :  $ ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "INTERES ANUAL : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "MONTO INICIAL :  $ ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DULCE JASMIN VILLALOBOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENTE :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ForTxt);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.SaldoFinal);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.IncialTxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(307, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 155);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RESULTADOS";
            // 
            // SaldoFinal
            // 
            this.SaldoFinal.AutoSize = true;
            this.SaldoFinal.Location = new System.Drawing.Point(155, 95);
            this.SaldoFinal.Name = "SaldoFinal";
            this.SaldoFinal.Size = new System.Drawing.Size(34, 13);
            this.SaldoFinal.TabIndex = 3;
            this.SaldoFinal.Text = "00.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "SALDO FINAL:    $ ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(431, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "BORRAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // IncialTxt
            // 
            this.IncialTxt.AutoSize = true;
            this.IncialTxt.Location = new System.Drawing.Point(155, 63);
            this.IncialTxt.Name = "IncialTxt";
            this.IncialTxt.Size = new System.Drawing.Size(46, 13);
            this.IncialTxt.TabIndex = 1;
            this.IncialTxt.Text = "1000.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "7  %";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(204, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 5;
            // 
            // ForTxt
            // 
            this.ForTxt.AutoSize = true;
            this.ForTxt.Location = new System.Drawing.Point(155, 126);
            this.ForTxt.Name = "ForTxt";
            this.ForTxt.Size = new System.Drawing.Size(34, 13);
            this.ForTxt.TabIndex = 6;
            this.ForTxt.Text = "00.00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "PERIODO DE AHORRO : ";
            // 
            // PeriodoBox
            // 
            this.PeriodoBox.FormattingEnabled = true;
            this.PeriodoBox.Items.AddRange(new object[] {
            "1 AÑO",
            "2 AÑOS",
            "3 AÑOS",
            "4 AÑOS",
            "5 AÑOS"});
            this.PeriodoBox.Location = new System.Drawing.Point(165, 92);
            this.PeriodoBox.Name = "PeriodoBox";
            this.PeriodoBox.Size = new System.Drawing.Size(89, 21);
            this.PeriodoBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 227);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ComposicionBox;
        private System.Windows.Forms.TextBox CuotaTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label SaldoFinal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label ForTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label IncialTxt;
        private System.Windows.Forms.ComboBox PeriodoBox;
    }
}

