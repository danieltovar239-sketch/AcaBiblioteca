namespace AcaBiblioteca
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            pctPrincipal = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctPrincipal).BeginInit();
            SuspendLayout();
            // 
            // pctPrincipal
            // 
            pctPrincipal.BackColor = Color.Transparent;
            pctPrincipal.BackgroundImageLayout = ImageLayout.Zoom;
            pctPrincipal.Dock = DockStyle.Fill;
            pctPrincipal.ErrorImage = null;
            pctPrincipal.Image = (Image)resources.GetObject("pctPrincipal.Image");
            pctPrincipal.InitialImage = null;
            pctPrincipal.Location = new Point(0, 0);
            pctPrincipal.Name = "pctPrincipal";
            pctPrincipal.Size = new Size(800, 450);
            pctPrincipal.SizeMode = PictureBoxSizeMode.Zoom;
            pctPrincipal.TabIndex = 1;
            pctPrincipal.TabStop = false;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pctPrincipal);
            Name = "FrmInicio";
            Text = "FrmInicio";
            ((System.ComponentModel.ISupportInitialize)pctPrincipal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pctPrincipal;
    }
}