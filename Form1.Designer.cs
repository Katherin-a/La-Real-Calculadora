namespace Calculator
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
            this.BtnSumar = new System.Windows.Forms.Button();
            this.Btnrestar = new System.Windows.Forms.Button();
            this.BtnMultiplicar = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.BtnDiv = new System.Windows.Forms.Button();
            this.Valor1 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.Valor2 = new System.Windows.Forms.Label();
            this.TBValor1 = new System.Windows.Forms.TextBox();
            this.TBValor2 = new System.Windows.Forms.TextBox();
            this.TBResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSumar
            // 
            this.BtnSumar.Location = new System.Drawing.Point(13, 115);
            this.BtnSumar.Name = "BtnSumar";
            this.BtnSumar.Size = new System.Drawing.Size(75, 23);
            this.BtnSumar.TabIndex = 0;
            this.BtnSumar.Text = "+";
            this.BtnSumar.UseVisualStyleBackColor = true;
            this.BtnSumar.Click += new System.EventHandler(this.BtnSumar_Click);
            // 
            // Btnrestar
            // 
            this.Btnrestar.Location = new System.Drawing.Point(137, 115);
            this.Btnrestar.Name = "Btnrestar";
            this.Btnrestar.Size = new System.Drawing.Size(75, 23);
            this.Btnrestar.TabIndex = 1;
            this.Btnrestar.Text = "-";
            this.Btnrestar.UseVisualStyleBackColor = true;
            this.Btnrestar.Click += new System.EventHandler(this.Btnrestar_Click);
            // 
            // BtnMultiplicar
            // 
            this.BtnMultiplicar.Location = new System.Drawing.Point(272, 115);
            this.BtnMultiplicar.Name = "BtnMultiplicar";
            this.BtnMultiplicar.Size = new System.Drawing.Size(75, 23);
            this.BtnMultiplicar.TabIndex = 2;
            this.BtnMultiplicar.Text = "*";
            this.BtnMultiplicar.UseVisualStyleBackColor = true;
            this.BtnMultiplicar.Click += new System.EventHandler(this.BtnMultiplicar_Click);
            // 
            // EXIT
            // 
            this.EXIT.Location = new System.Drawing.Point(410, 180);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(75, 23);
            this.EXIT.TabIndex = 3;
            this.EXIT.Text = "SALIR";
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // BtnDiv
            // 
            this.BtnDiv.Location = new System.Drawing.Point(410, 115);
            this.BtnDiv.Name = "BtnDiv";
            this.BtnDiv.Size = new System.Drawing.Size(75, 23);
            this.BtnDiv.TabIndex = 4;
            this.BtnDiv.Text = "/";
            this.BtnDiv.UseVisualStyleBackColor = true;
            this.BtnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // Valor1
            // 
            this.Valor1.AutoSize = true;
            this.Valor1.Location = new System.Drawing.Point(10, 36);
            this.Valor1.Name = "Valor1";
            this.Valor1.Size = new System.Drawing.Size(52, 13);
            this.Valor1.TabIndex = 5;
            this.Valor1.Text = "VALOR 1";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(269, 36);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(73, 13);
            this.Result.TabIndex = 6;
            this.Result.Text = "RESULTADO";
            // 
            // Valor2
            // 
            this.Valor2.AutoSize = true;
            this.Valor2.Location = new System.Drawing.Point(134, 36);
            this.Valor2.Name = "Valor2";
            this.Valor2.Size = new System.Drawing.Size(52, 13);
            this.Valor2.TabIndex = 7;
            this.Valor2.Text = "VALOR 2";
            // 
            // TBValor1
            // 
            this.TBValor1.Location = new System.Drawing.Point(13, 52);
            this.TBValor1.Name = "TBValor1";
            this.TBValor1.Size = new System.Drawing.Size(100, 20);
            this.TBValor1.TabIndex = 8;
            // 
            // TBValor2
            // 
            this.TBValor2.Location = new System.Drawing.Point(137, 52);
            this.TBValor2.Name = "TBValor2";
            this.TBValor2.Size = new System.Drawing.Size(100, 20);
            this.TBValor2.TabIndex = 9;
            // 
            // TBResult
            // 
            this.TBResult.Enabled = false;
            this.TBResult.Location = new System.Drawing.Point(272, 52);
            this.TBResult.Name = "TBResult";
            this.TBResult.Size = new System.Drawing.Size(100, 20);
            this.TBResult.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 215);
            this.Controls.Add(this.TBResult);
            this.Controls.Add(this.TBValor2);
            this.Controls.Add(this.TBValor1);
            this.Controls.Add(this.Valor2);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Valor1);
            this.Controls.Add(this.BtnDiv);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.BtnMultiplicar);
            this.Controls.Add(this.Btnrestar);
            this.Controls.Add(this.BtnSumar);
            this.Name = "Form1";
            this.Text = "CALCULADORA ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSumar;
        private System.Windows.Forms.Button Btnrestar;
        private System.Windows.Forms.Button BtnMultiplicar;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Button BtnDiv;
        private System.Windows.Forms.Label Valor1;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label Valor2;
        private System.Windows.Forms.TextBox TBValor1;
        private System.Windows.Forms.TextBox TBValor2;
        private System.Windows.Forms.TextBox TBResult;
    }
}

