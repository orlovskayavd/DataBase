
namespace DB
{
    partial class EditForm
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
            this.EditForm1 = new System.Windows.Forms.Panel();
            this.ButtonReload = new System.Windows.Forms.Button();
            this.ButtonSingleEdit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonExit = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EditForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditForm1
            // 
            this.EditForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(58)))), ((int)(((byte)(128)))));
            this.EditForm1.Controls.Add(this.ButtonReload);
            this.EditForm1.Controls.Add(this.ButtonSingleEdit);
            this.EditForm1.Controls.Add(this.dataGridView1);
            this.EditForm1.Controls.Add(this.panel2);
            this.EditForm1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EditForm1.Location = new System.Drawing.Point(12, 6);
            this.EditForm1.Name = "EditForm1";
            this.EditForm1.Size = new System.Drawing.Size(1396, 756);
            this.EditForm1.TabIndex = 5;
            // 
            // ButtonReload
            // 
            this.ButtonReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonReload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(13)))), ((int)(((byte)(55)))));
            this.ButtonReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonReload.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.ButtonReload.Location = new System.Drawing.Point(3, 702);
            this.ButtonReload.Name = "ButtonReload";
            this.ButtonReload.Size = new System.Drawing.Size(159, 48);
            this.ButtonReload.TabIndex = 10;
            this.ButtonReload.Text = "Reload";
            this.ButtonReload.UseVisualStyleBackColor = true;
            this.ButtonReload.Click += new System.EventHandler(this.ButtonReload_Click);
            // 
            // ButtonSingleEdit
            // 
            this.ButtonSingleEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSingleEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(13)))), ((int)(((byte)(55)))));
            this.ButtonSingleEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSingleEdit.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSingleEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.ButtonSingleEdit.Location = new System.Drawing.Point(487, 702);
            this.ButtonSingleEdit.Name = "ButtonSingleEdit";
            this.ButtonSingleEdit.Size = new System.Drawing.Size(323, 48);
            this.ButtonSingleEdit.TabIndex = 9;
            this.ButtonSingleEdit.Text = "Single Delete Mode";
            this.ButtonSingleEdit.UseVisualStyleBackColor = true;
            this.ButtonSingleEdit.Click += new System.EventHandler(this.ButtonSingleEdit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1384, 488);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserAddedRow);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(69)))), ((int)(((byte)(110)))));
            this.panel2.Controls.Add(this.ButtonExit);
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1396, 113);
            this.panel2.TabIndex = 0;
            // 
            // ButtonExit
            // 
            this.ButtonExit.AutoSize = true;
            this.ButtonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.ButtonExit.Location = new System.Drawing.Point(3, 7);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(63, 32);
            this.ButtonExit.TabIndex = 2;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(227)))));
            this.CloseButton.Location = new System.Drawing.Point(1346, -1);
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
            this.label1.Size = new System.Drawing.Size(1208, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Mode";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 763);
            this.Controls.Add(this.EditForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EditForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EditForm_MouseMove);
            this.EditForm1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EditForm1;
        private System.Windows.Forms.Button ButtonReload;
        private System.Windows.Forms.Button ButtonSingleEdit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ButtonExit;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label1;
    }
}