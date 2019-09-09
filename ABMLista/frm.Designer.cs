namespace ABMLista
{
    partial class frm
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
            this.btAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCarga = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.lblOrdenado = new System.Windows.Forms.Label();
            this.btMostrar = new System.Windows.Forms.Button();
            this.btOrdenar = new System.Windows.Forms.Button();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(286, 347);
            this.btAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(100, 28);
            this.btAgregar.TabIndex = 1;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.BtAgregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(220, 103);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(99, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // lblCarga
            // 
            this.lblCarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCarga.Location = new System.Drawing.Point(171, 146);
            this.lblCarga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCarga.Name = "lblCarga";
            this.lblCarga.Size = new System.Drawing.Size(159, 186);
            this.lblCarga.TabIndex = 4;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(416, 347);
            this.btBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(100, 28);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(560, 347);
            this.btBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(100, 28);
            this.btBorrar.TabIndex = 3;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.BtBorrar_Click);
            // 
            // lblOrdenado
            // 
            this.lblOrdenado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOrdenado.Location = new System.Drawing.Point(431, 157);
            this.lblOrdenado.Name = "lblOrdenado";
            this.lblOrdenado.Size = new System.Drawing.Size(137, 162);
            this.lblOrdenado.TabIndex = 5;
            // 
            // btMostrar
            // 
            this.btMostrar.Location = new System.Drawing.Point(159, 347);
            this.btMostrar.Margin = new System.Windows.Forms.Padding(4);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(100, 28);
            this.btMostrar.TabIndex = 17;
            this.btMostrar.Text = "Mostrar";
            this.btMostrar.UseVisualStyleBackColor = true;
            this.btMostrar.Click += new System.EventHandler(this.BtMostrar_Click);
            // 
            // btOrdenar
            // 
            this.btOrdenar.Location = new System.Drawing.Point(35, 347);
            this.btOrdenar.Margin = new System.Windows.Forms.Padding(4);
            this.btOrdenar.Name = "btOrdenar";
            this.btOrdenar.Size = new System.Drawing.Size(100, 28);
            this.btOrdenar.TabIndex = 15;
            this.btOrdenar.Text = "Ordenar";
            this.btOrdenar.UseVisualStyleBackColor = true;
            this.btOrdenar.Click += new System.EventHandler(this.BtOrdenar_Click);
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(378, 105);
            this.txtNota.Margin = new System.Windows.Forms.Padding(4);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(92, 22);
            this.txtNota.TabIndex = 20;
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(378, 85);
            this.lblNota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(38, 17);
            this.lblNota.TabIndex = 19;
            this.lblNota.Text = "Nota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombres";
            // 
            // frm
            // 
            this.AcceptButton = this.btAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(720, 376);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.btMostrar);
            this.Controls.Add(this.btOrdenar);
            this.Controls.Add(this.lblOrdenado);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.lblCarga);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btAgregar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm";
            this.Text = "Manejo de lista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCarga;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Label lblOrdenado;
        private System.Windows.Forms.Button btMostrar;
        private System.Windows.Forms.Button btOrdenar;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label label2;
    }
}

