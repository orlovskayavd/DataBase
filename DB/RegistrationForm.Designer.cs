
namespace DB
{
    partial class RegistrationForm
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
            this.RegisterForm = new System.Windows.Forms.Panel();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.userSurnameField = new System.Windows.Forms.TextBox();
            this.userNameField = new System.Windows.Forms.TextBox();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegisterForm
            // 
            this.RegisterForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(58)))), ((int)(((byte)(128)))));
            this.RegisterForm.Controls.Add(this.RegisterLabel);
            this.RegisterForm.Controls.Add(this.userSurnameField);
            this.RegisterForm.Controls.Add(this.userNameField);
            this.RegisterForm.Controls.Add(this.ButtonLogin);
            this.RegisterForm.Controls.Add(this.passField);
            this.RegisterForm.Controls.Add(this.pictureBox2);
            this.RegisterForm.Controls.Add(this.loginField);
            this.RegisterForm.Controls.Add(this.pictureBox1);
            this.RegisterForm.Controls.Add(this.panel2);
            this.RegisterForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegisterForm.Location = new System.Drawing.Point(0, 0);
            this.RegisterForm.Name = "RegisterForm";
            this.RegisterForm.Size = new System.Drawing.Size(852, 450);
            this.RegisterForm.TabIndex = 1;
            this.RegisterForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseDown);
            this.RegisterForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseMove);
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.RegisterLabel.Location = new System.Drawing.Point(374, 409);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(77, 20);
            this.RegisterLabel.TabIndex = 8;
            this.RegisterLabel.Text = "Authorize";
            this.RegisterLabel.Click += new System.EventHandler(this.RegisterLabel_Click);
            // 
            // userSurnameField
            // 
            this.userSurnameField.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSurnameField.Location = new System.Drawing.Point(495, 140);
            this.userSurnameField.Multiline = true;
            this.userSurnameField.Name = "userSurnameField";
            this.userSurnameField.Size = new System.Drawing.Size(269, 64);
            this.userSurnameField.TabIndex = 7;
            this.userSurnameField.Enter += new System.EventHandler(this.userSurnameField_Enter);
            this.userSurnameField.Leave += new System.EventHandler(this.userSurnameField_Leave);
            // 
            // userNameField
            // 
            this.userNameField.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameField.Location = new System.Drawing.Point(77, 140);
            this.userNameField.Multiline = true;
            this.userNameField.Name = "userNameField";
            this.userNameField.Size = new System.Drawing.Size(269, 64);
            this.userNameField.TabIndex = 6;
            this.userNameField.Enter += new System.EventHandler(this.userNameField_Enter);
            this.userNameField.Leave += new System.EventHandler(this.userNameField_Leave);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(13)))), ((int)(((byte)(55)))));
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.ButtonLogin.Location = new System.Drawing.Point(330, 337);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(159, 48);
            this.ButtonLogin.TabIndex = 5;
            this.ButtonLogin.Text = "Register";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passField.Location = new System.Drawing.Point(495, 210);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(269, 58);
            this.passField.TabIndex = 4;
            this.passField.UseSystemPasswordChar = true;
            this.passField.Enter += new System.EventHandler(this.passField_Enter);
            this.passField.Leave += new System.EventHandler(this.passField_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DB.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(425, 210);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginField.Location = new System.Drawing.Point(77, 210);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(269, 64);
            this.loginField.TabIndex = 2;
            this.loginField.Enter += new System.EventHandler(this.loginField_Enter);
            this.loginField.Leave += new System.EventHandler(this.loginField_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DB.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(7, 210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(69)))), ((int)(((byte)(110)))));
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(852, 113);
            this.panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.CloseButton.Location = new System.Drawing.Point(817, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(35, 40);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "x";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe Script", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(864, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 450);
            this.Controls.Add(this.RegisterForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.RegisterForm.ResumeLayout(false);
            this.RegisterForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RegisterForm;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userSurnameField;
        private System.Windows.Forms.TextBox userNameField;
        private System.Windows.Forms.Label RegisterLabel;
    }
}