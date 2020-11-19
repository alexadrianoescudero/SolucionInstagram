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
    public partial class Bibliografia : UserControl
    {
        public Bibliografia()
        {
            InitializeComponent();
        }
        private Image _icon;     

        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; ImgIconBI.Image = value; }
        }
        
    }
}
