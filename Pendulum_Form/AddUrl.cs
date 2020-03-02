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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pendulum_Form
{
    public partial class AddUrl : Form
    {
        SqlConnection conn;
        String title;
        public AddUrl(SqlConnection conn, string title)
        {
            this.conn = conn;
            this.title = title;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Regex url = new Regex(@"(?:youtu\.be(\/.*)?)");
            Match match = url.Match(tbUrl.Text.ToString());
            for (int i = 0; i < tbUrl.Text.Length; i++)
            {
                if (match.Success)
                {
                    MessageBox.Show("URL feltöltése az adatbázisba");
                    var youtube = tbUrl.Text.ToString().Remove(0,17);
                    MessageBox.Show(youtube);

                    conn.Open();
                                        
                    var add = new SqlCommand(
                        "UPDATE Tracks" +
                        $" SET url = '{youtube}' " +
                        $"WHERE Tracks.title like '{title}'" , conn);
                    add.ExecuteNonQuery();

                    conn.Close();
                    break;
                    
                }
                else MessageBox.Show("Nem megfelelő az URL!");
                break;
            }

            AddUrl.ActiveForm.Close();
        }
    }
}
