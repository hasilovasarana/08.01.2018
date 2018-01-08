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
    public partial class LanguageData : Form
    {
        public LanguageData()
        {
            InitializeComponent();
        }

        private void LanguageData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookStoreDataDataSet4.Languages' table. You can move, or remove it, as needed.
            this.languagesTableAdapter.Fill(this.bookStoreDataDataSet4.Languages);

        }
    }
}
