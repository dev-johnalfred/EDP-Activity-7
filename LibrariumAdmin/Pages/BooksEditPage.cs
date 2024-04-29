using Krypton.Toolkit;
using LibrariumAdmin.Backend;
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

namespace LibrariumAdmin.Pages
{
    public partial class BooksEditPage : UserControl, INavigable, IPageParameter
    {
        private NavigationManager? navigationManager;

        private int bookId;

        public BooksEditPage()
        {
            InitializeComponent();
        }

        public void InitializeNavigation(NavigationManager navigationManager)
        {
            this.navigationManager = navigationManager;
        }

        public void SetParameter(object? parameter)
        {
            if (parameter is int id)
            {
                bookId = id;
                BookModel? book = BookBackend.GetBookById(bookId);
                if (book != null)
                {
                    TitleTextBox.Text = book.Title;
                    PublisherTextBox.Text = book.Publisher;
                    ISBNTextBox.Text = book.ISBN;
                    AuthorTextBox.Text = book.Author;
                    DescriptionTextBox.Text = book.Description;

                    if (book.Thumbnail != null && book.Thumbnail.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(book.Thumbnail))
                        {
                            Image image = Image.FromStream(ms);
                            ThumbnailPictureBox.Image = image;
                        }
                    }
                }
            }
        }

        private void ClearInput()
        {
            TitleTextBox.Clear();
            AuthorTextBox.Clear();
            PublisherTextBox.Clear();
            ISBNTextBox.Clear();
            DescriptionTextBox.Clear();
            ThumbnailPictureBox.Image = null;
        }

        private void SaveBookButton_Click(object sender, EventArgs e)
        {
            byte[]? thumbnail = null;
            string title = TitleTextBox.Text;
            string author = AuthorTextBox.Text;
            string publisher = PublisherTextBox.Text;
            string isbn = ISBNTextBox.Text;
            string description = DescriptionTextBox.Text;

            if (ThumbnailPictureBox.Image != null)
            {
                using (MemoryStream ms = new())
                {
                    ThumbnailPictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    thumbnail = ms.ToArray();
                }
            }

            BookModel updateBook = new()
            {
                BookID = bookId,
                Title = title,
                Author = author,
                Publisher = publisher,
                ISBN = isbn,
                Description = description,
                Thumbnail = thumbnail
            };

            BookBackend.UpdateBook(updateBook);
            MessageBox.Show("Book updated successful!");

            TitleTextBox.Clear();
            AuthorTextBox.Clear();
            PublisherTextBox.Clear();
            ISBNTextBox.Clear();
            DescriptionTextBox.Clear();
            ThumbnailPictureBox.Image = null;

            ClearInput();

            navigationManager?.NavigateToPage("ListBooks");
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            navigationManager?.NavigateToPage("ListBooks");
        }

        private void UploadThumbnailButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Display the selected image in PictureBox
                    ThumbnailPictureBox.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private void RemoveThumbnailButton_Click(object sender, EventArgs e)
        {
            ThumbnailPictureBox.Image = null;
        }
    }
}
