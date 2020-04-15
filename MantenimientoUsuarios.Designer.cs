namespace Factura
{
    partial class MantenimientoUsuarios
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pusu = new System.Windows.Forms.RadioButton();
            this.padmin = new System.Windows.Forms.RadioButton();
            this.txtConUs = new MiLibreriaa.ErrorTextBox(this.components);
            this.txtCuentaUs = new MiLibreriaa.ErrorTextBox(this.components);
            this.txtNomUs = new MiLibreriaa.ErrorTextBox(this.components);
            this.txtIdUs = new MiLibreriaa.ErrorTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bebas Neue", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 38);
            this.label3.TabIndex = 32;
            this.label3.Text = "Cuenta:";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bebas Neue", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 38);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nombre de Usuario:";
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 38);
            this.label1.TabIndex = 30;
            this.label1.Text = "Id Usuario:";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bebas Neue", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 38);
            this.label4.TabIndex = 33;
            this.label4.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bebas Neue", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 38);
            this.label5.TabIndex = 34;
            this.label5.Text = "Persmisos:";
            // 
            // pusu
            // 
            this.pusu.AutoSize = true;
            this.pusu.Checked = true;
            this.pusu.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pusu.Location = new System.Drawing.Point(294, 444);
            this.pusu.Name = "pusu";
            this.pusu.Size = new System.Drawing.Size(82, 29);
            this.pusu.TabIndex = 36;
            this.pusu.TabStop = true;
            this.pusu.Text = "Usuario";
            this.pusu.UseVisualStyleBackColor = true;
            // 
            // padmin
            // 
            this.padmin.AutoSize = true;
            this.padmin.Font = new System.Drawing.Font("Bebas Neue", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.padmin.Location = new System.Drawing.Point(409, 444);
            this.padmin.Name = "padmin";
            this.padmin.Size = new System.Drawing.Size(71, 29);
            this.padmin.TabIndex = 37;
            this.padmin.Text = "Admin";
            this.padmin.UseVisualStyleBackColor = true;
            // 
            // txtConUs
            // 
            this.txtConUs.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConUs.Location = new System.Drawing.Point(294, 355);
            this.txtConUs.Name = "txtConUs";
            this.txtConUs.Nums = false;
            this.txtConUs.Size = new System.Drawing.Size(211, 31);
            this.txtConUs.TabIndex = 41;
            this.txtConUs.Validar = true;
            // 
            // txtCuentaUs
            // 
            this.txtCuentaUs.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuentaUs.Location = new System.Drawing.Point(294, 268);
            this.txtCuentaUs.Name = "txtCuentaUs";
            this.txtCuentaUs.Nums = false;
            this.txtCuentaUs.Size = new System.Drawing.Size(211, 31);
            this.txtCuentaUs.TabIndex = 40;
            this.txtCuentaUs.Validar = true;
            // 
            // txtNomUs
            // 
            this.txtNomUs.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomUs.Location = new System.Drawing.Point(294, 162);
            this.txtNomUs.Name = "txtNomUs";
            this.txtNomUs.Nums = false;
            this.txtNomUs.Size = new System.Drawing.Size(211, 31);
            this.txtNomUs.TabIndex = 39;
            this.txtNomUs.Validar = true;
            // 
            // txtIdUs
            // 
            this.txtIdUs.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUs.Location = new System.Drawing.Point(294, 58);
            this.txtIdUs.Name = "txtIdUs";
            this.txtIdUs.Nums = true;
            this.txtIdUs.Size = new System.Drawing.Size(211, 31);
            this.txtIdUs.TabIndex = 38;
            this.txtIdUs.Validar = true;
            // 
            // MantenimientoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.txtConUs);
            this.Controls.Add(this.txtCuentaUs);
            this.Controls.Add(this.txtNomUs);
            this.Controls.Add(this.txtIdUs);
            this.Controls.Add(this.padmin);
            this.Controls.Add(this.pusu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MantenimientoUsuarios";
            this.Text = "Mantenimiento Usuarios";
            this.Load += new System.EventHandler(this.MantenimientoUnidades_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.pusu, 0);
            this.Controls.SetChildIndex(this.padmin, 0);
            this.Controls.SetChildIndex(this.salir, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.txtIdUs, 0);
            this.Controls.SetChildIndex(this.txtNomUs, 0);
            this.Controls.SetChildIndex(this.txtCuentaUs, 0);
            this.Controls.SetChildIndex(this.txtConUs, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton pusu;
        private System.Windows.Forms.RadioButton padmin;
        private MiLibreriaa.ErrorTextBox txtIdUsu;
        private MiLibreriaa.ErrorTextBox txtNomUsu;
        private MiLibreriaa.ErrorTextBox txtCuentaUsu;
        private MiLibreriaa.ErrorTextBox txtConUsu;
        private MiLibreriaa.ErrorTextBox errorTxtBox1;
        private MiLibreriaa.ErrorTextBox txtIdUs;
        private MiLibreriaa.ErrorTextBox txtNomUs;
        private MiLibreriaa.ErrorTextBox txtCuentaUs;
        private MiLibreriaa.ErrorTextBox txtConUs;
    }
}