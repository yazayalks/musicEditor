
namespace KursovayaRabota
{
    partial class EditAlbumForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAlbumForm));
            this.dataGridViewEditAlbum = new System.Windows.Forms.DataGridView();
            this.nameTrack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namePerformer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDeleteTrack = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.buttonComeBack = new System.Windows.Forms.Button();
            this.textBoxNameAlbum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEditAlbum
            // 
            this.dataGridViewEditAlbum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEditAlbum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameTrack,
            this.nameGroup,
            this.namePerformer,
            this.duration,
            this.buttonDeleteTrack,
            this.Column1});
            this.dataGridViewEditAlbum.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewEditAlbum.Name = "dataGridViewEditAlbum";
            this.dataGridViewEditAlbum.RowTemplate.Height = 25;
            this.dataGridViewEditAlbum.Size = new System.Drawing.Size(545, 150);
            this.dataGridViewEditAlbum.TabIndex = 0;
            this.dataGridViewEditAlbum.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEditAlbum_CellContentClick);
            // 
            // nameTrack
            // 
            this.nameTrack.HeaderText = "Песня";
            this.nameTrack.Name = "nameTrack";
            // 
            // nameGroup
            // 
            this.nameGroup.HeaderText = "Группа";
            this.nameGroup.Name = "nameGroup";
            // 
            // namePerformer
            // 
            this.namePerformer.HeaderText = "Исполнитель";
            this.namePerformer.Name = "namePerformer";
            // 
            // duration
            // 
            this.duration.HeaderText = "Время";
            this.duration.Name = "duration";
            // 
            // buttonDeleteTrack
            // 
            this.buttonDeleteTrack.FillWeight = 200F;
            this.buttonDeleteTrack.HeaderText = "Действие";
            this.buttonDeleteTrack.Name = "buttonDeleteTrack";
            this.buttonDeleteTrack.Text = "Удалить";
            this.buttonDeleteTrack.ToolTipText = "Удалить";
            this.buttonDeleteTrack.UseColumnTextForButtonValue = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Location = new System.Drawing.Point(201, 168);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(175, 30);
            this.buttonSaveChanges.TabIndex = 1;
            this.buttonSaveChanges.Text = "Сохранить изменения";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // buttonComeBack
            // 
            this.buttonComeBack.Location = new System.Drawing.Point(382, 168);
            this.buttonComeBack.Name = "buttonComeBack";
            this.buttonComeBack.Size = new System.Drawing.Size(175, 30);
            this.buttonComeBack.TabIndex = 2;
            this.buttonComeBack.Text = "Вернуться назад";
            this.buttonComeBack.UseVisualStyleBackColor = true;
            this.buttonComeBack.Click += new System.EventHandler(this.buttonComeBack_Click);
            // 
            // textBoxNameAlbum
            // 
            this.textBoxNameAlbum.Location = new System.Drawing.Point(20, 173);
            this.textBoxNameAlbum.Name = "textBoxNameAlbum";
            this.textBoxNameAlbum.Size = new System.Drawing.Size(175, 23);
            this.textBoxNameAlbum.TabIndex = 3;
            this.textBoxNameAlbum.TextChanged += new System.EventHandler(this.textBoxNameAlbum_TextChanged);
            // 
            // EditAlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 208);
            this.Controls.Add(this.textBoxNameAlbum);
            this.Controls.Add(this.buttonComeBack);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.dataGridViewEditAlbum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditAlbumForm";
            this.Text = "EditAlbumForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEditAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEditAlbum;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.Button buttonComeBack;
        private System.Windows.Forms.TextBox textBoxNameAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameTrack;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn namePerformer;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewButtonColumn buttonDeleteTrack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}