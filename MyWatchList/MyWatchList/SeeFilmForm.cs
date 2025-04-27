using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWatchList
{
    //TODO creacion dinamica de generos en feature funcionalidad
    //TODO creacion dinamica de capitulos en feature funcionalidad, dejarlo
    //TODO para cuando esté la base de datos hecha?
    public partial class SeeFilmForm : Form
    {
        public SeeFilmForm()
        {
            InitializeComponent();
            sinopsisTxb.Enter += (s, e) => this.ActiveControl = null;
        }
    }
}
