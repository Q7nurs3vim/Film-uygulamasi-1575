using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film_Otomasyonu_1575
{
    public partial class Form1 : Form
    {
        BindingList<Film> filmler = new BindingList<Film>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            Film film1 = new Film(1, "Oppenheimer", 180, "Gerilim", new DateTime(2023, 07, 14), true);

            Film film2 = new Film(2, "Thor", 140, "Aksiyon", new DateTime(2023, 08, 23), true);

            Film film3 = new Film(3, "Spiderman", 100, "Animasyon", new DateTime(2023, 06, 12), true);

            Film film4 = new Film(4, "Tünel", 120, "Gerilim", new DateTime(2023, 03, 25), true);

            filmler.Add(film1);
            filmler.Add(film2);
            filmler.Add(film3);
            filmler.Add(film4);

            dataGridView1.DataSource = filmler;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            string filmAd = txtFilm.Text;
            int sure = Convert.ToInt32(txtSure.Text);
            string tur = cbTur.Text;
            DateTime tarih = DateTime.Now;
            bool begendim = checkBox1.Checked;

            Film film = new Film(id, filmAd, sure, tur, tarih, begendim);

            filmler.Add(film);

            dataGridView1.Refresh();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Film film = (Film)dataGridView1.SelectedRows[0].DataBoundItem;

                film.FilmAd = txtFilm.Text;
                film.Sure = Convert.ToInt32(txtSure.Text);
                film.KayitTarih = dtp1.Value;
                film.Tur = cbTur.SelectedText;
                film.Begenme = checkBox1.Checked;

                dataGridView1.Refresh();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Film film = (Film)dataGridView1.SelectedRows[0].DataBoundItem;

                txtId.Text = film.Id.ToString();
                txtFilm.Text = film.FilmAd;
                txtSure.Text = film.Sure.ToString();
                dtp1.Value = film.KayitTarih;
                cbTur.Text = film.Tur;
                checkBox1.Checked = film.Begenme;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Film film = (Film)dataGridView1.SelectedRows[0].DataBoundItem;

                DialogResult sonuc = MessageBox.Show(film.FilmAd + " silinsin mi?", "Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (sonuc == DialogResult.Yes)
                {

                    filmler.Remove(film);

                }
            }
        }
    }
}
