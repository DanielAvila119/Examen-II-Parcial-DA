
namespace Examen_II_Parcial_DA.Vistas
{
    partial class TicketsView
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NomCliente = new System.Windows.Forms.TextBox();
            this.txt_Asunto = new System.Windows.Forms.TextBox();
            this.txt_Mensaje = new System.Windows.Forms.TextBox();
            this.txt_EmailCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Dispositivo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_numTicket = new System.Windows.Forms.TextBox();
            this.TicketsDataGridView = new System.Windows.Forms.DataGridView();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TicketsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Asunto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mensaje:";
            // 
            // txt_NomCliente
            // 
            this.txt_NomCliente.Enabled = false;
            this.txt_NomCliente.Location = new System.Drawing.Point(96, 80);
            this.txt_NomCliente.Name = "txt_NomCliente";
            this.txt_NomCliente.Size = new System.Drawing.Size(300, 20);
            this.txt_NomCliente.TabIndex = 3;
            // 
            // txt_Asunto
            // 
            this.txt_Asunto.Enabled = false;
            this.txt_Asunto.Location = new System.Drawing.Point(96, 166);
            this.txt_Asunto.Name = "txt_Asunto";
            this.txt_Asunto.Size = new System.Drawing.Size(300, 20);
            this.txt_Asunto.TabIndex = 4;
            // 
            // txt_Mensaje
            // 
            this.txt_Mensaje.Enabled = false;
            this.txt_Mensaje.Location = new System.Drawing.Point(96, 197);
            this.txt_Mensaje.Multiline = true;
            this.txt_Mensaje.Name = "txt_Mensaje";
            this.txt_Mensaje.Size = new System.Drawing.Size(300, 53);
            this.txt_Mensaje.TabIndex = 5;
            // 
            // txt_EmailCliente
            // 
            this.txt_EmailCliente.Enabled = false;
            this.txt_EmailCliente.Location = new System.Drawing.Point(96, 106);
            this.txt_EmailCliente.Name = "txt_EmailCliente";
            this.txt_EmailCliente.Size = new System.Drawing.Size(300, 20);
            this.txt_EmailCliente.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(185, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Generador de Tickets";
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(96, 54);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(101, 20);
            this.txt_ID.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Dispositivo:";
            // 
            // txt_Dispositivo
            // 
            this.txt_Dispositivo.Enabled = false;
            this.txt_Dispositivo.Location = new System.Drawing.Point(96, 135);
            this.txt_Dispositivo.Name = "txt_Dispositivo";
            this.txt_Dispositivo.Size = new System.Drawing.Size(300, 20);
            this.txt_Dispositivo.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Numero de Ticket:";
            // 
            // txt_numTicket
            // 
            this.txt_numTicket.Enabled = false;
            this.txt_numTicket.Location = new System.Drawing.Point(433, 40);
            this.txt_numTicket.Name = "txt_numTicket";
            this.txt_numTicket.Size = new System.Drawing.Size(89, 20);
            this.txt_numTicket.TabIndex = 15;
            // 
            // TicketsDataGridView
            // 
            this.TicketsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TicketsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketsDataGridView.Location = new System.Drawing.Point(0, 294);
            this.TicketsDataGridView.Name = "TicketsDataGridView";
            this.TicketsDataGridView.Size = new System.Drawing.Size(548, 132);
            this.TicketsDataGridView.TabIndex = 57;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(428, 256);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(94, 32);
            this.btn_Cancelar.TabIndex = 56;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(328, 256);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(94, 32);
            this.btn_Eliminar.TabIndex = 55;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Enabled = false;
            this.btn_Guardar.Location = new System.Drawing.Point(228, 256);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(94, 32);
            this.btn_Guardar.TabIndex = 54;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(128, 256);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(94, 32);
            this.btn_Modificar.TabIndex = 53;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Location = new System.Drawing.Point(28, 256);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(94, 32);
            this.btn_Nuevo.TabIndex = 52;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TicketsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(548, 424);
            this.Controls.Add(this.TicketsDataGridView);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.txt_numTicket);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Dispositivo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_EmailCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Mensaje);
            this.Controls.Add(this.txt_Asunto);
            this.Controls.Add(this.txt_NomCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TicketsView";
            this.Text = "Tickets";
            ((System.ComponentModel.ISupportInitialize)(this.TicketsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_NomCliente;
        public System.Windows.Forms.TextBox txt_Asunto;
        public System.Windows.Forms.TextBox txt_Mensaje;
        public System.Windows.Forms.TextBox txt_EmailCliente;
        public System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_Dispositivo;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DataGridView TicketsDataGridView;
        public System.Windows.Forms.Button btn_Cancelar;
        public System.Windows.Forms.Button btn_Eliminar;
        public System.Windows.Forms.Button btn_Guardar;
        public System.Windows.Forms.Button btn_Modificar;
        public System.Windows.Forms.Button btn_Nuevo;
        public System.Windows.Forms.TextBox txt_numTicket;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}