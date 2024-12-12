namespace UI
{
    partial class frmbanco
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
            this.label3 = new System.Windows.Forms.Label();
            this.busqueda = new System.Windows.Forms.TextBox();
            this.gridbancos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.nuevo = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.TextBox();
            this.aceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridbancos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Descripción:";
            // 
            // busqueda
            // 
            this.busqueda.Location = new System.Drawing.Point(99, 22);
            this.busqueda.Name = "busqueda";
            this.busqueda.Size = new System.Drawing.Size(305, 22);
            this.busqueda.TabIndex = 14;
            this.busqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.busqueda_KeyPress);
            // 
            // gridbancos
            // 
            this.gridbancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridbancos.Location = new System.Drawing.Point(12, 70);
            this.gridbancos.Name = "gridbancos";
            this.gridbancos.RowHeadersWidth = 51;
            this.gridbancos.RowTemplate.Height = 24;
            this.gridbancos.Size = new System.Drawing.Size(392, 179);
            this.gridbancos.TabIndex = 12;
            this.gridbancos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridbancos_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.descripcion);
            this.groupBox1.Controls.Add(this.nuevo);
            this.groupBox1.Controls.Add(this.codigo);
            this.groupBox1.Controls.Add(this.aceptar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.eliminar);
            this.groupBox1.Location = new System.Drawing.Point(419, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 227);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código:";
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(111, 92);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(100, 22);
            this.descripcion.TabIndex = 6;
            // 
            // nuevo
            // 
            this.nuevo.Location = new System.Drawing.Point(7, 171);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(87, 40);
            this.nuevo.TabIndex = 0;
            this.nuevo.Text = "Nuevo";
            this.nuevo.UseVisualStyleBackColor = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(111, 45);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(100, 22);
            this.codigo.TabIndex = 5;
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(100, 171);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(87, 40);
            this.aceptar.TabIndex = 1;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripción:";
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(196, 171);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(87, 40);
            this.eliminar.TabIndex = 2;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // frmbanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 264);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.busqueda);
            this.Controls.Add(this.gridbancos);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmbanco";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridbancos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox busqueda;
        private System.Windows.Forms.DataGridView gridbancos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.Button nuevo;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button eliminar;
    }
}

