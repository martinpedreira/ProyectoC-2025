namespace WindowsApp
{
    partial class LibrosPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.btnTraerTodo = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnObtenerPorId = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.btnObtenerPorAutor = new System.Windows.Forms.Button();
            this.btnObtenerPorLectura = new System.Windows.Forms.Button();
            this.cmbObtenerPorLectura = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToResizeColumns = false;
            this.dgvLibros.AllowUserToResizeRows = false;
            this.dgvLibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLibros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLibros.ColumnHeadersHeight = 35;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLibros.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLibros.Location = new System.Drawing.Point(75, 40);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvLibros.Size = new System.Drawing.Size(981, 362);
            this.dgvLibros.TabIndex = 0;
            this.dgvLibros.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLibros_CellFormatting);
            // 
            // btnTraerTodo
            // 
            this.btnTraerTodo.Location = new System.Drawing.Point(111, 477);
            this.btnTraerTodo.Name = "btnTraerTodo";
            this.btnTraerTodo.Size = new System.Drawing.Size(109, 44);
            this.btnTraerTodo.TabIndex = 1;
            this.btnTraerTodo.Text = "Traer Todo";
            this.btnTraerTodo.UseVisualStyleBackColor = true;
            this.btnTraerTodo.Click += new System.EventHandler(this.btnTraerTodo_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(237, 477);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(99, 44);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(354, 477);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(112, 44);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(484, 477);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 44);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnObtenerPorId
            // 
            this.btnObtenerPorId.Location = new System.Drawing.Point(733, 485);
            this.btnObtenerPorId.Name = "btnObtenerPorId";
            this.btnObtenerPorId.Size = new System.Drawing.Size(132, 23);
            this.btnObtenerPorId.TabIndex = 5;
            this.btnObtenerPorId.Text = "Obtener por id";
            this.btnObtenerPorId.UseVisualStyleBackColor = true;
            this.btnObtenerPorId.Click += new System.EventHandler(this.btnObtenerPorId_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(889, 488);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(124, 20);
            this.txtId.TabIndex = 6;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(889, 516);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(124, 20);
            this.txtAutor.TabIndex = 8;
            // 
            // btnObtenerPorAutor
            // 
            this.btnObtenerPorAutor.Location = new System.Drawing.Point(733, 514);
            this.btnObtenerPorAutor.Name = "btnObtenerPorAutor";
            this.btnObtenerPorAutor.Size = new System.Drawing.Size(132, 23);
            this.btnObtenerPorAutor.TabIndex = 7;
            this.btnObtenerPorAutor.Text = "Obtener por Autor";
            this.btnObtenerPorAutor.UseVisualStyleBackColor = true;
            this.btnObtenerPorAutor.Click += new System.EventHandler(this.btnObtenerPorAutor_Click);
            // 
            // btnObtenerPorLectura
            // 
            this.btnObtenerPorLectura.Location = new System.Drawing.Point(733, 456);
            this.btnObtenerPorLectura.Name = "btnObtenerPorLectura";
            this.btnObtenerPorLectura.Size = new System.Drawing.Size(132, 23);
            this.btnObtenerPorLectura.TabIndex = 9;
            this.btnObtenerPorLectura.Text = "Obtener por Lectura";
            this.btnObtenerPorLectura.UseVisualStyleBackColor = true;
            this.btnObtenerPorLectura.Click += new System.EventHandler(this.btnObtenerPorLectura_Click);
            // 
            // cmbObtenerPorLectura
            // 
            this.cmbObtenerPorLectura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbObtenerPorLectura.FormattingEnabled = true;
            this.cmbObtenerPorLectura.Items.AddRange(new object[] {
            "Leido",
            "No Leido"});
            this.cmbObtenerPorLectura.Location = new System.Drawing.Point(889, 458);
            this.cmbObtenerPorLectura.Name = "cmbObtenerPorLectura";
            this.cmbObtenerPorLectura.Size = new System.Drawing.Size(124, 21);
            this.cmbObtenerPorLectura.TabIndex = 12;
            // 
            // LibrosPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1129, 597);
            this.Controls.Add(this.cmbObtenerPorLectura);
            this.Controls.Add(this.btnObtenerPorLectura);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.btnObtenerPorAutor);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnObtenerPorId);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnTraerTodo);
            this.Controls.Add(this.dgvLibros);
            this.Name = "LibrosPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibrosPrincipal";
            this.Load += new System.EventHandler(this.LibrosPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.Button btnTraerTodo;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnObtenerPorId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Button btnObtenerPorAutor;
        private System.Windows.Forms.Button btnObtenerPorLectura;
        private System.Windows.Forms.ComboBox cmbObtenerPorLectura;
    }
}