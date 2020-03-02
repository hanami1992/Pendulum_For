namespace Pendulum_Form
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbArtist = new System.Windows.Forms.ComboBox();
            this.cbAlbum = new System.Windows.Forms.ComboBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.dgvZeneSzam = new System.Windows.Forms.DataGridView();
            this.rtbAdat = new System.Windows.Forms.RichTextBox();
            this.btnAddDisc = new System.Windows.Forms.Button();
            this.llUrl = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.btnAddUrl = new System.Windows.Forms.Button();
            this.btnSzerkeszt = new System.Windows.Forms.Button();
            this.pbKep = new System.Windows.Forms.PictureBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZeneSzam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKep)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artist";
            // 
            // cbArtist
            // 
            this.cbArtist.FormattingEnabled = true;
            this.cbArtist.Location = new System.Drawing.Point(11, 51);
            this.cbArtist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbArtist.Name = "cbArtist";
            this.cbArtist.Size = new System.Drawing.Size(115, 21);
            this.cbArtist.TabIndex = 1;
            this.cbArtist.SelectedIndexChanged += new System.EventHandler(this.cbArtist_SelectedIndexChanged);
            // 
            // cbAlbum
            // 
            this.cbAlbum.FormattingEnabled = true;
            this.cbAlbum.Location = new System.Drawing.Point(139, 51);
            this.cbAlbum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbAlbum.Name = "cbAlbum";
            this.cbAlbum.Size = new System.Drawing.Size(120, 21);
            this.cbAlbum.TabIndex = 2;
            this.cbAlbum.SelectedIndexChanged += new System.EventHandler(this.cbAlbum_SelectedIndexChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(11, 111);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(247, 20);
            this.tbSearch.TabIndex = 3;
            // 
            // dgvZeneSzam
            // 
            this.dgvZeneSzam.AllowUserToAddRows = false;
            this.dgvZeneSzam.AllowUserToDeleteRows = false;
            this.dgvZeneSzam.AllowUserToResizeColumns = false;
            this.dgvZeneSzam.AllowUserToResizeRows = false;
            this.dgvZeneSzam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvZeneSzam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZeneSzam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvZeneSzam.Location = new System.Drawing.Point(11, 145);
            this.dgvZeneSzam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvZeneSzam.Name = "dgvZeneSzam";
            this.dgvZeneSzam.ReadOnly = true;
            this.dgvZeneSzam.RowHeadersVisible = false;
            this.dgvZeneSzam.RowHeadersWidth = 30;
            this.dgvZeneSzam.RowTemplate.Height = 24;
            this.dgvZeneSzam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZeneSzam.Size = new System.Drawing.Size(246, 210);
            this.dgvZeneSzam.TabIndex = 4;
            this.dgvZeneSzam.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvZeneSzam_CellMouseClick);
            // 
            // rtbAdat
            // 
            this.rtbAdat.Location = new System.Drawing.Point(394, 145);
            this.rtbAdat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbAdat.Name = "rtbAdat";
            this.rtbAdat.Size = new System.Drawing.Size(198, 96);
            this.rtbAdat.TabIndex = 6;
            this.rtbAdat.Text = "";
            // 
            // btnAddDisc
            // 
            this.btnAddDisc.Location = new System.Drawing.Point(275, 314);
            this.btnAddDisc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddDisc.Name = "btnAddDisc";
            this.btnAddDisc.Size = new System.Drawing.Size(104, 41);
            this.btnAddDisc.TabIndex = 7;
            this.btnAddDisc.Text = "Add Discography";
            this.btnAddDisc.UseVisualStyleBackColor = true;
            // 
            // llUrl
            // 
            this.llUrl.AutoSize = true;
            this.llUrl.Location = new System.Drawing.Point(350, 271);
            this.llUrl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llUrl.Name = "llUrl";
            this.llUrl.Size = new System.Drawing.Size(37, 13);
            this.llUrl.TabIndex = 8;
            this.llUrl.TabStop = true;
            this.llUrl.Text = "NOPE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "URL (if any):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Search in track\'s title";
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Location = new System.Drawing.Point(136, 17);
            this.lblAlbum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(36, 13);
            this.lblAlbum.TabIndex = 11;
            this.lblAlbum.Text = "Album";
            // 
            // btnAddUrl
            // 
            this.btnAddUrl.Location = new System.Drawing.Point(394, 314);
            this.btnAddUrl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddUrl.Name = "btnAddUrl";
            this.btnAddUrl.Size = new System.Drawing.Size(93, 41);
            this.btnAddUrl.TabIndex = 12;
            this.btnAddUrl.Text = "Add URL";
            this.btnAddUrl.UseVisualStyleBackColor = true;
            this.btnAddUrl.Click += new System.EventHandler(this.btnAddUrl_Click);
            // 
            // btnSzerkeszt
            // 
            this.btnSzerkeszt.Location = new System.Drawing.Point(500, 314);
            this.btnSzerkeszt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSzerkeszt.Name = "btnSzerkeszt";
            this.btnSzerkeszt.Size = new System.Drawing.Size(84, 41);
            this.btnSzerkeszt.TabIndex = 13;
            this.btnSzerkeszt.Text = "Edit Selected";
            this.btnSzerkeszt.UseVisualStyleBackColor = true;
            this.btnSzerkeszt.Click += new System.EventHandler(this.btnSzerkeszt_Click);
            // 
            // pbKep
            // 
            this.pbKep.Location = new System.Drawing.Point(275, 133);
            this.pbKep.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbKep.Name = "pbKep";
            this.pbKep.Size = new System.Drawing.Size(110, 119);
            this.pbKep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKep.TabIndex = 5;
            this.pbKep.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 10F;
            this.Column1.HeaderText = "Title";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 5F;
            this.Column2.HeaderText = "Length";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 10F;
            this.Column3.HeaderText = "Url";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnSzerkeszt);
            this.Controls.Add(this.btnAddUrl);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.llUrl);
            this.Controls.Add(this.btnAddDisc);
            this.Controls.Add(this.rtbAdat);
            this.Controls.Add(this.pbKep);
            this.Controls.Add(this.dgvZeneSzam);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.cbAlbum);
            this.Controls.Add(this.cbArtist);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmMain";
            this.Text = "Discography Tracker";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZeneSzam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbArtist;
        private System.Windows.Forms.ComboBox cbAlbum;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridView dgvZeneSzam;
        private System.Windows.Forms.PictureBox pbKep;
        private System.Windows.Forms.RichTextBox rtbAdat;
        private System.Windows.Forms.Button btnAddDisc;
        private System.Windows.Forms.LinkLabel llUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Button btnAddUrl;
        private System.Windows.Forms.Button btnSzerkeszt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

