using MyWatchList.Data.Controller;
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

namespace MyWatchList
{
    public partial class CreateFilmForm : Form
    {
        private readonly MyWatchListQueryService _service;
        private readonly bool _isUpdate;
        private readonly int _userId;
        private readonly int? _serieId;
        private readonly string _defaultImagePath = Images.ImageNotFound;
        private string _selectedImagePath = string.Empty;
        private readonly List<CheckBox> _genreCheckboxes = new List<CheckBox>();

        public CreateFilmForm(MyWatchListQueryService service, bool isUpdate, int userId, int? serieId = null)
        {
            InitializeComponent();
            brandPbx.Image = Image.FromFile(Images.MyWatchListTransparentIcon);
            _service = service;
            _isUpdate = isUpdate;
            _userId = userId;
            _serieId = serieId;

            LoadGenreCheckboxes();

            if (_isUpdate && _serieId.HasValue)
                LoadSerieData();

            createBtn.Text = _isUpdate ? "Actualizar serie" : "Añadir serie";
            imageBtn.Click += OnImageButtonClick;
            createBtn.Click += OnCreateOrUpdateClick;

            this.FormClosing += CreateFilmForm_FormClosing;

            libraryLbl.Click += LibraryLbl_Click;
        }

        private void LoadGenreCheckboxes()
        {
            var genres = _service.GetAllGenres();

            flowLayoutPanel1.Controls.Clear();
            _genreCheckboxes.Clear();

            foreach (var genre in genres)
            {
                var checkBox = new CheckBox
                {
                    Text = genre.Name,
                    Tag = genre.Id,
                    AutoSize = true,
                    Font = new Font("Bahnschrift Condensed", 10),
                    Margin = new Padding(5)
                };
                _genreCheckboxes.Add(checkBox);
                flowLayoutPanel1.Controls.Add(checkBox);
            }
        }

        private void LoadSerieData()
        {
            var serie = _service.GetAllSeries().FirstOrDefault(s => s.Id == _serieId);
            if (serie == null) return;

            titleTxb.Text = serie.Title;
            chaptersTxb.Text = serie.TotalEpisodes.ToString();
            textBox1.Text = serie.Synopsis;
            _selectedImagePath = serie.ImagePath;

            var selectedGenres = _service.GetGenresForSerie(serie.Id).Select(g => g.Id).ToHashSet();
            foreach (var cb in _genreCheckboxes)
            {
                if (selectedGenres.Contains((int) cb.Tag))
                    cb.Checked = true;
            }
        }

        private void OnImageButtonClick(object? sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Seleccionar imagen"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _selectedImagePath = ofd.FileName;
            }
        }

        private void OnCreateOrUpdateClick(object? sender, EventArgs e)
        {
            string title = titleTxb.Text.Trim();
            string chaptersText = chaptersTxb.Text.Trim();
            string synopsis = textBox1.Text.Trim();
            string imagePath = File.Exists(_selectedImagePath) ? _selectedImagePath : _defaultImagePath;

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(chaptersText) || string.IsNullOrEmpty(synopsis))
            {
                MessageBox.Show("Por favor completa todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(chaptersText, out int totalEpisodes) || totalEpisodes <= 0)
            {
                MessageBox.Show("El campo de capítulos debe ser un número válido mayor que 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedGenres = _genreCheckboxes.Where(cb => cb.Checked).Select(cb => (int) cb.Tag).ToList();
            if (selectedGenres.Count == 0)
            {
                MessageBox.Show("Selecciona al menos un género.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_isUpdate && _serieId.HasValue)
            {
                _service.UpdateSerie(_serieId.Value, title, totalEpisodes, imagePath, synopsis);

                _service.NormalizeWatchedEpisodes(_serieId.Value);

                var currentGenres = _service.GetGenresForSerie(_serieId.Value);
                foreach (var g in currentGenres)
                {
                    _service.RemoveSerieGenre(_serieId.Value, g.Id);
                }

                foreach (int genreId in selectedGenres)
                {
                    _service.AddSerieGenre(_serieId.Value, genreId);
                }

                MessageBox.Show("Serie actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _service.AddSerie(title, totalEpisodes, imagePath, synopsis);
                var newSerieId = _service.GetAllSeries().Last().Id;

                foreach (int genreId in selectedGenres)
                {
                    _service.AddSerieGenre(newSerieId, genreId);
                }

                MessageBox.Show("Serie añadida correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            var form = new FilmLibraryForm(_service, _userId);
            form.Show();
            this.Hide();
        }

        private void CreateFilmForm_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
