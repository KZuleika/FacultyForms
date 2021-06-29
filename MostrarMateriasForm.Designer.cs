
namespace Faculty
{
    partial class MostrarMateriasForm
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
            this.dgvMostrarMaterias = new System.Windows.Forms.DataGridView();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creditos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostrarMaterias
            // 
            this.dgvMostrarMaterias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMostrarMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave,
            this.Nombre,
            this.Creditos});
            this.dgvMostrarMaterias.Location = new System.Drawing.Point(16, 21);
            this.dgvMostrarMaterias.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvMostrarMaterias.Name = "dgvMostrarMaterias";
            this.dgvMostrarMaterias.RowHeadersWidth = 51;
            this.dgvMostrarMaterias.RowTemplate.Height = 24;
            this.dgvMostrarMaterias.Size = new System.Drawing.Size(610, 325);
            this.dgvMostrarMaterias.TabIndex = 2;
            // 
            // Clave
            // 
            this.Clave.DataPropertyName = "Clave";
            this.Clave.DividerWidth = 1;
            this.Clave.Frozen = true;
            this.Clave.HeaderText = "Clave";
            this.Clave.MinimumWidth = 100;
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Clave.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Materia";
            this.Nombre.MinimumWidth = 150;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Creditos
            // 
            this.Creditos.DataPropertyName = "Creditos";
            this.Creditos.HeaderText = "Créditos";
            this.Creditos.MinimumWidth = 100;
            this.Creditos.Name = "Creditos";
            this.Creditos.ReadOnly = true;
            this.Creditos.Width = 125;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(485, 355);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(139, 44);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // MostrarMateriasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 413);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvMostrarMaterias);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MostrarMateriasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MostrarMateriasForm";
            this.Load += new System.EventHandler(this.MostrarMateriasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarMaterias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrarMaterias;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creditos;
    }
}