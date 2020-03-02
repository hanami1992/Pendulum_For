using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendulum_Form
{
    public partial class EditSelected : Form
    {
        SqlConnection conn;
        string title;
        public EditSelected(SqlConnection conn, string title)
        {
            this.conn = conn;
            this.title = title;
            InitializeComponent();

        }

        private void EditSelected_Load(object sender, EventArgs e)
        {
            conn.Open();

            var fill = new SqlCommand(
                "SELECT Tracks.title, Albums.artist, Albums.title, Albums.release, Tracks.length " +
                "FROM Albums inner join Tracks on Albums.id = Tracks.album " +
                $"WHERE Tracks.title like '{title}'", conn);

            var f = fill.ExecuteReader();

            while (f.Read())
            {
                tbCim.Text = f[0].ToString();
                tbZenekar.Text = f[1].ToString();
                tbAlbum.Text = f[2].ToString();
                tbKiadas.Text = f.GetDateTime(3).ToString("yyyy.MM.dd");
                tbHossz.Text = f.GetTimeSpan(4).ToString();
            }

            conn.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            var ch = MessageBox.Show("Biztos, hogy szerkeszted?", "Figyelmeztetés", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (ch == DialogResult.Yes)
            {
                //conn.Open();

                //string change =
                //    "UPDATE Albums INNER JOIN Tracks ON Albums.id = Tracks.album" +
                //    " SET Tracks.title =@tracksTitle, " +
                //    " Albums.artist=@artist, " +
                //    " Albums.title =@albumTitle, " +
                //    " Albums.release = @release, " +
                //    " Tracks.length = @length " +
                //    $" WHERE Tracks.title like '{title}';";

                //SqlCommand commandEdit = new SqlCommand(change, conn);
                //commandEdit.Parameters.AddWithValue("@tracksTitle", tbCim.Text);
                //commandEdit.Parameters.AddWithValue("@artist", tbZenekar.Text);
                //commandEdit.Parameters.AddWithValue("@albumTitle", tbAlbum.Text);
                //commandEdit.Parameters.AddWithValue("@release", tbKiadas.Text);
                //commandEdit.Parameters.AddWithValue("@length", tbHossz.Text);

                //commandEdit.ExecuteNonQuery();

                //conn.Close();
            }
            else EditSelected.ActiveForm.Close();
        }
    }
}
