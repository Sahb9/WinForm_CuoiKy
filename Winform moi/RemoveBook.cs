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
    public partial class RemoveBook : UserControl
    {
        public RemoveBook()
        {
            InitializeComponent();
        }
        Book book = new Book();
        private void RemoveBook_Load(object sender, EventArgs e)
        {
            string sql = "select *from ShowBook";
            guna2DataGridView1.DataSource = book.getBook(sql);
        }

    }
}
