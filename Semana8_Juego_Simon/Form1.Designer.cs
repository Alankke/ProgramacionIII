namespace JuegoSimon3
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
            this.button_jugar = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.label_Puntaje = new System.Windows.Forms.Label();
            this.label_Puntaje_Nro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_jugar
            // 
            resources.ApplyResources(this.button_jugar, "button_jugar");
            this.button_jugar.Name = "button_jugar";
            this.button_jugar.UseVisualStyleBackColor = true;
            this.button_jugar.Click += new System.EventHandler(this.button_jugar_Click);
            // 
            // button_0
            // 
            resources.ApplyResources(this.button_0, "button_0");
            this.button_0.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_0.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button_0.Name = "button_0";
            this.button_0.UseVisualStyleBackColor = false;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            this.button_0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_0_MouseDown);
            this.button_0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_0_MouseUp);
            // 
            // button_1
            // 
            resources.ApplyResources(this.button_1, "button_1");
            this.button_1.BackColor = System.Drawing.Color.Olive;
            this.button_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button_1.Name = "button_1";
            this.button_1.UseVisualStyleBackColor = false;
            this.button_1.Click += new System.EventHandler(this.button_0_Click);
            this.button_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_1_MouseDown);
            this.button_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_1_MouseUp);
            // 
            // button_2
            // 
            resources.ApplyResources(this.button_2, "button_2");
            this.button_2.BackColor = System.Drawing.Color.DarkRed;
            this.button_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button_2.Name = "button_2";
            this.button_2.UseVisualStyleBackColor = false;
            this.button_2.Click += new System.EventHandler(this.button_0_Click);
            this.button_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_2_MouseDown);
            this.button_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_2_MouseUp);
            // 
            // button_3
            // 
            resources.ApplyResources(this.button_3, "button_3");
            this.button_3.BackColor = System.Drawing.Color.DarkGreen;
            this.button_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button_3.Name = "button_3";
            this.button_3.UseVisualStyleBackColor = false;
            this.button_3.Click += new System.EventHandler(this.button_0_Click);
            this.button_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_3_MouseDown);
            this.button_3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_3_MouseUp);
            // 
            // label_Puntaje
            // 
            resources.ApplyResources(this.label_Puntaje, "label_Puntaje");
            this.label_Puntaje.Name = "label_Puntaje";
            // 
            // label_Puntaje_Nro
            // 
            resources.ApplyResources(this.label_Puntaje_Nro, "label_Puntaje_Nro");
            this.label_Puntaje_Nro.Name = "label_Puntaje_Nro";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_Puntaje_Nro);
            this.Controls.Add(this.label_Puntaje);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_jugar);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_jugar;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Label label_Puntaje;
        private System.Windows.Forms.Label label_Puntaje_Nro;
    }
}

