namespace Formulario_proyecto_5
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
            this.Lb_Nombre = new System.Windows.Forms.Label();
            this.Lb_Apellidos = new System.Windows.Forms.Label();
            this.Lb_Telefono = new System.Windows.Forms.Label();
            this.Lb_estatura = new System.Windows.Forms.Label();
            this.Lb_Edad = new System.Windows.Forms.Label();
            this.Tb_Nombre = new System.Windows.Forms.TextBox();
            this.Tb_Apellidos = new System.Windows.Forms.TextBox();
            this.Tb_Telefono = new System.Windows.Forms.TextBox();
            this.Tb_Estatura = new System.Windows.Forms.TextBox();
            this.Tb_Edad = new System.Windows.Forms.TextBox();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Gb_Genero = new System.Windows.Forms.GroupBox();
            this.Rbt_Mujer = new System.Windows.Forms.RadioButton();
            this.Rbt_Hombre = new System.Windows.Forms.RadioButton();
            this.Gb_Genero.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lb_Nombre
            // 
            this.Lb_Nombre.AutoSize = true;
            this.Lb_Nombre.Location = new System.Drawing.Point(12, 31);
            this.Lb_Nombre.Name = "Lb_Nombre";
            this.Lb_Nombre.Size = new System.Drawing.Size(59, 16);
            this.Lb_Nombre.TabIndex = 0;
            this.Lb_Nombre.Text = "Nombre:";
            // 
            // Lb_Apellidos
            // 
            this.Lb_Apellidos.AutoSize = true;
            this.Lb_Apellidos.Location = new System.Drawing.Point(12, 72);
            this.Lb_Apellidos.Name = "Lb_Apellidos";
            this.Lb_Apellidos.Size = new System.Drawing.Size(67, 16);
            this.Lb_Apellidos.TabIndex = 1;
            this.Lb_Apellidos.Text = "Apellidos:";
            // 
            // Lb_Telefono
            // 
            this.Lb_Telefono.AutoSize = true;
            this.Lb_Telefono.Location = new System.Drawing.Point(12, 109);
            this.Lb_Telefono.Name = "Lb_Telefono";
            this.Lb_Telefono.Size = new System.Drawing.Size(64, 16);
            this.Lb_Telefono.TabIndex = 2;
            this.Lb_Telefono.Text = "Teléfono:";
            // 
            // Lb_estatura
            // 
            this.Lb_estatura.AutoSize = true;
            this.Lb_estatura.Location = new System.Drawing.Point(12, 140);
            this.Lb_estatura.Name = "Lb_estatura";
            this.Lb_estatura.Size = new System.Drawing.Size(60, 16);
            this.Lb_estatura.TabIndex = 3;
            this.Lb_estatura.Text = "Estarura:";
            // 
            // Lb_Edad
            // 
            this.Lb_Edad.AutoSize = true;
            this.Lb_Edad.Location = new System.Drawing.Point(12, 176);
            this.Lb_Edad.Name = "Lb_Edad";
            this.Lb_Edad.Size = new System.Drawing.Size(43, 16);
            this.Lb_Edad.TabIndex = 4;
            this.Lb_Edad.Text = "Edad:";
            // 
            // Tb_Nombre
            // 
            this.Tb_Nombre.Location = new System.Drawing.Point(90, 31);
            this.Tb_Nombre.Name = "Tb_Nombre";
            this.Tb_Nombre.Size = new System.Drawing.Size(100, 22);
            this.Tb_Nombre.TabIndex = 5;
            // 
            // Tb_Apellidos
            // 
            this.Tb_Apellidos.Location = new System.Drawing.Point(90, 72);
            this.Tb_Apellidos.Name = "Tb_Apellidos";
            this.Tb_Apellidos.Size = new System.Drawing.Size(100, 22);
            this.Tb_Apellidos.TabIndex = 6;
            // 
            // Tb_Telefono
            // 
            this.Tb_Telefono.Location = new System.Drawing.Point(90, 109);
            this.Tb_Telefono.Name = "Tb_Telefono";
            this.Tb_Telefono.Size = new System.Drawing.Size(100, 22);
            this.Tb_Telefono.TabIndex = 7;
            // 
            // Tb_Estatura
            // 
            this.Tb_Estatura.Location = new System.Drawing.Point(90, 140);
            this.Tb_Estatura.Name = "Tb_Estatura";
            this.Tb_Estatura.Size = new System.Drawing.Size(100, 22);
            this.Tb_Estatura.TabIndex = 8;
            // 
            // Tb_Edad
            // 
            this.Tb_Edad.Location = new System.Drawing.Point(90, 176);
            this.Tb_Edad.Name = "Tb_Edad";
            this.Tb_Edad.Size = new System.Drawing.Size(100, 22);
            this.Tb_Edad.TabIndex = 9;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(90, 430);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(190, 88);
            this.Btn_Guardar.TabIndex = 10;
            this.Btn_Guardar.Text = "Guardad";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(90, 564);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(190, 88);
            this.Btn_Cancelar.TabIndex = 11;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Gb_Genero
            // 
            this.Gb_Genero.Controls.Add(this.Rbt_Mujer);
            this.Gb_Genero.Controls.Add(this.Rbt_Hombre);
            this.Gb_Genero.Location = new System.Drawing.Point(38, 266);
            this.Gb_Genero.Name = "Gb_Genero";
            this.Gb_Genero.Size = new System.Drawing.Size(303, 73);
            this.Gb_Genero.TabIndex = 12;
            this.Gb_Genero.TabStop = false;
            this.Gb_Genero.Text = "Género";
            // 
            // Rbt_Mujer
            // 
            this.Rbt_Mujer.AutoSize = true;
            this.Rbt_Mujer.Location = new System.Drawing.Point(158, 41);
            this.Rbt_Mujer.Name = "Rbt_Mujer";
            this.Rbt_Mujer.Size = new System.Drawing.Size(61, 20);
            this.Rbt_Mujer.TabIndex = 13;
            this.Rbt_Mujer.TabStop = true;
            this.Rbt_Mujer.Text = "Mujer";
            this.Rbt_Mujer.UseVisualStyleBackColor = true;
            // 
            // Rbt_Hombre
            // 
            this.Rbt_Hombre.AutoSize = true;
            this.Rbt_Hombre.Location = new System.Drawing.Point(6, 41);
            this.Rbt_Hombre.Name = "Rbt_Hombre";
            this.Rbt_Hombre.Size = new System.Drawing.Size(77, 20);
            this.Rbt_Hombre.TabIndex = 13;
            this.Rbt_Hombre.TabStop = true;
            this.Rbt_Hombre.Text = "Hombre";
            this.Rbt_Hombre.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 783);
            this.Controls.Add(this.Gb_Genero);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.Tb_Edad);
            this.Controls.Add(this.Tb_Estatura);
            this.Controls.Add(this.Tb_Telefono);
            this.Controls.Add(this.Tb_Apellidos);
            this.Controls.Add(this.Tb_Nombre);
            this.Controls.Add(this.Lb_Edad);
            this.Controls.Add(this.Lb_estatura);
            this.Controls.Add(this.Lb_Telefono);
            this.Controls.Add(this.Lb_Apellidos);
            this.Controls.Add(this.Lb_Nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Gb_Genero.ResumeLayout(false);
            this.Gb_Genero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_Nombre;
        private System.Windows.Forms.Label Lb_Apellidos;
        private System.Windows.Forms.Label Lb_Telefono;
        private System.Windows.Forms.Label Lb_estatura;
        private System.Windows.Forms.Label Lb_Edad;
        private System.Windows.Forms.TextBox Tb_Nombre;
        private System.Windows.Forms.TextBox Tb_Apellidos;
        private System.Windows.Forms.TextBox Tb_Telefono;
        private System.Windows.Forms.TextBox Tb_Estatura;
        private System.Windows.Forms.TextBox Tb_Edad;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.GroupBox Gb_Genero;
        private System.Windows.Forms.RadioButton Rbt_Mujer;
        private System.Windows.Forms.RadioButton Rbt_Hombre;
    }
}

