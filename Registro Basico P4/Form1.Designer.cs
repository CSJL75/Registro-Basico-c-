namespace Registro_Basico_P4
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
            this.lbN = new System.Windows.Forms.Label();
            this.lbA = new System.Windows.Forms.Label();
            this.lbT = new System.Windows.Forms.Label();
            this.lbE = new System.Windows.Forms.Label();
            this.lbeD = new System.Windows.Forms.Label();
            this.tbN = new System.Windows.Forms.TextBox();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbT = new System.Windows.Forms.TextBox();
            this.tbE = new System.Windows.Forms.TextBox();
            this.tbeD = new System.Windows.Forms.TextBox();
            this.gbG = new System.Windows.Forms.GroupBox();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.rbH = new System.Windows.Forms.RadioButton();
            this.bG = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.gbG.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbN
            // 
            this.lbN.AutoSize = true;
            this.lbN.Location = new System.Drawing.Point(12, 41);
            this.lbN.Name = "lbN";
            this.lbN.Size = new System.Drawing.Size(44, 13);
            this.lbN.TabIndex = 0;
            this.lbN.Text = "Nombre";
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(12, 80);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(49, 13);
            this.lbA.TabIndex = 1;
            this.lbA.Text = "Apellidos";
            // 
            // lbT
            // 
            this.lbT.AutoSize = true;
            this.lbT.Location = new System.Drawing.Point(12, 120);
            this.lbT.Name = "lbT";
            this.lbT.Size = new System.Drawing.Size(49, 13);
            this.lbT.TabIndex = 2;
            this.lbT.Text = "Telefono";
            // 
            // lbE
            // 
            this.lbE.AutoSize = true;
            this.lbE.Location = new System.Drawing.Point(12, 159);
            this.lbE.Name = "lbE";
            this.lbE.Size = new System.Drawing.Size(49, 13);
            this.lbE.TabIndex = 3;
            this.lbE.Text = "Estadura";
            // 
            // lbeD
            // 
            this.lbeD.AutoSize = true;
            this.lbeD.Location = new System.Drawing.Point(12, 194);
            this.lbeD.Name = "lbeD";
            this.lbeD.Size = new System.Drawing.Size(32, 13);
            this.lbeD.TabIndex = 4;
            this.lbeD.Text = "Edad";
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(102, 34);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(143, 20);
            this.tbN.TabIndex = 5;
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(102, 73);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(143, 20);
            this.tbA.TabIndex = 6;
            // 
            // tbT
            // 
            this.tbT.Location = new System.Drawing.Point(102, 113);
            this.tbT.Name = "tbT";
            this.tbT.Size = new System.Drawing.Size(143, 20);
            this.tbT.TabIndex = 7;
            // 
            // tbE
            // 
            this.tbE.Location = new System.Drawing.Point(102, 152);
            this.tbE.Name = "tbE";
            this.tbE.Size = new System.Drawing.Size(143, 20);
            this.tbE.TabIndex = 8;
            // 
            // tbeD
            // 
            this.tbeD.Location = new System.Drawing.Point(102, 187);
            this.tbeD.Name = "tbeD";
            this.tbeD.Size = new System.Drawing.Size(143, 20);
            this.tbeD.TabIndex = 9;
            // 
            // gbG
            // 
            this.gbG.Controls.Add(this.rbM);
            this.gbG.Controls.Add(this.rbH);
            this.gbG.Location = new System.Drawing.Point(15, 226);
            this.gbG.Name = "gbG";
            this.gbG.Size = new System.Drawing.Size(230, 73);
            this.gbG.TabIndex = 10;
            this.gbG.TabStop = false;
            this.gbG.Text = "Género";
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Location = new System.Drawing.Point(147, 28);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(51, 17);
            this.rbM.TabIndex = 11;
            this.rbM.TabStop = true;
            this.rbM.Text = "Mujer";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // rbH
            // 
            this.rbH.AutoSize = true;
            this.rbH.Location = new System.Drawing.Point(38, 28);
            this.rbH.Name = "rbH";
            this.rbH.Size = new System.Drawing.Size(62, 17);
            this.rbH.TabIndex = 11;
            this.rbH.TabStop = true;
            this.rbH.Text = "Hombre";
            this.rbH.UseVisualStyleBackColor = true;
            // 
            // bG
            // 
            this.bG.Location = new System.Drawing.Point(82, 314);
            this.bG.Name = "bG";
            this.bG.Size = new System.Drawing.Size(100, 45);
            this.bG.TabIndex = 11;
            this.bG.Text = "Guardar";
            this.bG.UseVisualStyleBackColor = true;
            this.bG.Click += new System.EventHandler(this.bG_Click);
            // 
            // bC
            // 
            this.bC.Location = new System.Drawing.Point(82, 365);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(100, 39);
            this.bC.TabIndex = 12;
            this.bC.Text = "Cancelar";
            this.bC.UseVisualStyleBackColor = true;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(278, 435);
            this.Controls.Add(this.bC);
            this.Controls.Add(this.bG);
            this.Controls.Add(this.gbG);
            this.Controls.Add(this.tbeD);
            this.Controls.Add(this.tbE);
            this.Controls.Add(this.tbT);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.lbeD);
            this.Controls.Add(this.lbE);
            this.Controls.Add(this.lbT);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.lbN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbG.ResumeLayout(false);
            this.gbG.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbN;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbT;
        private System.Windows.Forms.Label lbE;
        private System.Windows.Forms.Label lbeD;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbT;
        private System.Windows.Forms.TextBox tbE;
        private System.Windows.Forms.TextBox tbeD;
        private System.Windows.Forms.GroupBox gbG;
        private System.Windows.Forms.RadioButton rbH;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.Button bG;
        private System.Windows.Forms.Button bC;
    }
}

