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
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            InitializeComponent();

            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 41);
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
        private void AuthorizationForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AuthorizationForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            string loginUser = loginField.Text;
            string passUser = passField.Text;

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
            else
                MessageBox.Show("Wrong login or password. Try again");

        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `lvl` = @lL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@lL", MySqlDbType.Int32).Value = 1;

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                this.Hide();
                EditForm editForm = new EditForm();
                editForm.Show();
            }
            else
                MessageBox.Show("Sorry. You do not have access to this section");

        }
    }
}
