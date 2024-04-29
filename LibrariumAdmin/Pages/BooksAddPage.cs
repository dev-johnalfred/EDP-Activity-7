using Krypton.Toolkit;
using LibrariumAdmin.Backend;
using LibrariumAdmin.Forms;
using LibrariumAdmin.Helpers;
using LibrariumAdmin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibrariumAdmin.Pages
{
    public partial class BooksAddPage : UserControl, INavigable
    {
        private NavigationManager? navigationManager;

        public BooksAddPage()
        {
            InitializeComponent();
        }

        public void InitializeNavigation(NavigationManager navigationManager)
        {
            this.navigationManager = navigationManager;
        }

        private void ClearInput()
        {

        }

        private void SaveBookButton_Click(object sender, EventArgs e)
        {
            byte[]? thumbnail = null;
            string title = TitleTextBox.Text;
            string author = AuthorTextBox.Text;
            string publisher = PublisherTextBox.Text;
            string isbn = ISBNTextBox.Text;
            string description = DescriptionTextBox.Text;

            if (kryptonPictureBox1.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    // Convert the image to a byte array
                    kryptonPictureBox1.Image.Save(ms, kryptonPictureBox1.Image.RawFormat);
                    thumbnail = ms.ToArray();
                }
            }

            BookModel newBook = new()
            {
                Title = title,
                Author = author,
                Publisher = publisher,
                ISBN = isbn,
                Description = description,
                Thumbnail = thumbnail
            };

            BookBackend.AddBook(newBook);
            MessageBox.Show("Book added successful!");

            TitleTextBox.Clear();
            AuthorTextBox.Clear();
            PublisherTextBox.Clear();
            ISBNTextBox.Clear();
            DescriptionTextBox.Clear();
            kryptonPictureBox1.Image = null;

            navigationManager.NavigateToPage("ListBooks");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            navigationManager.NavigateToPage("ListBooks");
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Display the selected image in PictureBox
                    kryptonPictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            kryptonPictureBox1.Image = null;
        }
    }
}
