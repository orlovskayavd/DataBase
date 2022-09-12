
namespace DB
{
    partial class AutorizationForm
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
            this.AuthorizationForm = new System.Windows.Forms.Panel();
            this.editButton = new System.Windows.Forms.Button();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.ButtonEdit = new System.Windows.Forms.Label();
            this.AuthorizationForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuthorizationForm
            // 
            this.AuthorizationForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(58)))), ((int)(((byte)(128)))));
            this.AuthorizationForm.Controls.Add(this.editButton);
            this.AuthorizationForm.Controls.Add(this.RegisterLabel);
            this.AuthorizationForm.Controls.Add(this.ButtonLogin);
            this.AuthorizationForm.Controls.Add(this.passField);
            this.AuthorizationForm.Controls.Add(this.pictureBox2);
            this.AuthorizationForm.Controls.Add(this.loginField);
            this.AuthorizationForm.Controls.Add(this.pictureBox1);
            this.AuthorizationForm.Controls.Add(this.panel2);
            this.AuthorizationForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuthorizationForm.Location = new System.Drawing.Point(0, 0);
            this.AuthorizationForm.Name = "AuthorizationForm";
            this.AuthorizationForm.Size = new System.Drawing.Size(480, 450);
            this.AuthorizationForm.TabIndex = 0;
            this.AuthorizationForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AuthorizationForm_MouseDown);
            this.AuthorizationForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AuthorizationForm_MouseMove);
            // 
            // editButton
            // 
            this.editButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(13)))), ((int)(((byte)(55)))));
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.editButton.Location = new System.Drawing.Point(376, 396);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(92, 45);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.RegisterLabel.Location = new System.Drawing.Point(192, 421);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(83, 20);
            this.RegisterLabel.TabIndex = 6;
            this.RegisterLabel.Text = "Or register";
            this.RegisterLabel.Click += new System.EventHandler(this.RegisterLabel_Click);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(13)))), ((int)(((byte)(55)))));
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.ButtonLogin.Location = new System.Drawing.Point(152, 352);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(159, 48);
            this.ButtonLogin.TabIndex = 5;
            this.ButtonLogin.Text = "Enter";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passField.Location = new System.Drawing.Point(123, 270);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(269, 58);
            this.passField.TabIndex = 4;
            this.passField.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DB.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(53, 270);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginField.Location = new System.Drawing.Point(123, 191);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(269, 64);
            this.loginField.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DB.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(53, 191);
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
            this.panel2.Controls.Add(this.ButtonEdit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 113);
            this.panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.CloseButton.Location = new System.Drawing.Point(445, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(35, 40);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "x";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonEdit.Font = new System.Drawing.Font("Segoe Script", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.ButtonEdit.Location = new System.Drawing.Point(3, 7);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(492, 106);
            this.ButtonEdit.TabIndex = 0;
            this.ButtonEdit.Text = "Authorization";
            this.ButtonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AutorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.AuthorizationForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AutorizationForm";
            this.Text = "AutorizationForm";
            this.AuthorizationForm.ResumeLayout(false);
            this.AuthorizationForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AuthorizationForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label ButtonEdit;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.Button editButton;
    }
}