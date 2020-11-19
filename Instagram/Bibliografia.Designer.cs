
namespace Instagram
{
    partial class Bibliografia
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImgIconBI = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgIconBI)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgIconBI
            // 
            this.ImgIconBI.Location = new System.Drawing.Point(3, 3);
            this.ImgIconBI.Name = "ImgIconBI";
            this.ImgIconBI.Size = new System.Drawing.Size(112, 111);
            this.ImgIconBI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgIconBI.TabIndex = 6;
            this.ImgIconBI.TabStop = false;
            // 
            // Bibliografia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ImgIconBI);
            this.Name = "Bibliografia";
            this.Size = new System.Drawing.Size(120, 119);
            ((System.ComponentModel.ISupportInitialize)(this.ImgIconBI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgIconBI;
    }
}
