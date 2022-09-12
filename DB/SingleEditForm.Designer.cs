
namespace DB
{
    partial class SingleEditForm
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
            this.MainForm1 = new System.Windows.Forms.Panel();
            this.EditDeleteGenre = new System.Windows.Forms.TextBox();
            this.EditDeleteActor = new System.Windows.Forms.TextBox();
            this.EditDeleteFilm = new System.Windows.Forms.TextBox();
            this.EditDeleteStudio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonDeleteActor = new System.Windows.Forms.Button();
            this.ButtonDeleteStudio = new System.Windows.Forms.Button();
            this.ButtonDeleteFilm = new System.Windows.Forms.Button();
            this.ButtonDeleteGenre = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonBack = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MainForm1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainForm1
            // 
            this.MainForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(58)))), ((int)(((byte)(128)))));
            this.MainForm1.Controls.Add(this.EditDeleteGenre);
            this.MainForm1.Controls.Add(this.EditDeleteActor);
            this.MainForm1.Controls.Add(this.EditDeleteFilm);
            this.MainForm1.Controls.Add(this.EditDeleteStudio);
            this.MainForm1.Controls.Add(this.label6);
            this.MainForm1.Controls.Add(this.label5);
            this.MainForm1.Controls.Add(this.label4);
            this.MainForm1.Controls.Add(this.label3);
            this.MainForm1.Controls.Add(this.label2);
            this.MainForm1.Controls.Add(this.ButtonDeleteActor);
            this.MainForm1.Controls.Add(this.ButtonDeleteStudio);
            this.MainForm1.Controls.Add(this.ButtonDeleteFilm);
            this.MainForm1.Controls.Add(this.ButtonDeleteGenre);
            this.MainForm1.Controls.Add(this.panel2);
            this.MainForm1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MainForm1.Location = new System.Drawing.Point(0, 0);
            this.MainForm1.Name = "MainForm1";
            this.MainForm1.Size = new System.Drawing.Size(1149, 619);
            this.MainForm1.TabIndex = 3;
            // 
            // EditDeleteGenre
            // 
            this.EditDeleteGenre.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditDeleteGenre.Location = new System.Drawing.Point(620, 434);
            this.EditDeleteGenre.Multiline = true;
            this.EditDeleteGenre.Name = "EditDeleteGenre";
            this.EditDeleteGenre.Size = new System.Drawing.Size(443, 64);
            this.EditDeleteGenre.TabIndex = 25;
            // 
            // EditDeleteActor
            // 
            this.EditDeleteActor.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditDeleteActor.Location = new System.Drawing.Point(620, 223);
            this.EditDeleteActor.Multiline = true;
            this.EditDeleteActor.Name = "EditDeleteActor";
            this.EditDeleteActor.Size = new System.Drawing.Size(443, 64);
            this.EditDeleteActor.TabIndex = 24;
            // 
            // EditDeleteFilm
            // 
            this.EditDeleteFilm.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditDeleteFilm.Location = new System.Drawing.Point(69, 223);
            this.EditDeleteFilm.Multiline = true;
            this.EditDeleteFilm.Name = "EditDeleteFilm";
            this.EditDeleteFilm.Size = new System.Drawing.Size(443, 64);
            this.EditDeleteFilm.TabIndex = 23;
            // 
            // EditDeleteStudio
            // 
            this.EditDeleteStudio.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditDeleteStudio.Location = new System.Drawing.Point(69, 434);
            this.EditDeleteStudio.Multiline = true;
            this.EditDeleteStudio.Name = "EditDeleteStudio";
            this.EditDeleteStudio.Size = new System.Drawing.Size(443, 64);
            this.EditDeleteStudio.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe Script", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.label6.Location = new System.Drawing.Point(69, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(443, 64);
            this.label6.TabIndex = 21;
            this.label6.Text = "Select Film";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe Script", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.label5.Location = new System.Drawing.Point(620, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(439, 64);
            this.label5.TabIndex = 20;
            this.label5.Text = "Select Genre";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe Script", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.label4.Location = new System.Drawing.Point(620, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(443, 58);
            this.label4.TabIndex = 19;
            this.label4.Text = "Select Actor";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe Script", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.label3.Location = new System.Drawing.Point(69, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(443, 64);
            this.label3.TabIndex = 18;
            this.label3.Text = "Select Studio";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Segoe Script", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.label2.Location = new System.Drawing.Point(69, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 0);
            this.label2.TabIndex = 17;
            this.label2.Text = "Select Film";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonDeleteActor
            // 
            this.ButtonDeleteActor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDeleteActor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(13)))), ((int)(((byte)(55)))));
            this.ButtonDeleteActor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDeleteActor.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeleteActor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.ButtonDeleteActor.Location = new System.Drawing.Point(620, 293);
            this.ButtonDeleteActor.Name = "ButtonDeleteActor";
            this.ButtonDeleteActor.Size = new System.Drawing.Size(443, 48);
            this.ButtonDeleteActor.TabIndex = 12;
            this.ButtonDeleteActor.Text = "Delete Actor";
            this.ButtonDeleteActor.UseVisualStyleBackColor = true;
            this.ButtonDeleteActor.Click += new System.EventHandler(this.ButtonToDeleteActor);
            // 
            // ButtonDeleteStudio
            // 
            this.ButtonDeleteStudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDeleteStudio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(13)))), ((int)(((byte)(55)))));
            this.ButtonDeleteStudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDeleteStudio.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeleteStudio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.ButtonDeleteStudio.Location = new System.Drawing.Point(69, 504);
            this.ButtonDeleteStudio.Name = "ButtonDeleteStudio";
            this.ButtonDeleteStudio.Size = new System.Drawing.Size(443, 48);
            this.ButtonDeleteStudio.TabIndex = 11;
            this.ButtonDeleteStudio.Text = "Delete Studio";
            this.ButtonDeleteStudio.UseVisualStyleBackColor = true;
            this.ButtonDeleteStudio.Click += new System.EventHandler(this.ButtonToDeleteStudio);
            // 
            // ButtonDeleteFilm
            // 
            this.ButtonDeleteFilm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDeleteFilm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(13)))), ((int)(((byte)(55)))));
            this.ButtonDeleteFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDeleteFilm.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeleteFilm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.ButtonDeleteFilm.Location = new System.Drawing.Point(69, 293);
            this.ButtonDeleteFilm.Name = "ButtonDeleteFilm";
            this.ButtonDeleteFilm.Size = new System.Drawing.Size(443, 48);
            this.ButtonDeleteFilm.TabIndex = 10;
            this.ButtonDeleteFilm.Text = "Delete Film";
            this.ButtonDeleteFilm.UseVisualStyleBackColor = true;
            this.ButtonDeleteFilm.Click += new System.EventHandler(this.ButtonToDeleteFilm);
            // 
            // ButtonDeleteGenre
            // 
            this.ButtonDeleteGenre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDeleteGenre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(13)))), ((int)(((byte)(55)))));
            this.ButtonDeleteGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDeleteGenre.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeleteGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.ButtonDeleteGenre.Location = new System.Drawing.Point(620, 504);
            this.ButtonDeleteGenre.Name = "ButtonDeleteGenre";
            this.ButtonDeleteGenre.Size = new System.Drawing.Size(443, 48);
            this.ButtonDeleteGenre.TabIndex = 9;
            this.ButtonDeleteGenre.Text = "Delete Genre";
            this.ButtonDeleteGenre.UseVisualStyleBackColor = true;
            this.ButtonDeleteGenre.Click += new System.EventHandler(this.ButtonToDeleteGenre);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(69)))), ((int)(((byte)(110)))));
            this.panel2.Controls.Add(this.ButtonBack);
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1149, 113);
            this.panel2.TabIndex = 0;
            // 
            // ButtonBack
            // 
            this.ButtonBack.AutoSize = true;
            this.ButtonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.ButtonBack.Location = new System.Drawing.Point(3, 7);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(78, 32);
            this.ButtonBack.TabIndex = 2;
            this.ButtonBack.Text = "Back";
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.CloseButton.Location = new System.Drawing.Point(1111, 0);
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
            this.label1.Font = new System.Drawing.Font("Segoe Script", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.label1.Location = new System.Drawing.Point(94, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(961, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "Single Edit Mode";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SingleEditForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1152, 622);
            this.Controls.Add(this.MainForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SingleEditForm";
            this.Text = "SingleEditForm";
            this.Load += new System.EventHandler(this.SingleEditForm_Load);
            this.MainForm1.ResumeLayout(false);
            this.MainForm1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainForm1;
        private System.Windows.Forms.Button ButtonDeleteGenre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ButtonBack;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonDeleteActor;
        private System.Windows.Forms.Button ButtonDeleteStudio;
        private System.Windows.Forms.Button ButtonDeleteFilm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EditDeleteGenre;
        private System.Windows.Forms.TextBox EditDeleteActor;
        private System.Windows.Forms.TextBox EditDeleteFilm;
        private System.Windows.Forms.TextBox EditDeleteStudio;
    }
}