namespace Winform_moi
{
    partial class EditBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2GroupBoxStatus = new Guna.UI2.WinForms.Guna2GroupBox();
            this.ComboBoxGenre = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelBookID = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TextBoxPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelBookName = new System.Windows.Forms.Label();
            this.TextBoxBookID = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBoxQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.TextBoxBookName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBoxStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBoxStatus
            // 
            this.guna2GroupBoxStatus.Controls.Add(this.ComboBoxGenre);
            this.guna2GroupBoxStatus.Controls.Add(this.labelBookID);
            this.guna2GroupBoxStatus.Controls.Add(this.labelQuantity);
            this.guna2GroupBoxStatus.Controls.Add(this.labelGenre);
            this.guna2GroupBoxStatus.Controls.Add(this.labelPrice);
            this.guna2GroupBoxStatus.Controls.Add(this.guna2DataGridView1);
            this.guna2GroupBoxStatus.Controls.Add(this.TextBoxPrice);
            this.guna2GroupBoxStatus.Controls.Add(this.labelBookName);
            this.guna2GroupBoxStatus.Controls.Add(this.TextBoxBookID);
            this.guna2GroupBoxStatus.Controls.Add(this.TextBoxQuantity);
            this.guna2GroupBoxStatus.Controls.Add(this.ButtonUpdate);
            this.guna2GroupBoxStatus.Controls.Add(this.TextBoxBookName);
            this.guna2GroupBoxStatus.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(95)))), ((int)(((byte)(197)))));
            this.guna2GroupBoxStatus.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBoxStatus.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBoxStatus.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBoxStatus.Name = "guna2GroupBoxStatus";
            this.guna2GroupBoxStatus.ShadowDecoration.Parent = this.guna2GroupBoxStatus;
            this.guna2GroupBoxStatus.Size = new System.Drawing.Size(766, 364);
            this.guna2GroupBoxStatus.TabIndex = 26;
            this.guna2GroupBoxStatus.Text = "Edit Book";
            // 
            // ComboBoxGenre
            // 
            this.ComboBoxGenre.BackColor = System.Drawing.Color.Transparent;
            this.ComboBoxGenre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxGenre.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBoxGenre.FocusedState.Parent = this.ComboBoxGenre;
            this.ComboBoxGenre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBoxGenre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBoxGenre.FormattingEnabled = true;
            this.ComboBoxGenre.HoverState.Parent = this.ComboBoxGenre;
            this.ComboBoxGenre.ItemHeight = 30;
            this.ComboBoxGenre.ItemsAppearance.Parent = this.ComboBoxGenre;
            this.ComboBoxGenre.Location = new System.Drawing.Point(144, 147);
            this.ComboBoxGenre.Name = "ComboBoxGenre";
            this.ComboBoxGenre.ShadowDecoration.Parent = this.ComboBoxGenre;
            this.ComboBoxGenre.Size = new System.Drawing.Size(198, 36);
            this.ComboBoxGenre.TabIndex = 24;
            // 
            // labelBookID
            // 
            this.labelBookID.AutoSize = true;
            this.labelBookID.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookID.Location = new System.Drawing.Point(50, 65);
            this.labelBookID.Name = "labelBookID";
            this.labelBookID.Size = new System.Drawing.Size(65, 20);
            this.labelBookID.TabIndex = 15;
            this.labelBookID.Text = "Book ID";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(50, 196);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(70, 20);
            this.labelQuantity.TabIndex = 19;
            this.labelQuantity.Text = "Quantity";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenre.Location = new System.Drawing.Point(50, 147);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(51, 20);
            this.labelGenre.TabIndex = 17;
            this.labelGenre.Text = "Genre";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(50, 229);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(43, 20);
            this.labelPrice.TabIndex = 18;
            this.labelPrice.Text = "Price";
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(372, 46);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 10;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(391, 296);
            this.guna2DataGridView1.TabIndex = 0;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.SystemColors.Window;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 25;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            this.guna2DataGridView1.Click += new System.EventHandler(this.guna2DataGridView1_Click);
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxPrice.DefaultText = "";
            this.TextBoxPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPrice.DisabledState.Parent = this.TextBoxPrice;
            this.TextBoxPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxPrice.FocusedState.Parent = this.TextBoxPrice;
            this.TextBoxPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxPrice.HoverState.Parent = this.TextBoxPrice;
            this.TextBoxPrice.Location = new System.Drawing.Point(143, 226);
            this.TextBoxPrice.Margin = new System.Windows.Forms.Padding(27, 26, 27, 26);
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.PasswordChar = '\0';
            this.TextBoxPrice.PlaceholderText = "";
            this.TextBoxPrice.SelectedText = "";
            this.TextBoxPrice.ShadowDecoration.Parent = this.TextBoxPrice;
            this.TextBoxPrice.Size = new System.Drawing.Size(199, 23);
            this.TextBoxPrice.TabIndex = 23;
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookName.Location = new System.Drawing.Point(50, 114);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(91, 20);
            this.labelBookName.TabIndex = 16;
            this.labelBookName.Text = "Book Name";
            // 
            // TextBoxBookID
            // 
            this.TextBoxBookID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxBookID.DefaultText = "";
            this.TextBoxBookID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxBookID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxBookID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxBookID.DisabledState.Parent = this.TextBoxBookID;
            this.TextBoxBookID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxBookID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxBookID.FocusedState.Parent = this.TextBoxBookID;
            this.TextBoxBookID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxBookID.HoverState.Parent = this.TextBoxBookID;
            this.TextBoxBookID.Location = new System.Drawing.Point(144, 196);
            this.TextBoxBookID.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.TextBoxBookID.Name = "TextBoxBookID";
            this.TextBoxBookID.PasswordChar = '\0';
            this.TextBoxBookID.PlaceholderText = "";
            this.TextBoxBookID.SelectedText = "";
            this.TextBoxBookID.ShadowDecoration.Parent = this.TextBoxBookID;
            this.TextBoxBookID.Size = new System.Drawing.Size(198, 23);
            this.TextBoxBookID.TabIndex = 20;
            // 
            // TextBoxQuantity
            // 
            this.TextBoxQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxQuantity.DefaultText = "";
            this.TextBoxQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxQuantity.DisabledState.Parent = this.TextBoxQuantity;
            this.TextBoxQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxQuantity.FocusedState.Parent = this.TextBoxQuantity;
            this.TextBoxQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxQuantity.HoverState.Parent = this.TextBoxQuantity;
            this.TextBoxQuantity.Location = new System.Drawing.Point(146, 111);
            this.TextBoxQuantity.Margin = new System.Windows.Forms.Padding(16);
            this.TextBoxQuantity.Name = "TextBoxQuantity";
            this.TextBoxQuantity.PasswordChar = '\0';
            this.TextBoxQuantity.PlaceholderText = "";
            this.TextBoxQuantity.SelectedText = "";
            this.TextBoxQuantity.ShadowDecoration.Parent = this.TextBoxQuantity;
            this.TextBoxQuantity.Size = new System.Drawing.Size(196, 23);
            this.TextBoxQuantity.TabIndex = 22;
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.CheckedState.Parent = this.ButtonUpdate;
            this.ButtonUpdate.CustomImages.Parent = this.ButtonUpdate;
            this.ButtonUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonUpdate.ForeColor = System.Drawing.Color.White;
            this.ButtonUpdate.HoverState.Parent = this.ButtonUpdate;
            this.ButtonUpdate.Location = new System.Drawing.Point(146, 278);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.ShadowDecoration.Parent = this.ButtonUpdate;
            this.ButtonUpdate.Size = new System.Drawing.Size(105, 31);
            this.ButtonUpdate.TabIndex = 14;
            this.ButtonUpdate.Text = "Update";
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // TextBoxBookName
            // 
            this.TextBoxBookName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBoxBookName.DefaultText = "";
            this.TextBoxBookName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBoxBookName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBoxBookName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxBookName.DisabledState.Parent = this.TextBoxBookName;
            this.TextBoxBookName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBoxBookName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxBookName.FocusedState.Parent = this.TextBoxBookName;
            this.TextBoxBookName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBoxBookName.HoverState.Parent = this.TextBoxBookName;
            this.TextBoxBookName.Location = new System.Drawing.Point(144, 65);
            this.TextBoxBookName.Margin = new System.Windows.Forms.Padding(16);
            this.TextBoxBookName.Name = "TextBoxBookName";
            this.TextBoxBookName.PasswordChar = '\0';
            this.TextBoxBookName.PlaceholderText = "";
            this.TextBoxBookName.SelectedText = "";
            this.TextBoxBookName.ShadowDecoration.Parent = this.TextBoxBookName;
            this.TextBoxBookName.Size = new System.Drawing.Size(198, 23);
            this.TextBoxBookName.TabIndex = 21;
            // 
            // EditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GroupBoxStatus);
            this.Name = "EditBook";
            this.Size = new System.Drawing.Size(766, 364);
            this.Load += new System.EventHandler(this.EditBook_Load);
            this.guna2GroupBoxStatus.ResumeLayout(false);
            this.guna2GroupBoxStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBoxStatus;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBoxGenre;
        private System.Windows.Forms.Label labelBookID;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelPrice;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxPrice;
        private System.Windows.Forms.Label labelBookName;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxBookID;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxQuantity;
        private Guna.UI2.WinForms.Guna2Button ButtonUpdate;
        private Guna.UI2.WinForms.Guna2TextBox TextBoxBookName;
    }
}
