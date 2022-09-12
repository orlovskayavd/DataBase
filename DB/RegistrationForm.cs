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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

            userNameField.Text = "Name";
            userNameField.ForeColor = Color.Gray;
            userSurnameField.Text = "Surname";
            userSurnameField.ForeColor = Color.Gray;
            loginField.Text = "Login";
            loginField.ForeColor = Color.Gray;
            passField.Text = "Password";
            passField.ForeColor = Color.Gray;
        }

        Point lastPoint;
        private void RegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Name")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;
            }
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Name";
                userNameField.ForeColor = Color.Gray;
            }
        }

        private void userSurnameField_Enter(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "Surname")
            {
                userSurnameField.Text = "";
                userSurnameField.ForeColor = Color.Black;
            }
        }

        private void userSurnameField_Leave(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "")
            {
                userSurnameField.Text = "Surname";
                userSurnameField.ForeColor = Color.Gray;
            }
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Login")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Login";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            if (passField.Text == "Password")
            {
                passField.Text = "";
                passField.ForeColor = Color.Black;
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
            if (passField.Text == "")
            {
                passField.Text = "Password";
                passField.ForeColor = Color.Gray;
            }
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (userNameField.Text == "Name")
            {
                MessageBox.Show("Enter your name");
                return;
            }
            if (userNameField.Text == "")
            {
                MessageBox.Show("Enter your surname");
                return;
            }
            if (loginField.Text == "")
            {
                MessageBox.Show("Enter your login");
                return;
            }
            if (passField.Text == "")
            {
                MessageBox.Show("Enter your password");
                return;
            }

            if (isUserExists())
                return;

            string login = loginField.Text;
            string pass = passField.Text;

            //if (isUserExists(login))
            //{
            //    return;
            //}

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`,`name`,`surname`, lvl) VALUES (@login, @pass, @name, @surname, @lvl);", db.getConnection());


            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField.Text;
            command.Parameters.Add("@lvl", MySqlDbType.Int16).Value = 0;


            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Registration was successful");
            else
                MessageBox.Show("Error. Try again");


            db.closeConnection();

        }
        public Boolean isUserExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("This login is already registered. Enter another one");
                return true;
            }
            else
                return false;
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutorizationForm authorizationForm = new AutorizationForm();
            authorizationForm.Show();
        }        
    }
}
