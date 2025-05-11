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
            brandPbx.Image = Image.FromFile(Images.MyWatchListTransparentIcon);
            searchPbx.Image = Image.FromFile(Images.Search);
            heartPbx.Image = Image.FromFile(Images.EmptyRedHeart);
            star1Pbx.Image = Image.FromFile(Images.FilledStar);
            star2Pbx.Image = Image.FromFile(Images.FilledStar);
            star3Pbx.Image = Image.FromFile(Images.FilledStar);
            star4Pbx.Image = Image.FromFile(Images.HalfStar);
            star5Pbx.Image = Image.FromFile(Images.EmptyStar);
            imagePbx.Image = Image.FromFile(Images.ImagenPrueba);
        }
    }
}
