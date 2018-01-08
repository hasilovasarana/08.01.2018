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
    public partial class StartScreen : Form
    {
        bookStoreDataEntities db = new bookStoreDataEntities();
        public StartScreen()
        {
            InitializeComponent();
            fillAuthorCmb();
            fillCategoryCmb();
            fillLanguageCmb();
            fillFormatCmb();
            fillPublisherCmb();
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookStoreDataDataSet1.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.bookStoreDataDataSet1.Books);

        }

       
     
        
        //Author ComboBox List
        private void fillAuthorCmb()
        {
            this.book_author.Items.Clear();
            List <Author> authorList = db.Authors.ToList();
            foreach (Author item in authorList)
            {
                this.book_author.Items.Add(item.author_name);
            }
        }


        // Categories ComboBox List

        private void fillCategoryCmb()
        {
            this.book_category.Items.Clear();
            List<Category> categoryList = db.Categories.ToList();
            foreach (Category item in categoryList)
            {
                this.book_category.Items.Add(item.category_name);
            }

        }

        // Language ComboBox List

        private void fillLanguageCmb()
        {
            this.book_lang.Items.Clear();
            List<Language> languageList = db.Languages.ToList();
            foreach (Language item in languageList)
            {
                this.book_lang.Items.Add(item.lang_name);
            }
        }

        //Format ComboBox List

        private void fillFormatCmb()
        {
            this.book_format.Items.Clear();
            List<BookType> formatList = db.BookTypes.ToList();
            foreach (BookType item in formatList)
            {
                this.book_format.Items.Add(item.book_type_name);
            }
        }

        //Publisher ComboBox List

        private void fillPublisherCmb()
        {
            this.book_publisher.Items.Clear();
            List<Publisher> publisherList = db.Publishers.ToList();
            foreach (Publisher item in publisherList)
            {
                this.book_publisher.Items.Add(item.publisher_name);
            }
        }

        private void add_book_Click_1(object sender, EventArgs e)
        {

            int authorId = db.Authors.Where(a => a.author_name == this.book_author.Text).First().id;
            int catId =  db.Categories.Where(c => c.category_name == this.book_category.Text).First().id;
            int langId = db.Languages.Where(l => l.lang_name == this.book_lang.Text).First().id;
            int formatId = db.BookTypes.Where(f => f.book_type_name == this.book_format.Text).First().id;
            int publishId = db.Publishers.Where(p => p.publisher_name == this.book_publisher.Text).First().id;
            var newBook = new Book();
            newBook.book_name = book_name.Text;
            newBook.book_isbn = book_isbn.Text;
            newBook.book_author = authorId;
            newBook.book_category = catId;
            newBook.book_lang = langId;
            newBook.book_type = formatId;
            newBook.book_publisher = publishId;
            newBook.book_price = Convert.ToInt32(book_price.Text);
            newBook.book_amount = Convert.ToInt32(book_amount.Text);
            newBook.book_publish_date = publish_date.Value.ToString();
            newBook.book_add_date = publish_add_date.Value;
            db.Books.Add(newBook);
            db.SaveChanges();
        }

        private void add_photo_Click(object sender, EventArgs e)
        {
            
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
 