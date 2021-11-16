
namespace PainterBesson
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCirculo = new System.Windows.Forms.Button();
            this.btnCuadrado = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDibujoMano = new System.Windows.Forms.Button();
            this.btnTexto = new System.Windows.Forms.Button();
            this.btnImagen = new System.Windows.Forms.Button();
            this.btnLinea = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCirculo
            // 
            this.btnCirculo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCirculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCirculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCirculo.ForeColor = System.Drawing.Color.White;
            this.btnCirculo.Image = ((System.Drawing.Image)(resources.GetObject("btnCirculo.Image")));
            this.btnCirculo.Location = new System.Drawing.Point(118, 12);
            this.btnCirculo.Name = "btnCirculo";
            this.btnCirculo.Size = new System.Drawing.Size(69, 65);
            this.btnCirculo.TabIndex = 0;
            this.btnCirculo.UseVisualStyleBackColor = false;
            this.btnCirculo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCirculo_MouseClick);
            // 
            // btnCuadrado
            // 
            this.btnCuadrado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuadrado.ForeColor = System.Drawing.Color.White;
            this.btnCuadrado.Image = ((System.Drawing.Image)(resources.GetObject("btnCuadrado.Image")));
            this.btnCuadrado.Location = new System.Drawing.Point(193, 12);
            this.btnCuadrado.Name = "btnCuadrado";
            this.btnCuadrado.Size = new System.Drawing.Size(69, 65);
            this.btnCuadrado.TabIndex = 1;
            this.btnCuadrado.UseVisualStyleBackColor = false;
            this.btnCuadrado.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCuadrado_MouseClick);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(12, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(69, 65);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnNuevo_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.btnDibujoMano);
            this.panel1.Controls.Add(this.btnTexto);
            this.panel1.Controls.Add(this.btnImagen);
            this.panel1.Controls.Add(this.btnLinea);
            this.panel1.Controls.Add(this.btnCuadrado);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.btnCirculo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 100);
            this.panel1.TabIndex = 3;
            // 
            // btnDibujoMano
            // 
            this.btnDibujoMano.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDibujoMano.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnDibujoMano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDibujoMano.ForeColor = System.Drawing.Color.White;
            this.btnDibujoMano.Image = global::PainterBesson.Properties.Resources.Pincel;
            this.btnDibujoMano.Location = new System.Drawing.Point(343, 12);
            this.btnDibujoMano.Name = "btnDibujoMano";
            this.btnDibujoMano.Size = new System.Drawing.Size(69, 65);
            this.btnDibujoMano.TabIndex = 6;
            this.btnDibujoMano.UseVisualStyleBackColor = false;
            // 
            // btnTexto
            // 
            this.btnTexto.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTexto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnTexto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTexto.ForeColor = System.Drawing.Color.White;
            this.btnTexto.Image = global::PainterBesson.Properties.Resources.Texto;
            this.btnTexto.Location = new System.Drawing.Point(418, 12);
            this.btnTexto.Name = "btnTexto";
            this.btnTexto.Size = new System.Drawing.Size(69, 65);
            this.btnTexto.TabIndex = 5;
            this.btnTexto.UseVisualStyleBackColor = false;
            // 
            // btnImagen
            // 
            this.btnImagen.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnImagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImagen.ForeColor = System.Drawing.Color.White;
            this.btnImagen.Image = global::PainterBesson.Properties.Resources.Imagen;
            this.btnImagen.Location = new System.Drawing.Point(493, 12);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(69, 65);
            this.btnImagen.TabIndex = 4;
            this.btnImagen.UseVisualStyleBackColor = false;
            // 
            // btnLinea
            // 
            this.btnLinea.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLinea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinea.ForeColor = System.Drawing.Color.White;
            this.btnLinea.Image = global::PainterBesson.Properties.Resources.Linea;
            this.btnLinea.Location = new System.Drawing.Point(268, 12);
            this.btnLinea.Name = "btnLinea";
            this.btnLinea.Size = new System.Drawing.Size(69, 65);
            this.btnLinea.TabIndex = 3;
            this.btnLinea.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 97);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Move += new System.EventHandler(this.Form1_Move);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCirculo;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLinea;
        private System.Windows.Forms.Button btnTexto;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.Button btnDibujoMano;
    }
}

