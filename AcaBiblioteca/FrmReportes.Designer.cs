namespace AcaBiblioteca
{
    partial class FrmReportes
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
            panel1 = new Panel();
            btnLimpiar = new Button();
            btnGenerar = new Button();
            lblGenerar = new Label();
            cmbTipoReporte = new ComboBox();
            dgvReportes = new DataGridView();
            panel2 = new Panel();
            lblgenerarRepor = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnGenerar);
            panel1.Location = new Point(384, 195);
            panel1.Name = "panel1";
            panel1.Size = new Size(619, 71);
            panel1.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(343, 21);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(204, 29);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerar.Location = new Point(56, 21);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(204, 29);
            btnGenerar.TabIndex = 0;
            btnGenerar.Text = "Generar Reporte";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // lblGenerar
            // 
            lblGenerar.AutoSize = true;
            lblGenerar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGenerar.Location = new Point(384, 93);
            lblGenerar.Name = "lblGenerar";
            lblGenerar.Size = new Size(150, 23);
            lblGenerar.TabIndex = 0;
            lblGenerar.Text = "Tipo de Reporte :";
            // 
            // cmbTipoReporte
            // 
            cmbTipoReporte.FormattingEnabled = true;
            cmbTipoReporte.Location = new Point(602, 93);
            cmbTipoReporte.Name = "cmbTipoReporte";
            cmbTipoReporte.Size = new Size(225, 28);
            cmbTipoReporte.TabIndex = 1;
            // 
            // dgvReportes
            // 
            dgvReportes.BackgroundColor = Color.MistyRose;
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Dock = DockStyle.Bottom;
            dgvReportes.Location = new Point(0, 353);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.RowHeadersWidth = 51;
            dgvReportes.Size = new Size(1348, 200);
            dgvReportes.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SkyBlue;
            panel2.Controls.Add(lblgenerarRepor);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1348, 72);
            panel2.TabIndex = 3;
            // 
            // lblgenerarRepor
            // 
            lblgenerarRepor.AutoSize = true;
            lblgenerarRepor.BackColor = Color.Transparent;
            lblgenerarRepor.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblgenerarRepor.Location = new Point(602, 23);
            lblgenerarRepor.Name = "lblgenerarRepor";
            lblgenerarRepor.Size = new Size(293, 35);
            lblgenerarRepor.TabIndex = 0;
            lblgenerarRepor.Text = "Gestión Reportes";
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 553);
            Controls.Add(panel2);
            Controls.Add(dgvReportes);
            Controls.Add(cmbTipoReporte);
            Controls.Add(lblGenerar);
            Controls.Add(panel1);
            Name = "FrmReportes";
            Text = "FrmReportes";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnGenerar;
        private Label lblGenerar;
        private ComboBox cmbTipoReporte;
        private Button btnLimpiar;
        private DataGridView dgvReportes;
        private Panel panel2;
        private Label lblgenerarRepor;
    }
}