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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Datos();
        }
        public void Datos()
        {
            string[] user = { "Alex Adriano", "Maria Chicaiza", "Juan Alvares" };
            string[] descripcion = { "Viaje a los Alpes ", "Visitando Ecuador", "Un dia de campo" };
            Bitmap[] UserImagen = { Resources._1, Resources._2, Resources._3 };
            Bitmap[] imagen = { Resources.alpes1, Resources.ecuador1, Resources.campo1 };
            Inicio[] a = new Inicio[3];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = new Inicio();                
                a[i].IconUser = UserImagen[i];
                a[i].Icon = imagen[i];
                a[i].Usuario = user[i];
                a[i].Descripcion = "Le gusta a " + user[i] + " y otras personas \n " +user[i] + " "+ descripcion[i];
                if (flowLayoutPanel1.Controls.Count < 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                }
                flowLayoutPanel1.Controls.Add(a[i]);
            }
        }
    }
}
