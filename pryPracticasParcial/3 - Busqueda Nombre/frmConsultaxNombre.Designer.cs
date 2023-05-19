namespace pryPracticasParcial
{
    partial class frmConsultaxNombre
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
            this.cboBarrio = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Barrio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dni = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboBarrio
            // 
            this.cboBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBarrio.FormattingEnabled = true;
            this.cboBarrio.Location = new System.Drawing.Point(190, 133);
            this.cboBarrio.Name = "cboBarrio";
            this.cboBarrio.Size = new System.Drawing.Size(145, 21);
            this.cboBarrio.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFoto
            // 
            this.txtFoto.Location = new System.Drawing.Point(190, 200);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.ReadOnly = true;
            this.txtFoto.Size = new System.Drawing.Size(145, 20);
            this.txtFoto.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Foto";
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(190, 166);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.ReadOnly = true;
            this.txtSexo.Size = new System.Drawing.Size(145, 20);
            this.txtSexo.TabIndex = 18;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(190, 79);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(145, 20);
            this.txtNombre.TabIndex = 17;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(190, 107);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.ReadOnly = true;
            this.txtDNI.Size = new System.Drawing.Size(145, 20);
            this.txtDNI.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Sexo";
            // 
            // Barrio
            // 
            this.Barrio.AutoSize = true;
            this.Barrio.Location = new System.Drawing.Point(148, 133);
            this.Barrio.Name = "Barrio";
            this.Barrio.Size = new System.Drawing.Size(34, 13);
            this.Barrio.TabIndex = 14;
            this.Barrio.Text = "Barrio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre";
            // 
            // dni
            // 
            this.dni.AutoSize = true;
            this.dni.Location = new System.Drawing.Point(148, 107);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(23, 13);
            this.dni.TabIndex = 12;
            this.dni.Text = "Dni";
            // 
            // frmConsultaxNombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboBarrio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFoto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Barrio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dni);
            this.Name = "frmConsultaxNombre";
            this.Text = "frmConsultaxNombre";
            this.Load += new System.EventHandler(this.frmConsultaxNombre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBarrio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Barrio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dni;
    }
}