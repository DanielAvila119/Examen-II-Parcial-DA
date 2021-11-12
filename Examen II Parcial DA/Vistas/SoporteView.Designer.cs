
namespace Examen_II_Parcial_DA.Vistas
{
    partial class SoporteView
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_Servicio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_Problema = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el tipo de servicio:";
            // 
            // cbx_Servicio
            // 
            this.cbx_Servicio.FormattingEnabled = true;
            this.cbx_Servicio.Items.AddRange(new object[] {
            "Celular",
            "Computadora"});
            this.cbx_Servicio.Location = new System.Drawing.Point(222, 61);
            this.cbx_Servicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_Servicio.Name = "cbx_Servicio";
            this.cbx_Servicio.Size = new System.Drawing.Size(264, 28);
            this.cbx_Servicio.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soporte que brinda la empresa";
            // 
            // cbx_Problema
            // 
            this.cbx_Problema.FormattingEnabled = true;
            this.cbx_Problema.Items.AddRange(new object[] {
            "Reparación",
            "Limpieza",
            "Cambio de piezas",
            "Mantenimiento"});
            this.cbx_Problema.Location = new System.Drawing.Point(222, 99);
            this.cbx_Problema.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_Problema.Name = "cbx_Problema";
            this.cbx_Problema.Size = new System.Drawing.Size(264, 28);
            this.cbx_Problema.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Díganos su problema:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SoporteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 209);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbx_Problema);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_Servicio);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SoporteView";
            this.Text = "Servicios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_Servicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_Problema;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}