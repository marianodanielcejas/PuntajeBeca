
namespace Presentación1
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
            this.LBLresult = new System.Windows.Forms.Label();
            this.BTconteo = new System.Windows.Forms.Button();
            this.TXTconteo = new System.Windows.Forms.TextBox();
            this.LBLintroducción = new System.Windows.Forms.Label();
            this.LBLpuntos = new System.Windows.Forms.Label();
            this.LBLaclaración = new System.Windows.Forms.Label();
            this.LBLpuntaje = new System.Windows.Forms.Label();
            this.LBLrespuesta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBLresult
            // 
            this.LBLresult.AutoSize = true;
            this.LBLresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLresult.Location = new System.Drawing.Point(487, 141);
            this.LBLresult.Name = "LBLresult";
            this.LBLresult.Size = new System.Drawing.Size(0, 20);
            this.LBLresult.TabIndex = 0;
            // 
            // BTconteo
            // 
            this.BTconteo.BackColor = System.Drawing.Color.Silver;
            this.BTconteo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTconteo.Location = new System.Drawing.Point(360, 137);
            this.BTconteo.Name = "BTconteo";
            this.BTconteo.Size = new System.Drawing.Size(87, 33);
            this.BTconteo.TabIndex = 1;
            this.BTconteo.Text = "Accion";
            this.BTconteo.UseVisualStyleBackColor = false;
            this.BTconteo.Click += new System.EventHandler(this.BTconteo_Click);
            // 
            // TXTconteo
            // 
            this.TXTconteo.Location = new System.Drawing.Point(84, 140);
            this.TXTconteo.Name = "TXTconteo";
            this.TXTconteo.Size = new System.Drawing.Size(100, 20);
            this.TXTconteo.TabIndex = 2;
            this.TXTconteo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LBLintroducción
            // 
            this.LBLintroducción.AutoSize = true;
            this.LBLintroducción.BackColor = System.Drawing.Color.Lime;
            this.LBLintroducción.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLintroducción.Location = new System.Drawing.Point(188, 27);
            this.LBLintroducción.Name = "LBLintroducción";
            this.LBLintroducción.Size = new System.Drawing.Size(449, 25);
            this.LBLintroducción.TabIndex = 3;
            this.LBLintroducción.Text = "Prueba Beca: Ingrese un número entre 1 y 20";
            // 
            // LBLpuntos
            // 
            this.LBLpuntos.AutoSize = true;
            this.LBLpuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLpuntos.Location = new System.Drawing.Point(531, 141);
            this.LBLpuntos.Name = "LBLpuntos";
            this.LBLpuntos.Size = new System.Drawing.Size(0, 20);
            this.LBLpuntos.TabIndex = 4;
            // 
            // LBLaclaración
            // 
            this.LBLaclaración.AutoSize = true;
            this.LBLaclaración.BackColor = System.Drawing.Color.Yellow;
            this.LBLaclaración.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLaclaración.Location = new System.Drawing.Point(31, 81);
            this.LBLaclaración.Name = "LBLaclaración";
            this.LBLaclaración.Size = new System.Drawing.Size(757, 25);
            this.LBLaclaración.TabIndex = 5;
            this.LBLaclaración.Text = "Al número ingresado se le suman los números que le siguen hasta llegar a 20";
            // 
            // LBLpuntaje
            // 
            this.LBLpuntaje.AutoSize = true;
            this.LBLpuntaje.BackColor = System.Drawing.Color.Red;
            this.LBLpuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLpuntaje.Location = new System.Drawing.Point(462, 174);
            this.LBLpuntaje.Name = "LBLpuntaje";
            this.LBLpuntaje.Size = new System.Drawing.Size(52, 17);
            this.LBLpuntaje.TabIndex = 6;
            this.LBLpuntaje.Text = "Puntos";
            // 
            // LBLrespuesta
            // 
            this.LBLrespuesta.AutoSize = true;
            this.LBLrespuesta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LBLrespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLrespuesta.Location = new System.Drawing.Point(536, 174);
            this.LBLrespuesta.Name = "LBLrespuesta";
            this.LBLrespuesta.Size = new System.Drawing.Size(76, 17);
            this.LBLrespuesta.TabIndex = 7;
            this.LBLrespuesta.Text = "Respuesta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Presione el boton acción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Completar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBLrespuesta);
            this.Controls.Add(this.LBLpuntaje);
            this.Controls.Add(this.LBLaclaración);
            this.Controls.Add(this.LBLpuntos);
            this.Controls.Add(this.LBLintroducción);
            this.Controls.Add(this.TXTconteo);
            this.Controls.Add(this.BTconteo);
            this.Controls.Add(this.LBLresult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLresult;
        private System.Windows.Forms.Button BTconteo;
        private System.Windows.Forms.TextBox TXTconteo;
        private System.Windows.Forms.Label LBLintroducción;
        private System.Windows.Forms.Label LBLpuntos;
        private System.Windows.Forms.Label LBLaclaración;
        private System.Windows.Forms.Label LBLpuntaje;
        private System.Windows.Forms.Label LBLrespuesta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

