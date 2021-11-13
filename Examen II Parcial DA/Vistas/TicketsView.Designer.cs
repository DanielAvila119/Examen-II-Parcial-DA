
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NomCliente = new System.Windows.Forms.TextBox();
            this.txt_Asunto = new System.Windows.Forms.TextBox();
            this.txt_Mensaje = new System.Windows.Forms.TextBox();
            this.txt_EmailCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_GenerarTicket = new System.Windows.Forms.Button();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Dispositivo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_numTicket = new System.Windows.Forms.TextBox();
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
            this.txt_NomCliente.Location = new System.Drawing.Point(96, 80);
            this.txt_NomCliente.Name = "txt_NomCliente";
            this.txt_NomCliente.Size = new System.Drawing.Size(300, 20);
            this.txt_NomCliente.TabIndex = 3;
            // 
            // txt_Asunto
            // 
            this.txt_Asunto.Location = new System.Drawing.Point(96, 166);
            this.txt_Asunto.Name = "txt_Asunto";
            this.txt_Asunto.Size = new System.Drawing.Size(300, 20);
            this.txt_Asunto.TabIndex = 4;
            // 
            // txt_Mensaje
            // 
            this.txt_Mensaje.Location = new System.Drawing.Point(96, 197);
            this.txt_Mensaje.Multiline = true;
            this.txt_Mensaje.Name = "txt_Mensaje";
            this.txt_Mensaje.Size = new System.Drawing.Size(300, 79);
            this.txt_Mensaje.TabIndex = 5;
            // 
            // txt_EmailCliente
            // 
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
            this.label5.Location = new System.Drawing.Point(113, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Generador de Tickets";
            // 
            // btn_GenerarTicket
            // 
            this.btn_GenerarTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GenerarTicket.Location = new System.Drawing.Point(137, 282);
            this.btn_GenerarTicket.Name = "btn_GenerarTicket";
            this.btn_GenerarTicket.Size = new System.Drawing.Size(147, 43);
            this.btn_GenerarTicket.TabIndex = 9;
            this.btn_GenerarTicket.Text = "Generar ticket";
            this.btn_GenerarTicket.UseVisualStyleBackColor = true;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(96, 54);
            this.txt_ID.Name = "txt_ID";
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
            this.txt_Dispositivo.Location = new System.Drawing.Point(96, 135);
            this.txt_Dispositivo.Name = "txt_Dispositivo";
            this.txt_Dispositivo.Size = new System.Drawing.Size(300, 20);
            this.txt_Dispositivo.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(107, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Numero de Ticket:";
            // 
            // txt_numTicket
            // 
            this.txt_numTicket.Location = new System.Drawing.Point(209, 340);
            this.txt_numTicket.Name = "txt_numTicket";
            this.txt_numTicket.Size = new System.Drawing.Size(89, 20);
            this.txt_numTicket.TabIndex = 15;
            // 
            // TicketsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 388);
            this.Controls.Add(this.txt_numTicket);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Dispositivo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_GenerarTicket);
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
        public System.Windows.Forms.Button btn_GenerarTicket;
        public System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_Dispositivo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_numTicket;
    }
}