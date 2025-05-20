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
    public partial class SeeFilmForm : Form
    {
        private readonly MyWatchListQueryService _service;
        private readonly int _userId;
        private readonly int _serieId;
        private Serie _serie;
        private UserSerieConfig _config;
        private PictureBox[] _stars;

        private readonly SerieStatus[] _allStatuses = new[]
        {
            SerieStatus.Inactive,
            SerieStatus.Watching,
            SerieStatus.Completed,
            SerieStatus.Rewatching,
            SerieStatus.Dropped,
            SerieStatus.PlanToWatch
        };

        private readonly Dictionary<SerieStatus, string> _statusTranslations = new()
        {
            { SerieStatus.Inactive, "Inactiva" },
            { SerieStatus.Watching, "Viendo" },
            { SerieStatus.Completed, "Completada" },
            { SerieStatus.Rewatching, "Reviendo" },
            { SerieStatus.Dropped, "Abandonada" },
            { SerieStatus.PlanToWatch, "Pendiente" }
        };

        public SeeFilmForm(MyWatchListQueryService service, int userId, int serieId)
        {
            InitializeComponent();
            _service = service;
            _userId = userId;
            _serieId = serieId;

            sinopsisTxb.Enter += (s, e) => this.ActiveControl = null;

            brandPbx.Image = Image.FromFile(Images.MyWatchListTransparentIcon);

            _stars = new[] { star1Pbx, star2Pbx, star3Pbx, star4Pbx, star5Pbx };

            LoadSerieData();

            this.FormClosing += SeeFilmForm_FormClosing;

            libraryLbl.Click += LibraryLbl_Click;
            addLbl.Click += addLbl_Click;
        }

        private void LoadSerieData()
        {
            _serie = _service.GetAllSeries().FirstOrDefault(s => s.Id == _serieId);
            _config = _service.GetUserSerieConfig(_userId, _serieId);

            if (_serie == null || _config == null) return;

            titleLbl.Text = _serie.Title;
            sinopsisTxb.Text = _serie.Synopsis;
            imagePbx.Image = File.Exists(_serie.ImagePath) ? Image.FromFile(_serie.ImagePath) : null;

            genresFlowPanel.Controls.Clear();
            var genres = _service.GetGenresForSerie(_serieId);
            foreach (var genre in genres)
            {
                var label = new Label
                {
                    Text = genre.Name,
                    AutoSize = true,
                    Padding = new Padding(3),
                    BackColor = Color.LightGray,
                    Margin = new Padding(3)
                };
                genresFlowPanel.Controls.Add(label);
            }

            statusBtn.Text = _statusTranslations[_config.Status];
            statusBtn.Click += (s, e) =>
            {
                int currentIndex = Array.IndexOf(_allStatuses, _config.Status);
                int nextIndex = (currentIndex + 1) % _allStatuses.Length;
                _config.Status = _allStatuses[nextIndex];
                statusBtn.Text = _statusTranslations[_config.Status];
            };

            heartPbx.Image = Image.FromFile(_config.Liked ? Images.FilledRedHeart : Images.EmptyRedHeart);
            heartPbx.Click += (s, e) =>
            {
                _config.Liked = !_config.Liked;
                heartPbx.Image = Image.FromFile(_config.Liked ? Images.FilledRedHeart : Images.EmptyRedHeart);
            };

            UpdateStarsDisplay();
            for (int i = 0; i < _stars.Length; i++)
            {
                int index = i;
                _stars[i].Click += (s, e) =>
                {
                    _config.Score = index + 1;
                    UpdateStarsDisplay();
                };
            }

            LoadEpisodes();
        }

        private void LoadEpisodes()
        {
            episodesFlowPanel.Controls.Clear();
            episodesFlowPanel.AutoScroll = true;

            for (int i = 1; i <= _serie.TotalEpisodes; i++)
            {
                var check = new CheckBox
                {
                    Text = $"Ep. {i}",
                    Checked = i <= _config.EpisodesWatched,
                    AutoSize = true,
                    Margin = new Padding(5)
                };
                episodesFlowPanel.Controls.Add(check);
            }
        }

        private void UpdateStarsDisplay()
        {
            for (int i = 0; i < _stars.Length; i++)
            {
                _stars[i].Image = Image.FromFile(i < _config.Score ? Images.FilledStar : Images.EmptyStar);
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (_config == null) return;

            _config.EpisodesWatched = episodesFlowPanel.Controls
                .OfType<CheckBox>()
                .Count(cb => cb.Checked);

            _service.SaveChanges();

            var filmLibraryForm = new FilmLibraryForm(_service, _userId);
            filmLibraryForm.Show();
            this.Hide();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("¿Estás seguro de que quieres eliminar esta serie?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                _service.DeleteSerie(_serieId);
                this.Hide();
                var filmLibraryForm = new FilmLibraryForm(_service, _userId);
                filmLibraryForm.Show();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            var editForm = new CreateFilmForm(_service, true, _userId, _serieId);
            editForm.Show();
            this.Hide();
        }

        private void SeeFilmForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void LibraryLbl_Click(object sender, EventArgs e)
        {
            var form = new FilmLibraryForm(_service, _userId);
            form.Show();
            this.Hide();
        }

        private void addLbl_Click(object sender, EventArgs e)
        {
            var form = new CreateFilmForm(_service, false, _userId);
            form.Show();
            this.Hide();
        }
    }
}
