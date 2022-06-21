using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovayaRabota
{
    public partial class EditAlbumForm : Form
    {
        public Album album;
        public EditAlbumForm(Album a)
        {
            album = a;
            InitializeComponent();
            this.Text += " - " + a.Name;
            UpdateTable();
            textBoxNameAlbum.Text = a.Name;
        }
        private void UpdateTable()
        {
            dataGridViewEditAlbum.Rows.Clear();
            foreach (var track in album.tracks)
            {
                dataGridViewEditAlbum.Rows.Add(track.NameTrack, track.NameGroup, track.NamePerformer, track.DurationStr);
            }
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            var tracks = new List<Track>();
            for (int i = 0; i < dataGridViewEditAlbum.Rows.Count - 1; i++)
            {
                try
                {
                    var nameTrack = dataGridViewEditAlbum.Rows[i].Cells[0].Value.ToString();
                    var nameGroup = dataGridViewEditAlbum.Rows[i].Cells[1].Value.ToString();
                    var namePerformer = dataGridViewEditAlbum.Rows[i].Cells[2].Value.ToString();
                    var duration = dataGridViewEditAlbum.Rows[i].Cells[3].Value.ToString();
                    try
                    {
                        var newTrack = new Track(nameTrack, nameGroup, namePerformer, duration);
                        tracks.Add(newTrack);
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Таблица заполнена некоректно");
                    return;
                }
            }

            album.tracks.Clear();
            album.tracks.AddRange(tracks);
            try
            {
                album.Name = textBoxNameAlbum.Text;
            }
            catch
            {
                MessageBox.Show("Имя альбома некоректно");
                return;
            }
            //MessageBox.Show("Изменения сохранены");
            this.Close();
        }

        private void dataGridViewEditAlbum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((e.ColumnIndex == 4) && (dataGridViewEditAlbum.Rows.Count > 1))
                {
                    dataGridViewEditAlbum.Rows.RemoveAt(e.RowIndex);
                }
            }
            catch
            {
                MessageBox.Show("Нельзя удалить пустое поле");
            }

        }

        private void buttonComeBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxNameAlbum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
