namespace Winform_moi
{
    partial class QuanLySach
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.ButtonRemove = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.ButtonEdit = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.ButtonAdd = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.ButtonView = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.ButtonSeach = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.removeBook1 = new Winform_moi.RemoveBook();
            this.viewBook1 = new Winform_moi.ViewBook();
            this.editBook1 = new Winform_moi.EditBook();
            this.addBook1 = new Winform_moi.AddBook();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.ButtonRemove);
            this.guna2Panel2.Controls.Add(this.ButtonEdit);
            this.guna2Panel2.Controls.Add(this.ButtonAdd);
            this.guna2Panel2.Controls.Add(this.ButtonView);
            this.guna2Panel2.Location = new System.Drawing.Point(31, 77);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(766, 72);
            this.guna2Panel2.TabIndex = 9;
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.CheckedState.Parent = this.ButtonRemove;
            this.ButtonRemove.CustomImages.Parent = this.ButtonRemove;
            this.ButtonRemove.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(145)))));
            this.ButtonRemove.HoverState.Parent = this.ButtonRemove;
            this.ButtonRemove.Location = new System.Drawing.Point(605, 25);
            this.ButtonRemove.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.ShadowDecoration.Parent = this.ButtonRemove;
            this.ButtonRemove.Size = new System.Drawing.Size(140, 39);
            this.ButtonRemove.TabIndex = 4;
            this.ButtonRemove.Text = "Remove";
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.CheckedState.Parent = this.ButtonEdit;
            this.ButtonEdit.CustomImages.Parent = this.ButtonEdit;
            this.ButtonEdit.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(145)))));
            this.ButtonEdit.HoverState.Parent = this.ButtonEdit;
            this.ButtonEdit.Location = new System.Drawing.Point(396, 25);
            this.ButtonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.ShadowDecoration.Parent = this.ButtonEdit;
            this.ButtonEdit.Size = new System.Drawing.Size(140, 39);
            this.ButtonEdit.TabIndex = 3;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.CheckedState.Parent = this.ButtonAdd;
            this.ButtonAdd.CustomImages.Parent = this.ButtonAdd;
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(145)))));
            this.ButtonAdd.HoverState.Parent = this.ButtonAdd;
            this.ButtonAdd.Location = new System.Drawing.Point(204, 25);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.ShadowDecoration.Parent = this.ButtonAdd;
            this.ButtonAdd.Size = new System.Drawing.Size(140, 39);
            this.ButtonAdd.TabIndex = 2;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonView
            // 
            this.ButtonView.CheckedState.Parent = this.ButtonView;
            this.ButtonView.CustomImages.Parent = this.ButtonView;
            this.ButtonView.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(145)))));
            this.ButtonView.HoverState.Parent = this.ButtonView;
            this.ButtonView.Location = new System.Drawing.Point(14, 25);
            this.ButtonView.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonView.Name = "ButtonView";
            this.ButtonView.ShadowDecoration.Parent = this.ButtonView;
            this.ButtonView.Size = new System.Drawing.Size(140, 39);
            this.ButtonView.TabIndex = 0;
            this.ButtonView.Text = "View";
            this.ButtonView.Click += new System.EventHandler(this.ButtonView_Click);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.FormattingEnabled = true;
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(116, 34);
            this.guna2ComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(204, 36);
            this.guna2ComboBox1.TabIndex = 10;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(102)))), ((int)(((byte)(5)))));
            this.labelSearch.Location = new System.Drawing.Point(26, 42);
            this.labelSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(79, 21);
            this.labelSearch.TabIndex = 11;
            this.labelSearch.Text = "Category";
            // 
            // ButtonSeach
            // 
            this.ButtonSeach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(203)))), ((int)(((byte)(9)))));
            this.ButtonSeach.CheckedState.Parent = this.ButtonSeach;
            this.ButtonSeach.CustomImages.Parent = this.ButtonSeach;
            this.ButtonSeach.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(203)))), ((int)(((byte)(9)))));
            this.ButtonSeach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonSeach.ForeColor = System.Drawing.Color.White;
            this.ButtonSeach.HoverState.Parent = this.ButtonSeach;
            this.ButtonSeach.Location = new System.Drawing.Point(351, 34);
            this.ButtonSeach.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSeach.Name = "ButtonSeach";
            this.ButtonSeach.ShadowDecoration.Parent = this.ButtonSeach;
            this.ButtonSeach.Size = new System.Drawing.Size(116, 36);
            this.ButtonSeach.TabIndex = 12;
            this.ButtonSeach.Text = "Search";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.removeBook1);
            this.guna2Panel1.Controls.Add(this.viewBook1);
            this.guna2Panel1.Controls.Add(this.editBook1);
            this.guna2Panel1.Controls.Add(this.addBook1);
            this.guna2Panel1.Location = new System.Drawing.Point(31, 155);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(766, 364);
            this.guna2Panel1.TabIndex = 13;
            // 
            // removeBook1
            // 
            this.removeBook1.Location = new System.Drawing.Point(0, 0);
            this.removeBook1.Name = "removeBook1";
            this.removeBook1.Size = new System.Drawing.Size(766, 364);
            this.removeBook1.TabIndex = 3;
            this.removeBook1.Load += new System.EventHandler(this.removeBook1_Load);
            // 
            // viewBook1
            // 
            this.viewBook1.Location = new System.Drawing.Point(0, -3);
            this.viewBook1.Name = "viewBook1";
            this.viewBook1.Size = new System.Drawing.Size(766, 364);
            this.viewBook1.TabIndex = 2;
            // 
            // editBook1
            // 
            this.editBook1.Location = new System.Drawing.Point(0, 0);
            this.editBook1.Name = "editBook1";
            this.editBook1.Size = new System.Drawing.Size(766, 364);
            this.editBook1.TabIndex = 1;
            // 
            // addBook1
            // 
            this.addBook1.Location = new System.Drawing.Point(0, 0);
            this.addBook1.Name = "addBook1";
            this.addBook1.Size = new System.Drawing.Size(766, 364);
            this.addBook1.TabIndex = 0;
            // 
            // QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.ButtonSeach);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.guna2Panel2);
            this.Name = "QuanLySach";
            this.Size = new System.Drawing.Size(833, 540);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2GradientTileButton ButtonRemove;
        private Guna.UI2.WinForms.Guna2GradientTileButton ButtonEdit;
        private Guna.UI2.WinForms.Guna2GradientTileButton ButtonAdd;
        private Guna.UI2.WinForms.Guna2GradientTileButton ButtonView;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Label labelSearch;
        private Guna.UI2.WinForms.Guna2Button ButtonSeach;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private EditBook editBook1;
        private AddBook addBook1;
        private ViewBook viewBook1;
        private RemoveBook removeBook1;
    }
}
