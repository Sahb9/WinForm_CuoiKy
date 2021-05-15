using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_moi
{
    public partial class EditBook : UserControl
    {
        public EditBook()
        {
            InitializeComponent();
        }
        Book book = new Book();


        private void EditBook_Load(object sender, EventArgs e)
        {
            string sql = "select *from ShowBook";
            guna2DataGridView1.DataSource = book.getBook(sql);
            ComboBoxGenre.DataSource = book.getBook(sql);
            ComboBoxGenre.DisplayMember = "Genre";
            ComboBoxGenre.ValueMember = "Genre";
        }

        private void guna2DataGridView1_Click(object sender, EventArgs e)
        {
            TextBoxBookID.Text = guna2DataGridView1.CurrentRow.Cells[0].Value.ToString();
            TextBoxBookName.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString();
            ComboBoxGenre.Text = guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();
            TextBoxPrice.Text = guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();
            TextBoxQuantity.Text = guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
