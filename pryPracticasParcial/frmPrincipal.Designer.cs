namespace pryPracticasParcial
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ejerciciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarAlumnoPorDNIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarAlumnoPorNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaFrutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodasLasFrutasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarOQuitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verFrutasQueLeGustanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queFrutasNoLeGustanLosALumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queAlumnoLeGustaUnaFrutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejerciciosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ejerciciosToolStripMenuItem
            // 
            this.ejerciciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoAlumnoToolStripMenuItem,
            this.consultarAlumnoPorDNIToolStripMenuItem,
            this.consultarAlumnoPorNombreToolStripMenuItem,
            this.verTodosToolStripMenuItem,
            this.nuevaFrutaToolStripMenuItem,
            this.verTodasLasFrutasToolStripMenuItem,
            this.agregarOQuitarToolStripMenuItem,
            this.verFrutasQueLeGustanToolStripMenuItem,
            this.queFrutasNoLeGustanLosALumnosToolStripMenuItem,
            this.queAlumnoLeGustaUnaFrutaToolStripMenuItem});
            this.ejerciciosToolStripMenuItem.Name = "ejerciciosToolStripMenuItem";
            this.ejerciciosToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.ejerciciosToolStripMenuItem.Text = "Ejercicios";
            // 
            // nuevoAlumnoToolStripMenuItem
            // 
            this.nuevoAlumnoToolStripMenuItem.Name = "nuevoAlumnoToolStripMenuItem";
            this.nuevoAlumnoToolStripMenuItem.Size = new System.Drawing.Size(329, 22);
            this.nuevoAlumnoToolStripMenuItem.Text = "Nuevo Alumno";
            this.nuevoAlumnoToolStripMenuItem.Click += new System.EventHandler(this.nuevoAlumnoToolStripMenuItem_Click);
            // 
            // consultarAlumnoPorDNIToolStripMenuItem
            // 
            this.consultarAlumnoPorDNIToolStripMenuItem.Name = "consultarAlumnoPorDNIToolStripMenuItem";
            this.consultarAlumnoPorDNIToolStripMenuItem.Size = new System.Drawing.Size(329, 22);
            this.consultarAlumnoPorDNIToolStripMenuItem.Text = "Consultar Alumno por DNI";
            this.consultarAlumnoPorDNIToolStripMenuItem.Click += new System.EventHandler(this.consultarAlumnoPorDNIToolStripMenuItem_Click);
            // 
            // consultarAlumnoPorNombreToolStripMenuItem
            // 
            this.consultarAlumnoPorNombreToolStripMenuItem.Name = "consultarAlumnoPorNombreToolStripMenuItem";
            this.consultarAlumnoPorNombreToolStripMenuItem.Size = new System.Drawing.Size(329, 22);
            this.consultarAlumnoPorNombreToolStripMenuItem.Text = "Consultar Alumno por Nombre";
            this.consultarAlumnoPorNombreToolStripMenuItem.Click += new System.EventHandler(this.consultarAlumnoPorNombreToolStripMenuItem_Click);
            // 
            // verTodosToolStripMenuItem
            // 
            this.verTodosToolStripMenuItem.Name = "verTodosToolStripMenuItem";
            this.verTodosToolStripMenuItem.Size = new System.Drawing.Size(329, 22);
            this.verTodosToolStripMenuItem.Text = "Ver Todos los Alumnos";
            this.verTodosToolStripMenuItem.Click += new System.EventHandler(this.verTodosToolStripMenuItem_Click);
            // 
            // nuevaFrutaToolStripMenuItem
            // 
            this.nuevaFrutaToolStripMenuItem.Name = "nuevaFrutaToolStripMenuItem";
            this.nuevaFrutaToolStripMenuItem.Size = new System.Drawing.Size(329, 22);
            this.nuevaFrutaToolStripMenuItem.Text = "Nueva Fruta";
            this.nuevaFrutaToolStripMenuItem.Click += new System.EventHandler(this.nuevaFrutaToolStripMenuItem_Click);
            // 
            // verTodasLasFrutasToolStripMenuItem
            // 
            this.verTodasLasFrutasToolStripMenuItem.Name = "verTodasLasFrutasToolStripMenuItem";
            this.verTodasLasFrutasToolStripMenuItem.Size = new System.Drawing.Size(329, 22);
            this.verTodasLasFrutasToolStripMenuItem.Text = "Ver Todas las Frutas";
            this.verTodasLasFrutasToolStripMenuItem.Click += new System.EventHandler(this.verTodasLasFrutasToolStripMenuItem_Click);
            // 
            // agregarOQuitarToolStripMenuItem
            // 
            this.agregarOQuitarToolStripMenuItem.Name = "agregarOQuitarToolStripMenuItem";
            this.agregarOQuitarToolStripMenuItem.Size = new System.Drawing.Size(329, 22);
            this.agregarOQuitarToolStripMenuItem.Text = "Agregar o Quitar Frutas que le gustan al Alumno";
            this.agregarOQuitarToolStripMenuItem.Click += new System.EventHandler(this.agregarOQuitarToolStripMenuItem_Click);
            // 
            // verFrutasQueLeGustanToolStripMenuItem
            // 
            this.verFrutasQueLeGustanToolStripMenuItem.Name = "verFrutasQueLeGustanToolStripMenuItem";
            this.verFrutasQueLeGustanToolStripMenuItem.Size = new System.Drawing.Size(329, 22);
            this.verFrutasQueLeGustanToolStripMenuItem.Text = "Ver Frutas Que Le Gustan";
            this.verFrutasQueLeGustanToolStripMenuItem.Click += new System.EventHandler(this.verFrutasQueLeGustanToolStripMenuItem_Click);
            // 
            // queFrutasNoLeGustanLosALumnosToolStripMenuItem
            // 
            this.queFrutasNoLeGustanLosALumnosToolStripMenuItem.Name = "queFrutasNoLeGustanLosALumnosToolStripMenuItem";
            this.queFrutasNoLeGustanLosALumnosToolStripMenuItem.Size = new System.Drawing.Size(329, 22);
            this.queFrutasNoLeGustanLosALumnosToolStripMenuItem.Text = "Que Frutas No Le Gustan Los ALumnos";
            this.queFrutasNoLeGustanLosALumnosToolStripMenuItem.Click += new System.EventHandler(this.queFrutasNoLeGustanLosALumnosToolStripMenuItem_Click);
            // 
            // queAlumnoLeGustaUnaFrutaToolStripMenuItem
            // 
            this.queAlumnoLeGustaUnaFrutaToolStripMenuItem.Name = "queAlumnoLeGustaUnaFrutaToolStripMenuItem";
            this.queAlumnoLeGustaUnaFrutaToolStripMenuItem.Size = new System.Drawing.Size(329, 22);
            this.queAlumnoLeGustaUnaFrutaToolStripMenuItem.Text = "Que Alumno Le Gusta Una Fruta";
            this.queAlumnoLeGustaUnaFrutaToolStripMenuItem.Click += new System.EventHandler(this.queAlumnoLeGustaUnaFrutaToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ejerciciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarAlumnoPorDNIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarAlumnoPorNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaFrutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTodasLasFrutasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarOQuitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verFrutasQueLeGustanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queFrutasNoLeGustanLosALumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queAlumnoLeGustaUnaFrutaToolStripMenuItem;
    }
}

