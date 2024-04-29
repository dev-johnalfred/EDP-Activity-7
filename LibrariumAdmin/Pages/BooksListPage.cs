using Krypton.Toolkit;
using LibrariumAdmin.Backend;
using LibrariumAdmin.Helpers;
using LibrariumAdmin.Models;
using LibrariumAdmin.Widgets;
using System.Data;
using System.Windows.Forms;

namespace LibrariumAdmin.Pages
{
    public partial class BooksListPage : UserControl, INavigable, IUpdatableDataGrid
    {
        private NavigationManager? navigationManager;
        public BooksListPage()
        {
            InitializeComponent();
            LoadBooks();
        }

        public void InitializeNavigation(NavigationManager navigationManager)
        {
            this.navigationManager = navigationManager;
        }

        private void LoadBooks()
        {
            List<BookModel> books = BookBackend.GetBooks();

            BooksDataGridView.Rows.Clear();

            foreach (var book in books)
            {
                BooksDataGridView.Rows.Add(book.Thumbnail, book.Title, book.Author, book.Publisher, book.BookID, book.ISBN, book.Status);
            }
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            navigationManager.NavigateToPage("AddBooks");
        }

        public void UpdateDataGrid()
        {
            LoadBooks();
        }

        private void BooksDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == 7)
            {
                var cellRect = BooksDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                IconButton EditButton = new IconButton(Properties.Resources.EditIcon);
                EditButton.Size = new Size(48, 48);
                var centerXEdit = cellRect.X + 5;
                var centerYEdit = cellRect.Y + cellRect.Height / 2 - EditButton.Height / 2;
                EditButton.Location = new Point(centerXEdit, centerYEdit);
                EditButton.Click += (s, ev) =>
                {
                    var bookId = (int)BooksDataGridView.Rows[e.RowIndex].Cells[4].Value;
                    navigationManager?.NavigateToPage("EditBooks", bookId);
                };

                IconButton DeleteButton = new IconButton(Properties.Resources.DeleteIcon);
                DeleteButton.Size = new Size(48, 48);
                var centerXDelete = centerXEdit + EditButton.Width + 5; // Adjust this value as needed for spacing
                var centerYDelete = cellRect.Y + cellRect.Height / 2 - DeleteButton.Height / 2;
                DeleteButton.Location = new Point(centerXDelete, centerYDelete);
                DeleteButton.Click += (s, ev) =>
                {
                    var bookId = (int)BooksDataGridView.Rows[e.RowIndex].Cells[4].Value;
                    if (MessageBox.Show("Are you sure you want to delete this book?", "Delete Book", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        BookBackend.DeleteBook(bookId);
                        navigationManager?.NavigateToPage("ListBooks");
                    }
                };

                BooksDataGridView.Controls.Add(EditButton);
                BooksDataGridView.Controls.Add(DeleteButton);
            }
        }


        private void BooksDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            foreach (Control control in BooksDataGridView.Controls.OfType<IconButton>().ToList())
            {
                BooksDataGridView.Controls.Remove(control);
                control.Dispose(); // Dispose to release resources
            }
        }
    }
}
