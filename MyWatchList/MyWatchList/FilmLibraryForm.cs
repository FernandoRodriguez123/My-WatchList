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
    //TODO creacion dinamica de checkboxes en feature funcionalidad
    public partial class FilmLibraryForm : Form
    {
        public FilmLibraryForm()
        {
            InitializeComponent();
            brandPbx.Image = Image.FromFile(Images.MyWatchListTransparentIcon);
            genreDropPbx.Image = Image.FromFile(Images.ChevronDown);
            searchPbx.Image = Image.FromFile(Images.Search);
            orderDropPbx.Image = Image.FromFile(Images.ChevronDown);
            ratingDropPbx.Image = Image.FromFile(Images.ChevronDown);
            statusDropPbx.Image = Image.FromFile(Images.ChevronDown);
            imagePbx.Image = Image.FromFile(Images.ImagenPrueba);
        }

        private void FilmLibraryForm_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
