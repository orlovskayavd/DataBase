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
    public partial class SingleEditForm : Form
    {
        public SingleEditForm()
        {
            InitializeComponent();
        }
      
        private void SingleEditForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditForm editForm = new EditForm();
            editForm.Show();
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
        private void SingleEditForm1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        private void SingleEditForm1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void ButtonToDeleteFilm(object sender, EventArgs e)
        {
            try
            {
                string str = EditDeleteFilm.Text;
                if (IsFilmExists(str))
                {
                    if (MessageBox.Show("Are you sure you want to delete this film?", "Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            == DialogResult.Yes)
                    {
                        DB db = new DB();
                        db.openConnection();
                        MySqlCommand command = new MySqlCommand("DELETE FROM `film` WHERE `film_name` = @fN", db.getConnection());
                        command.Parameters.Add("@fN", MySqlDbType.VarChar).Value = str;

                        command.ExecuteNonQuery();

                        db.closeConnection();

                        MessageBox.Show("Film deleted successfully");
                    }
                }
                else
                {
                    MessageBox.Show("Error! There is no such film");
                }
                EditDeleteFilm.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonToDeleteActor(object sender, EventArgs e)
        {
            try
            {
                string str = EditDeleteActor.Text;
                if (IsActorExists(str))
                {
                    if (MessageBox.Show("Are you sure you want to delete this actor?", "Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            == DialogResult.Yes)
                    {
                        DB db = new DB();
                        db.openConnection();
                        MySqlCommand command = new MySqlCommand("DELETE FROM `actor` WHERE `actor_name` = @aN", db.getConnection());
                        command.Parameters.Add("@aN", MySqlDbType.VarChar).Value = str;

                        command.ExecuteNonQuery();

                        db.closeConnection();

                        MessageBox.Show("Actor deleted successfully");
                    }

                }
                else
                {
                    MessageBox.Show("Error! There is no such actor");
                }
                EditDeleteActor.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonToDeleteStudio(object sender, EventArgs e)
        {
            try
            {
                string str = EditDeleteStudio.Text;
                if (IsStudioExists(str))
                {
                    if (MessageBox.Show("Are you sure you want to delete this studio?", "Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            == DialogResult.Yes)
                    {
                        DB db = new DB();
                        db.openConnection();
                        MySqlCommand command = new MySqlCommand("DELETE FROM `studio` WHERE `Studio_name` = @sN", db.getConnection());
                        command.Parameters.Add("@sN", MySqlDbType.VarChar).Value = str;

                        command.ExecuteNonQuery();

                        db.closeConnection();

                        MessageBox.Show("Studio deleted successfully");
                    }

                }
                else
                {
                    MessageBox.Show("Error! There is no such studio");
                }
                EditDeleteStudio.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonToDeleteGenre(object sender, EventArgs e)
        {
            try
            {
                string str = EditDeleteGenre.Text;
                if (IsGenreExists(str))
                {
                    if (MessageBox.Show("Are you sure you want to delete this genre?", "Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            == DialogResult.Yes)
                    {
                        DB db = new DB();
                        db.openConnection();
                        MySqlCommand command = new MySqlCommand("DELETE FROM `genre` WHERE `genre_name` = @gN", db.getConnection());
                        command.Parameters.Add("@gN", MySqlDbType.VarChar).Value = str;

                        command.ExecuteNonQuery();

                        db.closeConnection();

                        MessageBox.Show("Genre deleted successfully");
                    }
                }
                else
                {
                    MessageBox.Show("Error! There is no such genre");
                }
                EditDeleteGenre.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool IsFilmExists(string film)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            db.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT film_name FROM `film` " +
                "WHERE `film_name` = @fN", db.getConnection());
            command.Parameters.Add("@fN", MySqlDbType.VarChar).Value = film;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            db.closeConnection();

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsActorExists(string actor)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            db.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT actor_name FROM `actor` " +
                "WHERE `actor_name` = @aN", db.getConnection());
            command.Parameters.Add("@aN", MySqlDbType.VarChar).Value = actor;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            db.closeConnection();

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStudioExists(string studio)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            db.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT studio_name FROM `studio` " +
                "WHERE `studio_name` = @sN", db.getConnection());
            command.Parameters.Add("@sN", MySqlDbType.VarChar).Value = studio;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            db.closeConnection();

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsGenreExists(string genre)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            db.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT genre_name FROM `genre` " +
                "WHERE `genre_name` = @gN", db.getConnection());
            command.Parameters.Add("@gN", MySqlDbType.VarChar).Value = genre;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            db.closeConnection();

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

       
    }
}
