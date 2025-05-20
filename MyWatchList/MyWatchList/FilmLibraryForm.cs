using MyWatchList.Data.Controller;
using MyWatchList.Models;
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
    public partial class FilmLibraryForm : Form
    {
        private readonly MyWatchListQueryService _service;
        private readonly int _userId;

        private readonly Dictionary<SerieStatus, string> _statusTranslations = new()
        {
            { SerieStatus.Inactive, "Inactiva" },
            { SerieStatus.Watching, "Viendo" },
            { SerieStatus.Completed, "Completada" },
            { SerieStatus.Rewatching, "Reviendo" },
            { SerieStatus.Dropped, "Abandonada" },
            { SerieStatus.PlanToWatch, "Pendiente" }
        };

        private readonly Dictionary<OrderStatus, string> _orderTranslations = new()
        {
            { OrderStatus.TitleAsc, "Título (A-Z)" },
            { OrderStatus.TitleDesc, "Título (Z-A)" },
            { OrderStatus.ScoreAsc, "Puntuación (ascendente)" },
            { OrderStatus.ScoreDesc, "Puntuación (descendente)" },
            { OrderStatus.EpisodesAsc, "Episodios (ascendente)" },
            { OrderStatus.EpisodesDesc, "Episodios (descendente)" }
        };

        public FilmLibraryForm(MyWatchListQueryService service, int userId)
        {
            InitializeComponent();
            brandPbx.Image = Image.FromFile(Images.MyWatchListTransparentIcon);
            genreDropPbx.Image = Image.FromFile(Images.ChevronUp);
            searchPbx.Image = Image.FromFile(Images.Search);
            orderDropPbx.Image = Image.FromFile(Images.ChevronUp);
            statusDropPbx.Image = Image.FromFile(Images.ChevronUp);
            _service = service;
            _userId = userId;

            PopulateGenreCheckboxes();
            PopulateStatusCheckboxes();
            PopulateOrderRadios();

            filterBtn.Click += filterBtn_Click;
            libraryLbl.Click += libraryLbl_Click;
            addLbl.Click += addLbl_Click;

            LoadAllSeries();

            genresFlowPanel.BringToFront();
            statusFlowPanel.BringToFront();
            orderFlowPanel.BringToFront();

            this.FormClosing += FilmLibraryForm_FormClosing;
        }

        private void genrePanel_Click(object sender, EventArgs e)
        {
            genresFlowPanel.Visible = !genresFlowPanel.Visible;
            if (genresFlowPanel.Visible)
            {
                orderFlowPanel.Visible = false;
                statusFlowPanel.Visible = false;
                genreDropPbx.Image = Image.FromFile(Images.ChevronDown);
                statusDropPbx.Image = Image.FromFile(Images.ChevronUp);
                orderDropPbx.Image = Image.FromFile(Images.ChevronUp);
            }
            else
            {
                genreDropPbx.Image = Image.FromFile(Images.ChevronUp);
            }
        }

        private void statusPanel_Click(object sender, EventArgs e)
        {
            statusFlowPanel.Visible = !statusFlowPanel.Visible;
            if (statusFlowPanel.Visible)
            {
                genresFlowPanel.Visible = false;
                orderFlowPanel.Visible = false;
                statusDropPbx.Image = Image.FromFile(Images.ChevronDown);
                genreDropPbx.Image = Image.FromFile(Images.ChevronUp);
                orderDropPbx.Image = Image.FromFile(Images.ChevronUp);
            }
            else
            {
                statusDropPbx.Image = Image.FromFile(Images.ChevronUp);
            }
        }

        private void orderPanel_Click(object sender, EventArgs e)
        {
            orderFlowPanel.Visible = !orderFlowPanel.Visible;
            if (orderFlowPanel.Visible)
            {
                genresFlowPanel.Visible = false;
                statusFlowPanel.Visible = false;
                orderDropPbx.Image = Image.FromFile(Images.ChevronDown);
                genreDropPbx.Image = Image.FromFile(Images.ChevronUp);
                statusDropPbx.Image = Image.FromFile(Images.ChevronUp);
            }
            else
            {
                orderDropPbx.Image = Image.FromFile(Images.ChevronUp);
            }
        }

        private void PopulateGenreCheckboxes()
        {
            genresFlowPanel.Controls.Clear();
            foreach (var genre in _service.GetAllGenres())
            {
                var cb = new CheckBox
                {
                    Text = genre.Name,
                    AutoSize = true,
                    Tag = genre.Name
                };
                genresFlowPanel.Controls.Add(cb);
            }
        }

        private void PopulateStatusCheckboxes()
        {
            statusFlowPanel.Controls.Clear();
            foreach (SerieStatus status in Enum.GetValues(typeof(SerieStatus)))
            {
                var cb = new CheckBox
                {
                    Text = _statusTranslations[status],
                    AutoSize = true,
                    Tag = status
                };
                statusFlowPanel.Controls.Add(cb);
            }
        }

        private void PopulateOrderRadios()
        {
            orderFlowPanel.Controls.Clear();
            foreach (OrderStatus order in Enum.GetValues(typeof(OrderStatus)))
            {
                var rb = new RadioButton
                {
                    Text = _orderTranslations[order],
                    AutoSize = true,
                    Tag = order
                };
                orderFlowPanel.Controls.Add(rb);
            }
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            var selectedGenres = genresFlowPanel.Controls
                .OfType<CheckBox>()
                .Where(cb => cb.Checked)
                .Select(cb => cb.Tag.ToString())
                .ToList();

            var selectedStatuses = statusFlowPanel.Controls
                .OfType<CheckBox>()
                .Where(cb => cb.Checked)
                .Select(cb => (SerieStatus) cb.Tag)
                .ToList();

            var selectedOrder = orderFlowPanel.Controls
                .OfType<RadioButton>()
                .FirstOrDefault(rb => rb.Checked)?.Tag as OrderStatus? ?? OrderStatus.TitleAsc;

            var title = searchTxb.Text;

            var filteredSeries = _service.FilterSeries(_userId, selectedGenres, selectedStatuses, selectedOrder, title);

            libraryFlowPanel.Controls.Clear();
            foreach (var serie in filteredSeries)
            {
                AddSerieToLibraryPanel(serie);
            }
        }

        private void AddSerieToLibraryPanel(Serie serie)
        {
            var maxTitleLength = 20;

            string displayedTitle = serie.Title.Length > maxTitleLength
                ? serie.Title.Substring(0, maxTitleLength - 3) + "..."
                : serie.Title;

            var panel = new Panel
            {
                Width = 150,
                Height = 250,
                Margin = new Padding(5),
                Cursor = Cursors.Hand,
                BackColor = Color.Transparent
            };

            var pictureBox = new PictureBox
            {
                ImageLocation = serie.ImagePath,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Width = 150,
                Height = 200,
                Location = new Point(0, 0)
            };

            var label = new Label
            {
                Text = displayedTitle,
                AutoSize = false,
                Width = 150,
                Height = 40,
                Location = new Point(0, 205),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 9, FontStyle.Bold)
            };

            var toolTip = new ToolTip();
            toolTip.SetToolTip(panel, serie.Title);
            toolTip.SetToolTip(pictureBox, serie.Title);
            toolTip.SetToolTip(label, serie.Title);

            panel.Controls.Add(pictureBox);
            panel.Controls.Add(label);

            void ShowSerieForm()
            {
                var seeFilmForm = new SeeFilmForm(_service, _userId, serie.Id);
                seeFilmForm.Show();
                this.Hide();
            }

            panel.Click += (sender, e) => ShowSerieForm();
            pictureBox.Click += (sender, e) => ShowSerieForm();
            label.Click += (sender, e) => ShowSerieForm();

            libraryFlowPanel.Controls.Add(panel);
        }

        private void LoadAllSeries()
        {
            libraryFlowPanel.Controls.Clear();
            var allSeries = _service.GetAllSeries();
            foreach (var serie in allSeries)
            {
                AddSerieToLibraryPanel(serie);
            }
        }

        private void libraryLbl_Click(object sender, EventArgs e)
        {
            foreach (CheckBox cb in genresFlowPanel.Controls)
                cb.Checked = false;
            foreach (CheckBox cb in statusFlowPanel.Controls)
                cb.Checked = false;
            foreach (RadioButton rb in orderFlowPanel.Controls)
                rb.Checked = false;

            searchTxb.Text = "";
            LoadAllSeries();
        }

        private void addLbl_Click(object sender, EventArgs e)
        {
            var form = new CreateFilmForm(_service, false, _userId);
            form.Show();
            this.Hide();
        }

        private void FilmLibraryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}