namespace OscarRodriguez.Vista
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresoDeEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeMateriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeNotasDeEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoDeEstudianteToolStripMenuItem,
            this.materiaToolStripMenuItem,
            this.ingresoDeNotasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(660, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresoDeEstudianteToolStripMenuItem
            // 
            this.ingresoDeEstudianteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosEstudianteToolStripMenuItem});
            this.ingresoDeEstudianteToolStripMenuItem.Name = "ingresoDeEstudianteToolStripMenuItem";
            this.ingresoDeEstudianteToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.ingresoDeEstudianteToolStripMenuItem.Text = "Ingreso de estudiante";
            // 
            // materiaToolStripMenuItem
            // 
            this.materiaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoDeMateriasToolStripMenuItem});
            this.materiaToolStripMenuItem.Name = "materiaToolStripMenuItem";
            this.materiaToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.materiaToolStripMenuItem.Text = "Materia";
            // 
            // ingresoDeNotasToolStripMenuItem
            // 
            this.ingresoDeNotasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoDeNotasDeEstudianteToolStripMenuItem});
            this.ingresoDeNotasToolStripMenuItem.Name = "ingresoDeNotasToolStripMenuItem";
            this.ingresoDeNotasToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.ingresoDeNotasToolStripMenuItem.Text = "Ingreso de notas";
            // 
            // datosEstudianteToolStripMenuItem
            // 
            this.datosEstudianteToolStripMenuItem.Name = "datosEstudianteToolStripMenuItem";
            this.datosEstudianteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.datosEstudianteToolStripMenuItem.Text = "Datos estudiante";
            // 
            // mantenimientoDeMateriasToolStripMenuItem
            // 
            this.mantenimientoDeMateriasToolStripMenuItem.Name = "mantenimientoDeMateriasToolStripMenuItem";
            this.mantenimientoDeMateriasToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.mantenimientoDeMateriasToolStripMenuItem.Text = "Mantenimiento de materias";
            // 
            // ingresoDeNotasDeEstudianteToolStripMenuItem
            // 
            this.ingresoDeNotasDeEstudianteToolStripMenuItem.Name = "ingresoDeNotasDeEstudianteToolStripMenuItem";
            this.ingresoDeNotasDeEstudianteToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.ingresoDeNotasDeEstudianteToolStripMenuItem.Text = "Ingreso de notas de Estudiante";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(660, 291);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeMateriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeNotasDeEstudianteToolStripMenuItem;
    }
}