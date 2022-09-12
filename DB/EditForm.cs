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
    public partial class EditForm : Form
    {
        private MySqlDataAdapter sqlDataAdapter;
        private DataSet dataSet;
        private bool newRowAdding;
        public EditForm()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                dataGridView1.ForeColor = Color.Black;
                DB db = new DB();
                db.openConnection();

                string query = "SELECT film_name, release_year, studio_name, actor_name, country, form_year, genre_name," +
                    "'Delete' AS `Delete` FROM `media` " +
                    "JOIN `film` ON media.id_film = film.id " +
                    "JOIN `actor` ON media.id_actor = actor.id " +
                    "JOIN `genre` ON media.id_genre = genre.id JOIN `studio` ON media.id_studio = studio.id";

                sqlDataAdapter = new MySqlDataAdapter(query, db.getConnection());

                dataSet = new DataSet();
                dataSet.Tables.Clear();

                sqlDataAdapter.Fill(dataSet, "media");

                dataGridView1.DataSource = dataSet.Tables["media"];
                int i;

                for (i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[7, i] = linkCell;
                }

                db.closeConnection();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReloadData()
        {
            try
            {
                dataGridView1.ForeColor = Color.Black;
                DB db = new DB();
                db.openConnection();

                dataSet.Tables.Clear();

                sqlDataAdapter.Fill(dataSet, "media");

                dataGridView1.DataSource = dataSet.Tables["media"];
                int i;

                for (i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[7, i] = linkCell;
                }

                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        Point lastPoint;
        
        private void EditForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
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

        private void EditForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        
        private void EditForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 7)
                {
                    string task = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

                    if (task == "Delete")
                    {
                        if (MessageBox.Show("Are you sure you want to delete this string?", "Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            == DialogResult.Yes)
                        {
                            DB db = new DB();

                            int rowIndex = e.RowIndex;
                            string str = dataGridView1[0, rowIndex].Value as string;
                            Deletion(str);

                            dataGridView1.Rows.RemoveAt(rowIndex);

                            ReloadData();
                        }
                    }
                    else if (task == "Insert")
                    {
                        int rowIndex = dataGridView1.Rows.Count - 2;

                        DataRow row = dataSet.Tables["media"].NewRow();

                        row["film_name"] = dataGridView1.Rows[rowIndex].Cells["film_name"].Value;
                        row["release_year"] = dataGridView1.Rows[rowIndex].Cells["release_year"].Value;
                        row["studio_name"] = dataGridView1.Rows[rowIndex].Cells["studio_name"].Value;
                        row["actor_name"] = dataGridView1.Rows[rowIndex].Cells["actor_name"].Value;
                        row["country"] = dataGridView1.Rows[rowIndex].Cells["country"].Value;
                        row["form_year"] = dataGridView1.Rows[rowIndex].Cells["form_year"].Value;
                        row["genre_name"] = dataGridView1.Rows[rowIndex].Cells["genre_name"].Value;
                        if (row["film_name"].ToString().Length == 0 || row["release_year"].ToString().Length == 0 || row["studio_name"].ToString().Length == 0 ||
                            row["actor_name"].ToString().Length == 0 || row["country"].ToString().Length == 0 || row["form_year"].ToString().Length == 0 || row["genre_name"].ToString().Length == 0)
                        {
                            MessageBox.Show("Please, fill in all the fields");
                        }
                        else
                        {
                            DB db = new DB();
                            DataTable table = new DataTable();
                            db.openConnection();
                            //Фильм
                            MySqlCommand command = new MySqlCommand("SELECT film_name FROM `film`" +
                                "WHERE `film_name` = @fN", db.getConnection());
                            command.Parameters.Add("@fN", MySqlDbType.VarChar).Value = row["film_name"].ToString();

                            sqlDataAdapter.SelectCommand = command;
                            sqlDataAdapter.Fill(table);

                            if (table.Rows.Count <= 0)
                            {
                                command = new MySqlCommand("INSERT INTO `film`(`film_name`, `release_year`) " +
                                    "VALUES (@fN, @rY)", db.getConnection());
                                command.Parameters.Add("@fN", MySqlDbType.VarChar).Value = row["film_name"].ToString();
                                command.Parameters.Add("@rY", MySqlDbType.VarChar).Value = row["release_year"].ToString();
                                command.ExecuteNonQuery();
                            }

                            //Актер
                            table = new DataTable();
                            command = new MySqlCommand("SELECT actor_name FROM `actor`" +
                                "WHERE `actor_name` = @aN", db.getConnection());
                            command.Parameters.Add("@aN", MySqlDbType.VarChar).Value = row["actor_name"].ToString();

                            sqlDataAdapter.SelectCommand = command;
                            sqlDataAdapter.Fill(table);

                            if (table.Rows.Count <= 0)
                            {
                                command = new MySqlCommand("INSERT INTO `actor`(`actor_name`, `country`, `form_year`) " +
                                    "VALUES (@aN, @c, @fY)", db.getConnection());
                                command.Parameters.Add("@aN", MySqlDbType.VarChar).Value = row["actor_name"].ToString();
                                command.Parameters.Add("@c", MySqlDbType.VarChar).Value = row["country"].ToString();
                                command.Parameters.Add("@fY", MySqlDbType.VarChar).Value = row["form_year"].ToString();
                                command.ExecuteNonQuery();
                            }

                            //Киностудия
                            table = new DataTable();
                            command = new MySqlCommand("SELECT studio_name FROM `studio`" +
                                "WHERE `studio_name` = @sN", db.getConnection());
                            command.Parameters.Add("@sN", MySqlDbType.VarChar).Value = row["studio_name"].ToString();

                            sqlDataAdapter.SelectCommand = command;
                            sqlDataAdapter.Fill(table);

                            if (table.Rows.Count <= 0)
                            {
                                command = new MySqlCommand("INSERT INTO `studio`(`studio_name`) " +
                                    "VALUES (@sN)", db.getConnection());
                                command.Parameters.Add("@sN", MySqlDbType.VarChar).Value = row["studio_name"].ToString();
                                command.ExecuteNonQuery();
                            }

                            //Жанр
                            table = new DataTable();
                            command = new MySqlCommand("SELECT genre_name FROM `genre`" +
                                "WHERE `genre_name` = @gN", db.getConnection());
                            command.Parameters.Add("@gN", MySqlDbType.VarChar).Value = row["genre_name"].ToString();

                            sqlDataAdapter.SelectCommand = command;
                            sqlDataAdapter.Fill(table);
                            if (table.Rows.Count <= 0)
                            {
                                command = new MySqlCommand("INSERT INTO `genre`(`genre_name`) " +
                                    "VALUES (@gN)", db.getConnection());
                                command.Parameters.Add("@gN", MySqlDbType.VarChar).Value = row["genre_name"].ToString();
                                command.ExecuteNonQuery();
                            }

                            //Медиа

                            command = new MySqlCommand("SELECT id FROM `actor` WHERE `actor_name` = @aN", db.getConnection());
                            command.Parameters.Add("@aN", MySqlDbType.VarChar).Value = row["actor_name"].ToString();
                            int id_actor = (int)command.ExecuteScalar();

                            command = new MySqlCommand("SELECT id FROM `film` WHERE `film_name` = @fN", db.getConnection());
                            command.Parameters.Add("@fN", MySqlDbType.VarChar).Value = row["film_name"].ToString();
                            int id_film = (int)command.ExecuteScalar();

                            command = new MySqlCommand("SELECT id FROM `studio` WHERE `studio_name` = @sN", db.getConnection());
                            command.Parameters.Add("@sN", MySqlDbType.VarChar).Value = row["studio_name"].ToString();
                            int id_studio = (int)command.ExecuteScalar();

                            command = new MySqlCommand("SELECT id FROM `genre` WHERE `genre_name` = @gN", db.getConnection());
                            command.Parameters.Add("@gN", MySqlDbType.VarChar).Value = row["genre_name"].ToString();
                            int id_genre = (int)command.ExecuteScalar();

                            command = new MySqlCommand("INSERT INTO `media`(`id_actor`, `id_film`, `id_studio`, `id_genre`) " +
                                "VALUES (@iA, @iF, @iS, @iG)", db.getConnection());
                            command.Parameters.Add("@iA", MySqlDbType.VarChar).Value = id_actor.ToString();
                            command.Parameters.Add("@iF", MySqlDbType.VarChar).Value = id_film.ToString();
                            command.Parameters.Add("@iS", MySqlDbType.VarChar).Value = id_studio.ToString();
                            command.Parameters.Add("@iG", MySqlDbType.VarChar).Value = id_genre.ToString();

                            command.ExecuteNonQuery();


                            db.closeConnection();
                        }

                        newRowAdding = false;

                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Deletion(string str)
        {
            try
            {
                DB db = new DB();
                db.openConnection();
                MySqlCommand command = new MySqlCommand("SELECT id FROM `film` WHERE `film_name` = @fN", db.getConnection());
                command.Parameters.Add("@fN", MySqlDbType.VarChar).Value = str;
                int id = (int)command.ExecuteScalar();

                command = new MySqlCommand("DELETE FROM `media` " +
                "WHERE `id_film` = @iF", db.getConnection());
                command.Parameters.Add("@iF", MySqlDbType.VarChar).Value = id.ToString();

                command.ExecuteNonQuery();

                db.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

                    DataGridViewRow editingRow = dataGridView1.Rows[rowIndex];

                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[7, rowIndex] = linkCell;

                    editingRow.Cells["Delete"].Value = "Insert";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    newRowAdding = true;

                    int lastRow = dataGridView1.Rows.Count - 2;

                    DataGridViewRow row = dataGridView1.Rows[lastRow];

                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[7, lastRow] = linkCell;

                    row.Cells["Delete"].Value = "Insert";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutorizationForm autorizationForm = new AutorizationForm();
            autorizationForm.Show();
        }

        private void ButtonSingleEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            SingleEditForm singleEditForm = new SingleEditForm();
            singleEditForm.Show();
        }

        private void ButtonBackup_Click(object sender, EventArgs e)
        {
            try
            {
                string constring = "server=localhost;port=3306;username=root;password=root;database=kino;charset=utf8";
                string file = "F:\\Backups\\backup.sql";
                using (MySqlConnection conn = new MySqlConnection(constring))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        MySqlBackup mb = new MySqlBackup(cmd);
                        
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(file);
                        conn.Close();
                        MessageBox.Show("Backup export completed successfully");
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonRestoreBackup_Click(object sender, EventArgs e)
        {
            try
            {
                string constring = "server=localhost;port=3306;username=root;password=root;database=kino";
                string file = "F:\\Backups\\backup.sql";
                using (MySqlConnection conn = new MySqlConnection(constring))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        MySqlBackup mb = new MySqlBackup(cmd);
                        
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(file);
                        conn.Close();
                        MessageBox.Show("Backup export completed successfully");
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonReload_Click(object sender, EventArgs e)
        {
            ReloadData();
        }        
    }
}
