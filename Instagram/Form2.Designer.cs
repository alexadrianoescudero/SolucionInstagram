
namespace Instagram
{
    partial class Form2
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
            this.blusuario = new System.Windows.Forms.Label();
            this.blDescripcion = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bibliografia1 = new Instagram.Bibliografia();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.blPublicaciones = new System.Windows.Forms.Label();
            this.lbseguidor = new System.Windows.Forms.Label();
            this.ImgAtras = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // blusuario
            // 
            this.blusuario.Location = new System.Drawing.Point(9, 113);
            this.blusuario.Name = "blusuario";
            this.blusuario.Size = new System.Drawing.Size(179, 34);
            this.blusuario.TabIndex = 0;
            this.blusuario.Text = "label1";
            // 
            // blDescripcion
            // 
            this.blDescripcion.Location = new System.Drawing.Point(12, 156);
            this.blDescripcion.Name = "blDescripcion";
            this.blDescripcion.Size = new System.Drawing.Size(318, 44);
            this.blDescripcion.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.bibliografia1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 203);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(322, 172);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // bibliografia1
            // 
            this.bibliografia1.Icon = null;
            this.bibliografia1.Location = new System.Drawing.Point(3, 3);
            this.bibliografia1.Name = "bibliografia1";
            this.bibliografia1.Size = new System.Drawing.Size(120, 119);
            this.bibliografia1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // blPublicaciones
            // 
            this.blPublicaciones.Location = new System.Drawing.Point(121, 57);
            this.blPublicaciones.Name = "blPublicaciones";
            this.blPublicaciones.Size = new System.Drawing.Size(100, 32);
            this.blPublicaciones.TabIndex = 4;
            this.blPublicaciones.Text = "label1";
            this.blPublicaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbseguidor
            // 
            this.lbseguidor.Location = new System.Drawing.Point(227, 56);
            this.lbseguidor.Name = "lbseguidor";
            this.lbseguidor.Size = new System.Drawing.Size(100, 32);
            this.lbseguidor.TabIndex = 5;
            this.lbseguidor.Text = "label1";
            this.lbseguidor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImgAtras
            // 
            this.ImgAtras.Location = new System.Drawing.Point(11, 9);
            this.ImgAtras.Name = "ImgAtras";
            this.ImgAtras.Size = new System.Drawing.Size(52, 18);
            this.ImgAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgAtras.TabIndex = 6;
            this.ImgAtras.TabStop = false;
            this.ImgAtras.Click += new System.EventHandler(this.bntAtras);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 379);
            this.Controls.Add(this.ImgAtras);
            this.Controls.Add(this.lbseguidor);
            this.Controls.Add(this.blPublicaciones);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.blDescripcion);
            this.Controls.Add(this.blusuario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgAtras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label blusuario;
        private System.Windows.Forms.Label blDescripcion;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bibliografia bibliografia1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label blPublicaciones;
        private System.Windows.Forms.Label lbseguidor;
        private System.Windows.Forms.PictureBox ImgAtras;
    }
}