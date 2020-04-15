namespace Factura
{
    partial class MantenimientoSuplidores
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
            this.txtIdSup = new MiLibreriaa.ErrorTextBox(this.components);
            this.txtNomSup = new MiLibreriaa.ErrorTextBox(this.components);
            this.txtDirSup = new MiLibreriaa.ErrorTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bebas Neue", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 38);
            this.label3.TabIndex = 38;
            this.label3.Text = "Direccion:";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bebas Neue", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 38);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nombre Suplidor:";
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 38);
            this.label1.TabIndex = 36;
            this.label1.Text = "Id Suplidor";
            // 
            // txtIdSup
            // 
            this.txtIdSup.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdSup.Location = new System.Drawing.Point(314, 97);
            this.txtIdSup.Name = "txtIdSup";
            this.txtIdSup.Nums = true;
            this.txtIdSup.Size = new System.Drawing.Size(200, 31);
            this.txtIdSup.TabIndex = 39;
            this.txtIdSup.Validar = true;
            // 
            // txtNomSup
            // 
            this.txtNomSup.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomSup.Location = new System.Drawing.Point(314, 201);
            this.txtNomSup.Name = "txtNomSup";
            this.txtNomSup.Nums = true;
            this.txtNomSup.Size = new System.Drawing.Size(200, 31);
            this.txtNomSup.TabIndex = 40;
            this.txtNomSup.Validar = true;
            this.txtNomSup.TextChanged += new System.EventHandler(this.errorTextBox1_TextChanged);
            // 
            // txtDirSup
            // 
            this.txtDirSup.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirSup.Location = new System.Drawing.Point(314, 309);
            this.txtDirSup.Name = "txtDirSup";
            this.txtDirSup.Nums = true;
            this.txtDirSup.Size = new System.Drawing.Size(200, 31);
            this.txtDirSup.TabIndex = 41;
            this.txtDirSup.Validar = true;
            // 
            // MantenimientoSuplidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDirSup);
            this.Controls.Add(this.txtNomSup);
            this.Controls.Add(this.txtIdSup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MantenimientoSuplidores";
            this.Text = "Mantenimiento Suplidores";
            this.Load += new System.EventHandler(this.MantenimientoDepartamentos_Load);
            this.Controls.SetChildIndex(this.salir, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtIdSup, 0);
            this.Controls.SetChildIndex(this.txtNomSup, 0);
            this.Controls.SetChildIndex(this.txtDirSup, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MiLibreriaa.ErrorTextBox txtIdSup;
        private MiLibreriaa.ErrorTextBox txtNomSup;
        private MiLibreriaa.ErrorTextBox txtDirSup;
    }
}