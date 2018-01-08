using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataRelation
{
    public partial class FormatData : Form
    {
        public FormatData()
        {
            InitializeComponent();
        }

        private void FormatData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookStoreDataDataSet5.BookTypes' table. You can move, or remove it, as needed.
            this.bookTypesTableAdapter.Fill(this.bookStoreDataDataSet5.BookTypes);

        }
    }
}
