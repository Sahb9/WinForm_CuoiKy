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
    public partial class ViewBook : UserControl
    {
        public ViewBook()
        {
            InitializeComponent();
        }
        Book book = new Book();
        private void ViewBook_Load(object sender, EventArgs e)
        {
            string sql = "select *from ShowBook";
            guna2DataGridView3.DataSource = book.getBook(sql);
        }

        private void guna2DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //guna2DataGridView3.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
