using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendulum_Form
{
    public partial class FrmMain : Form
    {
        SqlConnection conn;
        public FrmMain()
        {
            AppDomain.CurrentDomain.SetData( 
                "DataDirectory", 
                Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
                .Replace(@"bin\Debug","Data"));
            conn = new SqlConnection(
                @"Server = (localdb)\MSSQLLocalDB;" +
                @"AttachDBFilename=|DataDirectory|music.mdf;");

            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            cbAlbum.Enabled = false;
            tbSearch.Enabled = false;
            btnAddUrl.Enabled = false;
            
            conn.Open();

            var cmd = new SqlCommand(
                "SELECT DISTINCT artist " +
                "FROM Albums;", conn);

            var artist = cmd.ExecuteReader();

            while (artist.Read())
            {
               cbArtist.Items.Add(artist[0]);
            }

            conn.Close();
        }

        private void cbArtist_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbAlbum.Enabled = true;
            cbAlbum.Text = "";
            cbAlbum.Items.Clear();
            pbKep.Image = null;
            rtbAdat.Text = "";
            dgvZeneSzam.Rows.Clear();
            tbSearch.Enabled = false;
            llUrl.Text = "NOPE";
            btnAddUrl.Enabled = false;

            conn.Open();

            var title = new SqlCommand(
                "SELECT title " +
                "FROM Albums " +
                $"WHERE artist like '{cbArtist.SelectedItem.ToString()}';", conn);

            var t = title.ExecuteReader();

            while (t.Read())
            {
                cbAlbum.Items.Add(t[0]);
                string album = t[0].ToString();
               
            }
            
            conn.Close();
        }

        private void cbAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbAdat.Text = "";
            dgvZeneSzam.Rows.Clear();
            llUrl.Text = "NOPE";
            btnAddUrl.Enabled = false;


            if (cbAlbum.SelectedItem.ToString().Equals("Amaranthe")) pbKep.Image = Properties.Resources.Amaranthe;
            else if (cbAlbum.SelectedItem.ToString().Equals("The Nexus")) pbKep.Image = Properties.Resources.Nexus;
            else if (cbAlbum.SelectedItem.ToString().Equals("Massive Addictive")) pbKep.Image = Properties.Resources.Massive_addictive;
            else if (cbAlbum.SelectedItem.ToString().Equals("Maximalism")) pbKep.Image = Properties.Resources.Maximalism;
            else if (cbAlbum.SelectedItem.ToString().Equals("Hold Your Colour")) pbKep.Image = Properties.Resources.Hold_your_colour;
            else if (cbAlbum.SelectedItem.ToString().Equals("In Silico")) pbKep.Image = Properties.Resources.In_silico;
            if (cbAlbum.SelectedItem.ToString().Equals("Immersion")) pbKep.Image = Properties.Resources.Immersion;

            conn.Open();

            var date = new SqlCommand(
                "SELECT Distinct Albums.release, Tracks.length " +
                "FROM Albums inner join Tracks on Albums.id = Tracks.album " +
                $"WHERE Albums.title like '{cbAlbum.SelectedItem.ToString()}' ", conn);

            var dat = date.ExecuteReader();
            
            while (dat.Read())
            {

                //TimeSpan sum = TimeSpan.Zero;
                //for (int i = 0; i < dat.ToString().Length; i++)
                //{
                //    TimeSpan d = dat.GetTimeSpan(1);
                //    sum += d; 
                //}
                rtbAdat.Text = dat.GetDateTime(0).ToString("yyyy.MM.dd") + '\n';

            }

            conn.Close();

            conn.Open();

            var zeneszam = new SqlCommand( 
                "SELECT Tracks.title, Tracks.length, Tracks.url " +
                "FROM Albums inner join Tracks on Albums.id = Tracks.album " +
                $"WHERE Albums.title like '{cbAlbum.SelectedItem.ToString()}'", conn);

            var zsz = zeneszam.ExecuteReader();

            while (zsz.Read())
            {
                dgvZeneSzam.Rows.Add(zsz[0], zsz[1], zsz[2]);
                
                if (!dgvZeneSzam.CurrentRow.Cells[2].Value.ToString().Contains("null"))
                {
                    
                    llUrl.Text = $"https://youtu.be/{dgvZeneSzam.CurrentRow.Cells[2].Value.ToString()}";
                    btnAddUrl.Enabled = false;

                }
                else
                {
                    llUrl.Text = "NOPE";
                    btnAddUrl.Enabled = true;

                }
            }

            conn.Close();
            tbSearch.Enabled = true;
        }

              
        private void dgvZeneSzam_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

                if (!dgvZeneSzam.CurrentRow.Cells[2].Value.ToString().Contains("null"))
                {

                    llUrl.Text = $"https://youtu.be/{dgvZeneSzam.CurrentRow.Cells[2].Value.ToString()}";
                    btnAddUrl.Enabled = false;
                    
                }
                else
                {

                    llUrl.Text = "NOPE";
                    btnAddUrl.Enabled = true;

                }
                
            
        }
        private void btnAddUrl_Click(object sender, EventArgs e)
        {
            var frm = new AddUrl(conn, dgvZeneSzam.SelectedRows[0].Cells[0].Value.ToString());
            frm.ShowDialog();
        }

        private void btnSzerkeszt_Click(object sender, EventArgs e)
        {
            var frm = new EditSelected(conn, dgvZeneSzam.SelectedRows[0].Cells[0].Value.ToString());
            frm.Show();
        }
    }
}
