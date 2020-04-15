namespace Factura
{
    partial class MantenimientoDepartamento
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
            this.txtIdDep = new MiLibreriaa.ErrorTextBox(this.components);
            this.txtNomDep = new MiLibreriaa.ErrorTextBox(this.components);
            this.txtEstatus = new MiLibreriaa.ErrorTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bebas Neue", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 38);
            this.label3.TabIndex = 32;
            this.label3.Text = "Estatus";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bebas Neue", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 38);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 38);
            this.label1.TabIndex = 30;
            this.label1.Text = "Id DEpartamento:";
            // 
            // txtIdDep
            // 
            this.txtIdDep.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdDep.Location = new System.Drawing.Point(272, 94);
            this.txtIdDep.Name = "txtIdDep";
            this.txtIdDep.Nums = true;
            this.txtIdDep.Size = new System.Drawing.Size(200, 31);
            this.txtIdDep.TabIndex = 33;
            this.txtIdDep.Validar = true;
            // 
            // txtNomDep
            // 
            this.txtNomDep.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomDep.Location = new System.Drawing.Point(272, 198);
            this.txtNomDep.Name = "txtNomDep";
            this.txtNomDep.Nums = false;
            this.txtNomDep.Size = new System.Drawing.Size(200, 31);
            this.txtNomDep.TabIndex = 34;
            this.txtNomDep.Validar = true;
            // 
            // txtEstatus
            // 
            this.txtEstatus.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstatus.Location = new System.Drawing.Point(272, 306);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Nums = false;
            this.txtEstatus.Size = new System.Drawing.Size(200, 31);
            this.txtEstatus.TabIndex = 35;
            this.txtEstatus.Validar = true;
            // 
            // MantenimientoDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.txtNomDep);
            this.Controls.Add(this.txtIdDep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MantenimientoDepartamento";
            this.Text = "Mantenimiento Departamento";
            this.Load += new System.EventHandler(this.MantenimientoDepartamento_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtIdDep, 0);
            this.Controls.SetChildIndex(this.salir, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.txtNomDep, 0);
            this.Controls.SetChildIndex(this.txtEstatus, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MiLibreriaa.ErrorTextBox txtIdDep;
        private MiLibreriaa.ErrorTextBox txtNomDep;
        private MiLibreriaa.ErrorTextBox txtEstatus;
    }
}