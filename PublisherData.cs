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
    public partial class PublisherData : Form
    {
        public PublisherData()
        {
            InitializeComponent();
        }

        private void PublisherData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookStoreDataDataSet6.Publishers' table. You can move, or remove it, as needed.
            this.publishersTableAdapter.Fill(this.bookStoreDataDataSet6.Publishers);

        }
    }
}
