namespace Winform_moi
{
    partial class QuanLyForm
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
            this.Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ButtonQLNhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ButtonQLSach = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.quanLySach1 = new Winform_moi.QuanLySach();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.Panel1.Controls.Add(this.guna2ButtonQLNhanVien);
            this.Panel1.Controls.Add(this.guna2ButtonQLSach);
            this.Panel1.Controls.Add(this.pictureBox1);
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.ShadowDecoration.Parent = this.Panel1;
            this.Panel1.Size = new System.Drawing.Size(167, 540);
            this.Panel1.TabIndex = 1;
            // 
            // guna2ButtonQLNhanVien
            // 
            this.guna2ButtonQLNhanVien.CheckedState.Parent = this.guna2ButtonQLNhanVien;
            this.guna2ButtonQLNhanVien.CustomImages.Parent = this.guna2ButtonQLNhanVien;
            this.guna2ButtonQLNhanVien.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonQLNhanVien.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonQLNhanVien.HoverState.Parent = this.guna2ButtonQLNhanVien;
            this.guna2ButtonQLNhanVien.Location = new System.Drawing.Point(-23, 217);
            this.guna2ButtonQLNhanVien.Name = "guna2ButtonQLNhanVien";
            this.guna2ButtonQLNhanVien.ShadowDecoration.Parent = this.guna2ButtonQLNhanVien;
            this.guna2ButtonQLNhanVien.Size = new System.Drawing.Size(193, 42);
            this.guna2ButtonQLNhanVien.TabIndex = 4;
            this.guna2ButtonQLNhanVien.Text = "Quản Lý Nhân Viên";
            // 
            // guna2ButtonQLSach
            // 
            this.guna2ButtonQLSach.CheckedState.Parent = this.guna2ButtonQLSach;
            this.guna2ButtonQLSach.CustomImages.Parent = this.guna2ButtonQLSach;
            this.guna2ButtonQLSach.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ButtonQLSach.ForeColor = System.Drawing.Color.White;
            this.guna2ButtonQLSach.HoverState.Parent = this.guna2ButtonQLSach;
            this.guna2ButtonQLSach.Location = new System.Drawing.Point(-29, 169);
            this.guna2ButtonQLSach.Name = "guna2ButtonQLSach";
            this.guna2ButtonQLSach.ShadowDecoration.Parent = this.guna2ButtonQLSach;
            this.guna2ButtonQLSach.Size = new System.Drawing.Size(196, 42);
            this.guna2ButtonQLSach.TabIndex = 3;
            this.guna2ButtonQLSach.Text = "Quản Lý Sách";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 83);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.quanLySach1);
            this.Panel2.Location = new System.Drawing.Point(167, 0);
            this.Panel2.Name = "Panel2";
            this.Panel2.ShadowDecoration.Parent = this.Panel2;
            this.Panel2.Size = new System.Drawing.Size(833, 540);
            this.Panel2.TabIndex = 2;
            // 
            // quanLySach1
            // 
            this.quanLySach1.Location = new System.Drawing.Point(0, 0);
            this.quanLySach1.Name = "quanLySach1";
            this.quanLySach1.Size = new System.Drawing.Size(833, 540);
            this.quanLySach1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 540);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonQLNhanVien;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonQLSach;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel Panel2;
        private QuanLySach quanLySach1;
    }
}

