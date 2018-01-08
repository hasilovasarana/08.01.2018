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
    public partial class CategoriesData : Form
    {
        public CategoriesData()
        {
            InitializeComponent();
        }

        private void CategoriesData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookStoreDataDataSet3.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.bookStoreDataDataSet3.Categories);

        }
    }
}
