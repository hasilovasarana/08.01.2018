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
    public partial class AuthorData : Form
    {
        public AuthorData()
        {
            InitializeComponent();
        }

        private void AuthorData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookStoreDataDataSet2.Authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this.bookStoreDataDataSet2.Authors);

        }
    }
}
