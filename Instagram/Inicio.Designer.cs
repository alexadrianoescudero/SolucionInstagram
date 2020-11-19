
namespace Instagram
{
    partial class Inicio
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.blUsuario = new System.Windows.Forms.Label();
            this.blDescripcion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ImgIcon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ImgIcon);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.blUsuario);
            this.panel1.Controls.Add(this.blDescripcion);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 313);
            this.panel1.TabIndex = 0;
            // 
            // blUsuario
            // 
            this.blUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blUsuario.Location = new System.Drawing.Point(91, 24);
            this.blUsuario.Name = "blUsuario";
            this.blUsuario.Size = new System.Drawing.Size(141, 23);
            this.blUsuario.TabIndex = 2;
            this.blUsuario.Text = "Usuario";
            // 
            // blDescripcion
            // 
            this.blDescripcion.Location = new System.Drawing.Point(16, 247);
            this.blDescripcion.Name = "blDescripcion";
            this.blDescripcion.Size = new System.Drawing.Size(216, 50);
            this.blDescripcion.TabIndex = 1;
            this.blDescripcion.Text = "Descripcion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ImgIcon
            // 
            this.ImgIcon.Location = new System.Drawing.Point(19, 20);
            this.ImgIcon.Name = "ImgIcon";
            this.ImgIcon.Size = new System.Drawing.Size(53, 34);
            this.ImgIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgIcon.TabIndex = 4;
            this.ImgIcon.TabStop = false;
            this.ImgIcon.Click += new System.EventHandler(this.PerfilUser);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Inicio";
            this.Size = new System.Drawing.Size(268, 325);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label blDescripcion;
        private System.Windows.Forms.Label blUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ImgIcon;
    }
}
