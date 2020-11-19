using Instagram.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instagram
{
    public partial class Form2 : Form
    {
        public Form2(string nombre)
        {
            var frm1 = new Form1();
            frm1.Close();
            InitializeComponent();
            blusuario.Text = nombre;
            Datos(nombre);
            ImgAtras.Image = Resources.atras;
        }
        public void Datos(string nombre)
        {
            Bitmap[] imagenAlex = { Resources.alpes1, Resources.alpes2, Resources.alpes3 };
            Bitmap[] imagenMaria = { Resources.ecuador1, Resources.ecuador2, Resources.ecuador3 };
            Bitmap[] imagenJuan = { Resources.campo1, Resources.campo2, Resources.campo3 };
            Bitmap[] imagen = null ;
            switch (nombre)
            {
                case "Alex Adriano":
                    pictureBox1.Image = Resources._1;
                    imagen = imagenAlex;
                    blPublicaciones.Text = "3 \n Publicaciones";
                    lbseguidor.Text = "702 mil \n Seguidores";
                    blDescripcion.Text = "Me gusta el futbol es mi pasión";
                    break;
                case "Maria Chicaiza":
                    pictureBox1.Image = Resources._2;
                    imagen = imagenMaria;
                    blPublicaciones.Text = "3 \n Publicaciones";
                    lbseguidor.Text = "102 mil \n Seguidores";
                    blDescripcion.Text = "Amo la música";
                    break;
                case "Juan Alvares":
                    pictureBox1.Image = Resources._3;
                    imagen = imagenJuan;
                    blPublicaciones.Text = "3 \n Publicaciones";
                    lbseguidor.Text = "502 mil \n Seguidores";
                    blDescripcion.Text = "Todo Ready";
                    break;
                default:
                    break;
            }
            Bibliografia[] a = new Bibliografia[3];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new Bibliografia();
                a[i].Icon = imagen[i];
                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                flowLayoutPanel1.Controls.Add(a[i]);
            }
        }

        private void bntAtras(object sender, EventArgs e)
        {
            this.Close();
            var frm1 = new Form1();
            frm1.Show();
        }
    }
}
