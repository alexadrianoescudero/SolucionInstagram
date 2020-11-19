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
    public partial class Inicio : UserControl
    {
        public Inicio()
        {
            InitializeComponent();
        }
        private Image _icon;
        private Image _iconuser;
        private string _usuario;
        private string _descripcion;
        [Category("Custom Props")]
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; blDescripcion.Text = value; }
        }
        [Category("Custom Props")]
        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; blUsuario.Text = value; }
        }

        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBox1.Image = value; }
        }
        [Category("Custom Props")]
        public Image IconUser
        {
            get { return _iconuser; }
            set { _iconuser = value; ImgIcon.Image = value; }
        }
        private void PerfilUser(object sender, EventArgs e)
        {
            string datos = Usuario;
            var frm1 = new Form1();
            var frm = new Form2(datos); 
            frm1.Close();
            frm.Show();
            
        }
    }
}
