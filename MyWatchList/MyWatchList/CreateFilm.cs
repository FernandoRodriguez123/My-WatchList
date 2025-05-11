using MyWatchList.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//TODO creacion dinamica de checkboxes en feature/funcionalidad
namespace MyWatchList
{
    public partial class CreateFilmForm : Form
    {
        public CreateFilmForm()
        {
            InitializeComponent();
            searchPbx.Image = Image.FromFile(Images.Search);
            brandPbx.Image = Image.FromFile(Images.MyWatchListTransparentIcon);
        }
    }
}
