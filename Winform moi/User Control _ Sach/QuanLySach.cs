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
    public partial class QuanLySach : UserControl
    {
        public QuanLySach()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            addBook1.BringToFront();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            editBook1.BringToFront();
        }

        private void ButtonView_Click(object sender, EventArgs e)
        {
            viewBook1.BringToFront();
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            removeBook1.BringToFront();
        }

        private void removeBook1_Load(object sender, EventArgs e)
        {

        }
    }
}
