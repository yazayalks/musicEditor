
namespace KursovayaRabota
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.albumList = new System.Windows.Forms.ListBox();
            this.buttonEditAlbum = new System.Windows.Forms.Button();
            this.buttonDeleteAlbum = new System.Windows.Forms.Button();
            this.buttonDeleteAllAlbums = new System.Windows.Forms.Button();
            this.buttonAddAlbum = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonAddFile = new System.Windows.Forms.Button();
            this.textBoxInputNameAlbum = new System.Windows.Forms.TextBox();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.buttonPrintAlbums = new System.Windows.Forms.Button();
            this.buttonFindDurationAlbums = new System.Windows.Forms.Button();
            this.buttonPrintAlbum = new System.Windows.Forms.Button();
            this.buttonFindDurationAlbum = new System.Windows.Forms.Button();
            this.textBoxOutputNameAlbum = new System.Windows.Forms.TextBox();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.buttonClearBoxOutput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFindTrackTimeBorder = new System.Windows.Forms.Button();
            this.labelTimeBorder = new System.Windows.Forms.Label();
            this.textBoxInputTimeBorder = new System.Windows.Forms.TextBox();
            this.label2TimeBorder = new System.Windows.Forms.Label();
            this.textBox2InputTimeBorder = new System.Windows.Forms.TextBox();
            this.buttonFindTrackTimeBorderAllAlbums = new System.Windows.Forms.Button();
            this.buttonExportExcel = new System.Windows.Forms.Button();
            this.labelNameFile = new System.Windows.Forms.Label();
            this.textBoxInputNameFile = new System.Windows.Forms.TextBox();
            this.buttonOutputInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // albumList
            // 
            this.albumList.FormattingEnabled = true;
            this.albumList.ItemHeight = 15;
            this.albumList.Location = new System.Drawing.Point(197, 45);
            this.albumList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.albumList.Name = "albumList";
            this.albumList.Size = new System.Drawing.Size(174, 289);
            this.albumList.TabIndex = 0;
            this.albumList.SelectedIndexChanged += new System.EventHandler(this.albumList_SelectedIndexChanged);
            // 
            // buttonEditAlbum
            // 
            this.buttonEditAlbum.Location = new System.Drawing.Point(15, 74);
            this.buttonEditAlbum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonEditAlbum.Name = "buttonEditAlbum";
            this.buttonEditAlbum.Size = new System.Drawing.Size(175, 30);
            this.buttonEditAlbum.TabIndex = 1;
            this.buttonEditAlbum.Text = "Редактировать альбом";
            this.buttonEditAlbum.UseVisualStyleBackColor = true;
            this.buttonEditAlbum.Click += new System.EventHandler(this.buttonEditAlbum_Click);
            // 
            // buttonDeleteAlbum
            // 
            this.buttonDeleteAlbum.Location = new System.Drawing.Point(15, 109);
            this.buttonDeleteAlbum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDeleteAlbum.Name = "buttonDeleteAlbum";
            this.buttonDeleteAlbum.Size = new System.Drawing.Size(175, 30);
            this.buttonDeleteAlbum.TabIndex = 2;
            this.buttonDeleteAlbum.Text = "Удалить альбом";
            this.buttonDeleteAlbum.UseVisualStyleBackColor = true;
            this.buttonDeleteAlbum.Click += new System.EventHandler(this.buttonDeleteAlbum_Click);
            // 
            // buttonDeleteAllAlbums
            // 
            this.buttonDeleteAllAlbums.Location = new System.Drawing.Point(15, 145);
            this.buttonDeleteAllAlbums.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDeleteAllAlbums.Name = "buttonDeleteAllAlbums";
            this.buttonDeleteAllAlbums.Size = new System.Drawing.Size(175, 30);
            this.buttonDeleteAllAlbums.TabIndex = 3;
            this.buttonDeleteAllAlbums.Text = "Удалить все альбомы";
            this.buttonDeleteAllAlbums.UseVisualStyleBackColor = true;
            this.buttonDeleteAllAlbums.Click += new System.EventHandler(this.buttonDeleteAllAlbums_Click);
            // 
            // buttonAddAlbum
            // 
            this.buttonAddAlbum.Location = new System.Drawing.Point(13, 432);
            this.buttonAddAlbum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddAlbum.Name = "buttonAddAlbum";
            this.buttonAddAlbum.Size = new System.Drawing.Size(175, 30);
            this.buttonAddAlbum.TabIndex = 4;
            this.buttonAddAlbum.Text = "Добавить альбом";
            this.buttonAddAlbum.UseVisualStyleBackColor = true;
            this.buttonAddAlbum.Click += new System.EventHandler(this.buttonAddAlbum_Click);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Location = new System.Drawing.Point(196, 361);
            this.buttonSaveFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(175, 30);
            this.buttonSaveFile.TabIndex = 5;
            this.buttonSaveFile.Text = "Сохранить файл";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(196, 397);
            this.buttonOpenFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(175, 30);
            this.buttonOpenFile.TabIndex = 6;
            this.buttonOpenFile.Text = "Открыть файл";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonAddFile
            // 
            this.buttonAddFile.Location = new System.Drawing.Point(196, 432);
            this.buttonAddFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddFile.Name = "buttonAddFile";
            this.buttonAddFile.Size = new System.Drawing.Size(175, 30);
            this.buttonAddFile.TabIndex = 7;
            this.buttonAddFile.Text = "Добавить файл";
            this.buttonAddFile.UseVisualStyleBackColor = true;
            this.buttonAddFile.Click += new System.EventHandler(this.buttonAddFile_Click);
            // 
            // textBoxInputNameAlbum
            // 
            this.textBoxInputNameAlbum.Location = new System.Drawing.Point(13, 402);
            this.textBoxInputNameAlbum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxInputNameAlbum.Name = "textBoxInputNameAlbum";
            this.textBoxInputNameAlbum.Size = new System.Drawing.Size(175, 23);
            this.textBoxInputNameAlbum.TabIndex = 8;
            this.textBoxInputNameAlbum.TextChanged += new System.EventHandler(this.textBoxNameAlbum_TextChanged);
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(404, 45);
            this.richTextBoxOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.Size = new System.Drawing.Size(395, 301);
            this.richTextBoxOutput.TabIndex = 9;
            this.richTextBoxOutput.Text = "";
            this.richTextBoxOutput.TextChanged += new System.EventHandler(this.richTextBoxOutput_TextChanged);
            // 
            // buttonPrintAlbums
            // 
            this.buttonPrintAlbums.Location = new System.Drawing.Point(404, 352);
            this.buttonPrintAlbums.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPrintAlbums.Name = "buttonPrintAlbums";
            this.buttonPrintAlbums.Size = new System.Drawing.Size(175, 30);
            this.buttonPrintAlbums.TabIndex = 10;
            this.buttonPrintAlbums.Text = "Вывести все альбомы";
            this.buttonPrintAlbums.UseVisualStyleBackColor = true;
            this.buttonPrintAlbums.Click += new System.EventHandler(this.buttonPrintAlbums_Click);
            // 
            // buttonFindDurationAlbums
            // 
            this.buttonFindDurationAlbums.Location = new System.Drawing.Point(587, 352);
            this.buttonFindDurationAlbums.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonFindDurationAlbums.Name = "buttonFindDurationAlbums";
            this.buttonFindDurationAlbums.Size = new System.Drawing.Size(175, 30);
            this.buttonFindDurationAlbums.TabIndex = 11;
            this.buttonFindDurationAlbums.Text = "Найти длительности";
            this.buttonFindDurationAlbums.UseVisualStyleBackColor = true;
            this.buttonFindDurationAlbums.Click += new System.EventHandler(this.buttonFindDurationAlbums_Click);
            // 
            // buttonPrintAlbum
            // 
            this.buttonPrintAlbum.Location = new System.Drawing.Point(15, 181);
            this.buttonPrintAlbum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPrintAlbum.Name = "buttonPrintAlbum";
            this.buttonPrintAlbum.Size = new System.Drawing.Size(175, 30);
            this.buttonPrintAlbum.TabIndex = 12;
            this.buttonPrintAlbum.Text = "Вывести альбом";
            this.buttonPrintAlbum.UseVisualStyleBackColor = true;
            this.buttonPrintAlbum.Click += new System.EventHandler(this.buttonPrintAlbum_Click);
            // 
            // buttonFindDurationAlbum
            // 
            this.buttonFindDurationAlbum.Location = new System.Drawing.Point(15, 217);
            this.buttonFindDurationAlbum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonFindDurationAlbum.Name = "buttonFindDurationAlbum";
            this.buttonFindDurationAlbum.Size = new System.Drawing.Size(175, 30);
            this.buttonFindDurationAlbum.TabIndex = 13;
            this.buttonFindDurationAlbum.Text = "Найти длительность";
            this.buttonFindDurationAlbum.UseVisualStyleBackColor = true;
            this.buttonFindDurationAlbum.Click += new System.EventHandler(this.buttonFindDurationAlbum_Click);
            // 
            // textBoxOutputNameAlbum
            // 
            this.textBoxOutputNameAlbum.Enabled = false;
            this.textBoxOutputNameAlbum.Location = new System.Drawing.Point(15, 45);
            this.textBoxOutputNameAlbum.Name = "textBoxOutputNameAlbum";
            this.textBoxOutputNameAlbum.Size = new System.Drawing.Size(175, 23);
            this.textBoxOutputNameAlbum.TabIndex = 14;
            this.textBoxOutputNameAlbum.TextChanged += new System.EventHandler(this.textBoxOutputNameAlbum_TextChanged);
            // 
            // saveFile
            // 
            this.saveFile.Filter = "Json files (.json)|.json|Text files (.txt)|.txt";
            // 
            // buttonClearBoxOutput
            // 
            this.buttonClearBoxOutput.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClearBoxOutput.BackgroundImage")));
            this.buttonClearBoxOutput.Location = new System.Drawing.Point(769, 352);
            this.buttonClearBoxOutput.Name = "buttonClearBoxOutput";
            this.buttonClearBoxOutput.Size = new System.Drawing.Size(30, 30);
            this.buttonClearBoxOutput.TabIndex = 15;
            this.buttonClearBoxOutput.UseVisualStyleBackColor = true;
            this.buttonClearBoxOutput.Click += new System.EventHandler(this.buttonClearBoxOutput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Введите название альбома:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Выбранный альбом:";
            // 
            // buttonFindTrackTimeBorder
            // 
            this.buttonFindTrackTimeBorder.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFindTrackTimeBorder.Location = new System.Drawing.Point(15, 300);
            this.buttonFindTrackTimeBorder.Name = "buttonFindTrackTimeBorder";
            this.buttonFindTrackTimeBorder.Size = new System.Drawing.Size(175, 30);
            this.buttonFindTrackTimeBorder.TabIndex = 18;
            this.buttonFindTrackTimeBorder.Text = "Найти песни по фильтру времени в альбоме";
            this.buttonFindTrackTimeBorder.UseVisualStyleBackColor = true;
            this.buttonFindTrackTimeBorder.Click += new System.EventHandler(this.buttonFindTrackTimeBorder_Click);
            // 
            // labelTimeBorder
            // 
            this.labelTimeBorder.AutoSize = true;
            this.labelTimeBorder.Location = new System.Drawing.Point(15, 253);
            this.labelTimeBorder.Name = "labelTimeBorder";
            this.labelTimeBorder.Size = new System.Drawing.Size(152, 15);
            this.labelTimeBorder.TabIndex = 20;
            this.labelTimeBorder.Text = "Введите границу времени:";
            // 
            // textBoxInputTimeBorder
            // 
            this.textBoxInputTimeBorder.Location = new System.Drawing.Point(15, 271);
            this.textBoxInputTimeBorder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxInputTimeBorder.Name = "textBoxInputTimeBorder";
            this.textBoxInputTimeBorder.Size = new System.Drawing.Size(175, 23);
            this.textBoxInputTimeBorder.TabIndex = 19;
            this.textBoxInputTimeBorder.Text = "00:02:00";
            // 
            // label2TimeBorder
            // 
            this.label2TimeBorder.AutoSize = true;
            this.label2TimeBorder.Location = new System.Drawing.Point(404, 385);
            this.label2TimeBorder.Name = "label2TimeBorder";
            this.label2TimeBorder.Size = new System.Drawing.Size(152, 15);
            this.label2TimeBorder.TabIndex = 23;
            this.label2TimeBorder.Text = "Введите границу времени:";
            // 
            // textBox2InputTimeBorder
            // 
            this.textBox2InputTimeBorder.Location = new System.Drawing.Point(404, 403);
            this.textBox2InputTimeBorder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2InputTimeBorder.Name = "textBox2InputTimeBorder";
            this.textBox2InputTimeBorder.Size = new System.Drawing.Size(175, 23);
            this.textBox2InputTimeBorder.TabIndex = 22;
            this.textBox2InputTimeBorder.Text = "00:02:00";
            // 
            // buttonFindTrackTimeBorderAllAlbums
            // 
            this.buttonFindTrackTimeBorderAllAlbums.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFindTrackTimeBorderAllAlbums.Location = new System.Drawing.Point(404, 432);
            this.buttonFindTrackTimeBorderAllAlbums.Name = "buttonFindTrackTimeBorderAllAlbums";
            this.buttonFindTrackTimeBorderAllAlbums.Size = new System.Drawing.Size(175, 30);
            this.buttonFindTrackTimeBorderAllAlbums.TabIndex = 21;
            this.buttonFindTrackTimeBorderAllAlbums.Text = "Найти песни по фильтру времени в альбомах";
            this.buttonFindTrackTimeBorderAllAlbums.UseVisualStyleBackColor = true;
            this.buttonFindTrackTimeBorderAllAlbums.Click += new System.EventHandler(this.buttonFindTrackTimeBorderAllAlbums_Click);
            // 
            // buttonExportExcel
            // 
            this.buttonExportExcel.Location = new System.Drawing.Point(586, 432);
            this.buttonExportExcel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonExportExcel.Name = "buttonExportExcel";
            this.buttonExportExcel.Size = new System.Drawing.Size(175, 30);
            this.buttonExportExcel.TabIndex = 24;
            this.buttonExportExcel.Text = "Экспорт в Excel";
            this.buttonExportExcel.UseVisualStyleBackColor = true;
            this.buttonExportExcel.Click += new System.EventHandler(this.buttonExportExcel_Click);
            // 
            // labelNameFile
            // 
            this.labelNameFile.AutoSize = true;
            this.labelNameFile.Location = new System.Drawing.Point(587, 385);
            this.labelNameFile.Name = "labelNameFile";
            this.labelNameFile.Size = new System.Drawing.Size(138, 15);
            this.labelNameFile.TabIndex = 26;
            this.labelNameFile.Text = "Введите имя для файла:";
            // 
            // textBoxInputNameFile
            // 
            this.textBoxInputNameFile.Location = new System.Drawing.Point(587, 403);
            this.textBoxInputNameFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxInputNameFile.Name = "textBoxInputNameFile";
            this.textBoxInputNameFile.Size = new System.Drawing.Size(175, 23);
            this.textBoxInputNameFile.TabIndex = 25;
            this.textBoxInputNameFile.Text = "book1.xlsx";
            // 
            // buttonOutputInfo
            // 
            this.buttonOutputInfo.Location = new System.Drawing.Point(624, 9);
            this.buttonOutputInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonOutputInfo.Name = "buttonOutputInfo";
            this.buttonOutputInfo.Size = new System.Drawing.Size(175, 30);
            this.buttonOutputInfo.TabIndex = 27;
            this.buttonOutputInfo.Text = "Информация о программе";
            this.buttonOutputInfo.UseVisualStyleBackColor = true;
            this.buttonOutputInfo.Click += new System.EventHandler(this.buttonOutputInfo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 474);
            this.Controls.Add(this.buttonOutputInfo);
            this.Controls.Add(this.labelNameFile);
            this.Controls.Add(this.textBoxInputNameFile);
            this.Controls.Add(this.buttonExportExcel);
            this.Controls.Add(this.label2TimeBorder);
            this.Controls.Add(this.textBox2InputTimeBorder);
            this.Controls.Add(this.buttonFindTrackTimeBorderAllAlbums);
            this.Controls.Add(this.labelTimeBorder);
            this.Controls.Add(this.textBoxInputTimeBorder);
            this.Controls.Add(this.buttonFindTrackTimeBorder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClearBoxOutput);
            this.Controls.Add(this.textBoxOutputNameAlbum);
            this.Controls.Add(this.buttonFindDurationAlbum);
            this.Controls.Add(this.buttonPrintAlbum);
            this.Controls.Add(this.buttonFindDurationAlbums);
            this.Controls.Add(this.buttonPrintAlbums);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.textBoxInputNameAlbum);
            this.Controls.Add(this.buttonAddFile);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.buttonAddAlbum);
            this.Controls.Add(this.buttonDeleteAllAlbums);
            this.Controls.Add(this.buttonDeleteAlbum);
            this.Controls.Add(this.buttonEditAlbum);
            this.Controls.Add(this.albumList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "MusicEditor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox albumList;
        private System.Windows.Forms.Button buttonEditAlbum;
        private System.Windows.Forms.Button buttonDeleteAlbum;
        private System.Windows.Forms.Button buttonDeleteAllAlbums;
        private System.Windows.Forms.Button buttonAddAlbum;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonAddFile;
        private System.Windows.Forms.TextBox textBoxInputNameAlbum;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.Button buttonPrintAlbums;
        private System.Windows.Forms.Button buttonFindDurationAlbums;
        private System.Windows.Forms.Button buttonPrintAlbum;
        private System.Windows.Forms.Button buttonFindDurationAlbum;
        private System.Windows.Forms.TextBox textBoxOutputNameAlbum;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button buttonClearBoxOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFindTrackTimeBorder;
        private System.Windows.Forms.Label labelTimeBorder;
        private System.Windows.Forms.TextBox textBoxInputTimeBorder;
        private System.Windows.Forms.Label label2TimeBorder;
        private System.Windows.Forms.TextBox textBox2InputTimeBorder;
        private System.Windows.Forms.Button buttonFindTrackTimeBorderAllAlbums;
        private System.Windows.Forms.Button buttonExportExcel;
        private System.Windows.Forms.Label labelNameFile;
        private System.Windows.Forms.TextBox textBoxInputNameFile;
        private System.Windows.Forms.Button buttonOutputInfo;
    }
}

