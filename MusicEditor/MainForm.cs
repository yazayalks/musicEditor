using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;



namespace KursovayaRabota
{
    public partial class MainForm : Form
    {
        public static List<Album> albums;
        public static int currentAlbumIndex = -1;
        private Application application;
        private Workbook workBook;
        private Worksheet worksheet;
        public MainForm()
        {
            InitializeComponent();
            albums = new List<Album>();

        }

        public void UpdateAlbumList(List<Album> al)
        {
            foreach (var a in al)
            {
                albums.Insert(++currentAlbumIndex, a);
                albumList.Items.Insert(currentAlbumIndex, a.Name);
                albumList.SelectedIndex = currentAlbumIndex;
            }
        }
        private void buttonAddAlbum_Click(object sender, EventArgs e)
        {
            AddAlbum();
        }
        private void AddAlbum()
        {
            if (textBoxInputNameAlbum.Text == "")
            {
                MessageBox.Show("Напишите название альбома");
            }
            if (textBoxInputNameAlbum.Text != "")
            {
                foreach (var a in albums)
                {
                    if (a.Name == textBoxInputNameAlbum.Text)
                    {
                        MessageBox.Show("Альбом с таким именем уже существует");
                        return;
                    }
                }
                try
                {
                    Album newAlbum = new(textBoxInputNameAlbum.Text);
                    albums.Insert(++currentAlbumIndex, newAlbum);
                    albumList.Items.Insert(currentAlbumIndex, textBoxInputNameAlbum.Text);
                    albumList.SelectedIndex = currentAlbumIndex;
                    textBoxInputNameAlbum.Clear();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                    return;
                }
            }
        }

        private void textBoxNameAlbum_TextChanged(object sender, EventArgs e)
        {

        }

        private void albumList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (albumList.SelectedIndex == -1)
            {
                return;
            }
            currentAlbumIndex = albumList.SelectedIndex;
            textBoxOutputNameAlbum.Text = albums[currentAlbumIndex].Name;
        }

        private void buttonEditAlbum_Click(object sender, EventArgs e)
        {
            try
            {
                using (EditAlbumForm form = new EditAlbumForm(albums[currentAlbumIndex]))
                {
                    form.Owner = this;
                    form.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Не выбран альбом для редактирования");
            }
            albumList.Items[currentAlbumIndex] = albums[currentAlbumIndex].Name;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonDeleteAlbum_Click(object sender, EventArgs e)
        {
            try
            {
                int curAlbumIndex = albumList.SelectedIndex;
                albums.RemoveAt(curAlbumIndex);
                currentAlbumIndex--;
                albumList.Items.RemoveAt(curAlbumIndex);
                textBoxOutputNameAlbum.Clear();
            }
            catch
            {
                MessageBox.Show("Не выбран альбом для удаления");
            }
        }

        private void textBoxOutputNameAlbum_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDeleteAllAlbums_Click(object sender, EventArgs e)
        {
            if (currentAlbumIndex == -1)
            {
                MessageBox.Show("Список альбомов пуст");
                return;
            }
            try
            {
                albumList.Items.Clear();
                textBoxOutputNameAlbum.Clear();
                albums.Clear();
                currentAlbumIndex = -1;
            }
            catch
            {
                MessageBox.Show("Ошибка удаления");
            }

        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                var json = JsonSerializer.Serialize(albums);
                File.WriteAllText(saveFile.FileName, json);
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    List<Album> al = JsonSerializer.Deserialize<List<Album>>(File.ReadAllText(openFile.FileName));
                    albums.Clear();
                    albumList.Items.Clear();
                    currentAlbumIndex = -1;
                    UpdateAlbumList(al);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Ошибка открытия файла");
            }
        }

        private void buttonAddFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    List<Album> al = JsonSerializer.Deserialize<List<Album>>(File.ReadAllText(openFile.FileName));
                    UpdateAlbumList(al);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка добавления файла");
            }
        }

        private void buttonPrintAlbum_Click(object sender, EventArgs e)
        {

            try
            {
                int curAlbumIndex = albumList.SelectedIndex;
                richTextBoxOutput.Clear();
                var al = albums[curAlbumIndex];
                richTextBoxOutput.Text += "Альбом - " + al.Name + "\n";
                int count = 1;
                foreach (var b in al.tracks)
                {
                    richTextBoxOutput.Text += "     ~Песня №" + count + "\n";
                    richTextBoxOutput.Text += "          *Название: " + b.NameTrack + "\n";
                    richTextBoxOutput.Text += "          *Группа: " + b.NameGroup + "\n";
                    richTextBoxOutput.Text += "          *Исполнитель: " + b.NamePerformer + "\n";
                    richTextBoxOutput.Text += "          *Время: " + TimeSpan.Parse(b.DurationStr) + "\n";
                    count++;
                }
            }
            catch
            {
                MessageBox.Show("Не выбран альбом для печати");
            }
        }

        private void buttonFindDurationAlbum_Click(object sender, EventArgs e)
        {
            try
            {
                int curAlbumIndex = albumList.SelectedIndex;
                richTextBoxOutput.Clear();
                var al = albums[curAlbumIndex];
                richTextBoxOutput.Text += "Альбом - " + al.Name + "\n";
                richTextBoxOutput.Text += "     ~Продолжительность: " + al.getDurationTracks() + "\n";
            }
            catch
            {
                MessageBox.Show("Не выбран альбом для печати");
            }
        }

        private void buttonPrintAlbums_Click(object sender, EventArgs e)
        {
            if (albums.Count <= 0)
            {
                MessageBox.Show("Нет альбомов для печати");
                return;
            }
            try
            {
                richTextBoxOutput.Clear();
                foreach (var al in albums)
                {
                    int count = 1;
                    richTextBoxOutput.Text += "Альбом - " + al.Name + "\n";
                    foreach (var b in al.tracks)
                    {
                        richTextBoxOutput.Text += "     ~Песня №" + count + "\n";
                        richTextBoxOutput.Text += "          *Название: " + b.NameTrack + "\n";
                        richTextBoxOutput.Text += "          *Группа: " + b.NameGroup + "\n";
                        richTextBoxOutput.Text += "          *Исполнитель: " + b.NamePerformer + "\n";
                        richTextBoxOutput.Text += "          *Время: " + TimeSpan.Parse(b.DurationStr) + "\n";
                        count++;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка печати альбомов");
            }
        }

        private void buttonFindDurationAlbums_Click(object sender, EventArgs e)
        {
            if (albums.Count <= 0)
            {
                MessageBox.Show("Нет альбомов для печати");
                return;
            }
            try
            {
                richTextBoxOutput.Clear();
                foreach (var al in albums)
                {
                    richTextBoxOutput.Text += "Альбом - " + al.Name + "\n";
                    richTextBoxOutput.Text += "     ~Продолжительность: " + TimeSpan.Parse(al.getDurationTracks()) + "\n";
                }
            }
            catch
            {
                MessageBox.Show("Ошибка печати альбомов");
            }
        }

        private void buttonClearBoxOutput_Click(object sender, EventArgs e)
        {
            richTextBoxOutput.Clear();
        }

        private void richTextBoxOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonFindTrackTimeBorder_Click(object sender, EventArgs e)
        {
            
            try
            {
                int curAlbumIndex = albumList.SelectedIndex;
                richTextBoxOutput.Clear();
                var al = albums[curAlbumIndex];

                bool flag = true;
                int count = 1;
                foreach (var b in al.tracks)
                {
                    if (TimeSpan.Parse(textBoxInputTimeBorder.Text) > TimeSpan.Parse(b.DurationStr)) { 
                        if (flag)
                        {
                            richTextBoxOutput.Text += "Альбом - " + al.Name + "\n";
                            richTextBoxOutput.Text += "Песни короче " + TimeSpan.Parse(textBoxInputTimeBorder.Text) + ":" + "\n";
                            flag = false;
                        }
                    richTextBoxOutput.Text += "     ~Песня №" + count + "\n";
                    richTextBoxOutput.Text += "          *Название: " + b.NameTrack + "\n";
                    richTextBoxOutput.Text += "          *Группа: " + b.NameGroup + "\n";
                    richTextBoxOutput.Text += "          *Исполнитель: " + b.NamePerformer + "\n";
                    richTextBoxOutput.Text += "          *Время: " + TimeSpan.Parse(b.DurationStr) + "\n";
                    count++;
                    }
                }
                if (flag)
                {
                    richTextBoxOutput.Text += "В альбоме \"" + al.Name + "\" нет песен короче " + TimeSpan.Parse(textBoxInputTimeBorder.Text) + ".\n";
                }
            }
            catch
            {
                MessageBox.Show("Не выбран альбом для печати");
            }
        }

        private void buttonFindTrackTimeBorderAllAlbums_Click(object sender, EventArgs e)
        {
            if (albums.Count <= 0)
            {
                MessageBox.Show("Нет альбомов для печати");
                return;
            }
            try
            {
                richTextBoxOutput.Clear();
                foreach (var al in albums)
                {
                    bool flag = true;
                    int count = 1;
                    foreach (var b in al.tracks)
                    {
                        if (TimeSpan.Parse(textBox2InputTimeBorder.Text) > TimeSpan.Parse(b.DurationStr))
                        {
                            if (flag)
                            {
                                richTextBoxOutput.Text += "Альбом - " + al.Name + "\n";
                                richTextBoxOutput.Text += "Песни короче " + TimeSpan.Parse(textBox2InputTimeBorder.Text) + ":" + "\n";
                                flag = false;
                            }
                            richTextBoxOutput.Text += "     ~Песня №" + count + "\n";
                            richTextBoxOutput.Text += "          *Название: " + b.NameTrack + "\n";
                            richTextBoxOutput.Text += "          *Группа: " + b.NameGroup + "\n";
                            richTextBoxOutput.Text += "          *Исполнитель: " + b.NamePerformer + "\n";
                            richTextBoxOutput.Text += "          *Время: " + TimeSpan.Parse(b.DurationStr) + "\n";
                            count++;
                        }
                    }
                    if (flag)
                    {
                        richTextBoxOutput.Text += "В альбоме \"" + al.Name + "\" нет песен короче " + TimeSpan.Parse(textBox2InputTimeBorder.Text) + ".\n";
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка печати альбомов");
            }
        }

  
        private void buttonExportExcel_Click(object sender, EventArgs e)
        {
            if (albums.Count <= 0)
            {
                MessageBox.Show("Нет альбомов для экспорта");
                return;
            }
            if (textBoxInputNameFile.Text == "")
            {
                MessageBox.Show("Нет имени для файла");
                return;
            }
            // Открываем приложение
            application = new Application
            {
                DisplayAlerts = false
            };

            // Файл шаблона
            const string template = "template.xlsx";

            // Открываем книгу
            workBook = application.Workbooks.Open(Path.Combine(Environment.CurrentDirectory, template));

            // Получаем активную таблицу
            worksheet = workBook.ActiveSheet as Worksheet;

            // Записываем данные
            worksheet.Range["A1"].Value = DateTime.Now;
            worksheet.Range["A2"].Value = "Номер";
            worksheet.Range["B2"].Value = "Песня";
            worksheet.Range["C2"].Value = "Группа";
            worksheet.Range["D2"].Value = "Исполнитель";
            worksheet.Range["E2"].Value = "Альбом";
            worksheet.Range["F2"].Value = "Время";
            int count = 3;
            int number = 1;
            worksheet.StandardWidth = 30;


            try
            {
                foreach (var al in albums)
                {
                    foreach (var b in al.tracks)
                    {
                        worksheet.Cells[count, 1].Value = number++;
                        worksheet.Cells[count, 2].Value = b.NameTrack;
                        worksheet.Cells[count, 3].Value = b.NameGroup;
                        worksheet.Cells[count, 4].Value = b.NamePerformer;
                        worksheet.Cells[count, 5].Value = al.Name;
                        worksheet.Cells[count, 6].Value = b.DurationStr;
                        count++;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка экспорта альбомов");
            }

            // Показываем приложение
            application.Visible = true;
            TopMost = true;

            string savedFileName = textBoxInputNameFile.Text;
            workBook.SaveAs(Path.Combine(Environment.CurrentDirectory, savedFileName));
            CloseExcel();
            MessageBox.Show("Данные успешно экспортированны в файл " + textBoxInputNameFile.Text);
        }
        private void CloseExcel()
        {
            if (application != null)
            {
                int excelProcessId = -1;
                GetWindowThreadProcessId(application.Hwnd, ref excelProcessId);

                Marshal.ReleaseComObject(worksheet);
                workBook.Close();
                Marshal.ReleaseComObject(workBook);
                application.Quit();
                Marshal.ReleaseComObject(application);

                application = null;
                // Прибиваем висящий процесс
                try
                {
                    Process process = Process.GetProcessById(excelProcessId);
                    process.Kill();
                }
                finally { }
            }

        }
        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(int hWnd, ref int lpdwProcessId);

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseExcel();
        }

        private void buttonOutputInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Перед вами программа для создания и редактирования на основе базы данных Вашей музыки.\n © Lysak Kirill 2021\n");
        }
    }
}
