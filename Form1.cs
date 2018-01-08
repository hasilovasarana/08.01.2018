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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

     

        private void Open_Click_1(object sender, EventArgs e)
        {
            StartScreen str = new StartScreen();
            str.ShowDialog();
        }

        private void openAuthor_Click(object sender, EventArgs e)
        {
            AuthorData startAuthor = new AuthorData();
            startAuthor.ShowDialog();

        }

        private void openCategory_Click(object sender, EventArgs e)
        {
            CategoriesData startCategory = new CategoriesData();
            startCategory.ShowDialog();
        }

        private void openFormat_Click(object sender, EventArgs e)
        {
            FormatData startFormat = new FormatData();
            startFormat.ShowDialog();

        }

        private void openPublisher_Click(object sender, EventArgs e)
        {
            PublisherData startPublisher = new PublisherData();
            startPublisher.ShowDialog();

        }
    }
}
