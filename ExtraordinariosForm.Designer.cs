﻿
namespace Faculty
{
    partial class ExtraordinariosForm
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
            this.dgvExtraordinarios = new System.Windows.Forms.DataGridView();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creditos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtraordinarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExtraordinarios
            // 
            this.dgvExtraordinarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvExtraordinarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExtraordinarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave,
            this.Nombre,
            this.Creditos});
            this.dgvExtraordinarios.Location = new System.Drawing.Point(13, 54);
            this.dgvExtraordinarios.Margin = new System.Windows.Forms.Padding(4);
            this.dgvExtraordinarios.MultiSelect = false;
            this.dgvExtraordinarios.Name = "dgvExtraordinarios";
            this.dgvExtraordinarios.RowHeadersWidth = 51;
            this.dgvExtraordinarios.RowTemplate.Height = 24;
            this.dgvExtraordinarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExtraordinarios.Size = new System.Drawing.Size(774, 335);
            this.dgvExtraordinarios.TabIndex = 7;
            // 
            // Clave
            // 
            this.Clave.DataPropertyName = "Clave";
            this.Clave.DividerWidth = 1;
            this.Clave.Frozen = true;
            this.Clave.HeaderText = "Clave";
            this.Clave.MinimumWidth = 100;
            this.Clave.Name = "Clave";
            this.Clave.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Clave.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Materia";
            this.Nombre.MinimumWidth = 150;
            this.Nombre.Name = "Nombre";
            // 
            // Creditos
            // 
            this.Creditos.DataPropertyName = "Creditos";
            this.Creditos.HeaderText = "Número de reprobados";
            this.Creditos.MinimumWidth = 100;
            this.Creditos.Name = "Creditos";
            this.Creditos.Width = 125;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(671, 397);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(116, 42);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Número de reprobados por materia";
            // 
            // ExtraordinariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvExtraordinarios);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ExtraordinariosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reprobados por materia";
            this.Load += new System.EventHandler(this.ExtraordinariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtraordinarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExtraordinarios;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creditos;
        private System.Windows.Forms.Label label1;
    }
}