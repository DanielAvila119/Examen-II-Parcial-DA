
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_Dispositivo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_Problema = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ServicioDataGridView = new System.Windows.Forms.DataGridView();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ServicioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dispositivo para el tipo de servicio:";
            // 
            // cbx_Dispositivo
            // 
            this.cbx_Dispositivo.Enabled = false;
            this.cbx_Dispositivo.FormattingEnabled = true;
            this.cbx_Dispositivo.Items.AddRange(new object[] {
            "Celular",
            "Computadora"});
            this.cbx_Dispositivo.Location = new System.Drawing.Point(245, 122);
            this.cbx_Dispositivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_Dispositivo.Name = "cbx_Dispositivo";
            this.cbx_Dispositivo.Size = new System.Drawing.Size(264, 28);
            this.cbx_Dispositivo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soporte que brinda la empresa";
            // 
            // cbx_Problema
            // 
            this.cbx_Problema.Enabled = false;
            this.cbx_Problema.FormattingEnabled = true;
            this.cbx_Problema.Items.AddRange(new object[] {
            "Reparación",
            "Limpieza",
            "Cambio de piezas",
            "Mantenimiento"});
            this.cbx_Problema.Location = new System.Drawing.Point(245, 163);
            this.cbx_Problema.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbx_Problema.Name = "cbx_Problema";
            this.cbx_Problema.Size = new System.Drawing.Size(264, 28);
            this.cbx_Problema.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Díganos su problema:";
            // 
            // ServicioDataGridView
            // 
            this.ServicioDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServicioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServicioDataGridView.Location = new System.Drawing.Point(0, 252);
            this.ServicioDataGridView.Name = "ServicioDataGridView";
            this.ServicioDataGridView.Size = new System.Drawing.Size(569, 155);
            this.ServicioDataGridView.TabIndex = 45;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(445, 214);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(94, 32);
            this.btn_Cancelar.TabIndex = 44;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(345, 214);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(94, 32);
            this.btn_Eliminar.TabIndex = 43;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Enabled = false;
            this.btn_Guardar.Location = new System.Drawing.Point(245, 214);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(94, 32);
            this.btn_Guardar.TabIndex = 42;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(45, 214);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(94, 32);
            this.btn_Nuevo.TabIndex = 40;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(145, 214);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(94, 32);
            this.btn_Modificar.TabIndex = 41;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Cliente:";
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(245, 57);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(100, 26);
            this.txt_ID.TabIndex = 48;
            // 
            // txt_cliente
            // 
            this.txt_cliente.Enabled = false;
            this.txt_cliente.Location = new System.Drawing.Point(245, 90);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(261, 26);
            this.txt_cliente.TabIndex = 49;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // SoporteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(569, 406);
            this.Controls.Add(this.txt_cliente);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ServicioDataGridView);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.cbx_Problema);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_Dispositivo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SoporteView";
            this.Text = "Servicios";
            ((System.ComponentModel.ISupportInitialize)(this.ServicioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView ServicioDataGridView;
        public System.Windows.Forms.Button btn_Cancelar;
        public System.Windows.Forms.Button btn_Eliminar;
        public System.Windows.Forms.Button btn_Guardar;
        public System.Windows.Forms.Button btn_Nuevo;
        public System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_ID;
        public System.Windows.Forms.TextBox txt_cliente;
        public System.Windows.Forms.ComboBox cbx_Dispositivo;
        public System.Windows.Forms.ComboBox cbx_Problema;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}