namespace AppATLComplementa
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cntClaveLabel;
            System.Windows.Forms.Label cliPerNombreLabel;
            System.Windows.Forms.Label cliPerPaternoLabel;
            this.cntClaveTextBox = new System.Windows.Forms.TextBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cliPerNombreTextBox = new System.Windows.Forms.TextBox();
            this.cliPerPaternoTextBox = new System.Windows.Forms.TextBox();
            this.referenciaDePagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.referenciaDePagoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cntClaveLabel = new System.Windows.Forms.Label();
            cliPerNombreLabel = new System.Windows.Forms.Label();
            cliPerPaternoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenciaDePagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenciaDePagoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cntClaveLabel
            // 
            cntClaveLabel.AutoSize = true;
            cntClaveLabel.Location = new System.Drawing.Point(23, 11);
            cntClaveLabel.Name = "cntClaveLabel";
            cntClaveLabel.Size = new System.Drawing.Size(56, 13);
            cntClaveLabel.TabIndex = 1;
            cntClaveLabel.Text = "Cnt Clave:";
            // 
            // cliPerNombreLabel
            // 
            cliPerNombreLabel.AutoSize = true;
            cliPerNombreLabel.Location = new System.Drawing.Point(-1, 37);
            cliPerNombreLabel.Name = "cliPerNombreLabel";
            cliPerNombreLabel.Size = new System.Drawing.Size(80, 13);
            cliPerNombreLabel.TabIndex = 3;
            cliPerNombreLabel.Text = "Cli Per Nombre:";
            // 
            // cliPerPaternoLabel
            // 
            cliPerPaternoLabel.AutoSize = true;
            cliPerPaternoLabel.Location = new System.Drawing.Point(2, 65);
            cliPerPaternoLabel.Name = "cliPerPaternoLabel";
            cliPerPaternoLabel.Size = new System.Drawing.Size(80, 13);
            cliPerPaternoLabel.TabIndex = 5;
            cliPerPaternoLabel.Text = "Cli Per Paterno:";
            // 
            // cntClaveTextBox
            // 
            this.cntClaveTextBox.Location = new System.Drawing.Point(85, 8);
            this.cntClaveTextBox.Name = "cntClaveTextBox";
            this.cntClaveTextBox.Size = new System.Drawing.Size(100, 20);
            this.cntClaveTextBox.TabIndex = 2;
            this.cntClaveTextBox.Leave += new System.EventHandler(this.cntClaveTextBox_Leave);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(AppATLComplementa.Negocio.Dominio.Cliente);
            // 
            // cliPerNombreTextBox
            // 
            this.cliPerNombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "ClientePersona.CliPerNombre", true));
            this.cliPerNombreTextBox.Location = new System.Drawing.Point(85, 34);
            this.cliPerNombreTextBox.Name = "cliPerNombreTextBox";
            this.cliPerNombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.cliPerNombreTextBox.TabIndex = 4;
            // 
            // cliPerPaternoTextBox
            // 
            this.cliPerPaternoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "ClientePersona.CliPerPaterno", true));
            this.cliPerPaternoTextBox.Location = new System.Drawing.Point(88, 62);
            this.cliPerPaternoTextBox.Name = "cliPerPaternoTextBox";
            this.cliPerPaternoTextBox.Size = new System.Drawing.Size(100, 20);
            this.cliPerPaternoTextBox.TabIndex = 6;
            // 
            // referenciaDePagoBindingSource
            // 
            this.referenciaDePagoBindingSource.DataSource = typeof(AppATLComplementa.Negocio.Dominio.ReferenciaDePago);
            // 
            // referenciaDePagoDataGridView
            // 
            this.referenciaDePagoDataGridView.AutoGenerateColumns = false;
            this.referenciaDePagoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.referenciaDePagoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.referenciaDePagoDataGridView.DataSource = this.referenciaDePagoBindingSource;
            this.referenciaDePagoDataGridView.Location = new System.Drawing.Point(2, 88);
            this.referenciaDePagoDataGridView.Name = "referenciaDePagoDataGridView";
            this.referenciaDePagoDataGridView.Size = new System.Drawing.Size(760, 280);
            this.referenciaDePagoDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RefPagClave";
            this.dataGridViewTextBoxColumn1.HeaderText = "RefPagClave";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RefPagEmision";
            this.dataGridViewTextBoxColumn2.HeaderText = "RefPagEmision";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RefPagVencimiento";
            this.dataGridViewTextBoxColumn3.HeaderText = "RefPagVencimiento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RefPagTotal";
            this.dataGridViewTextBoxColumn4.HeaderText = "RefPagTotal";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RefPagRedondeo";
            this.dataGridViewTextBoxColumn5.HeaderText = "RefPagRedondeo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "RefPagTotalRedondeado";
            this.dataGridViewTextBoxColumn6.HeaderText = "RefPagTotalRedondeado";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "RefPagDocumentos";
            this.dataGridViewTextBoxColumn7.HeaderText = "RefPagDocumentos";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "EmpPerClave";
            this.dataGridViewTextBoxColumn8.HeaderText = "EmpPerClave";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "RefPagHostName";
            this.dataGridViewTextBoxColumn9.HeaderText = "RefPagHostName";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "RefPagReferencia";
            this.dataGridViewTextBoxColumn10.HeaderText = "RefPagReferencia";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "RefPagCancelada";
            this.dataGridViewTextBoxColumn11.HeaderText = "RefPagCancelada";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "CajTipDocClave";
            this.dataGridViewTextBoxColumn12.HeaderText = "CajTipDocClave";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "RefPagDocumentoClave";
            this.dataGridViewTextBoxColumn13.HeaderText = "RefPagDocumentoClave";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "CliClave";
            this.dataGridViewTextBoxColumn14.HeaderText = "CliClave";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.referenciaDePagoDataGridView);
            this.Controls.Add(cliPerPaternoLabel);
            this.Controls.Add(this.cliPerPaternoTextBox);
            this.Controls.Add(cliPerNombreLabel);
            this.Controls.Add(this.cliPerNombreTextBox);
            this.Controls.Add(cntClaveLabel);
            this.Controls.Add(this.cntClaveTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenciaDePagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenciaDePagoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.TextBox cntClaveTextBox;
        private System.Windows.Forms.TextBox cliPerNombreTextBox;
        private System.Windows.Forms.TextBox cliPerPaternoTextBox;
        private System.Windows.Forms.BindingSource referenciaDePagoBindingSource;
        private System.Windows.Forms.DataGridView referenciaDePagoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}