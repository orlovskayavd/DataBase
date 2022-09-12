using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadData(string str)
        {
            try
            {
                dataGridView1.Rows.Clear();

                DB db = new DB();

                db.openConnection();

                string query = "SELECT film_name, release_year, studio_name, actor_name, country, form_year, genre_name FROM `media` " +
                    "JOIN `film` ON media.id_film = film.id " +
                    "JOIN `actor` ON media.id_actor = actor.id " +
                    "JOIN `genre` ON media.id_genre = genre.id " +
                    "JOIN `studio` ON media.id_studio = studio.id";

                MySqlCommand command = new MySqlCommand(query, db.getConnection());



                MySqlDataReader reader = command.ExecuteReader();

                List<string[]> data = new List<string[]>();

                while (reader.Read())
                {
                    data.Add(new string[7]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                    data[data.Count - 1][6] = reader[6].ToString();
                }

                Console.WriteLine(data);

                reader.Close();

                db.closeConnection();

                foreach (string[] s in data)
                    if (str == null || s.Contains(str))
                        dataGridView1.Rows.Add(s);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        Point lastPoint;
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string enterMessage = enterField.Text;

            string film;
            string actor;

            if (IsActor(enterMessage))
            {
                actor = enterMessage;
                LoadData(actor);
            }

            else if (IsFilm(enterMessage))
            {
                film = enterMessage;
                LoadData(film);
            }
            else
            {
                LoadData(null);
            }
        }
        public bool IsFilm(string film)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT film_name FROM `media` " +
                "JOIN `film` ON media.id_film = film.id " +
                "WHERE `film_name` = @fN", db.getConnection());
            command.Parameters.Add("@fN", MySqlDbType.VarChar).Value = film;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsActor(string actor)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT actor_name FROM `media` " +
                "JOIN `actor` ON media.id_actor = actor.id " +
                "WHERE `actor_name` = @aN", db.getConnection());
            command.Parameters.Add("@aN", MySqlDbType.VarChar).Value = actor;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutorizationForm autorizationForm = new AutorizationForm();
            autorizationForm.Show();
        }        
    }
}
