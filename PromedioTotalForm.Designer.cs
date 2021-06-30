
namespace Faculty
{
    partial class PromedioTotalForm
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
            this.dgvMostrarAlumnos = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMostrarAlumnos
            // 
            this.dgvMostrarAlumnos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMostrarAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrarAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricula,
            this.NombreCompleto,
            this.Promedio});
            this.dgvMostrarAlumnos.Location = new System.Drawing.Point(13, 128);
            this.dgvMostrarAlumnos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMostrarAlumnos.Name = "dgvMostrarAlumnos";
            this.dgvMostrarAlumnos.RowHeadersWidth = 51;
            this.dgvMostrarAlumnos.RowTemplate.Height = 24;
            this.dgvMostrarAlumnos.Size = new System.Drawing.Size(774, 335);
            this.dgvMostrarAlumnos.TabIndex = 3;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(671, 471);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(116, 40);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // Matricula
            // 
            this.Matricula.DataPropertyName = "Matricula";
            this.Matricula.DividerWidth = 1;
            this.Matricula.Frozen = true;
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.MinimumWidth = 100;
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            this.Matricula.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Matricula.Width = 150;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreCompleto.DataPropertyName = "NombreCompleto";
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.MinimumWidth = 150;
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            // 
            // Promedio
            // 
            this.Promedio.DataPropertyName = "Promedio";
            this.Promedio.HeaderText = "Promedio total";
            this.Promedio.MinimumWidth = 100;
            this.Promedio.Name = "Promedio";
            this.Promedio.ReadOnly = true;
            this.Promedio.Width = 125;
            // 
            // PromedioTotalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.dgvMostrarAlumnos);
            this.Controls.Add(this.btnCerrar);
            this.Name = "PromedioTotalForm";
            this.Text = "PromedioTotalForm";
            this.Load += new System.EventHandler(this.PromedioTotalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrarAlumnos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Promedio;
    }
}