namespace WfaCalcGrafica
{
    partial class FrmCalc
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalc));
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOper = new System.Windows.Forms.Label();
            this.grpOperacoes = new System.Windows.Forms.GroupBox();
            this.rdbDividir = new System.Windows.Forms.RadioButton();
            this.rdbMulti = new System.Windows.Forms.RadioButton();
            this.rdbSomar = new System.Windows.Forms.RadioButton();
            this.rdbSubtrair = new System.Windows.Forms.RadioButton();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.grpOperacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNum1.Location = new System.Drawing.Point(40, 47);
            this.txtNum1.Margin = new System.Windows.Forms.Padding(2);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(86, 20);
            this.txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(194, 47);
            this.txtNum2.Margin = new System.Windows.Forms.Padding(2);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(86, 20);
            this.txtNum2.TabIndex = 1;
            this.txtNum2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "1º número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "2º número:";
            // 
            // lblOper
            // 
            this.lblOper.AutoSize = true;
            this.lblOper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOper.Location = new System.Drawing.Point(147, 47);
            this.lblOper.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOper.Name = "lblOper";
            this.lblOper.Size = new System.Drawing.Size(18, 20);
            this.lblOper.TabIndex = 2;
            this.lblOper.Text = "+";
            this.lblOper.Click += new System.EventHandler(this.lblOper_Click);
            // 
            // grpOperacoes
            // 
            this.grpOperacoes.Controls.Add(this.rdbDividir);
            this.grpOperacoes.Controls.Add(this.rdbMulti);
            this.grpOperacoes.Controls.Add(this.rdbSomar);
            this.grpOperacoes.Controls.Add(this.rdbSubtrair);
            this.grpOperacoes.Location = new System.Drawing.Point(40, 89);
            this.grpOperacoes.Margin = new System.Windows.Forms.Padding(2);
            this.grpOperacoes.Name = "grpOperacoes";
            this.grpOperacoes.Padding = new System.Windows.Forms.Padding(2);
            this.grpOperacoes.Size = new System.Drawing.Size(150, 114);
            this.grpOperacoes.TabIndex = 5;
            this.grpOperacoes.TabStop = false;
            this.grpOperacoes.Text = "Operações";
            this.grpOperacoes.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdbDividir
            // 
            this.rdbDividir.AutoSize = true;
            this.rdbDividir.Location = new System.Drawing.Point(5, 85);
            this.rdbDividir.Margin = new System.Windows.Forms.Padding(2);
            this.rdbDividir.Name = "rdbDividir";
            this.rdbDividir.Size = new System.Drawing.Size(54, 17);
            this.rdbDividir.TabIndex = 9;
            this.rdbDividir.TabStop = true;
            this.rdbDividir.Text = "&Dividir";
            this.rdbDividir.UseVisualStyleBackColor = true;
            this.rdbDividir.CheckedChanged += new System.EventHandler(this.RdbDividir_CheckedChanged);
            // 
            // rdbMulti
            // 
            this.rdbMulti.AutoSize = true;
            this.rdbMulti.Location = new System.Drawing.Point(5, 63);
            this.rdbMulti.Margin = new System.Windows.Forms.Padding(2);
            this.rdbMulti.Name = "rdbMulti";
            this.rdbMulti.Size = new System.Drawing.Size(72, 17);
            this.rdbMulti.TabIndex = 8;
            this.rdbMulti.TabStop = true;
            this.rdbMulti.Text = "&Multiplicar";
            this.rdbMulti.UseVisualStyleBackColor = true;
            this.rdbMulti.CheckedChanged += new System.EventHandler(this.RdbMulti_CheckedChanged);
            // 
            // rdbSomar
            // 
            this.rdbSomar.AutoSize = true;
            this.rdbSomar.Location = new System.Drawing.Point(5, 20);
            this.rdbSomar.Margin = new System.Windows.Forms.Padding(2);
            this.rdbSomar.Name = "rdbSomar";
            this.rdbSomar.Size = new System.Drawing.Size(55, 17);
            this.rdbSomar.TabIndex = 6;
            this.rdbSomar.TabStop = true;
            this.rdbSomar.Text = "&Somar";
            this.rdbSomar.UseVisualStyleBackColor = true;
            this.rdbSomar.CheckedChanged += new System.EventHandler(this.RdbSomar_CheckedChanged);
            // 
            // rdbSubtrair
            // 
            this.rdbSubtrair.AutoSize = true;
            this.rdbSubtrair.Location = new System.Drawing.Point(5, 41);
            this.rdbSubtrair.Margin = new System.Windows.Forms.Padding(2);
            this.rdbSubtrair.Name = "rdbSubtrair";
            this.rdbSubtrair.Size = new System.Drawing.Size(61, 17);
            this.rdbSubtrair.TabIndex = 7;
            this.rdbSubtrair.TabStop = true;
            this.rdbSubtrair.Text = "S&ubtrair";
            this.rdbSubtrair.UseVisualStyleBackColor = true;
            this.rdbSubtrair.CheckedChanged += new System.EventHandler(this.RdbSubtrair_CheckedChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCalc.Location = new System.Drawing.Point(220, 89);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(58, 28);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "&Calcular";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLimpar.Location = new System.Drawing.Point(220, 130);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(58, 27);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFechar.Location = new System.Drawing.Point(220, 177);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(60, 26);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "Fecha&r";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // FrmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(346, 275);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.grpOperacoes);
            this.Controls.Add(this.lblOper);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCalc_FormClosing);
            this.grpOperacoes.ResumeLayout(false);
            this.grpOperacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOper;
        private System.Windows.Forms.GroupBox grpOperacoes;
        private System.Windows.Forms.RadioButton rdbSomar;
        private System.Windows.Forms.RadioButton rdbSubtrair;
        private System.Windows.Forms.RadioButton rdbMulti;
        private System.Windows.Forms.RadioButton rdbDividir;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
    }
}

