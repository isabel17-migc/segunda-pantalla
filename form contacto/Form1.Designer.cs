namespace form_contacto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblnombre = new Label();
            txtnombre = new TextBox();
            lblcontacto = new Label();
            chkdeseo = new CheckBox();
            rdconsulta = new RadioButton();
            rdqueja = new RadioButton();
            rdsugerencia = new RadioButton();
            btnenviar = new Button();
            lblconfirmacion = new Label();
            txtconfirmacion = new TextBox();
            linkpolitica = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 18);
            label1.Name = "label1";
            label1.Size = new Size(280, 25);
            label1.TabIndex = 0;
            label1.Text = "FORMULARIO DE CONTACTO";
            label1.Click += label1_Click;
            // 
            // lblnombre
            // 
            lblnombre.AutoSize = true;
            lblnombre.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblnombre.Location = new Point(22, 69);
            lblnombre.Name = "lblnombre";
            lblnombre.Size = new Size(75, 20);
            lblnombre.TabIndex = 1;
            lblnombre.Text = "NOMBRE:";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(117, 66);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(171, 23);
            txtnombre.TabIndex = 2;
            // 
            // lblcontacto
            // 
            lblcontacto.AutoSize = true;
            lblcontacto.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblcontacto.Location = new Point(12, 117);
            lblcontacto.Name = "lblcontacto";
            lblcontacto.Size = new Size(177, 20);
            lblcontacto.TabIndex = 3;
            lblcontacto.Text = "MOTIVO DE CONTACTO:";
            // 
            // chkdeseo
            // 
            chkdeseo.AutoSize = true;
            chkdeseo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            chkdeseo.Location = new Point(22, 244);
            chkdeseo.Name = "chkdeseo";
            chkdeseo.Size = new Size(192, 21);
            chkdeseo.TabIndex = 4;
            chkdeseo.Text = "DESEO RECIBIR RESPUESTA";
            chkdeseo.UseVisualStyleBackColor = true;
            // 
            // rdconsulta
            // 
            rdconsulta.AutoSize = true;
            rdconsulta.Font = new Font("Segoe UI Historic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            rdconsulta.Location = new Point(22, 153);
            rdconsulta.Name = "rdconsulta";
            rdconsulta.Size = new Size(91, 21);
            rdconsulta.TabIndex = 5;
            rdconsulta.TabStop = true;
            rdconsulta.Text = "CONSULTA";
            rdconsulta.UseVisualStyleBackColor = true;
            // 
            // rdqueja
            // 
            rdqueja.AutoSize = true;
            rdqueja.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            rdqueja.Location = new Point(22, 180);
            rdqueja.Name = "rdqueja";
            rdqueja.Size = new Size(65, 21);
            rdqueja.TabIndex = 6;
            rdqueja.TabStop = true;
            rdqueja.Text = "QUEJA";
            rdqueja.UseVisualStyleBackColor = true;
            // 
            // rdsugerencia
            // 
            rdsugerencia.AutoSize = true;
            rdsugerencia.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            rdsugerencia.Location = new Point(22, 205);
            rdsugerencia.Name = "rdsugerencia";
            rdsugerencia.Size = new Size(102, 21);
            rdsugerencia.TabIndex = 7;
            rdsugerencia.TabStop = true;
            rdsugerencia.Text = "SUGERENCIA";
            rdsugerencia.UseVisualStyleBackColor = true;
            // 
            // btnenviar
            // 
            btnenviar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnenviar.Location = new Point(236, 243);
            btnenviar.Name = "btnenviar";
            btnenviar.Size = new Size(75, 23);
            btnenviar.TabIndex = 8;
            btnenviar.Text = "ENVIAR";
            btnenviar.UseVisualStyleBackColor = true;
            btnenviar.Click += btnenviar_Click;
            // 
            // lblconfirmacion
            // 
            lblconfirmacion.AutoSize = true;
            lblconfirmacion.Font = new Font("Segoe UI Variable Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblconfirmacion.Location = new Point(12, 268);
            lblconfirmacion.Name = "lblconfirmacion";
            lblconfirmacion.Size = new Size(120, 20);
            lblconfirmacion.TabIndex = 9;
            lblconfirmacion.Text = "CONFIRMACION";
            // 
            // txtconfirmacion
            // 
            txtconfirmacion.Location = new Point(31, 306);
            txtconfirmacion.Multiline = true;
            txtconfirmacion.Name = "txtconfirmacion";
            txtconfirmacion.Size = new Size(280, 73);
            txtconfirmacion.TabIndex = 10;
            // 
            // linkpolitica
            // 
            linkpolitica.AutoSize = true;
            linkpolitica.Location = new Point(89, 398);
            linkpolitica.Name = "linkpolitica";
            linkpolitica.Size = new Size(169, 15);
            linkpolitica.TabIndex = 11;
            linkpolitica.TabStop = true;
            linkpolitica.Text = " VER POLITICA DE PRIVACIDAD";
            linkpolitica.LinkClicked += linkpolitica_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 422);
            Controls.Add(linkpolitica);
            Controls.Add(txtconfirmacion);
            Controls.Add(lblconfirmacion);
            Controls.Add(btnenviar);
            Controls.Add(rdsugerencia);
            Controls.Add(rdqueja);
            Controls.Add(rdconsulta);
            Controls.Add(chkdeseo);
            Controls.Add(lblcontacto);
            Controls.Add(txtnombre);
            Controls.Add(lblnombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Formulario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblnombre;
        private TextBox txtnombre;
        private Label lblcontacto;
        private CheckBox chkdeseo;
        private RadioButton rdconsulta;
        private RadioButton rdqueja;
        private RadioButton rdsugerencia;
        private Button btnenviar;
        private Label lblconfirmacion;
        private TextBox txtconfirmacion;
        private LinkLabel linkpolitica;
    }
}
